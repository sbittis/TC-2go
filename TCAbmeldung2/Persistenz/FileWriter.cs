using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCAbmeldung2.Persistenz
{
    /*
     * Momentan nicht verwendet.
     */
    class FileWriter
    {
        public static bool writeToInfobeamer(int number)
        {
            try
            {
                if (Properties.Settings.Default.sendenAnInfobeamer)
                {
                    String pfad = Properties.Settings.Default.infobeamerPfad;
                    if (string.IsNullOrEmpty(pfad))
                    {
                        return false;
                    }
                    StreamWriter file = new StreamWriter(@pfad, false, System.Text.Encoding.Default);
                    file.Write(number + "");
                    file.Close();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
