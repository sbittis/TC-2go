using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCAbmeldung2.GUI;
using System.Media;

namespace TCAbmeldung2
{
    static class Program
    {
        private static SoundPlayer success = null;
        private static SoundPlayer fail = null;
        private static SoundPlayer feedback = null;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hauptfenster());
        }

        public static void playSoundSuccess()
        {
            try
            {
                if (success == null)
                {
                    success = new SoundPlayer(Application.StartupPath + "\\sound\\tones-wav\\music_marimba_chord.wav");
                    success.Play();
                }
                success.Play();
            }
            catch { /* es geschieht nichts und es gibt keinen Sound */ }
        }

        public static void playSoundFail()
        {
            try
            {
                if (fail == null)
                {
                    fail = new SoundPlayer(Application.StartupPath + "\\sound\\tones-wav\\beep_short_on.wav");
                    fail.Play();
                }
                fail.Play();
            }
            catch { /* es geschieht nichts und es gibt keinen Sound */ }
        }

        public static void playSoundFeedback()
        {
            try
            {
                if (feedback == null)
                {
                    feedback = new SoundPlayer(Application.StartupPath + "\\sound\\tones-wav\\pop_drip.wav");
                    feedback.Play();
                }
                feedback.Play();
            }
            catch { /* es geschieht nichts und es gibt keinen Sound */ }
        }
    }
}
