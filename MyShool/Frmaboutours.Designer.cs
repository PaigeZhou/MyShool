
namespace MyShool
{
    partial class Frmaboutours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaboutours));
            this.lblwy1 = new System.Windows.Forms.Label();
            this.lblwy2 = new System.Windows.Forms.Label();
            this.lblwy3 = new System.Windows.Forms.Label();
            this.pickd = new System.Windows.Forms.PictureBox();
            this.imglji = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tjsq = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pickd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwy1
            // 
            this.lblwy1.AutoSize = true;
            this.lblwy1.BackColor = System.Drawing.Color.Transparent;
            this.lblwy1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwy1.ForeColor = System.Drawing.Color.Maroon;
            this.lblwy1.Location = new System.Drawing.Point(289, 151);
            this.lblwy1.Name = "lblwy1";
            this.lblwy1.Size = new System.Drawing.Size(183, 26);
            this.lblwy1.TabIndex = 0;
            this.lblwy1.Text = "版权所有：北大青鸟";
            // 
            // lblwy2
            // 
            this.lblwy2.AutoSize = true;
            this.lblwy2.BackColor = System.Drawing.Color.Transparent;
            this.lblwy2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwy2.ForeColor = System.Drawing.Color.Maroon;
            this.lblwy2.Location = new System.Drawing.Point(287, 194);
            this.lblwy2.Name = "lblwy2";
            this.lblwy2.Size = new System.Drawing.Size(236, 26);
            this.lblwy2.TabIndex = 1;
            this.lblwy2.Text = "copyright：2021-07-07";
            // 
            // lblwy3
            // 
            this.lblwy3.AutoSize = true;
            this.lblwy3.BackColor = System.Drawing.Color.Transparent;
            this.lblwy3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwy3.ForeColor = System.Drawing.Color.Maroon;
            this.lblwy3.Location = new System.Drawing.Point(287, 244);
            this.lblwy3.Name = "lblwy3";
            this.lblwy3.Size = new System.Drawing.Size(165, 26);
            this.lblwy3.TabIndex = 2;
            this.lblwy3.Text = "技术支持：@龙龙";
            // 
            // pickd
            // 
            this.pickd.Image = global::MyShool.Properties.Resources.girl_1;
            this.pickd.Location = new System.Drawing.Point(23, 92);
            this.pickd.Name = "pickd";
            this.pickd.Size = new System.Drawing.Size(160, 178);
            this.pickd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickd.TabIndex = 3;
            this.pickd.TabStop = false;
            // 
            // imglji
            // 
            this.imglji.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglji.ImageStream")));
            this.imglji.TransparentColor = System.Drawing.Color.Transparent;
            this.imglji.Images.SetKeyName(0, "girl_1.gif");
            this.imglji.Images.SetKeyName(1, "girl_2.gif");
            this.imglji.Images.SetKeyName(2, "girl_3.gif");
            this.imglji.Images.SetKeyName(3, "girl_4.gif");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(431, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 34);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // tjsq
            // 
            this.tjsq.Enabled = true;
            this.tjsq.Tick += new System.EventHandler(this.tjsq_Tick);
            // 
            // Frmaboutours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyShool.Properties.Resources.aboug_bj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(628, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pickd);
            this.Controls.Add(this.lblwy3);
            this.Controls.Add(this.lblwy2);
            this.Controls.Add(this.lblwy1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmaboutours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            this.Load += new System.EventHandler(this.Frmaboutours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwy1;
        private System.Windows.Forms.Label lblwy2;
        private System.Windows.Forms.Label lblwy3;
        private System.Windows.Forms.PictureBox pickd;
        private System.Windows.Forms.ImageList imglji;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tjsq;
    }
}