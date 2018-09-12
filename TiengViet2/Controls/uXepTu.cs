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
    public partial class uXepTu : UserControl
    {
         
        private BaiHoc baihocTV;
        public int baihoc = -1;

        private frmTongHop _parent;
        public uXepTu(frmTongHop parent)
        {
            InitializeComponent();
            _parent = parent;

            init_color_list();


            MyFunction.FromXml();

            //set_font();
             
        }

         
        private List<Label> listCtr_Box;
        private List<Label> listCtr_Tu;
        private int rong = 140;
        private int cao = 50;
        int le_trai = 20;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        BaiHoc Load_Baihoc(int bai)
        {
            return MyFunction.danhsachBaihoc.FirstOrDefault(x => x.Id == bai);
        }
        private void set_font()
        {
            //MyFunction.Load_font();
            //txtBai.Font = new Font(".VnAvant", 15, FontStyle.Bold);
            ////txtBai.UseCompatibleTextRendering = true;

            //lblBai.Font = new Font(".VnAvant", 15, FontStyle.Bold);
            ////lblBai.UseCompatibleTextRendering = true;

        }

        public void HienThiBaiHoc(int bai)
        {
            baihocTV = Load_Baihoc(bai);

            if (baihocTV == null)
            {
                return;
            }

            init_Tu();
            init_box();
        }

        private void int_all()
        {
            //this.panel1.Controls.Clear();
            

            while (panel1.Controls.Count > 2)
            {
                foreach (Control ct in this.panel1.Controls)
                {
                    if (ct.Name != "picYeah" && ct.Name != "btnCmdTiep")
                    {
                        this.panel1.Controls.Remove(ct);
                    }
                }
            }

            picYeah.Visible = false;
        }


        private int sodongTu = 1;
        private int gen_height = 0;
        private void init_Tu()
        {
            int_all();
            Random randomX = new Random();
            Random randomY = new Random();

            int Y = this.Height / 2;
            int X = 0;


            listCtr_Tu = new List<Label>();
            List<string> listTu = new List<string>();
             
            foreach (Noidung nd in baihocTV.baihoc)
            {
                foreach (string str in nd.noidung.Split(' '))
                {
                    listTu.Add(str);
                }
            }

            int sotu = listTu.Count;
            int sotu_motdong = (this.panel1.Width - le_trai) / (rong + 5);

            int sodong = (int)Math.Ceiling((double)sotu / (double)sotu_motdong);

            sodongTu = sodong;

            gen_height = panel1.Height;
            int vY = panel1.Height - sodong * (cao + 5);

            List<Point> vitri_Tu = new List<Point>();

            for (int i = 0; i < sodong; i++)
            {
                vitri_Tu.Add(new Point(le_trai, vY));

                vY = vY + cao + 5;
            }

            int idxCnt = 0;

            while (listTu.Count > 0)
            {
                Random randomTu = new Random();
                int randomIndex = randomTu.Next(0, listTu.Count);
                Random randomDong = new Random();
                int dong = randomDong.Next(0, vitri_Tu.Count);

                Point p = vitri_Tu[dong];


                Label l = new Label();
                l.Name = "myLblCtr_Tu" + idxCnt;
                l.Text = MyFunction.ConvertUNI2TCV(listTu[randomIndex]);

                l.Font = new Font(".VnAvant", 26, FontStyle.Bold);
                //l.Font = new Font(MyFunction.myfonts.Families[0],20, FontStyle.Bold);
                //l.UseCompatibleTextRendering = true;
                l.BackColor = init_color();
                l.BorderStyle = BorderStyle.FixedSingle;
                //l.ForeColor = Color.Yellow;
                l.AutoSize = false;
                l.Width = rong;
                l.Height = cao;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Cursor = Cursors.Hand;
                l.BringToFront();


                l.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
                l.Location = p;


                l.MouseMove += LOnMouseMove;
                l.MouseDown += LOnMouseDown;
                l.MouseUp += LOnMouseUp;

                this.panel1.Controls.Add(l);
                listCtr_Tu.Add(l);


                idxCnt++;

                listTu.RemoveAt(randomIndex);

                p.X = p.X + (rong + 5);


                if (p.X > panel1.Width - (rong + 5))
                {
                    vitri_Tu.RemoveAt(dong);
                }
                else
                {
                    vitri_Tu[dong] = p;
                }
            }
             


        }

        private Color box_bcolor = Color.Aquamarine;
        void init_box()
        {
            int x = le_trai;
            int y = le_trai;
            int w = rong + 10;
            int h = cao + 10;



            foreach (Noidung dong in baihocTV.baihoc)
            {
                int i = 0;
                foreach (string str in dong.noidung.Split(' '))
                {
                    if (x == le_trai && i > 0)
                    {
                        y = y + h + 5;
                    }

                    Label label = new Label();
                    label.Name = "myLblCtr_Box_" + dong.dong + "_" + i;
                    label.Text = "";
                    label.Tag = MyFunction.ConvertUNI2TCV(str);


                    label.Width = w;
                    label.Height = h;
                    label.BackColor = box_bcolor;
                    label.Location = new Point(x, y);
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.Fixed3D;


                    this.panel1.Controls.Add(label);

                    x += w + 10;

                    if (x > panel1.Width - w)
                    {
                        x = le_trai;

                    }

                    i++;
                }
                y = y + h + 15;
                x = le_trai;
            }

        }

        private void LOnMouseUp(object sender, MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.Button == System.Windows.Forms.MouseButtons.Left)
            {

                if (tempBColor != null)
                {
                    tempBColor.BackColor = box_bcolor;
                    tempBColor = null;
                }

                Label lb = sender as Label;
                afterLocation = lb.Location;

                if (lb.Tag !=null && lb.Tag.ToString() == "OK") return;

                Label dich = XacDinhViTri(lb);

                

                if (dich != null && lb.Text.ToLower() == dich.Tag.ToString().ToLower() && dich.Tag.ToString() != "OK")
                {
                    int iY = (int)((dich.Height - lb.Height) / 2);
                    int iX = (int)((dich.Width - lb.Width) / 2);

                    lb.Left = dich.Left + iX;
                    lb.Top = dich.Top + iY;
                    lb.Tag = "OK";

                    dich.BackColor = Color.Blue;
                    lb.BackColor = Color.Yellow;
                    lb.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    dich.Tag = "OK";


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
                    lb.Location = beforeLocation;
                    System.IO.Stream str = Properties.Resources.uhoh;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                    player.Play();
                }
            }
        }

        private void LOnMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            Label lb = sender as Label;
            if (mouseEventArgs.Button == System.Windows.Forms.MouseButtons.Left)
            {

                MouseDownLocation = mouseEventArgs.Location;
                beforeLocation = lb.Location;

                lb.BringToFront();

            }
        }

        private Label tempBColor = null;
        private void LOnMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            Label lb = sender as Label;
            if (mouseEventArgs.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (tempBColor != null)
                {
                    tempBColor.BackColor = box_bcolor;
                    tempBColor = null;
                }
                if (lb.Tag == null || lb.Tag.ToString() != "OK")
                {
                    lb.Left = mouseEventArgs.X + lb.Left - MouseDownLocation.X;
                    lb.Top = mouseEventArgs.Y + lb.Top - MouseDownLocation.Y;

                    Label dich = XacDinhViTri(lb);

                    if (dich != null )
                    {
                        if (dich.Tag.ToString() != "OK")
                        {
                            tempBColor = dich;
                            tempBColor.BackColor = Color.DeepPink;
                            
                        }
                    }
                }

            }
        }


        private bool Kiemtra_hoantat()
        {
            foreach (Control ct in panel1.Controls)
            {
                if (ct.GetType() == typeof(Label))
                {
                    if (ct.Name.StartsWith("myLblCtr_Tu"))
                    {
                        if (ct.Tag == null)
                            return false;
                    }
                }
            }
            return true;
        }

        private List<Color> listColor;

        private void init_color_list()
        {
            listColor = new List<Color>();
            //listColor.Add(Color.BlueViolet);
            listColor.Add(Color.BurlyWood);
            listColor.Add(Color.DarkOrange);
            listColor.Add(Color.DarkSeaGreen);
            listColor.Add(Color.DeepSkyBlue);
            listColor.Add(Color.LemonChiffon);
            listColor.Add(Color.LawnGreen);
            listColor.Add(Color.HotPink);
            listColor.Add(Color.Wheat);
            listColor.Add(Color.PapayaWhip);
            listColor.Add(Color.Aqua);
            listColor.Add(Color.Honeydew);
            listColor.Add(Color.Fuchsia);
            listColor.Add(Color.Yellow);
            listColor.Add(Color.BurlyWood);
            listColor.Add(Color.LightSkyBlue);
            listColor.Add(Color.DeepPink);
            listColor.Add(Color.Khaki);
            listColor.Add(Color.IndianRed);
        }

        Random randomColor = new Random();
        private Color init_color()
        {

            int iColor = randomColor.Next(0, listColor.Count);

            return listColor[iColor];

        }


        //private bool selected = false;
        private Point MouseDownLocation;


        private Point beforeLocation;
        private Point afterLocation;


        private Label XacDinhViTri(Label dc)
        {
            Point dcLoc = dc.Location;


            foreach (Control ct in this.panel1.Controls)
            {
                if (ct.Name.StartsWith("myLblCtr_Box"))
                {
                    if (dcLoc.X >= ct.Location.X - ct.Width/2 &&
                        dcLoc.X <= ct.Location.X + ct.Width / 2
                        && dcLoc.Y >= ct.Location.Y - ct.Height/2 &&
                        dcLoc.Y <= ct.Location.Y + ct.Height/2)
                    {
                        return ct as Label;
                    }
                }
            }
            return null;
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                 
                init_Tu();
                init_box();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
         
         
         
        private void panel1_Resize(object sender, EventArgs e)
        {
            

        }

        private void frmHoc_Resize(object sender, EventArgs e)
        {
            if (panel1.Width > 50 && panel1.Height > 50)
            {
               picYeah.Location = new Point(panel1.Width / 2 - picYeah.Width / 2, panel1.Height / 2 - picYeah.Height / 2);
                btnCmdTiep.Location= new Point(panel1.Width / 2 - btnCmdTiep.Width / 2, picYeah.Location.Y+picYeah.Height+20);
            }

            //label1.Text = ""+ panel1.Height;

              
            //foreach (Control ctx in panel1.Controls)
            //{
            //    if (ctx.Name.StartsWith("myLblCtr_Tu"))
            //    {
            //        ctx.Top = ctx.Top* panel1.Height / gen_height;
            //    }
            //}
            //gen_height = panel1.Height;


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
