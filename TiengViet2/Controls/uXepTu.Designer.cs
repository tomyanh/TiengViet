namespace TiengViet2
{
    partial class uXepTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uXepTu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCmdTiep = new System.Windows.Forms.Button();
            this.picYeah = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYeah)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCmdTiep);
            this.panel1.Controls.Add(this.picYeah);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 396);
            this.panel1.TabIndex = 3;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // btnCmdTiep
            // 
            this.btnCmdTiep.BackColor = System.Drawing.Color.Lime;
            this.btnCmdTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdTiep.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCmdTiep.Location = new System.Drawing.Point(317, 235);
            this.btnCmdTiep.Name = "btnCmdTiep";
            this.btnCmdTiep.Size = new System.Drawing.Size(177, 63);
            this.btnCmdTiep.TabIndex = 1;
            this.btnCmdTiep.Text = "Tiếp tục";
            this.btnCmdTiep.UseVisualStyleBackColor = false;
            this.btnCmdTiep.Visible = false;
            this.btnCmdTiep.Click += new System.EventHandler(this.btnCmdTiep_Click);
            // 
            // picYeah
            // 
            this.picYeah.BackColor = System.Drawing.Color.Transparent;
            this.picYeah.Image = global::TiengViet2.Properties.Resources.yeah;
            this.picYeah.Location = new System.Drawing.Point(569, 68);
            this.picYeah.Name = "picYeah";
            this.picYeah.Size = new System.Drawing.Size(191, 195);
            this.picYeah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYeah.TabIndex = 0;
            this.picYeah.TabStop = false;
            this.picYeah.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uXepTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "uXepTu";
            this.Size = new System.Drawing.Size(820, 396);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmHoc_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picYeah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picYeah;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCmdTiep;
    }
}

