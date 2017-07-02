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
     * Fenster, in dem dynamisch alle existenten Zelte angezeigt werden.
     * Aus diesen kann dann eines ausgewählt werden, zu dem Informationen
     * angezeigt werden sollen.
     */
    public partial class Zeltauswahl : Form
    {
        private List<Teilnehmer> abwesend = new List<Teilnehmer>();
        private List<Teilnehmer> anwesend = new List<Teilnehmer>();

        public Zeltauswahl(List<Teilnehmer> abwesend, List<Teilnehmer> anwesend, List<int> zeltnummern)
        {
            InitializeComponent();

            this.abwesend = abwesend;
            this.anwesend = anwesend;

            if (zeltnummern.Count > 0)
            {
                int x = 0;
                int y = 0;
                int hoehe = 60;
                int breite = 60;
                int abstand = 8;
                int buttonsProReihe = 5;
                this.SetBounds(this.Location.X, this.Location.Y, abstand*2 + buttonsProReihe * (breite + abstand) + 7, abstand*2 + buttonsProReihe * (hoehe + abstand) + 29);
                foreach (int n in zeltnummern)
                {
                    try //Eigentlich sinnlos
                    {
                        Button bt = new Button();
                        bt.SetBounds(abstand + x * (breite + abstand), abstand + y * (hoehe + abstand), breite, hoehe);
                        bt.Font = new Font("Microsoft Sans Serif", 20);
                        bt.Text = n.ToString();
                        bt.Click += onButtonClick;
                        this.Controls.Add(bt);
                        x++;
                        if (x >= 5)
                        {
                            y++;
                            x = 0;
                        }
                    }
                    catch
                    {
                        Program.playSoundFail();
                        MessageBox.Show("Ein Zelt-Menüeintrag konnte nicht hinzugefügt werden.", "Fehler");
                    }
                }
            }
        }

        private void onButtonClick(Object sender, EventArgs e)
        {
            string zeltnrStr = ((Button)sender).Text;
            try
            {
                int zeltnr = int.Parse(zeltnrStr);
                ZeltFenster zf = new ZeltFenster(zeltnr, abwesend, anwesend);
                Program.playSoundFeedback();
                zf.ShowDialog();
            }
            catch
            {
                Program.playSoundFail();
                MessageBox.Show("Es ist ein Fehler aufgetreten:\nDas Zelt existiert nicht oder hat keine Teamer.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
