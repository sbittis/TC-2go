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
using System.IO;
using System.Reflection;

namespace TCAbmeldung2.GUI
{
    /*
     * Fenster zum Scannen der Teilnehmer, die sich ab-
     * oder anmelden. Hier kann auch das ManuellFenster
     * zum manuellen Eingeben eines Teilnehmers geöffnet
     * werden.
     */
    public partial class ScannenFenster : Form
    {
        public List<Teilnehmer> anwesendeTeilnehmer;
        public List<Teilnehmer> abwesendeTeilnehmer;
        public List<Teamer> teamer;
        private bool abmelden;
        private System.Media.SoundPlayer success = new System.Media.SoundPlayer(@"/resources/sound/success.wav");
        private System.Media.SoundPlayer fail = new System.Media.SoundPlayer(@"/resources/sound/fail.wav");


        public ScannenFenster(List<Teilnehmer> anwesendeTeilnehmer, List<Teilnehmer> abwesendeTeilnehmer, List<Teamer> teamer, bool abmelden)
        {
            InitializeComponent();
            this.anwesendeTeilnehmer = anwesendeTeilnehmer;
            this.abwesendeTeilnehmer = abwesendeTeilnehmer;
            this.teamer = teamer;
            this.abmelden = abmelden;

            // *** ListViewExtender für Buttons im LV
            lvAuswahl.FullRowSelect = true;
            ListViewExtender extender = new ListViewExtender(lvAuswahl);
            // extend 1st column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(0);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;
            extender.AddColumn(buttonAction);
            // *** ListViewExtender für Buttons im LV *** ENDE
        }

        private void ScannenFenster_SizeChanged(object sender, EventArgs e)
        {
            int abstaendeHorizontal = 10;
            int breite = (this.Width - 3 * abstaendeHorizontal) / 2 - 6;
            int hoehe = 108;

            btManuell.SetBounds(abstaendeHorizontal, btManuell.Location.Y, breite, hoehe);
            btFertig.SetBounds(breite + 2 * abstaendeHorizontal, btFertig.Location.Y, breite, hoehe);

            lvAuswahl.Columns[0].Width = 25;
            lvAuswahl.Columns[1].Width = lvAuswahl.Width * 4 / 9;
            lvAuswahl.Columns[2].Width = lvAuswahl.Width * 4 / 9;
            lvAuswahl.Columns[3].Width = lvAuswahl.Width * 1 / 9 - lvAuswahl.Columns[0].Width - 5;

            this.ActiveControl = txtScan;
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            lvAuswahl.Items.Remove(e.Item);
            Program.playSoundFeedback();
            this.ActiveControl = txtScan;
        }

