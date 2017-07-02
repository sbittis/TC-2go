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
     * Info-Fenster
     */
    public partial class InfoFenster : Form
    {
        public InfoFenster()
        {
            InitializeComponent();
            lbText.Text = "Diese Anwendung dient der Erfassung von Ab- und Anmeldungen von Teilnehmern im Bezug auf das zwischenzeitliche Verlassen des Campgeländes.\n" +
                            "Dazu werden die Teilnehmer jeweils per Scanner erfasst. Die Teilnehmer, die sich gerade nicht auf dem Campgelände befinden, werden im Hauptfenster " +
                            "angezeigt. Im Verlauf kann man nachvollziehen, welcher Teilnehmer sich wann bei wem ab- und angemeldet hat.\n" +
                            "Zusätzlich können Sanitäter-Tätigkeiten aufgenommen und verwaltet werden.\n\n\n" +
                            "TC-2go Version " + Application.ProductVersion + "\n" + Convert.ToChar(169) + " sb 2014-2017";
        }
    }
}
