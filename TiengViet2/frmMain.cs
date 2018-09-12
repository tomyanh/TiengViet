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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnXepTu_Click(object sender, EventArgs e)
        {
            frmHoc f = new frmHoc();   
            f.Show();
        }

        private void btnNoiOchu_Click(object sender, EventArgs e)
        {
            frmNoiCau f = new frmNoiCau();
            f.Show();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTongHop f = new frmTongHop();
            f.Show();
        }
    }
}
