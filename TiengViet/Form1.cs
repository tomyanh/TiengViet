using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiengViet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
             
            InitializeComponent();

            
        }

        Point[] _points;
        PointF[] _leftpoints;
        PointF[] _rightpoints;
        PointF[] _boundpoints;
        int _thickness;
        int _pointnum;
        private void Form1_Load(object sender, EventArgs e)
        {
            

             


        }
        bool mouseIsDown;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (flag)
            //{
            //    Graphics g = this.CreateGraphics();

            //    Point p2 = e.Location;

            //    EraseLine(p, endPoint, g);
                 
            //    DrawLine(p, p2, g);

            //    endPoint = p2;

            //    g.Dispose();
            //}
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //draw = false;
        }


        private void DrawLine(Point start, Point end, Graphics g)
        {
            //g.DrawLine(myPen, start, end);
        }
         

        private void EraseLine(Point start, Point end, Graphics g)
        {
            //g.DrawLine(erasePen, start, end);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    if (!flag)
            //    {
            //        flag = true;
            //        p = e.Location;
            //        endPoint = p;
            //    }
            //    else
            //    {
            //        flag = false;
            //    }

            //}
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);

            //using (var blackPen = new Pen(Color.Black, 3))
            //    e.Graphics.DrawLine(blackPen, new Point(20,20), new Point(50, 200));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        Point p1 = new Point();
        Point p2 = new Point();
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = get_start_location(sender as Control );
        }

        Point get_start_location(Control ct )
        {
            return new Point(ct.Location.X +  ct.Width-5, ct.Location.Y +ct.Height/2);
        }

        Point get_end_location(Point loc)
        {
            Point p = this.PointToClient(loc);
            foreach (Control ct in Controls)
            {
                if (ct.Name.StartsWith("lblEnd"))
                {
                    if (ct.Location.X <= p.X && p.X <= ct.Location.X + ct.Width &&
                        ct.Location.Y <= p.Y && p.Y <= ct.Location.Y + ct.Height)
                    {
                        return new Point(ct.Location.X+5, ct.Location.Y+ct.Height/2);
                    }
                }
            }
            return Point.Empty;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

            p2 = get_end_location(Cursor.Position); //this.PointToClient(Cursor.Position);

            if (!p2.IsEmpty)
                draw_line();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //p2 = new Point(button2.Location.X + 10, button2.Location.Y+10);
        }

        private void draw_line()
        {
            Point[] p = new Point[]
            {
                p1,
                p2
            };

            ZigzagControl line = new ZigzagControl(p, 2);

            this.Controls.Add(line);
            line.BringToFront();
            p2 = Point.Empty;
        }
    }
}
