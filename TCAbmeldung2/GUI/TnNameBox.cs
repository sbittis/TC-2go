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
     * Fenster zum Scannen einer einzelnen Person (Teilnehmer oder Teamer)
     * als Patient einer Behandlung
     */
    public partial class TnNameBox : Form
    {
        private List<Teilnehmer> tnliste = new List<Teilnehmer>();
        private List<Teamer> teamerliste = new List<Teamer>();
        public String tnId;

        public TnNameBox()
        {
            InitializeComponent();
            List<int> zelte = new List<int>(); // nicht notwendig, muss aber übergeben werden
            List<List<Teilnehmer>> _tnliste = CSVHandler.getInstance().readTnFromCSV(out zelte);
            teamerliste = CSVHandler.getInstance().readTeamerFromCSV();
            tnliste.AddRange(_tnliste[0]);
            tnliste.AddRange(_tnliste[1]);
        }

        private void TnNameBox_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTnId;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tnId))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                this.ActiveControl = txtTnId;
            }
            else
            {
                Program.playSoundSuccess();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter-Sound verhindern
                e.Handled = true;
                e.SuppressKeyPress = true;

                btOk_Click(this, e);
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                btOk.Enabled = false;
            }
        }

        private void txtTnId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tnId = null;
                try
                {
                    int _id = int.Parse(txtTnId.Text);
                    bool gefunden = false;
                    foreach (Teilnehmer t in tnliste)
                    {
                        if (t.id == _id)
                        {
                            txtName.Text = t.vorname + " " + t.nachname;
                            gefunden = true;
                            tnId = _id.ToString();
                            break;
                        }
                    }
                    if (!gefunden)
                    {
                        // in den Teamern suchen
                        foreach (Teamer t in teamerliste)
                        {
                            if (t.id == _id)
                            {
                                txtName.Text = t.vorname + " " + t.nachname;
                                gefunden = true;
                                tnId = _id.ToString();
                                break;
                            }
                        }
                    }
                    if (!gefunden)
                    {
                        showBoxNotFound(_id);
                    }
                }
                catch (FormatException)
                {
                    showBoxIdFehler(txtTnId.Text);
                }
                finally
                {
                    txtTnId.Text = "";
                    this.ActiveControl = txtTnId;
                }

                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    btOk.Enabled = true;
                }
                else
                {
                    btOk.Enabled = false;
                }
            }
        }

        private void showBoxIdFehler(String eingabe)
        {
            MessageBox.Show("ID " + eingabe + " nicht erkannt.\n\nErneut versuchen oder manuell eingeben.", "Fehler beim Scannen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showBoxNotFound(int id)
        {
            MessageBox.Show("Teilnehmer/Teamer mit ID " + id + " nicht gefunden.", "Fehler beim Scannen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
