namespace TiengViet
{
    partial class frmHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picYeah = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBai = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkNoidung = new System.Windows.Forms.CheckBox();
            this.btnDocbai = new System.Windows.Forms.Button();
            this.lblBai = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnBaiTruoc = new System.Windows.Forms.Button();
            this.btnBaiKe = new System.Windows.Forms.Button();
            this.btnChonBai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYeah)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picYeah);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 393);
            this.panel1.TabIndex = 3;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // picYeah
            // 
            this.picYeah.BackColor = System.Drawing.Color.Transparent;
            this.picYeah.Image = global::TiengViet.Properties.Resources.yeah;
            this.picYeah.Location = new System.Drawing.Point(584, 173);
            this.picYeah.Name = "picYeah";
            this.picYeah.Size = new System.Drawing.Size(191, 195);
            this.picYeah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYeah.TabIndex = 0;
            this.picYeah.TabStop = false;
            this.picYeah.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.Controls.Add(this.txtBai);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 100);
            this.panel3.TabIndex = 2;
            // 
            // txtBai
            // 
            this.txtBai.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBai.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBai.Location = new System.Drawing.Point(130, 0);
            this.txtBai.Name = "txtBai";
            this.txtBai.Size = new System.Drawing.Size(309, 100);
            this.txtBai.TabIndex = 4;
            this.txtBai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtBai.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.chkNoidung);
            this.panel4.Controls.Add(this.btnDocbai);
            this.panel4.Controls.Add(this.lblBai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 100);
            this.panel4.TabIndex = 3;
            // 
            // chkNoidung
            // 
            this.chkNoidung.AutoSize = true;
            this.chkNoidung.Location = new System.Drawing.Point(4, 50);
            this.chkNoidung.Name = "chkNoidung";
            this.chkNoidung.Size = new System.Drawing.Size(91, 17);
            this.chkNoidung.TabIndex = 2;
            this.chkNoidung.Text = "Xem nội dung";
            this.chkNoidung.UseVisualStyleBackColor = true;
            this.chkNoidung.CheckedChanged += new System.EventHandler(this.chkNoidung_CheckedChanged);
            // 
            // btnDocbai
            // 
            this.btnDocbai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDocbai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocbai.Location = new System.Drawing.Point(0, 69);
            this.btnDocbai.Name = "btnDocbai";
            this.btnDocbai.Size = new System.Drawing.Size(130, 31);
            this.btnDocbai.TabIndex = 1;
            this.btnDocbai.Text = "Đọc bài";
            this.btnDocbai.UseVisualStyleBackColor = true;
            this.btnDocbai.Click += new System.EventHandler(this.btnDocbai_Click);
            // 
            // lblBai
            // 
            this.lblBai.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBai.Location = new System.Drawing.Point(5, 8);
            this.lblBai.Name = "lblBai";
            this.lblBai.Size = new System.Drawing.Size(119, 36);
            this.lblBai.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLamLai);
            this.panel5.Controls.Add(this.btnBaiTruoc);
            this.panel5.Controls.Add(this.btnBaiKe);
            this.panel5.Controls.Add(this.btnChonBai);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(439, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 100);
            this.panel5.TabIndex = 4;
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLamLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLamLai.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.btnLamLai.Location = new System.Drawing.Point(1, 0);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(95, 100);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnBaiTruoc
            // 
            this.btnBaiTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBaiTruoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaiTruoc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.btnBaiTruoc.Location = new System.Drawing.Point(96, 0);
            this.btnBaiTruoc.Name = "btnBaiTruoc";
            this.btnBaiTruoc.Size = new System.Drawing.Size(95, 100);
            this.btnBaiTruoc.TabIndex = 5;
            this.btnBaiTruoc.Text = "Bài Trước";
            this.btnBaiTruoc.UseVisualStyleBackColor = false;
            this.btnBaiTruoc.Click += new System.EventHandler(this.btnBaiTruoc_Click);
            // 
            // btnBaiKe
            // 
            this.btnBaiKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBaiKe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaiKe.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.btnBaiKe.Location = new System.Drawing.Point(191, 0);
            this.btnBaiKe.Name = "btnBaiKe";
            this.btnBaiKe.Size = new System.Drawing.Size(95, 100);
            this.btnBaiKe.TabIndex = 4;
            this.btnBaiKe.Text = "Bài Kế";
            this.btnBaiKe.UseVisualStyleBackColor = false;
            this.btnBaiKe.Click += new System.EventHandler(this.btnBaiKe_Click);
            // 
            // btnChonBai
            // 
            this.btnChonBai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChonBai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChonBai.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.btnChonBai.Location = new System.Drawing.Point(286, 0);
            this.btnChonBai.Name = "btnChonBai";
            this.btnChonBai.Size = new System.Drawing.Size(95, 100);
            this.btnChonBai.TabIndex = 0;
            this.btnChonBai.Text = "Chọn Bài";
            this.btnChonBai.UseVisualStyleBackColor = false;
            this.btnChonBai.Click += new System.EventHandler(this.btnChonBai_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmHoc";
            this.Text = "Bé học xếp từ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmHoc_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picYeah)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChonBai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBai;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnDocbai;
        private System.Windows.Forms.Label txtBai;
        private System.Windows.Forms.CheckBox chkNoidung;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBaiTruoc;
        private System.Windows.Forms.Button btnBaiKe;
        private System.Windows.Forms.PictureBox picYeah;
        private System.Windows.Forms.Timer timer1;
    }
}

