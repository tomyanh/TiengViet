using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiengViet2
{
    public partial class uChonBai : UserControl
    {
        private frmTongHop _parent;
        public uChonBai(frmTongHop parent)
        {
            InitializeComponent();
            _parent = parent;

        }

        public void HienThiBaiHoc(List<int> lstBai)
        {
            int rong = 150;
            int cao = 45;
            int space = 5;
            int le = 50;
            int X=le;
            int Y=le;

            int sobai = lstBai.Count;
            int sobai_motdong = (this.pnMain.Width - le) / (rong + space);
            int sodong = (int)Math.Ceiling((double)sobai / (double)sobai_motdong);

            int Y_batdau = (this.pnMain.Height - sodong * (cao + space))/2;

            if (Y_batdau < 0) Y_batdau = 5;
            Y = Y_batdau;

            for (int i = 0; i < lstBai.Count; i++)
            {
                Label l = new Label();
                l.Name = "myLblCtr_bai" + i;
                l.Text = MyFunction.ConvertUNI2TCV("Bài " + lstBai[i]);
                l.Tag = lstBai[i];

                l.Font = new Font(".VnAvant", 16, FontStyle.Regular);
                 
                l.BackColor = Color.Bisque;
                l.BorderStyle = BorderStyle.FixedSingle;
                //l.ForeColor = Color.Blue;
                l.AutoSize = false;
                l.Width = rong;
                l.Height = cao;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Cursor = Cursors.Hand;
                l.BringToFront();


                //l.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

                Point p = new Point(X,Y);
                l.Location = p;
                
                l.Click += LOnClick; 
                //l.MouseHover += LOnMouseHover;
                l.MouseLeave += LOnMouseLeave;
                l.MouseMove += LOnMouseMove;

                this.pnMain.Controls.Add(l);

                X = X + rong + space;

                if (X > this.pnMain.Width - (rong +space))
                {
                    X = le;
                    Y = Y + cao + space;
                }
                 
            }

            
        }

        private void LOnMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            Label l = sender as Label;
            l.BackColor = Color.Pink;
        }

        private void LOnMouseLeave(object sender, EventArgs eventArgs)
        {
            Label l = sender as Label;
            l.BackColor = Color.Bisque;
        }



        private void LOnClick(object sender, EventArgs eventArgs)
        {
            _parent.bai = int.Parse(((sender) as Label).Tag.ToString());
            _parent.phan = -1;
            _parent.Load_Bai();
        }
    }
}
