using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCAbmeldung2.GUI
{
    /*
     * Passwortabfrage für den Zugriff auf die Behandlungsverwaltung
     */
    public partial class Zugangskontrolle : Form
    {
        public Zugangskontrolle()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPasswort.Text))
            {
                Program.playSoundFail();
                MessageBox.Show("Bitte Passwort eingeben!", "Fehler", MessageBoxButtons.OK);
            }
            else if (!"sanitc17".Equals(txtPasswort.Text))
            {
                Program.playSoundFail();
                lbTitel.Text = "Falsches Passwort!";
                if (lbTitel.ForeColor == Color.Red)
                {
                    lbTitel.ForeColor = Color.White;
                    lbTitel.BackColor = Color.Red;
                }
                else
                {
                    lbTitel.BackColor = Color.Empty;
                    lbTitel.ForeColor = Color.Red;
                }
            }
            else
            {
                Program.playSoundSuccess();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter-Sound verhindern
                e.Handled = true;
                e.SuppressKeyPress = true;

                btOk_Click(sender, e);
            }
        }

        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
        }
    }
}
