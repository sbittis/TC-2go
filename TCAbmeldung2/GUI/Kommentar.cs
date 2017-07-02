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
     * Fenster zum Erfassen eines Kommentars
     */
    public partial class Kommentar : Form
    {
        private bool warGefuellt = false;
        public String kommentar = "";

        public Kommentar(String tnName, String kommentar)
        {
            InitializeComponent();
            this.Text = tnName + " - Kommentar";
            if (!string.IsNullOrEmpty(kommentar))
            {
                warGefuellt = true;
                textBox1.Text = kommentar;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            if (string.IsNullOrEmpty(textBox1.Text) && warGefuellt)
            {
                if (MessageBox.Show("Soll der Kommentar wirklich gelöscht werden?", "Frage", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            kommentar = textBox1.Text;
        }

        private void btLoeschen_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            textBox1.Text = "";
        }
    }
}
