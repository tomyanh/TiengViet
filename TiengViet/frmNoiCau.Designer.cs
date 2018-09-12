namespace TiengViet
{
    partial class frmNoiCau
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
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnBai = new System.Windows.Forms.Button();
            this.pnBot = new System.Windows.Forms.Panel();
            this.lblBai = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTiep
            // 
            this.btnTiep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTiep.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.Location = new System.Drawing.Point(321, 9);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(107, 39);
            this.btnTiep.TabIndex = 0;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBai
            // 
            this.btnBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBai.BackColor = System.Drawing.Color.Transparent;
            this.btnBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai.Location = new System.Drawing.Point(3, 11);
            this.btnBai.Name = "btnBai";
            this.btnBai.Size = new System.Drawing.Size(107, 39);
            this.btnBai.TabIndex = 1;
            this.btnBai.Text = "Bài học";
            this.btnBai.UseVisualStyleBackColor = false;
            this.btnBai.Click += new System.EventHandler(this.btnBai_Click);
            // 
            // pnBot
            // 
            this.pnBot.BackColor = System.Drawing.Color.Transparent;
            this.pnBot.Controls.Add(this.lblBai);
            this.pnBot.Controls.Add(this.btnBai);
            this.pnBot.Controls.Add(this.btnTiep);
            this.pnBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBot.Location = new System.Drawing.Point(0, 433);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(743, 53);
            this.pnBot.TabIndex = 2;
            // 
            // lblBai
            // 
            this.lblBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBai.Font = new System.Drawing.Font(".VnAvant", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBai.ForeColor = System.Drawing.Color.Red;
            this.lblBai.Location = new System.Drawing.Point(621, 9);
            this.lblBai.Name = "lblBai";
            this.lblBai.Size = new System.Drawing.Size(119, 36);
            this.lblBai.TabIndex = 1;
            this.lblBai.Text = "123";
            this.lblBai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(743, 433);
            this.pnMain.TabIndex = 3;
            // 
            // frmNoiCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TiengViet.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 486);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnBot);
            this.Name = "frmNoiCau";
            this.Text = "Bé học nối ô chữ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmNoiCau_Resize);
            this.pnBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnBai;
        private System.Windows.Forms.Panel pnBot;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lblBai;
    }
}