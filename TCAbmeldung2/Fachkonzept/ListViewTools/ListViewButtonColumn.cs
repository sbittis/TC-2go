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
    public class ListViewButtonColumn : ListViewColumn
    {
        private Rectangle _hot = Rectangle.Empty;

        public ListViewButtonColumn(int columnIndex)
            : base(columnIndex)
        {
        }

        public bool FixedWidth { get; set; }
        public bool DrawIfEmpty { get; set; }

        public override ListViewExtender Extender
        {
            get
            {
                return base.Extender;
            }
            protected internal set
            {
                base.Extender = value;
                if (FixedWidth)
                {
                    base.Extender.ListView.ColumnWidthChanging += OnColumnWidthChanging;
                }
            }
        }

        protected virtual void OnColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == ColumnIndex)
            {
                e.Cancel = true;
                e.NewWidth = ListView.Columns[e.ColumnIndex].Width;
            }
        }

        public override void Draw(DrawListViewSubItemEventArgs e)
        {
            if (_hot != Rectangle.Empty)
            {
                if (_hot != e.Bounds)
                {
                    ListView.Invalidate(_hot);
                    _hot = Rectangle.Empty;
                }
            }

            if ((!DrawIfEmpty) && (string.IsNullOrEmpty(e.SubItem.Text)))
                return;

            Point mouse = e.Item.ListView.PointToClient(Control.MousePosition);
            if ((ListView.GetItemAt(mouse.X, mouse.Y) == e.Item) && (e.Item.GetSubItemAt(mouse.X, mouse.Y) == e.SubItem))
            {
                ButtonRenderer.DrawButton(e.Graphics, e.Bounds, e.SubItem.Text, Font, true, PushButtonState.Hot);
                _hot = e.Bounds;
            }
            else
            {
                ButtonRenderer.DrawButton(e.Graphics, e.Bounds, e.SubItem.Text, Font, false, PushButtonState.Default);
            }
        }
    }
}
