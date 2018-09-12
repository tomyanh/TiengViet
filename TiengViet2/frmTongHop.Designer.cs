namespace TiengViet2
{
    partial class frmTongHop
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBai = new System.Windows.Forms.Label();
            this.btnDocbai = new System.Windows.Forms.Button();
            this.txtBai = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnBaiTruoc = new System.Windows.Forms.Button();
            this.btnBaiKe = new System.Windows.Forms.Button();
            this.btnChonBai = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 56);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblBai);
            this.panel3.Controls.Add(this.btnDocbai);
            this.panel3.Controls.Add(this.txtBai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 56);
            this.panel3.TabIndex = 2;
            // 
            // lblBai
            // 
            this.lblBai.Font = new System.Drawing.Font(".VnArial", 20F, System.Drawing.FontStyle.Bold);
            this.lblBai.ForeColor = System.Drawing.Color.Blue;
            this.lblBai.Location = new System.Drawing.Point(143, 9);
            this.lblBai.Name = "lblBai";
            this.lblBai.Size = new System.Drawing.Size(119, 38);
            this.lblBai.TabIndex = 0;
            // 
            // btnDocbai
            // 
            this.btnDocbai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDocbai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDocbai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocbai.Image = global::TiengViet2.Properties.Resources.Question;
            this.btnDocbai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocbai.Location = new System.Drawing.Point(0, 0);
            this.btnDocbai.Name = "btnDocbai";
            this.btnDocbai.Size = new System.Drawing.Size(137, 56);
            this.btnDocbai.TabIndex = 2;
            this.btnDocbai.Text = "Đọc bài";
            this.btnDocbai.UseVisualStyleBackColor = false;
            this.btnDocbai.Click += new System.EventHandler(this.btnDocbai_Click);
            // 
            // txtBai
            // 
            this.txtBai.BackColor = System.Drawing.Color.Transparent;
            this.txtBai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBai.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBai.Location = new System.Drawing.Point(0, 0);
            this.txtBai.Name = "txtBai";
            this.txtBai.Size = new System.Drawing.Size(310, 56);
            this.txtBai.TabIndex = 4;
            this.txtBai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtBai.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLamLai);
            this.panel5.Controls.Add(this.btnBaiTruoc);
            this.panel5.Controls.Add(this.btnBaiKe);
            this.panel5.Controls.Add(this.btnChonBai);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(310, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(506, 56);
            this.panel5.TabIndex = 4;
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLamLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLamLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLamLai.Image = global::TiengViet2.Properties.Resources.refresh;
            this.btnLamLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamLai.Location = new System.Drawing.Point(10, 0);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(124, 56);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnBaiTruoc
            // 
            this.btnBaiTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBaiTruoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaiTruoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaiTruoc.Image = global::TiengViet2.Properties.Resources.pre;
            this.btnBaiTruoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaiTruoc.Location = new System.Drawing.Point(134, 0);
            this.btnBaiTruoc.Name = "btnBaiTruoc";
            this.btnBaiTruoc.Size = new System.Drawing.Size(124, 56);
            this.btnBaiTruoc.TabIndex = 5;
            this.btnBaiTruoc.Text = "Bài Trước";
            this.btnBaiTruoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaiTruoc.UseVisualStyleBackColor = false;
            this.btnBaiTruoc.Click += new System.EventHandler(this.btnBaiTruoc_Click);
            // 
            // btnBaiKe
            // 
            this.btnBaiKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBaiKe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaiKe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaiKe.Image = global::TiengViet2.Properties.Resources.next;
            this.btnBaiKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaiKe.Location = new System.Drawing.Point(258, 0);
            this.btnBaiKe.Name = "btnBaiKe";
            this.btnBaiKe.Size = new System.Drawing.Size(124, 56);
            this.btnBaiKe.TabIndex = 4;
            this.btnBaiKe.Text = "Bài Kế";
            this.btnBaiKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaiKe.UseVisualStyleBackColor = false;
            this.btnBaiKe.Click += new System.EventHandler(this.btnBaiKe_Click);
            // 
            // btnChonBai
            // 
            this.btnChonBai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChonBai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChonBai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonBai.Image = global::TiengViet2.Properties.Resources.find;
            this.btnChonBai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChonBai.Location = new System.Drawing.Point(382, 0);
            this.btnChonBai.Name = "btnChonBai";
            this.btnChonBai.Size = new System.Drawing.Size(124, 56);
            this.btnChonBai.TabIndex = 0;
            this.btnChonBai.Text = "Chọn Bài";
            this.btnChonBai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChonBai.UseVisualStyleBackColor = false;
            this.btnChonBai.Click += new System.EventHandler(this.btnChonBai_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(816, 376);
            this.pnMain.TabIndex = 7;
            // 
            // frmTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(816, 432);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Name = "frmTongHop";
            this.Text = "Học Tiếng Việt Lớp 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtBai;
        private System.Windows.Forms.Label lblBai;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnBaiTruoc;
        private System.Windows.Forms.Button btnBaiKe;
        private System.Windows.Forms.Button btnChonBai;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnDocbai;
    }
}