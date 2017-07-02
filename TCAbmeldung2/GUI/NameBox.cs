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
     * Fenster zum Erfassen des Teamers per Scanner
     */
    public partial class NameBox : Form
    {
        public String teamerId;
        public List<Teamer> teamer;

        public NameBox(List<Teamer> teamer)
        {
            InitializeComponent();
            this.teamer = teamer;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamerId))
            {
                Program.playSoundFeedback();
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                this.ActiveControl = txtName;
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

        private void NameBox_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTeamerId;
        }

        private void txtTeamerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                teamerId = null;
                try
                {
                    int _id = int.Parse(txtTeamerId.Text);
                    bool gefunden = false;
                    foreach (Teamer t in teamer)
                    {
                        if (t.id == _id)
                        {
                            txtName.Text = t.vorname + " " + t.nachname;
                            gefunden = true;
                            teamerId = _id.ToString();
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
                    showBoxIdFehler(txtTeamerId.Text);
                }
                finally
                {
                    txtTeamerId.Text = "";
                    this.ActiveControl = txtTeamerId;
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
            Program.playSoundFail();
            MessageBox.Show("ID "+ eingabe +" nicht erkannt.\n\nErneut versuchen oder manuell eingeben.", "Fehler beim Scannen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showBoxNotFound(int id)
        {
            Program.playSoundFail();
            MessageBox.Show("Teamer mit ID "+ id +" nicht gefunden.", "Fehler beim Scannen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
