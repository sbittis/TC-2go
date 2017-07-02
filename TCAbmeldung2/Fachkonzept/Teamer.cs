using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCAbmeldung2.Fachkonzept
{
    public class Teamer : Person
    {

        public Teamer(int id, String nachname, String vorname, int zeltnr)
        {
            this.id = id;
            this.nachname = nachname;
            this.vorname = vorname;
            this.zeltnr = zeltnr;
        }

        public override string ToString()
        {
            return vorname + " " + nachname;
        }

        public string ToFullString()
        {
            return vorname + " " + nachname + ", Zelt " + zeltnr.ToString();
        }
    }
}
