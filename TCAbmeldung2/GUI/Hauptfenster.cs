using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCAbmeldung2.Fachkonzept;
using TCAbmeldung2.Persistenz;

namespace TCAbmeldung2.GUI
{
    /*
     * Das Hauptfenster ist der Einstiegspunkt der Anwendung.
     * Hier werden die aktuell abgemeldeten Teilnehmer angezeigt und
     * Schaltflächen für Abmeldung, Anmeldung, Gesamtliste, Zeltliste
     * und Teamerliste werden bereitgestellt, außerdem kann zu einem
     * gerade abgemeldeten Teilnehmer ein Kommentar erfasst werden.
     * 
     * Über das Menü lassen sich verschiedene Einstellung vornehmen
     * und Dateipfade setzen.
     */
    public partial class Hauptfenster : Form
    {
        private ListViewColumnSorter columnSorter;
        private bool inProgress = false;

        public List<Teilnehmer> anwesendeTeilnehmer = new List<Teilnehmer>();
        public List<Teilnehmer> abwesendeTeilnehmer = new List<Teilnehmer>();
        public List<int> zeltnummern = new List<int>();

        public List<Teamer> teamer = new List<Teamer>();

        private int zaehler = 0;

        public Hauptfenster()
        {
            InitializeComponent();

            columnSorter = new ListViewColumnSorter();
            lvAbwesend.ListViewItemSorter = columnSorter;

            // Test-TN einfügen
            /*anwesendeTeilnehmer.Add(new Teilnehmer(1001, "Lindenberg", "Udo", 2));
            anwesendeTeilnehmer.Add(new Teilnehmer(1002, "Jürgens", "Udo", 5));
            anwesendeTeilnehmer.Add(new Teilnehmer(1003, "Lustig", "Peter", 21));
            anwesendeTeilnehmer.Add(new Teilnehmer(1004, "Maffay", "Peter", 15));
            anwesendeTeilnehmer.Add(new Teilnehmer(1005, "Goethe", "Wolfi", 4));
            anwesendeTeilnehmer.Add(new Teilnehmer(1006, "Jones", "Olivia", 21));
            anwesendeTeilnehmer.Add(new Teilnehmer(1007, "Obama", "Barrack", 1));
            anwesendeTeilnehmer.Add(new Teilnehmer(1008, "McDonald", "Ronald", 6));
            anwesendeTeilnehmer.Add(new Teilnehmer(1009, "Pofalla", "Ronald", 5));
            anwesendeTeilnehmer.Add(new Teilnehmer(1010, "Bosch", "Hermann", 1));
            anwesendeTeilnehmer.Add(new Teilnehmer(1012, "Bohlen", "Dieter", 14));
            anwesendeTeilnehmer.Add(new Teilnehmer(1013, "Neumeier", "Petry", 22));*/
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            teilnehmerdatenEinlesen();
            teamerdatenEinlesen();

            updateList();

            // Liste absteigend nach Zelt sortieren
            columnSorter.Order = SortOrder.Ascending;
            columnSorter.SortColumn = 3;
            lvAbwesend.Sort();

            // Monitoring aktivieren und zu Beginn einmal checken
            check();
            timerMonitoring.Enabled = true;
            automatischesSpeichernToolStripMenuItem.Checked = true;

            FileWriter.writeToInfobeamer(abwesendeTeilnehmer.Count);
        }

        private void updateList()
        {
            lvAbwesend.Items.Clear();

            lvAbwesend.BeginUpdate();
            inProgress = true;

            for (int i = 0; i < abwesendeTeilnehmer.Count; i++)
            {
                Teilnehmer tn = abwesendeTeilnehmer[i];
                if (txtSuche != null && !txtSuche.Text.Trim().Equals(""))
                {
                    try
                    {
                        int zeltnummer = int.Parse(txtSuche.Text.Trim());
                        if (tn.zeltnr == zeltnummer)
                        {
                            addToList(lvAbwesend, tn);
                        }
                    }
                    catch (FormatException)
                    {
                        if (tn.ToString().ToUpper().Contains(txtSuche.Text.ToUpper()))
                        {
                            addToList(lvAbwesend, tn);
                        }
                    }
                }
                else
                {
                    addToList(lvAbwesend, tn);
                }
            }

            inProgress = false;
            lvAbwesend.EndUpdate();
        }

