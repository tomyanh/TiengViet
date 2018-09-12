using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiengViet2
{
    public partial class uNoiOChu : UserControl
    {

        private BaiHoc baihocTV;
        private List<BaiHoc> danhsachNoiCau;

        public int baihoc = -1;

        private frmTongHop _parent;
        public uNoiOChu(frmTongHop parent)
        {
            InitializeComponent();

            
            _parent = parent;

            //HienThiBaiHoc();

        }

        BaiHoc Load_Baihoc(int bai)
        {
            MyFunction.FromXml_NoiCau();
            return MyFunction.danhsachBaihoc.FirstOrDefault(x => x.Id == bai);
        }

        public void HienThiBaiHoc(int bai)
        {
            baihocTV = null;
            baihocTV = Load_Baihoc(bai);

            if (baihocTV == null)
            {
                return;
            }

            init_noicau();
        }

        private int sotu = 0;

        void clear_all()
        {
            //pnMain.Controls.Clear();

            //while (this.Controls.OfType<Label>().Where(c => c.Name.StartsWith("myLbl")).Count() > 0)
            //{
            //    foreach (Control ctx in this.Controls)
            //    {
            //        if (ctx.Name.StartsWith("myLbl"))
            //        {
            //            this.Controls.Remove(ctx);
            //        }
            //    }
            //}

            while (pnMain.Controls.Count > 2)
            {
                foreach (Control ct in this.pnMain.Controls)
                {
                    if (ct.Name != "picYeah" && ct.Name != "btnCmdTiep")
                    {
                        this.pnMain.Controls.Remove(ct);
                    }
                }
            }

            picYeah.Visible = false;



        }
        void init_noicau()
        {
            clear_all();

            BaiHoc bh = baihocTV;

            if (bh == null) return;
             
            List<Cau> trai = new List<Cau>();
            List<Cau> phai = new List<Cau>();

            Random ranDong = new Random();

            List<Noidung> listCau = new List<Noidung>();
                listCau= bh.baihoc;

            sotu = listCau.Count;

             
            int i = 0;
            while (listCau.Count > 0)
            {
                int dong = ranDong.Next(0, listCau.Count);
                string strNoidung = bh.baihoc[dong].noidung;

                string[] s = strNoidung.Split(new[] { "//" }, StringSplitOptions.None);
                 

                trai.Add(new Cau() {id = bh.baihoc[dong].dong, noidung = s[0]});
                phai.Add(new Cau() {id = bh.baihoc[dong].dong, noidung = s[1]});

                listCau.RemoveAt(dong);
                i++;
            }

             
            ve_trai(trai);
            ve_phai(phai);


        }

        void ve_trai(List<Cau> cau)
        {
            
             
            int x = pnMain.Width/2-rong-100;
            int y = (pnMain.Height - cau.Count*cao - 20)/2-50;

            Random rdDong = new Random();

            while (cau.Count>0)
            {
                int idx = rdDong.Next(0, cau.Count);
                idx = rdDong.Next(0, cau.Count);

                Label lb = new Label();
                lb.Text = MyFunction.ConvertUNI2TCV(cau[idx].noidung);
                lb.Tag = cau[idx].id;
                lb.Name = "myLblTrai" + cau[idx].id;

                lb.Font = new Font(".VnAvant", 20, FontStyle.Bold);
                lb.BackColor = Color.Aquamarine;
                lb.BorderStyle = BorderStyle.FixedSingle;                
                lb.AutoSize = false;
                lb.Width = rong;
                lb.Height = cao;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.Cursor = Cursors.Hand;

                Point p = new Point(x,y);

                lb.Location = p;

                lb.MouseDown += button_MouseDown;
                lb.MouseUp += button_MouseUp;


                pnMain.Controls.Add(lb);

                y = y + cao + 20;

                cau.RemoveAt(idx);

            }
        }

        int rong = 250;
        int cao = 80;

        void ve_phai(List<Cau> cau)
        {
             
            

            int x = pnMain.Width / 2 + 100;
            int y = (pnMain.Height - cau.Count * cao - 20) / 2-50;

            Random rdDong = new Random();

            while (cau.Count > 0)
            {
                int idx = rdDong.Next(0, cau.Count);
                 
                Label lb = new Label();
                lb.Text = MyFunction.ConvertUNI2TCV(cau[idx].noidung);
                lb.Tag = cau[idx].id;
                lb.Name = "myLblPhai" + cau[idx].id;

                lb.Font = new Font(".VnAvant", 20, FontStyle.Bold);
                lb.BackColor = Color.Aquamarine;
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.AutoSize = false;
                lb.Width = rong;
                lb.Height = cao;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.Cursor = Cursors.Hand;

                Point p = new Point(x, y);

                lb.Location = p;



                pnMain.Controls.Add(lb);

                y = y + cao + 20;

                cau.RemoveAt(idx);

            }
        }


        private Label start_label = null;
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            start_label = sender as Label;
            if (start_label.Tag.ToString() == "OK")
            {
                start_label = null;

                System.IO.Stream str = Properties.Resources.uhoh;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play();
                return;
            }

            p1 = get_start_location(sender as Control);
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            if (start_label == null) return;

            Label end_label = get_end_Label(Cursor.Position);

            if (end_label !=null )
            {
                if (start_label.Tag.ToString() == end_label.Tag.ToString())
                {
                    p2 = get_end_location(end_label);
                    draw_line();

                    start_label.Tag = "OK";
                    start_label.BackColor = Color.Khaki;
                    end_label.BackColor = Color.Khaki;

                    //kiem tra hoan tat
                    if (Kiemtra_hoantat())
                    {
                        picYeah.BringToFront();
                        btnCmdTiep.BringToFront();
                        timer1.Enabled = true;
                        btnCmdTiep.Visible = true;

                    }

                    System.IO.Stream str = Properties.Resources.applause10;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                    player.Play();
                }
                else
                {
                    System.IO.Stream str = Properties.Resources.uhoh;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                    player.Play();
                }

                
            }
                
        }


        Point p1 = new Point();
        Point p2 = new Point();

        Point get_start_location(Control ct)
        {
            return new Point(ct.Location.X + ct.Width - 5, ct.Location.Y + ct.Height / 2);
        }

        Point get_end_location(Control ct)
        {

            return new Point(ct.Location.X + 5, ct.Location.Y + ct.Height / 2);
        }
 

        Label get_end_Label(Point loc)
        {
            Point p = pnMain.PointToClient(loc);
            foreach (Control ct in pnMain.Controls)
            {
                if (ct.Name.StartsWith("myLblPhai"))
                {
                    if (ct.Location.X <= p.X && p.X <= ct.Location.X + ct.Width &&
                        ct.Location.Y <= p.Y && p.Y <= ct.Location.Y + ct.Height)
                    {
                        return ct as Label;
                    }
                }
            }

            return null;
        }




        private void draw_line()
        {
            Point[] p = new Point[]
            {
                p1,
                p2
            };

            ZigzagControl line = new ZigzagControl(p, 2);
            line.Name = "myLbl" + DateTime.Now.ToString("yyyyMMddHHmmss");
            pnMain.Controls.Add(line);
            line.BringToFront();
            p2 = Point.Empty;
        }


        private bool Kiemtra_hoantat()
        {
            foreach (Control ct in pnMain.Controls)
            {
                if (ct.GetType() == typeof(Label))
                {
                    if (ct.Name.StartsWith("myLblTrai"))
                    {
                        if (ct.Tag.ToString() != "OK")
                            return false;
                    }
                }
            }
            return true;
        }

        private void frmNoiCau_Resize(object sender, EventArgs e)
        {
            if (pnMain.Width > 50 && pnMain.Height > 50)
            {
                picYeah.Location = new Point(pnMain.Width / 2 - picYeah.Width / 2, pnMain.Height / 2 - picYeah.Height / 2);
                btnCmdTiep.Location = new Point(pnMain.Width / 2 - btnCmdTiep.Width / 2, picYeah.Location.Y + picYeah.Height + 20);
            }



        }

        public void set_vitri()
        {
            int x = pnMain.Width / 2 - rong - 100;
            int y = (pnMain.Height - sotu * (cao + 20)) / 2 - 50;

            foreach (Control ctx in pnMain.Controls)
            {
                if (ctx.Name.StartsWith("myLblTrai"))
                {
                    ctx.Left = x;
                    ctx.Top = y;

                    y = y + cao + 20;
                }
            }

            int x2 = pnMain.Width / 2 + 100;
            y = (pnMain.Height - sotu * (cao + 20)) / 2 - 50;
            foreach (Control ctx in pnMain.Controls)
            {
                if (ctx.Name.StartsWith("myLblPhai"))
                {
                    ctx.Left = x2;
                    ctx.Top = y;
                    y = y + cao + 20;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init_noicau();
        }

        private void btnBai_Click(object sender, EventArgs e)
        {
             

        }
        private int timer_cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            picYeah.Visible = !picYeah.Visible;
            timer_cnt++;
            if (timer_cnt == 5)
            {
                timer1.Enabled = false;
                timer_cnt = 0;
                picYeah.Visible = true;
            }
        }

        private void btnCmdTiep_Click(object sender, EventArgs e)
        {
            _parent.Load_Bai();
        }
    }
     
}
