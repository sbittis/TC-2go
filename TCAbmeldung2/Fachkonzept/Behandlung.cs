using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCAbmeldung2.Fachkonzept
{
    public class Behandlung
    {
        public string erfasstDate { get; set; }
        // Teilnehmer-Objekt, nicht nachname, vorname, zelt. In der CSV nur die ID. Viel besser
        public Person patient { get; set; }
        public Teamer arzt { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }

        public Behandlung()
        {
            arzt = null;
        }


        override public String ToString()
        {
            return patient.nachname + " " + patient.vorname + " " + text1;
        }
    }
}
