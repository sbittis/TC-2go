using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCAbmeldung2.Fachkonzept
{
    /*
     * Eine Transaktion ist eine Abmeldung oder Anmeldung eines Teilnehmers.
     * Die Transaktionen werden in der Historie angezeigt.
     */
    class Transaktion
    {
        public bool abmeldung {get; set; }
        public String datum { get; set; }
        public String zeit { get; set; }
        public String tn { get; set; }
        public String teamer { get; set; }

        public Transaktion()
        {

        }

        public Transaktion(bool abmeldung, String datum, String zeit, String tn, String teamer)
        {
            this.abmeldung = abmeldung;
            this.datum = datum;
            this.zeit = zeit;
            this.tn = tn;
            this.teamer = teamer;
        }

        public override string ToString()
        {
            return datum + " " + zeit + " " + tn + " " + teamer;
        }
    }
}
