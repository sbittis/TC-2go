using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCAbmeldung2;

namespace TCAbmeldung2.Fachkonzept
{
    public class Teilnehmer : Person
    {
        public String gemeinde { get; set; }
        public bool abwesend { get; set; }
        public bool check { get; set; }
        public String kommentar { get; set; }

        public Teilnehmer(int id, String nachname, String vorname, String gemeinde, int zeltnr, String kommentar)
        {
            this.id = id;
            this.nachname = nachname;
            this.vorname = vorname;
            this.gemeinde = gemeinde;
            this.zeltnr = zeltnr;
            this.kommentar = kommentar;
        }

        public override string ToString()
        {
            return vorname + " " + nachname + ", Zelt " + zeltnr.ToString();
        }

        public string ToFullString()
        {
            return vorname + " " + nachname + ", Zelt " + zeltnr.ToString() + " " + gemeinde + " " + kommentar;
        }
    }
}
