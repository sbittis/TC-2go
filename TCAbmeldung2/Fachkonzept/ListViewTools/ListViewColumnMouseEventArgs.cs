using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TCAbmeldung2.Fachkonzept
{
    public class ListViewColumnMouseEventArgs : MouseEventArgs
    {
        public ListViewColumnMouseEventArgs(MouseEventArgs e, ListViewItem item, ListViewItem.ListViewSubItem subItem)
            : base(e.Button, e.Clicks, e.X, e.Y, e.Delta)
        {
            Item = item;
            SubItem = subItem;
        }

        public ListViewItem Item { get; private set; }
        public ListViewItem.ListViewSubItem SubItem { get; private set; }
    }
}
