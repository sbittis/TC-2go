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
     * Dieses Fenster stellt die Eingabemaske für eine Behandlung dar.
     */
    public partial class BehandlungFenster : Form
    {
        public Behandlung behandlung = null;
        private List<Teamer> teamer = new List<Teamer>();
        private List<Teilnehmer> teilnehmerliste = new List<Teilnehmer>();

        // Neue Behandlung
        public BehandlungFenster(Teamer arzt, List<Teamer> teamer, List<Teilnehmer> teilnehmerliste)
        {
            InitializeComponent();

            // neue Behandlung wird angelegt -> aktuelles Datum setzen
            behandlung = new Behandlung();
            DateTime date = DateTime.Now;
            txtErfasst.Text = date.ToString("dd.MM.yyyy HH:mm");
            if (arzt != null)
            {
                behandlung.arzt = arzt;
                txtTeamer.Text = arzt.ToString();
            }
            if (teamer != null)
            {
                this.teamer = teamer;
            }
            if (teilnehmerliste != null)
            {
                this.teilnehmerliste = teilnehmerliste;
            }
        }

        // Behandlung bearbeiten
        public BehandlungFenster(Behandlung b, List<Teamer> teamer, List<Teilnehmer> teilnehmerliste)
        {
            InitializeComponent();

            behandlung = b;
            if (!string.IsNullOrEmpty(b.erfasstDate))
            {
                txtErfasst.Text = b.erfasstDate;
            }
            if (!string.IsNullOrEmpty(b.patient.nachname))
            {
                txtNachname.Text = b.patient.nachname;
            }
            if (!string.IsNullOrEmpty(b.patient.vorname))
            {
                txtVorname.Text = b.patient.vorname;
            }
            if (b.patient.zeltnr > 0)
            {
                txtZelt.Text = b.patient.zeltnr + "";
            }
            if (b.arzt != null)
            {
                txtTeamer.Text = b.arzt.ToString();
            }
            if (!string.IsNullOrEmpty(b.text1))
            {
                txtText1.Text = b.text1;
            }
            if (!string.IsNullOrEmpty(b.text2))
            {
                txtText2.Text = b.text2;
            }

            if (teamer != null)
            {
                this.teamer = teamer;
            }
            if (teilnehmerliste != null)
            {
                this.teilnehmerliste = teilnehmerliste;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtErfasst.Text)
                || string.IsNullOrEmpty(txtTeamer.Text)
                || string.IsNullOrEmpty(txtText1.Text)
                || behandlung.patient == null)
            {
                this.DialogResult = DialogResult.None;
                Program.playSoundFail();
            }
            else
            {
                behandlung.erfasstDate = txtErfasst.Text;
                behandlung.text1 = txtText1.Text;
                behandlung.text2 = txtText2.Text;

                // behandlung.patient ist bereits gesetzt
                // behandlung.arzt ist bereits gesetzt

                Program.playSoundSuccess();
            }
        }

        private void btChangeTeamer_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            NameBox nb = new NameBox(teamer);
            if (nb.ShowDialog() == DialogResult.OK)
            {
                Teamer t = null;
                foreach (Teamer _t in teamer)
                {
                    if (nb.teamerId.Equals(_t.id.ToString()))
                    {
                        t = _t;
                        break;
                    }
                }
                behandlung.arzt = t;
                txtTeamer.Text = t.ToString();
            }
        }

        private void BehandlungFenster_Load(object sender, EventArgs e)
        {
            //txtText2.SetBounds(txtText2.Location.X, txtText2.Location.Y, txtText2.Width, 120);
            //this.SetBounds(this.Location.X, this.Location.Y, this.Width, txtText2.Top + txtText2.Height + 10);
            btScan.Text = "Scan\r\nTN";
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            Program.playSoundFeedback();
            // hier wird ein Teilnehmer-Scanfenster geöffnet
            TnNameBox tnbox = new TnNameBox();
            if (tnbox.ShowDialog() == DialogResult.OK)
            {
                Person p = null;
                foreach (Teilnehmer _tn in teilnehmerliste)
                {
                    if (tnbox.tnId.Equals(_tn.id.ToString()))
                    {
                        p = _tn;
                        break;
                    }
                }
                if (p == null)
                {
                    foreach (Teamer _t in teamer)
                    {
                        if (tnbox.tnId.Equals(_t.id.ToString()))
                        {
                            p = _t;
                            break;
                        }
                    }
                }
                if (p != null)
                {
                    behandlung.patient = p;

                    if (!string.IsNullOrEmpty(p.nachname))
                    {
                        txtNachname.Text = p.nachname;
                    }
                    if (!string.IsNullOrEmpty(p.vorname))
                    {
                        txtVorname.Text = p.vorname;
                    }
                    if (p.zeltnr > 0)
                    {
                        txtZelt.Text = p.zeltnr + "";
                    }
                }
            }
        }
    }
}