        private void txtScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter-Sound verhindern
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (abmelden)
                {
                    try
                    {
                        int _id = int.Parse(txtScan.Text);
                        bool gefunden = false;
                        foreach (Teilnehmer tn in anwesendeTeilnehmer)
                        {
                            if (tn.id == _id)
                            {
                                addToList(lvAuswahl, tn);
                                gefunden = true;
                                Program.playSoundSuccess();
                                break;
                            }
                        }
                        if (!gefunden)
                        {
                            showBoxNotFound(_id);
                        }
                    }
                    catch (FormatException)
                    {
                        showBoxIdFehler(txtScan.Text);
                    }
                    finally
                    {
                        txtScan.Text = "";
                        this.ActiveControl = txtScan;
                    }
                }
                else
                {
                    try
                    {
                        int _id = int.Parse(txtScan.Text);
                        bool gefunden = false;
                        foreach (Teilnehmer tn in abwesendeTeilnehmer)
                        {
                            if (tn.id == _id)
                            {
                                addToList(lvAuswahl, tn);
                                gefunden = true;
                                Program.playSoundSuccess();
                                break;
                            }
                        }
                        if (!gefunden)
                        {
                            showBoxNotFound(_id);
                        }
                    }
                    catch (FormatException)
                    {
                        showBoxIdFehler(txtScan.Text);
                    }
                    finally
                    {
                        txtScan.Text = "";
                        this.ActiveControl = txtScan;
                    }
                }
            }
        }

        private void showBoxIdFehler(String eingabe)
        {
            Program.playSoundFail();
            MessageBox.Show("ID "+ eingabe +" nicht erkannt.\n\nErneut versuchen oder manuell eingeben.", "Fehler beim Scannen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showBoxNotFound(int id)
        {
            Program.playSoundFail();
            MessageBox.Show("Teilnehmer mit ID "+ id +" nicht gefunden.\nIst der Teilnehmer vielleicht schon " + (abmelden?"abgemeldet":"angemeldet") + "?\n\nErneut versuchen oder manuell eingeben.", "Fehler beim Scannen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addToList(ListView lv, Teilnehmer tn)
        {
            bool vorhanden = false;
            foreach (ListViewItem lvi in lv.Items)
            {
                if (((Teilnehmer)lvi.Tag).Equals(tn))
                {
                    vorhanden = true; break;
                }
            }

            if (!vorhanden)
            {
                ListViewItem lvi = lv.Items.Add("X");
                lvi.Tag = tn;
                lvi.SubItems.Add(tn.nachname);
                lvi.SubItems.Add(tn.vorname);
                lvi.SubItems.Add(tn.zeltnr.ToString());
                Program.playSoundSuccess();
            }
        }

        private void ScannenFenster_Load(object sender, EventArgs e)
        {
            ScannenFenster_SizeChanged(this, null);
            this.ActiveControl = txtScan;
        }

        private void btFertig_Click(object sender, EventArgs e)
        {
            if (lvAuswahl.Items.Count == 0)
            {
                Program.playSoundFeedback();
            }
            else if (abmelden && lvAuswahl.Items.Count < 3)
            {
                Program.playSoundFeedback();
                if (MessageBox.Show("Teilnehmer dürfen das Gelände nur verlassen, wenn sie mindestens zu dritt sind. Trotzdem fortfahren?", "Warnung", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    NameBox nb = new NameBox(teamer);
                    Program.playSoundFeedback();
                    if (nb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        foreach (ListViewItem lvi in lvAuswahl.Items)
                        {
                            Teilnehmer tn = (Teilnehmer)lvi.Tag;
                            writeInHistory(tn, nb.teamerId);
                            if (abmelden)
                            {
                                anwesendeTeilnehmer.Remove(tn);
                                abwesendeTeilnehmer.Add(tn);
                            }
                            else
                            {
                                abwesendeTeilnehmer.Remove(tn);
                                anwesendeTeilnehmer.Add(tn);
                            }
                        }
                        Program.playSoundSuccess();
                    }
                    else
                    {
                        Program.playSoundFeedback();
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.ActiveControl = txtScan;
                    }
                }
                else
                {
                    Program.playSoundFeedback();
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    this.ActiveControl = txtScan;
                }
            }
            else 
            {
                NameBox nb = new NameBox(teamer);
                Program.playSoundFeedback();
                if (nb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (ListViewItem lvi in lvAuswahl.Items)
                    {
                        Teilnehmer tn = (Teilnehmer)lvi.Tag;
                        writeInHistory(tn, nb.teamerId);
                        if (abmelden)
                        {
                            anwesendeTeilnehmer.Remove(tn);
                            abwesendeTeilnehmer.Add(tn);
                        }
                        else
                        {
                            abwesendeTeilnehmer.Remove(tn);
                            anwesendeTeilnehmer.Add(tn);
                        }
                    }
                    Program.playSoundSuccess();
                }
                else
                {
                    Program.playSoundFeedback();
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    this.ActiveControl = txtScan;
                }
            }
        }

        private void btManuell_Click(object sender, EventArgs e)
        {
            List<Teilnehmer> schonAusgewaehlt = new List<Teilnehmer>();
            foreach (ListViewItem lvi in lvAuswahl.Items)
            {
                schonAusgewaehlt.Add((Teilnehmer)lvi.Tag);
            }

            ManuellFenster mf = new ManuellFenster(anwesendeTeilnehmer, abwesendeTeilnehmer, schonAusgewaehlt, abmelden);
            Program.playSoundFeedback();
            if (mf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                addToList(lvAuswahl, mf.selected);
            }
            this.ActiveControl = txtScan;
        }

        private void ScannenFenster_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtScan;
        }

        private void lvAuswahl_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtScan;
        }

        private void lbScannen_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtScan;
        }

        private void lvAuswahl_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.ActiveControl = txtScan;
        }

        private void lvAuswahl_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = txtScan;
        }

        private void writeInHistory(Teilnehmer tn, String teamerId)
        {
            String toWrite;
            if (abmelden)
            {
                toWrite = "1##";
            }
            else
            {
                toWrite = "0##";
            }
            toWrite += DateTime.Now.ToString("dd.MMMM.yyyy##HH:mm");
            toWrite += "##" + tn.ToString() + "##" + teamerId;
            
            // In Datei schreiben
            String pfad = Properties.Settings.Default.historyPfad;
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@pfad, true))
                {
                    file.WriteLine(toWrite);
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Schreiben in " + pfad, "Fehler beim Schreiben", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