        private void addToList(ListView lv, Teilnehmer tn)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = tn;
            lvi.SubItems.Add(tn.nachname);
            lvi.SubItems.Add(tn.vorname);
            lvi.SubItems.Add(tn.zeltnr.ToString());
            lvi.SubItems.Add(tn.kommentar);
            lv.Items.Add(lvi);
        }

        private void teilnehmerdatenEinlesen()
        {
            LoadBox lb = new LoadBox("Teilnehmerdaten werden eingelesen.");

            // hier werden die Teilnehmer aus der CSV-Datei eingelesen
            if (string.IsNullOrEmpty(Properties.Settings.Default.sourcePfad))
            {
                openDialog.Title = "Datei mit Teilnehmerdaten auswählen... (csv)";
                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.sourcePfad = openDialog.FileName;
                }
            }
            lb.Show();
            lb.Refresh();
            CSVHandler handler = CSVHandler.getInstance();
            List<List<Teilnehmer>> list = handler.readTnFromCSV(out zeltnummern);

            if (list != null)
            {
                anwesendeTeilnehmer = list[0];
                abwesendeTeilnehmer = list[1];
            }

            lb.Close();
        }

        private void teilnehmerdatenSchreiben()
        {
            LoadBox lb = new LoadBox("Teilnehmerdaten werden geschrieben.");

            if (string.IsNullOrEmpty(Properties.Settings.Default.sourcePfad))
            {
                openDialog.Title = "Datei mit Teilnehmerdaten auswählen... (csv)";
                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.sourcePfad = openDialog.FileName;
                }
            }
            lb.Show();
            lb.Refresh();
            CSVHandler handler = CSVHandler.getInstance();
            bool erfolg = handler.writeTnToCSV(anwesendeTeilnehmer, abwesendeTeilnehmer);
            lb.Close();

            if (!erfolg)
            {
                Program.playSoundFail();
                MessageBox.Show("Beim Schreiben der Daten ist ein Fehler aufgetreten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.playSoundSuccess();
            }
        }

        private void teamerdatenEinlesen()
        {
            LoadBox lb = new LoadBox("Teamerdaten werden eingelesen.");

            // hier werden die Teilnehmer aus der CSV-Datei eingelesen
            if (string.IsNullOrEmpty(Properties.Settings.Default.teamerPfad))
            {
                openDialog.Title = "Datei mit Teamerdaten auswählen... (csv)";
                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.teamerPfad = openDialog.FileName;
                }
            }
            lb.Show();
            lb.Refresh();
            CSVHandler handler = CSVHandler.getInstance();
            teamer = handler.readTeamerFromCSV();

            lb.Close();
        }

        private void check()
        {
            String hinweis = "";
            // Prüfen, ob Pfade gefüllt sind
            if (string.IsNullOrEmpty(Properties.Settings.Default.sourcePfad))
            {
                hinweis += "Keine Datei mit Teilnehmerdaten ausgewählt. Daten können nicht geschrieben werden!\n";
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.historyPfad))
            {
                hinweis += "Keine Verlaufsdatei ausgewählt. Der Verlauf wird nicht gespeichert!\n";
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.teamerPfad))
            {
                hinweis += "Keine Datei mit Teamerdaten ausgewählt. Die Zeltansicht kann nicht angezeigt werden.\n";
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.saniPfad))
            {
                hinweis += "Keine Datei mit Behandlungsdaten ausgewählt. Behandlungen können nicht angezeigt werden.\n";
            }
            if (Properties.Settings.Default.sendenAnInfobeamer && string.IsNullOrEmpty(Properties.Settings.Default.infobeamerPfad))
            {
                hinweis += "Kein Zielverzeichnis für die Kommunikation mit dem Infobeamer ausgewählt.\n";
            }
            // Nach n Timer-Durchläufen folgt eine "große Prüfung"
            if (zaehler >= 4)
            {
                // Prüfen, ob die Teilnehmerdaten innerhalb der letzten Stunde gespeichert wurden
                if (!string.IsNullOrEmpty(Properties.Settings.Default.sourcePfad))
                {
                    System.IO.FileInfo info = new System.IO.FileInfo(Properties.Settings.Default.sourcePfad);
                    if (info.LastWriteTime.AddHours(1) < DateTime.Now)
                    {
                        hinweis += "Teilnehmerdaten wurden längerem nicht gespeichert. ";
                        if (automatischesSpeichernToolStripMenuItem.Checked)
                        {
                            teilnehmerdatenSchreiben();
                            hinweis += "";
                        }
                        else
                        {
                            hinweis += "Automatisches Speichern ist deaktiviert.\n";
                        }
                    }
                }
                zaehler = 0;
            }

            // wenn Fehler vorhanden sind, werden sie angezeigt
            if (!string.IsNullOrEmpty(hinweis))
            {
                lbNotify.Text = "Hinweise:\n----------------------\n" + hinweis;
                pnNotify.Visible = true;
            }
            else
            {
                pnNotify.Visible = false;
            }
        }


        // ========================================== GUI-EVENTS =================================


        private void Hauptfenster_SizeChanged(object sender, EventArgs e)
        {
            int abstaendeHorizontal = 10;
            int abstandNachOben = 27;
            int breite = (this.Width - 3*abstaendeHorizontal)/2 - 6;
            int hoehe = 134;
            int hoeheZweiteReihe = 167;
            int breiteKommBt = 82;
            int hoeheKommBt = 62;

            // erste Reihe Buttons
            btAbmelden.SetBounds(abstaendeHorizontal, abstandNachOben, breite - 14, hoehe);
            btAnmelden.SetBounds(breite-14 + 2*abstaendeHorizontal, abstandNachOben, this.Width-(breite+2*abstaendeHorizontal+14), hoehe);

            breiteKommBt = (btAnmelden.Width - 40) / 5;

            // zweite Reihe Buttons
            btSani.SetBounds(btAnmelden.Location.X, hoeheZweiteReihe, breiteKommBt, hoeheKommBt);
            btTeamListe.SetBounds(btSani.Location.X + btSani.Width + 10, hoeheZweiteReihe, breiteKommBt, hoeheKommBt);
            btListe.SetBounds(btTeamListe.Location.X + btTeamListe.Width + 10, hoeheZweiteReihe, breiteKommBt, hoeheKommBt);
            btZelt.SetBounds(btListe.Location.X + btListe.Width + 10, hoeheZweiteReihe, breiteKommBt, hoeheKommBt);
            btAddKommentar.SetBounds(btZelt.Location.X + btZelt.Width + 10, hoeheZweiteReihe, breiteKommBt, hoeheKommBt);

            lvAbwesend.Columns[1].Width = lvAbwesend.Width * 3 / 10;
            lvAbwesend.Columns[2].Width = lvAbwesend.Width * 3 / 10;
            lvAbwesend.Columns[3].Width = lvAbwesend.Width * 1 / 10 - lvAbwesend.Columns[0].Width - 5;
            lvAbwesend.Columns[4].Width = lvAbwesend.Width * 3 / 10;
        }

        private void lvAbwesend_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Program.playSoundFeedback();
            if (e.Column == columnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (columnSorter.Order == SortOrder.Ascending)
                {
                    columnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    columnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lvAbwesend.Sort();
        }

        private void txtSuche_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void btAbmelden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.historyPfad))
            {
                Program.playSoundFail();
                MessageBox.Show("Es ist keine Verlauf-Datei ausgewählt.\n" +
                                "Bitte in den Einstellungen eine Datei auswählen.", "Fehler beim Lesen",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ScannenFenster sf = new ScannenFenster(anwesendeTeilnehmer, abwesendeTeilnehmer, teamer, true);
                Program.playSoundFeedback();
                if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    anwesendeTeilnehmer = sf.anwesendeTeilnehmer;
                    abwesendeTeilnehmer = sf.abwesendeTeilnehmer;
                    updateList();
                    FileWriter.writeToInfobeamer(abwesendeTeilnehmer.Count);
                }
            }
        }

        private void btAnmelden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.historyPfad))
            {
                Program.playSoundFail();
                MessageBox.Show("Es ist keine Verlauf-Datei ausgewählt.\n" +
                                "Bitte in den Einstellungen eine Datei auswählen.", "Fehler beim Lesen",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ScannenFenster sf = new ScannenFenster(anwesendeTeilnehmer, abwesendeTeilnehmer, teamer, false);
                Program.playSoundFeedback();
                if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    anwesendeTeilnehmer = sf.anwesendeTeilnehmer;
                    abwesendeTeilnehmer = sf.abwesendeTeilnehmer;
                    updateList();
                    FileWriter.writeToInfobeamer(abwesendeTeilnehmer.Count);
                }
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.historyPfad))
            {
                Program.playSoundFail();
                MessageBox.Show("Es ist keine Verlauf-Datei ausgewählt.\n" +
                                "Bitte in den Einstellungen eine Datei auswählen.", "Fehler beim Lesen",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HistoryFenster hf = new HistoryFenster(teamer);
                Program.playSoundFeedback();
                hf.ShowDialog();
            }
        }

        private void verlaufDateiAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.Title = "Verlaufsdatei auswählen...";
            Program.playSoundFeedback();
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.historyPfad = openDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void schließenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            this.Close();
        }

        private void teilnehmerdatenLesenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            teilnehmerdatenEinlesen();
            FileWriter.writeToInfobeamer(abwesendeTeilnehmer.Count);
        }

        private void teilnehmerdatenSchreibenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            teilnehmerdatenSchreiben();
        }

        private void timerMonitoring_Tick(object sender, EventArgs e)
        {
            zaehler++;
            check();
        }

        private void automatischesSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            if (automatischesSpeichernToolStripMenuItem.Checked)
            {
                automatischesSpeichernToolStripMenuItem.Checked = false;
            }
            else
            {
                automatischesSpeichernToolStripMenuItem.Checked = true;
            }
        }

        private void sourceDateiAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.Title = "Source-Datei auswählen...";
            Program.playSoundFeedback();
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.sourcePfad = openDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InfoFenster inf = new InfoFenster();
            Program.playSoundFeedback();
            inf.Show();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zeltnrStr = sender.ToString().Substring(5);
            try
            {
                int zeltnr = int.Parse(zeltnrStr);
                ZeltFenster zf = new ZeltFenster(zeltnr, abwesendeTeilnehmer, anwesendeTeilnehmer);
                Program.playSoundFeedback();
                zf.ShowDialog();
            }
            catch
            {
                Program.playSoundFail();
                MessageBox.Show("Es ist ein Fehler aufgetreten:\nDas Zelt existiert nicht oder hat keine Teamer.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zeltteamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.Title = "Zeltteamer-Datei auswählen...";
            Program.playSoundFeedback();
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.teamerPfad = openDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            teilnehmerdatenSchreiben();
        }

        private void btZelt_Click(object sender, EventArgs e)
        {
            Zeltauswahl za = new Zeltauswahl(abwesendeTeilnehmer, anwesendeTeilnehmer, zeltnummern);
            Program.playSoundFeedback();
            za.ShowDialog();
        }

        private void btListe_Click(object sender, EventArgs e)
        {
            Gesamtliste gl = new Gesamtliste(anwesendeTeilnehmer, abwesendeTeilnehmer);
            Program.playSoundFeedback();
            gl.ShowDialog();
        }

        private void teamerdatenLesenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            teamerdatenEinlesen();
        }

        private void btAddKommentar_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            if (lvAbwesend.SelectedItems.Count != 1)
            {
                Program.playSoundFail();
                MessageBox.Show("Um einen Kommentar hinzuzufügen oder zu bearbeiten, bitte einen Teilnehmer in der Liste anwählen!", "Fehler", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    String kommentar = lvAbwesend.SelectedItems[0].SubItems[4].Text;
                    Teilnehmer tn = (Teilnehmer)lvAbwesend.SelectedItems[0].Tag;
                    Kommentar komm = new Kommentar(tn.vorname + " " + tn.nachname, kommentar);
                    if (komm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        lvAbwesend.SelectedItems[0].SubItems[4].Text = komm.kommentar;
                        tn.kommentar = komm.kommentar;
                        Program.playSoundSuccess();
                    }
                }
                catch
                {
                    Program.playSoundFail();
                    MessageBox.Show("Fehler beim Auswählen/Kommentieren eines Teilnehmers.", "Fehler", MessageBoxButtons.OK);
                }
            }
        }

        private void btSani_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            Zugangskontrolle zDialog = new Zugangskontrolle();
            if (zDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                NameBox nb = new NameBox(teamer);
                if (nb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Teamer doctor = null;
                    try
                    {
                        int teamerId = int.Parse(nb.teamerId);
                        foreach (Teamer t in teamer)
                        {
                            if (t.id.Equals(teamerId))
                            {
                                doctor = t;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        // doctor bleibt null
                    }

                    bool access = false;
                    // nur in access.txt hinterlegte Teamer dürfen zugreifen
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.accessPfad) && doctor != null)
                    {
                        // Aus Datei lesen
                        String pfad = Properties.Settings.Default.accessPfad;

                        try
                        {
                            using (System.IO.StreamReader file = new System.IO.StreamReader(@pfad))
                            {
                                String aktZeile;
                                while (!file.EndOfStream)
                                {
                                    aktZeile = file.ReadLine();
                                    if ((doctor.id + "").Trim().Equals(aktZeile))
                                    {
                                        access = true;
                                        break;
                                    }
                                }
                                file.Close();
                            }
                        }
                        catch
                        {
                            Program.playSoundFail();
                            MessageBox.Show("Fehler beim Lesen aus " + pfad, "Fehler beim Lesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        access = true;
                    }

                    if (access)
                    {
                        // alle Teilnehmer übergeben
                        List<Teilnehmer> teilnehmerliste = new List<Teilnehmer>();
                        teilnehmerliste.AddRange(abwesendeTeilnehmer);
                        teilnehmerliste.AddRange(anwesendeTeilnehmer);

                        SaniFenster sani = new SaniFenster(doctor, teamer, teilnehmerliste);
                        if (sani.ShowDialog() == DialogResult.OK)
                        {
                            Program.playSoundSuccess();
                            // fertig, die Behandlungen sind in der CSV gesichert
                        }
                    }
                    else
                    {
                        Program.playSoundFail();
                        MessageBox.Show("Du hast keine Berechtigung, die Behandlungen einzusehen.", "Keine Berechtigung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btTeamListe_Click(object sender, EventArgs e)
        {
            Teamerliste tl = new Teamerliste(teamer);
            Program.playSoundFeedback();
            tl.ShowDialog();
        }

        private void zugriffskontrolleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.Title = "Zugriffskontrolle auswählen...";
            Program.playSoundFeedback();
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.accessPfad = openDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void infomonitorVerbindungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfobeamerFenster info = new InfobeamerFenster();
            Program.playSoundFeedback();
            if (info.ShowDialog() == DialogResult.OK)
            {
                FileWriter.writeToInfobeamer(abwesendeTeilnehmer.Count);
            }
        }
    }
}
