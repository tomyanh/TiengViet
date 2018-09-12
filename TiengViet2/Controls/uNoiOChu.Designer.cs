namespace TiengViet2
{
    partial class uNoiOChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uNoiOChu));
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnCmdTiep = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picYeah = new System.Windows.Forms.PictureBox();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYeah)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.picYeah);
            this.pnMain.Controls.Add(this.btnCmdTiep);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(789, 532);
            this.pnMain.TabIndex = 3;
            // 
            // btnCmdTiep
            // 
            this.btnCmdTiep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmdTiep.BackColor = System.Drawing.Color.Lime;
            this.btnCmdTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdTiep.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCmdTiep.Location = new System.Drawing.Point(599, 459);
            this.btnCmdTiep.Name = "btnCmdTiep";
            this.btnCmdTiep.Size = new System.Drawing.Size(177, 63);
            this.btnCmdTiep.TabIndex = 2;
            this.btnCmdTiep.Text = "Tiếp tục";
            this.btnCmdTiep.UseVisualStyleBackColor = false;
            this.btnCmdTiep.Visible = false;
            this.btnCmdTiep.Click += new System.EventHandler(this.btnCmdTiep_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picYeah
            // 
            this.picYeah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picYeah.BackColor = System.Drawing.Color.Transparent;
            this.picYeah.Image = global::TiengViet2.Properties.Resources.yeah;
            this.picYeah.Location = new System.Drawing.Point(599, 276);
            this.picYeah.Name = "picYeah";
            this.picYeah.Size = new System.Drawing.Size(160, 160);
            this.picYeah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYeah.TabIndex = 3;
            this.picYeah.TabStop = false;
            this.picYeah.Visible = false;
            // 
            // uNoiOChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnMain);
            this.Name = "uNoiOChu";
            this.Size = new System.Drawing.Size(789, 532);
            this.Resize += new System.EventHandler(this.frmNoiCau_Resize);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picYeah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnCmdTiep;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picYeah;
    }
}