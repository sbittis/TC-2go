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
     * Fenster zum Anzeigen der gesamten Teamerliste.
     * In dieser kann gesucht und gefiltert werden.
     */
    public partial class Teamerliste : Form
    {
        private ListViewColumnSorter columnSorter;
        private List<Teamer> teamerliste = new List<Teamer>();

        public Teamerliste(List<Teamer> teamer)
        {
            InitializeComponent();

            // Sorter für die Liste
            columnSorter = new ListViewColumnSorter();
            lvListe.ListViewItemSorter = columnSorter;

            teamerliste.AddRange(teamer);

            updateList();

            // Liste absteigend nach Zelt sortieren
            columnSorter.Order = SortOrder.Ascending;
            columnSorter.SortColumn = 1;
            lvListe.Sort();
        }

        private void addToList(ListView lv, Teamer t)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = t;
            lvi.SubItems.Clear();
            lvi.SubItems.Add(t.id.ToString());
            lvi.SubItems.Add(t.nachname);
            lvi.SubItems.Add(t.vorname);
            lvi.SubItems.Add(t.zeltnr.ToString());
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

            for (int i = 0; i < teamerliste.Count; i++)
            {
                Teamer t = teamerliste[i];
                if (txtSuche != null && !txtSuche.Text.Trim().Equals(""))
                {
                    try
                    {
                        int nummer = int.Parse(txtSuche.Text.Trim());
                        if (t.zeltnr == nummer || t.id == nummer)
                        {
                            addToList(lvListe, t);
                        }
                    }
                    catch (FormatException)
                    {
                        if (t.ToFullString().ToUpper().Contains(txtSuche.Text.ToUpper()))
                        {
                            addToList(lvListe, t);
                        }
                    }
                }
                else
                {
                    addToList(lvListe, t);
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
