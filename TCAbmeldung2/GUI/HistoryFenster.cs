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
     * In diesem Fenster lässt sich die Historie/der Verlauf der
     * Ab- und Anmeldungen nachvollziehen. Dabei kann gesucht oder
     * nach Datum oder nach An- oder Abmeldung gefiltert werden
     */
    public partial class HistoryFenster : Form
    {
        private List<Transaktion> eingeleseneDaten;
        private List<Teamer> teamer;

        private ListViewColumnSorter columnSorter;

        public HistoryFenster(List<Teamer> teamer)
        {
            InitializeComponent();

            eingeleseneDaten = new List<Transaktion>();

            columnSorter = new ListViewColumnSorter();
            lvVerlauf.ListViewItemSorter = columnSorter;

            this.teamer = teamer;

            // Default-Belegung
            cbHeute.Checked = true;
            cbAlle.Checked = true;
        }

        private void HistoryFenster_Load(object sender, EventArgs e)
        {
            LoadBox lb = new LoadBox();
            lb.setText("Verlaufsdatei wird geladen.");
            lb.Show();

            // Aus Datei lesen
            String pfad = Properties.Settings.Default.historyPfad;
            
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@pfad))
                {
                    String aktZeile;
                    String[] infoFeld;
                    while (!file.EndOfStream)
                    {
                        aktZeile = file.ReadLine();
                        infoFeld = aktZeile.Split(new String[] { "##" }, StringSplitOptions.RemoveEmptyEntries);
                        if (infoFeld.Length == 5)
                        {
                            Transaktion t = new Transaktion();
                            t.abmeldung = "1".Equals(infoFeld[0]);
                            t.datum = infoFeld[1];
                            t.zeit = infoFeld[2];
                            t.tn = infoFeld[3];
                            t.teamer = infoFeld[4];
                            eingeleseneDaten.Add(t);
                        }
                    }
                }
            }
            catch
            {
                Program.playSoundFail();
                MessageBox.Show("Fehler beim Lesen aus " + pfad, "Fehler beim Lesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            updateList();
            lb.Close();

            // Liste absteigend nach Zeit sortieren
            columnSorter.Order = SortOrder.Ascending;
            columnSorter.SortColumn = 2;
            lvVerlauf.Sort();
        }

        private void updateList()
        {
            lvVerlauf.Items.Clear();

            lvVerlauf.BeginUpdate();
            //inProgress = true;

            for (int i = 0; i < eingeleseneDaten.Count; i++)
            {
                Transaktion t = eingeleseneDaten[i];
                if (txtSuche != null && !txtSuche.Text.Trim().Equals(""))
                {
                    try
                    {
                        int zeltnummer = int.Parse(txtSuche.Text.Trim());
                        if (t.tn.Contains(zeltnummer.ToString()))
                        {
                            addToList(lvVerlauf, t);
                        }
                    }
                    catch (FormatException)
                    {
                        if (t.ToString().ToUpper().Contains(txtSuche.Text.ToUpper()))
                        {
                            addToList(lvVerlauf, t);
                        }
                    }
                }
                else
                {
                    addToList(lvVerlauf, t);
                }
            }

            //inProgress = false;
            lvVerlauf.EndUpdate();
        }

        private void addToList(ListView lv, Transaktion t)
        {
            // nur die Transaktionen hinzufügen, die durch Knopfauswahl gewünscht sind
            DateTime datum = convertStringToDate(t.datum);
            DateTime currentDate = DateTime.Now;
            if ((cbHeute.Checked && datum.DayOfYear != currentDate.DayOfYear) || (cbAbmeldungen.Checked && !t.abmeldung) || (cbAnmeldungen.Checked && t.abmeldung))
            {
                // Transaktion darf nicht hinzugefügt werden --> nichts passiert
            }
            else
            {
                ListViewItem lvi = lv.Items.Add(t.datum);
                lvi.Tag = t;

                lvi.SubItems.Add(t.zeit);
                lvi.SubItems.Add(t.tn);
                if (t.abmeldung)
                    lvi.SubItems.Add("Abmeldung");
                else
                    lvi.SubItems.Add("Anmeldung");

                // Teamername anhand der ID suchen
                String teamername = "";
                try
                {
                    int _id = int.Parse(t.teamer);
                    bool gefunden = false;
                    foreach (Teamer tm in teamer)
                    {
                        if (tm.id == _id)
                        {
                            teamername = tm.vorname + " " + tm.nachname;
                            gefunden = true;
                            break;
                        }
                    }
                }
                catch (FormatException)
                {
                    
                }

                lvi.SubItems.Add(teamername);
            }
        }

        private DateTime convertStringToDate(String datum)
        {
            try
            {
                String[] datumFeld = datum.Split(new char[] { '.' });
                int tag = int.Parse(datumFeld[0]);
                int monat = 1;
                switch (datumFeld[1])
                {
                    case "Januar": monat = 1; break;
                    case "Februar": monat = 2; break;
                    case "März": monat = 3; break;
                    case "April": monat = 4; break;
                    case "Mai": monat = 5; break;
                    case "Juni": monat = 6; break;
                    case "Juli": monat = 7; break;
                    case "August": monat = 8; break;
                    case "September": monat = 9; break;
                    case "Oktober": monat = 10; break;
                    case "November": monat = 11; break;
                    case "Dezember": monat = 12; break;
                }
                int jahr = int.Parse(datumFeld[2]);
                return new DateTime(jahr, monat, tag);
            }
            catch
            {
                // MessageBox.Show("Fehler beim Lesen des Datums.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DateTime();
            }
        }

        private void cb_Click(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                switch (cb.Name)
                {
                    case "cbAlleZeiten":
                        cbHeute.Checked = false;
                        break;
                    case "cbHeute":
                        cbAlleZeiten.Checked = false;
                        break;
                    case "cbAlle":
                        cbAbmeldungen.Checked = false;
                        cbAnmeldungen.Checked = false;
                        break;
                    case "cbAbmeldungen":
                        cbAlle.Checked = false;
                        cbAnmeldungen.Checked = false;
                        break;
                    case "cbAnmeldungen":
                        cbAlle.Checked = false;
                        cbAbmeldungen.Checked = false;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (cb.Name)
                {
                    case "cbAlleZeiten":
                        cbHeute.Checked = true;
                        break;
                    case "cbHeute":
                        cbHeute.Checked = true;
                        break;
                    case "cbAlle":
                        cbAlle.Checked = true;
                        break;
                    case "cbAbmeldungen":
                        cbAlle.Checked = true;
                        break;
                    case "cbAnmeldungen":
                        cbAlle.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            updateList();
        }

        private void HistoryFenster_SizeChanged(object sender, EventArgs e)
        {
            lvVerlauf.Columns[0].Width = lvVerlauf.Columns[1].Width = lvVerlauf.Width * 14/100;
            lvVerlauf.Columns[2].Width = lvVerlauf.Width * 31/100;
            lvVerlauf.Columns[3].Width = lvVerlauf.Width * 17/100;
            lvVerlauf.Columns[4].Width = lvVerlauf.Width * 22/100;
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

        private void lvVerlauf_ColumnClick(object sender, ColumnClickEventArgs e)
        {
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
            lvVerlauf.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
