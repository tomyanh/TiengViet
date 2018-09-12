namespace TiengViet
{
    partial class frmMain
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
            this.btnXepTu = new System.Windows.Forms.Button();
            this.btnNoiOchu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXepTu
            // 
            this.btnXepTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXepTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepTu.Location = new System.Drawing.Point(279, 163);
            this.btnXepTu.Name = "btnXepTu";
            this.btnXepTu.Size = new System.Drawing.Size(217, 51);
            this.btnXepTu.TabIndex = 0;
            this.btnXepTu.Text = "Xếp từ";
            this.btnXepTu.UseVisualStyleBackColor = false;
            this.btnXepTu.Click += new System.EventHandler(this.btnXepTu_Click);
            // 
            // btnNoiOchu
            // 
            this.btnNoiOchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNoiOchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoiOchu.Location = new System.Drawing.Point(279, 229);
            this.btnNoiOchu.Name = "btnNoiOchu";
            this.btnNoiOchu.Size = new System.Drawing.Size(217, 51);
            this.btnNoiOchu.TabIndex = 1;
            this.btnNoiOchu.Text = "Nối ô chữ";
            this.btnNoiOchu.UseVisualStyleBackColor = false;
            this.btnNoiOchu.Click += new System.EventHandler(this.btnNoiOchu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TiengViet.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(734, 457);
            this.Controls.Add(this.btnNoiOchu);
            this.Controls.Add(this.btnXepTu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bé học Tiếng Việt 1";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXepTu;
        private System.Windows.Forms.Button btnNoiOchu;
    }
}