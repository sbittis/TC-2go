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
     * Fenster zum Verwalten aller Behandlungen. Hier kann eine
     * einzelne Behandlung zum Bearbeiten ausgewählt werden
     * oder eine neue Behandlung angelegt werden.
     * 
     * Zuvor muss sich der Teamer über eine zweifache Zugriffskontrolle
     * (Passwort + Berechtigung) authentifizieren.
     */
    public partial class SaniFenster : Form
    {
        private Teamer arzt = null;
        private List<Behandlung> behandlungen = new List<Behandlung>();
        private bool inProgress = false;
        private List<Teamer> teamer = new List<Teamer>();
        private List<Teilnehmer> teilnehmerliste = new List<Teilnehmer>();

        public SaniFenster(Teamer doctor, List<Teamer> teamer, List<Teilnehmer> teilnehmerliste)
        {
            InitializeComponent();
            if (doctor != null)
            {
                arzt = doctor;
                lbBehandlungDurch.Text += arzt.ToString();
            }
            else
            {
                lbBehandlungDurch.Text += "-";
            }
            if (teamer != null)
            {
                this.teamer = teamer;
            }
            if (teilnehmerliste != null)
            {
                this.teilnehmerliste = teilnehmerliste;
            }
        }

        private void btNeu_Click(object sender, EventArgs e)
        {
            BehandlungFenster b = new BehandlungFenster(arzt, teamer, teilnehmerliste);
            Program.playSoundFeedback();
            if (b.ShowDialog() == DialogResult.OK)
            {
                behandlungen.Add(b.behandlung);
                ListViewItem lvi = new ListViewItem(b.behandlung.erfasstDate);
                lvi.Tag = b.behandlung;
                lvi.SubItems.Add(b.behandlung.patient.nachname);
                lvi.SubItems.Add(b.behandlung.patient.vorname);
                lvi.SubItems.Add(b.behandlung.text1.Replace('\n', ' '));
                lvBehandlungen.Items.Add(lvi);
            }
        }

        private void lvBehandlungen_DoubleClick(object sender, EventArgs e)
        {
            if (lvBehandlungen.SelectedItems.Count == 1)
            {
                // Behandlung bearbeiten
                ListViewItem lvi = lvBehandlungen.SelectedItems[0];
                Behandlung b = (Behandlung)lvi.Tag;
                BehandlungFenster bf = new BehandlungFenster(b, teamer, teilnehmerliste);
                Program.playSoundFeedback();
                if (bf.ShowDialog() == DialogResult.OK)
                {
                    behandlungen.Remove(b);
                    behandlungen.Add(bf.behandlung);
                    ListViewItem lvi_new = new ListViewItem(bf.behandlung.erfasstDate);
                    lvi_new.SubItems.Add(bf.behandlung.patient.nachname);
                    lvi_new.SubItems.Add(bf.behandlung.patient.vorname);
                    lvi_new.SubItems.Add(bf.behandlung.text1.Replace('\n', ' '));
                    lvi_new.Tag = bf.behandlung;
                    int index = lvBehandlungen.Items.IndexOf(lvi);
                    lvBehandlungen.Items.Remove(lvi);
                    lvBehandlungen.Items.Insert(index, lvi_new);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();

            // Behandlung in Datei schreiben
            LoadBox lb = new LoadBox("Behandlungsdaten werden geschrieben.");

            if (string.IsNullOrEmpty(Properties.Settings.Default.saniPfad))
            {
                openDialog.Title = "Datei mit Behandlungsdaten auswählen... (csv)";
                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.saniPfad = openDialog.FileName;
                }
            }
            lb.Show();
            lb.Refresh();
            CSVHandler handler = CSVHandler.getInstance();
            bool erfolg = handler.writeBehandlungenToCSV(behandlungen);
            lb.Close();

            if (!erfolg)
            {
                Program.playSoundFail();
                MessageBox.Show("Beim Schreiben der Daten ist ein Fehler aufgetreten!\nBitte die Daten manuell sichern und vorher nicht schließen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                Program.playSoundSuccess();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SaniFenster_Load(object sender, EventArgs e)
        {
            // Aus Datei lesen
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@Properties.Settings.Default.saniPfad, Encoding.Default))
                {
                    String aktZeile;
                    String[] infoFeld;
                    while (!file.EndOfStream)
                    {
                        aktZeile = file.ReadLine();
                        infoFeld = aktZeile.Split(new String[] { "##" }, StringSplitOptions.RemoveEmptyEntries);
                        if (infoFeld.Length == 5)
                        {
                            Behandlung b = new Behandlung();
                            b.erfasstDate = infoFeld[0];

                            // teilnehmer finden
                            try
                            {
                                int tnId = int.Parse(infoFeld[1]);
                                if (tnId != 0)
                                {
                                    foreach (Teilnehmer tn in teilnehmerliste)
                                    {
                                        if (tn.id.Equals(tnId))
                                        {
                                            b.patient = tn;
                                            break;
                                        }
                                    }
                                }
                                if (b.patient == null)
                                {
                                    foreach (Teamer t in teamer)
                                    {
                                        if (t.id.Equals(tnId))
                                        {
                                            b.patient = t;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                b.patient = null;
                            }

                            if (b.patient == null)
                            {
                                b.patient = new Person();
                                Program.playSoundFail();
                                MessageBox.Show("Fehler beim Lesen der Behandlungen. Bitte prüfen.", "Fehler");
                            }

                            // teamer finden
                            try
                            {
                                int teamerId = int.Parse(infoFeld[2]);
                                if (teamerId != 0)
                                {
                                    foreach (Teamer t in teamer)
                                    {
                                        if (t.id.Equals(teamerId))
                                        {
                                            b.arzt = t;
                                            break;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                b.arzt = null;
                            }
                            b.text1 = infoFeld[3];
                            b.text2 = infoFeld[4];

                            behandlungen.Add(b);
                        }
                    }
                }
            }
            catch
            {
                Program.playSoundFail();
                MessageBox.Show("Fehler beim Lesen aus " + Properties.Settings.Default.saniPfad, "Fehler beim Lesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            updateList();
        }

        private void updateList()
        {
            lvBehandlungen.Items.Clear();

            lvBehandlungen.BeginUpdate();
            inProgress = true;

            for (int i = 0; i < behandlungen.Count; i++)
            {
                Behandlung b = behandlungen[i];
                if (txtSuche != null && !txtSuche.Text.Trim().Equals(""))
                {
                    if (b.ToString().ToUpper().Contains(txtSuche.Text.ToUpper()))
                    {
                        addToList(lvBehandlungen, b);
                    }
                }
                else
                {
                    addToList(lvBehandlungen, b);
                }
            }

            inProgress = false;
            lvBehandlungen.EndUpdate();
        }

        private void addToList(ListView lv, Behandlung b)
        {
            ListViewItem lvi = new ListViewItem(b.erfasstDate);
            lvi.Tag = b;
            lvi.SubItems.Add(b.patient.nachname);
            lvi.SubItems.Add(b.patient.vorname);
            lvi.SubItems.Add(b.text1);
            lv.Items.Add(lvi);
        }

        private void txtSuche_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
