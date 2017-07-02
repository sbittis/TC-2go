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

namespace TCAbmeldung2.GUI
{
    /*
     * Fenster für die manuelle Auswahl eines Teilnehmers
     * anhand von Namen, Zelt, Gemeinde. Dieses kann genutzt
     * werden, wenn ein Teilnehmer über den Barcode nicht gefunden
     * werden kann.
     */
    public partial class ManuellFenster : Form
    {
        private List<Teilnehmer> anwesendeTeilnehmer;
        private List<Teilnehmer> abwesendeTeilnehmer;
        // Teilnehmer, die in ScannenFenster schon ausgewählt wurden und hier nicht mehr angezeigt werden dürfen
        private List<Teilnehmer> schonAusgewaehlt;

        public Teilnehmer selected;
        //public List<Teilnehmer> selected;
        private bool abmelden;
        private bool inProgress;

        public ManuellFenster(List<Teilnehmer> anwesendeTeilnehmer, List<Teilnehmer> abwesendeTeilnehmer, List<Teilnehmer> schonAusgewaehlt, bool abmelden)
        {
            InitializeComponent();
            this.anwesendeTeilnehmer = anwesendeTeilnehmer;
            this.abwesendeTeilnehmer = abwesendeTeilnehmer;
            this.schonAusgewaehlt = schonAusgewaehlt;
            selected = null;
            this.abmelden = abmelden;
        }

        private void ManuellFenster_SizeChanged(object sender, EventArgs e)
        {
            int abstaendeHorizontal = 10;
            int breite = (this.Width - 3 * abstaendeHorizontal) / 2 - 6;
            int hoehe = 108;

            btOK.SetBounds(abstaendeHorizontal, btOK.Location.Y, breite, hoehe);
            btAbbrechen.SetBounds(breite + 2 * abstaendeHorizontal, btAbbrechen.Location.Y, breite, hoehe);

            lvManuell.Columns[0].Width = 25;
            lvManuell.Columns[1].Width = lvManuell.Width * 4 / 9;
            lvManuell.Columns[2].Width = lvManuell.Width * 4 / 9;
            lvManuell.Columns[3].Width = lvManuell.Width * 1 / 9 - lvManuell.Columns[0].Width - 5;
        }

        private void ManuellFenster_Load(object sender, EventArgs e)
        {
            ManuellFenster_SizeChanged(this, null);
            this.ActiveControl = txtSuche;

            inProgress = true;
            if (abmelden)
            {
                foreach (Teilnehmer tn in anwesendeTeilnehmer)
                {
                    if (!schonAusgewaehlt.Contains(tn))
                        addToList(lvManuell, tn);
                }
            }
            else
            {
                foreach (Teilnehmer tn in abwesendeTeilnehmer)
                {
                    if (!schonAusgewaehlt.Contains(tn))
                        addToList(lvManuell, tn);
                }
            }
            inProgress = false;
        }

        private void addToList(ListView lv, Teilnehmer tn)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = tn;
            lvi.SubItems.Add(tn.nachname);
            lvi.SubItems.Add(tn.vorname);
            lvi.SubItems.Add(tn.zeltnr.ToString());
            if (tn.check)
                lvi.Checked = true;
            lv.Items.Add(lvi);
        }

        private void lvManuell_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            //lvManuell_ItemChecked(this, (System.Windows.Forms.ItemCheckedEventArgs)e);
            /*inProgress = true;
            foreach (ListViewItem lvi in lvManuell.SelectedItems)
            {
                if (!lvi.Checked)
                {
                    lvi.Checked = true;
                }
                else
                {
                    lvi.Checked = false;
                }
            }
            //inProgress = false;*/
        }

        private void txtSuche_TextChanged(object sender, EventArgs e)
        {
            lvManuell.Items.Clear();

            inProgress = true;
            lvManuell.BeginUpdate();

            int count;
            if (abmelden)
                count = anwesendeTeilnehmer.Count;
            else
                count = abwesendeTeilnehmer.Count;

            for (int i = 0; i < count; i++)
            {
                Teilnehmer tn;
                if (abmelden)
                    tn = anwesendeTeilnehmer[i];
                else
                    tn = abwesendeTeilnehmer[i];

                if (txtSuche != null && !txtSuche.Text.Trim().Equals(""))
                {
                    try
                    {
                        int zeltnummer = int.Parse(txtSuche.Text.Trim());
                        if (tn.zeltnr == zeltnummer)
                        {
                            addToList(lvManuell, tn);
                        }
                    }
                    catch (FormatException)
                    {
                        if (tn.ToString().ToUpper().Contains(txtSuche.Text.ToUpper()))
                        {
                            addToList(lvManuell, tn);
                        }
                    }
                }
                else
                {
                    addToList(lvManuell, tn);
                }
            }

            lvManuell.EndUpdate();
            inProgress = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lvManuell.SelectedItems.Count == 1)
            {
                Program.playSoundFeedback();
                selected = (Teilnehmer)lvManuell.SelectedItems[0].Tag;
            }
            else
            {
                Program.playSoundFail();
                lbManuell.Text = "Einen Teilnehmer auswählen!";
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void lvManuell_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            /*if (!inProgress)
            {
                inProgress = true;
                foreach (ListViewItem lvi in lvManuell.Items)
                {
                    if (lvi.Tag == e.Item.Tag)
                    {
                        lvi.Selected = true;
                    }
                    else
                    {
                        if (lvi.Checked)
                        {
                            lvi.Selected = false;
                            lvi.Checked = true;
                        }
                        else
                        {
                            lvi.Selected = false;
                        }
                    }
                }
                inProgress = false;
            }*/
        }

        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            /*if (abmelden)
            {
                foreach (Teilnehmer tn in anwesendeTeilnehmer)
                {
                    tn.check = false;
                }
            }
            else
            {
                foreach (Teilnehmer tn in abwesendeTeilnehmer)
                {
                    tn.check = false;
                }
            }*/
        }
    }
}
