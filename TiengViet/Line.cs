using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiengViet
{
    class Lines : Control
    {
        Pen b = new Pen(Color.Black, 3);
        Point pp, lb;
        public Pen B
        {
            get { return b; }
            set { b = value; }
        }

        public void takecords(PictureBox cb, PictureBox bc)
        {
            pp = new Point(cb.Location.X, cb.Location.Y);
            lb = new Point(bc.Location.X, bc.Location.Y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Focus(); //Focus is a method from the Controlclass
            base.OnPaint(e);
            e.Graphics.DrawLine(b, pp, lb);

        }

        public void paint(PaintEventArgs e)
        {
            OnPaint(e);
        }
    }
}
