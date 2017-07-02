using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCAbmeldung2.Persistenz;
using TCAbmeldung2.Fachkonzept;

namespace TCAbmeldung2.GUI
{
    /*
     * Fenster zur Anzeige eines Zeltes mit allen Teilnehmern und ihrem
     * Abwesenheits-Status und den Zeltteamern
     */
    public partial class ZeltFenster : Form
    {
        public ZeltFenster(int zeltnr, List<Teilnehmer> abwesend, List<Teilnehmer> anwesend)
        {
            InitializeComponent();
            List<Teamer> teamer = CSVHandler.getInstance().readTeamerFromCSV();
            this.Text = "Zelt " + zeltnr;
            lbTeamer.Text = "Zeltteamer: ";

            bool helpKomma = false;
            foreach (Teamer t in teamer)
            {
                if (t.zeltnr == zeltnr)
                {
                    if (helpKomma)
                    {
                        lbTeamer.Text += ", ";
                    }
                    lbTeamer.Text += t.vorname + " " + t.nachname;
                    helpKomma = true;
                }
            }

            lbTeilnehmer.Text += "\n";
            foreach (Teilnehmer tn in abwesend)
            {
                if (tn.zeltnr == zeltnr)
                {
                    lbTeilnehmer.Text += "\n" + tn.vorname + " " + tn.nachname + ", " + tn.gemeinde + " (unterwegs)";
                }
            }
            foreach (Teilnehmer tn in anwesend)
            {
                if (tn.zeltnr == zeltnr)
                {
                    lbTeilnehmer.Text += "\n" + tn.vorname + " " + tn.nachname + ", " + tn.gemeinde + " (anwesend)";
                }
            }
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
        }
    }
}
