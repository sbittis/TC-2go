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
    public partial class InfobeamerFenster : Form
    {
        /*
         * Momentan ohne Funktion
         */
        public InfobeamerFenster()
        {
            InitializeComponent();

            txtZielpfad.Text = Properties.Settings.Default.infobeamerPfad;
            cbInfobeamer.Checked = Properties.Settings.Default.sendenAnInfobeamer;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.infobeamerPfad = txtZielpfad.Text;
            Properties.Settings.Default.sendenAnInfobeamer = cbInfobeamer.Checked;
        }
    }
}
