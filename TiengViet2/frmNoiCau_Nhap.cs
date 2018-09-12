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
    public partial class frmNoiCau_Nhap : Form
    {
        public int id_chon=-1;
        public frmNoiCau_Nhap()
        {
            InitializeComponent();
            if (!MyFunction.FromXml_NoiCau())
            {
                MessageBox.Show("Hãy nhập thông tin bài học trước.");
                return;
            }
        }

        private void frmChonbai_Load(object sender, EventArgs e)
        {
            load_listBaihoc();
            init_input();
        }

        private void load_listBaihoc()
        {
            if (MyFunction.danhsachBaihoc == null) return;

            lstBaihoc.Items.Clear();
            foreach (BaiHoc bh in MyFunction.danhsachBaihoc.OrderBy(x=>x.thutu).ToList())
            {
                string[] row = { bh.tieude.ToString(), "Bài " + bh.tieude };
                var item = new ListViewItem(row);
                lstBaihoc.Items.Add(item);
            }
        }

        private void lstBaihoc_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void lstBaihoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBaihoc.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lstBaihoc.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String id = lstBaihoc.Items[intselectedindex].SubItems[0].Text;
                txtID.Text = id;

                BaiHoc bh = MyFunction.ThongtinBaihoc(int.Parse(id));
                txtTieude.Text = bh.tieude.ToString();
                txtNoidung.Text = MyFunction.NoidungToText(bh.baihoc);
                txtThutu.Text = bh.thutu.ToString();
            }
        }

        private void init_input()
        {
            txtID.Text = "";
            txtTieude.Text = "";
            txtNoidung.Text = "";
            txtTieude.Focus();
            txtThutu.Text = MyFunction.Get_MaxId().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            init_input();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            { 

                BaiHoc bh = MyFunction.danhsachBaihoc.FirstOrDefault(x => x.Id == int.Parse(txtID.Text));

                if (bh != null)
                {
                    try
                    {
                        MyFunction.danhsachBaihoc.Remove(bh);
                        MyFunction.ToXml_NoiCau();

                        load_listBaihoc();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Khong Xoa Duoc");
                        return;
                    }

                }
                 
            }
            init_input();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            ////foreach (BaiHoc bh in MyFunction.danhsachBaihoc)
            ////{
            ////    //bh.Id = int.Parse(bh.tieude.Replace("Bài ", "").Replace("Bai", "").Replace(" ", "").Trim());
            ////    bh.tieude = bh.tieude.Replace("Bài ", "").Replace("Bai", "").Replace(" ", "").Trim();

            ////}

            ////MyFunction.ToXml_NoiCau();

            ////return;

            if (txtTieude.Text.Trim() == "" || txtNoidung.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }

            List<string> txt = txtNoidung.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            int dong = 0;
            List<Noidung> baihoc = new List<Noidung>();


            foreach (string str in txt)
            {                
                if (str.Trim().Length > 0)
                {
                    Noidung nd = new Noidung();
                    dong++;
                    nd.dong = dong;
                    nd.noidung = str.Trim();

                    baihoc.Add(nd);
                }
            }

            
            if (txtID.Text != "")
            {

                int idx = MyFunction.danhsachBaihoc.FindIndex(x => x.Id == int.Parse(txtID.Text));
                MyFunction.danhsachBaihoc[idx].tieude = int.Parse(txtTieude.Text.Trim());
                MyFunction.danhsachBaihoc[idx].baihoc = baihoc;
                MyFunction.danhsachBaihoc[idx].thutu = int.Parse(txtThutu.Text);
            }
            else
            {
                BaiHoc bh = new BaiHoc();
                bh.Id = MyFunction.Get_MaxId() + 1;
                bh.tieude = int.Parse(txtTieude.Text.Trim());
                bh.baihoc = baihoc;
                bh.thutu = int.Parse(txtThutu.Text);
                MyFunction.danhsachBaihoc.Add(bh);
            }

            MyFunction.ToXml_NoiCau();

            load_listBaihoc();
            init_input();
        }

        private void btnHoc_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chưa chọn bài!!");
                return;
            }

            id_chon = int.Parse(txtThutu.Text);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pnInput.Visible = checkBox1.Checked;
        }
    }
}
