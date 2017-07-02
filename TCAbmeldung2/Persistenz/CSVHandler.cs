using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TCAbmeldung2.Fachkonzept;
using System.Windows.Forms;

namespace TCAbmeldung2.Persistenz
{
    /*
     * Klasse zur Anbindung von CSV-Dateien (Lesen und Schreiben).
     * In diesen können alle notwendigen Daten gespeichert werden.
     */
    class CSVHandler
    {
        private static CSVHandler reader = null;

        private CSVHandler()
        {
            
        }

        public static CSVHandler getInstance()
        {
            if (reader == null)
            {
                return new CSVHandler();
            }
            else
            {
                return reader;
            }
        }

        public List<List<Teilnehmer>> readTnFromCSV(out List<int> zelte)
        {
            zelte = new List<int>();

            List<List<Teilnehmer>> result = new List<List<Teilnehmer>>();
            List<Teilnehmer> anwesendListe = new List<Teilnehmer>();
            List<Teilnehmer> abwesendListe = new List<Teilnehmer>();
            result.Add(anwesendListe);
            result.Add(abwesendListe);

            try
            {
                StreamReader file = new StreamReader(@Properties.Settings.Default.sourcePfad, System.Text.Encoding.Default);
                // Titelzeile überspringen
                file.ReadLine();
                String line;
                while ((line = file.ReadLine()) != null)
                {
                    String[] daten = line.Split(new char[] { ',' });
                    int id = int.Parse(daten[0]);
                    String nachname = daten[1];
                    String vorname = daten[2];
                    String gemeinde = daten[3];
                    int zeltnr = int.Parse(daten[4]);
                    bool abwesend = "1".Equals(daten[5]);
                    String kommentar = daten[6];
                    Teilnehmer tn = new Teilnehmer(id, nachname, vorname, gemeinde, zeltnr, kommentar);
                    if (abwesend)
                    {
                        abwesendListe.Add(tn);
                    }
                    else
                    {
                        anwesendListe.Add(tn);
                    }

                    if (!zelte.Contains(zeltnr))
                    {
                        zelte.Add(zeltnr);
                    }
                }
                file.Close();
                zelte.Sort();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten:\n" + e.Message);
            }
            return null;
        }

        public bool writeTnToCSV(List<Teilnehmer> anwesendListe, List<Teilnehmer> abwesendListe)
        {
            try
            {
                StreamWriter file = new StreamWriter(@Properties.Settings.Default.sourcePfad, false, System.Text.Encoding.Default);
                file.WriteLine("ID,Nachname,Vorname,Gemeinde,Zelt,abwesend,Kommentar");
                foreach (Teilnehmer tn in anwesendListe)
                {
                    file.WriteLine(tn.id + "," + tn.nachname + "," + tn.vorname + "," + tn.gemeinde + "," + tn.zeltnr + "," + "0" + "," + tn.kommentar.Replace(',', ' '));
                }
                foreach (Teilnehmer tn in abwesendListe)
                {
                    file.WriteLine(tn.id + "," + tn.nachname + "," + tn.vorname + "," + tn.gemeinde + "," + tn.zeltnr + "," + "1" + "," + tn.kommentar.Replace(',', ' '));
                }
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Teamer> readTeamerFromCSV()
        {
            List<Teamer> result = new List<Teamer>();

            try
            {
                StreamReader file = new StreamReader(@Properties.Settings.Default.teamerPfad, System.Text.Encoding.Default);
                // Titelzeile überspringen
                file.ReadLine();
                String line;
                while ((line = file.ReadLine()) != null)
                {
                    String[] daten = line.Split(new char[] { ',' });
                    int id = int.Parse(daten[0]);
                    String nachname = daten[1];
                    String vorname = daten[2];
                    int zeltnr = int.Parse(daten[3]);
                    Teamer t = new Teamer(id, nachname, vorname, zeltnr);
                    result.Add(t);
                }
                file.Close();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten:\n" + e.Message);
            }
            return null;
        }

        public List<String> readZeltteamerFromCSV(int zeltnr)
        {
            try
            {
                StreamReader file = new StreamReader(@Properties.Settings.Default.teamerPfad, System.Text.Encoding.Default);

                String line;
                List<String> teamer = new List<String>();
                while ((line = file.ReadLine()) != null)
                {
                    String[] daten = line.Split(new char[] { ',' });
                    if (daten.Length > 0 && zeltnr == int.Parse(daten[0]))
                    {
                        if (daten.Length > 1)
                        {
                            teamer.Add(daten[1]);
                        }
                        if (daten.Length > 2)
                        {
                            teamer.Add(daten[2]);
                        }
                        break; break;
                    }
                }
                file.Close();
                return teamer;
            }
            catch
            {
                return null;
            }
        }

        public bool writeBehandlungenToCSV(List<Behandlung> behandlungen)
        {
            try
            {
                StreamWriter file = new StreamWriter(@Properties.Settings.Default.saniPfad, false, System.Text.Encoding.Default);
                foreach (Behandlung b in behandlungen)
                {
                    file.WriteLine(b.erfasstDate + "##" + (b.patient != null ? b.patient.id + "" : "0") + "##" + (b.arzt != null ? b.arzt.id + "" : "0") + "##" + b.text1 + "##" + b.text2);
                }
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
