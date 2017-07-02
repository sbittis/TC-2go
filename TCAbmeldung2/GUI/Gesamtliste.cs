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
     * Die Gesamtliste zeigt alle Informationen zu allen erfassten Teilnehmer an.
     * Darin kann gefiltert und nach einzelnen Teilnehmern gesucht werden.
     */
    public partial class Gesamtliste : Form
    {
        private ListViewColumnSorter columnSorter;
        private List<Teilnehmer> teilnehmerliste = new List<Teilnehmer>();

        public Gesamtliste(List<Teilnehmer> anwesendeTeilnehmer, List<Teilnehmer> abwesendeTeilnehmer)
        {
            InitializeComponent();

            // Sorter für die Liste
            columnSorter = new ListViewColumnSorter();
            lvListe.ListViewItemSorter = columnSorter;

            teilnehmerliste.AddRange(anwesendeTeilnehmer);
            teilnehmerliste.AddRange(abwesendeTeilnehmer);

            updateList();

            // Liste absteigend nach Zelt sortieren
            columnSorter.Order = SortOrder.Ascending;
            columnSorter.SortColumn = 1;
            lvListe.Sort();
        }

        private void addToList(ListView lv, Teilnehmer tn)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = tn;
            lvi.SubItems.Clear();
            lvi.SubItems.Add(tn.id.ToString());
            lvi.SubItems.Add(tn.nachname);
            lvi.SubItems.Add(tn.vorname);
            lvi.SubItems.Add(tn.zeltnr.ToString());
            lvi.SubItems.Add(tn.gemeinde);
            lv.Items.Add(lvi);
        }

        private void lvListe_ColumnClick(object sender, ColumnClickEventArgs e)
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
            lvListe.Sort();
        }

        private void txtSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadBox lb = new LoadBox("Wird gesucht...");
                lb.Show();
                lb.Refresh();
                updateList();
                lb.Close();
            }
        }

        private void updateList()
        {
            lvListe.Items.Clear();

            lvListe.BeginUpdate();
            //inProgress = true;

            for (int i = 0; i < teilnehmerliste.Count; i++)
            {
                Teilnehmer tn = teilnehmerliste[i];
                if (txtSuche != null && !txtSuche.Text.Trim().Equals(""))
                {
                    try
                    {
                        int nummer = int.Parse(txtSuche.Text.Trim());
                        if (tn.zeltnr == nummer || tn.id == nummer)
                        {
                            addToList(lvListe, tn);
                        }
                    }
                    catch (FormatException)
                    {
                        if (tn.ToFullString().ToUpper().Contains(txtSuche.Text.ToUpper()))
                        {
                            addToList(lvListe, tn);
                        }
                    }
                }
                else
                {
                    addToList(lvListe, tn);
                }
            }

            //inProgress = false;
            lvListe.EndUpdate();
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            this.Close();
        }
    }
}
