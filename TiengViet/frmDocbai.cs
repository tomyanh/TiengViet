using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiengViet
{
    public partial class frmDocbai : Form
    {
        public frmDocbai()
        {
            InitializeComponent();

            set_font();
        }

        private void set_font()
        {
             
            lblNoidung.Font = new Font(".VnAvant", 29, FontStyle.Bold);
            //lblNoidung.UseCompatibleTextRendering = true;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
