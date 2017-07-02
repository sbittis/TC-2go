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
     * Fenster mit einem Ladebalken für langdauernde Operationen
     */
    public partial class LoadBox : Form
    {
        public LoadBox()
        {
            InitializeComponent();
        }

        public LoadBox(string text)
        {
            InitializeComponent();
            lbLoadBox.Text = text;
        }

        public void setText(string text)
        {
            lbLoadBox.Text = text;
        }
    }
}
