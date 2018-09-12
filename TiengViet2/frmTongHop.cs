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
    public partial class frmTongHop : Form
    {
        public frmTongHop()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            Load_ListBai();

            //bai = 9;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Load_Bai();
            
        }
         
        public int phan = -1;
        public int bai = -1;

        private uXepTu u1;
        private uNoiOChu u2;
        void init_uControl(int bai, int phan)
        {
            pnMain.Controls.Clear();
            switch (phan)
            {
                case 1:
                    u1 = new uXepTu(this);
                    u1.Dock = DockStyle.Fill;
                    pnMain.Controls.Add(u1);
                    u1.HienThiBaiHoc(bai);
                    break;
                case 2:
                    u2 = new uNoiOChu(this);
                    u2.Dock = DockStyle.Fill;
                    pnMain.Controls.Add(u2);
                     
                    u2.HienThiBaiHoc(bai);
                    break;
            }
        }
        
        

        private List<BaiHoc> lstXepTu;
        private List<BaiHoc> lstNoiOChu;
        private List<int> lstBai = null;
        private List<int> lst1;     //list bai phan 1
        private List<int> lst2;     //list bai phan 2
        public void Load_ListBai()
        {
            lstXepTu = MyFunction.Get_Ds_XepTu();

            lst1 = lstXepTu.Select(b => b.Id).Distinct().OrderBy(s => s).ToList();

            lstNoiOChu = MyFunction.Get_Ds_NoiOChu();

            lst2 = lstNoiOChu.Select(b => b.Id).Distinct().OrderBy(s => s).ToList();

            lstBai = lst1.Union(lst2).ToList();

        }

        public void Load_Bai()
        {
            if (lstBai == null || lstBai.Count == 0) return;

            if (bai == -1)
            {
                bai = lstBai.OrderBy(s => s).FirstOrDefault();
            }
            else
            {
                if (phan == 2) //Den bai ke tiep
                {
                    int bai_ke;
                    bai_ke = lstBai.OrderBy(s => s).FirstOrDefault(s=> s > bai);

                    if (bai_ke == 0)
                    {
                        MessageBox.Show("Hết rồi !!!");
                        return;
                    }
                    bai = bai_ke;
                    phan = -1;
                }
            }

            if (phan < 1)
            {
                 
                //kiem tra Bai co phan 1 khong
                var p = lst1.FirstOrDefault(s => s == bai);
                if (p > 0)
                {
                    phan = 1;
                }
                else
                {
                    phan = 2;
                }
                init_uControl(bai, phan);
            }
            else if (phan == 1)
            {
                //kiem tra co phan 2 khong, neu co phan 2 thi hien thi phan 2. neu khong co thi hien thi bai ke tiep

                //kiem tra Bai co phan 2 khong
                var p = lst2.FirstOrDefault(s => s == bai);
                if (p > 0)
                {
                    phan = 2;
                    init_uControl(bai, phan);
                }
                else
                {
                    phan = 2;
                    Load_Bai();
                    return;
                }
            }

            lblBai.Text = MyFunction.ConvertUNI2TCV("Bài " + bai);
        }

        
        private void btnDocbai_Click(object sender, EventArgs e)
        {
            frmDocbai f = new frmDocbai();

            string strNoidung = "";

            if (phan == 1)
            {
                BaiHoc bh = lstXepTu.FirstOrDefault(s => s.Id == bai);
                foreach (Noidung nd in bh.baihoc)
                {
                    strNoidung += MyFunction.ConvertUNI2TCV(nd.noidung) + Environment.NewLine;

                }
            }

            if (phan == 2)
            {
                BaiHoc bh = lstNoiOChu.FirstOrDefault(s => s.Id == bai);
                foreach (Noidung nd in bh.baihoc)
                {
                    strNoidung += MyFunction.ConvertUNI2TCV(nd.noidung.Replace("//"," ")) + Environment.NewLine;

                }
            }
             
            f.lblNoidung.Text = strNoidung;
            f.ShowDialog();
            f.Dispose();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            if (phan == 1)
                u1.HienThiBaiHoc(bai);

            if (phan == 2)
                u2.HienThiBaiHoc(bai);
        }

        private void btnBaiKe_Click(object sender, EventArgs e)
        {
            phan = 2;
            Load_Bai();
        }

        private void btnBaiTruoc_Click(object sender, EventArgs e)
        {
            int bai_truoc;

            if (bai == -1) return;

            bai_truoc = lstBai.OrderBy(s => s).LastOrDefault(s => s < bai);

            if (bai_truoc > 0)
            {
                bai = bai_truoc;
                phan = -1;
                Load_Bai();
            }
            else
            {
                MessageBox.Show("Hết rồi !!!");
            }
            
        }

        private void btnChonBai_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();

            uChonBai u = new uChonBai(this);
            
            u.Dock = DockStyle.Fill;
            pnMain.Controls.Add(u);
            u.HienThiBaiHoc(lstBai);
             
             

        }
    }
}
