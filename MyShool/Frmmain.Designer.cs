
namespace MyShool
{
    partial class Frmmain
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
            this.mszcd = new System.Windows.Forms.MenuStrip();
            this.mszhgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmixgmm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmitc = new System.Windows.Forms.ToolStripMenuItem();
            this.msxsgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmixzxs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisrbyxm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicxbybj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmixslb = new System.Windows.Forms.ToolStripMenuItem();
            this.mskmgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmixzkm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmikmlb = new System.Windows.Forms.ToolStripMenuItem();
            this.msck = new System.Windows.Forms.ToolStripMenuItem();
            this.mshelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmime = new System.Windows.Forms.ToolStripMenuItem();
            this.tszcd = new System.Windows.Forms.ToolStrip();
            this.tsbtnaddstu = new System.Windows.Forms.ToolStripButton();
            this.tsbtncxbyname = new System.Windows.Forms.ToolStripButton();
            this.tsbtncxbyage = new System.Windows.Forms.ToolStripButton();
            this.cxstulb = new System.Windows.Forms.ToolStripButton();
            this.tsbtnkmlb = new System.Windows.Forms.ToolStripButton();
            this.mszcd.SuspendLayout();
            this.tszcd.SuspendLayout();
            this.SuspendLayout();
            // 
            // mszcd
            // 
            this.mszcd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mszcd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mszhgl,
            this.msxsgl,
            this.mskmgl,
            this.msck,
            this.mshelp});
            this.mszcd.Location = new System.Drawing.Point(0, 0);
            this.mszcd.MdiWindowListItem = this.msck;
            this.mszcd.Name = "mszcd";
            this.mszcd.Size = new System.Drawing.Size(800, 28);
            this.mszcd.TabIndex = 0;
            this.mszcd.Text = "menuStrip1";
            // 
            // mszhgl
            // 
            this.mszhgl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmixgmm,
            this.toolStripSeparator1,
            this.tsmitc});
            this.mszhgl.Name = "mszhgl";
            this.mszhgl.Size = new System.Drawing.Size(124, 24);
            this.mszhgl.Text = "账户管理（&U）";
            // 
            // tsmixgmm
            // 
            this.tsmixgmm.Image = global::MyShool.Properties.Resources.tsbtn4;
            this.tsmixgmm.Name = "tsmixgmm";
            this.tsmixgmm.Size = new System.Drawing.Size(224, 26);
            this.tsmixgmm.Text = "修改密码（&M）";
            this.tsmixgmm.Click += new System.EventHandler(this.tsmixgmm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmitc
            // 
            this.tsmitc.Image = global::MyShool.Properties.Resources.tsbtn3;
            this.tsmitc.Name = "tsmitc";
            this.tsmitc.Size = new System.Drawing.Size(224, 26);
            this.tsmitc.Text = "退出（&E）";
            this.tsmitc.Click += new System.EventHandler(this.tsmitc_Click);
            // 
            // msxsgl
            // 
            this.msxsgl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmixzxs,
            this.tsmisrbyxm,
            this.tsmicxbybj,
            this.tsmixslb});
            this.msxsgl.Name = "msxsgl";
            this.msxsgl.Size = new System.Drawing.Size(122, 24);
            this.msxsgl.Text = "学生管理（&S）";
            // 
            // tsmixzxs
            // 
            this.tsmixzxs.Name = "tsmixzxs";
            this.tsmixzxs.Size = new System.Drawing.Size(224, 26);
            this.tsmixzxs.Text = "新增学生（&N）";
            this.tsmixzxs.Click += new System.EventHandler(this.tsmixzxs_Click);
            // 
            // tsmisrbyxm
            // 
            this.tsmisrbyxm.Name = "tsmisrbyxm";
            this.tsmisrbyxm.Size = new System.Drawing.Size(224, 26);
            this.tsmisrbyxm.Text = "按姓名输入（&M）";
            // 
            // tsmicxbybj
            // 
            this.tsmicxbybj.Name = "tsmicxbybj";
            this.tsmicxbybj.Size = new System.Drawing.Size(224, 26);
            this.tsmicxbybj.Text = "按年级查询（&G）";
            this.tsmicxbybj.Click += new System.EventHandler(this.tsmicxbybj_Click);
            // 
            // tsmixslb
            // 
            this.tsmixslb.Name = "tsmixslb";
            this.tsmixslb.Size = new System.Drawing.Size(224, 26);
            this.tsmixslb.Text = "学生列表（&L）";
            // 
            // mskmgl
            // 
            this.mskmgl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmixzkm,
            this.tsmikmlb});
            this.mskmgl.Name = "mskmgl";
            this.mskmgl.Size = new System.Drawing.Size(123, 24);
            this.mskmgl.Text = "科目管理（&C）";
            // 
            // tsmixzkm
            // 
            this.tsmixzkm.Name = "tsmixzkm";
            this.tsmixzkm.Size = new System.Drawing.Size(193, 26);
            this.tsmixzkm.Text = "新增科目（&A）";
            // 
            // tsmikmlb
            // 
            this.tsmikmlb.Name = "tsmikmlb";
            this.tsmikmlb.Size = new System.Drawing.Size(193, 26);
            this.tsmikmlb.Text = "科目列表（&L）";
            // 
            // msck
            // 
            this.msck.Name = "msck";
            this.msck.Size = new System.Drawing.Size(98, 24);
            this.msck.Text = "窗口（&W）";
            // 
            // mshelp
            // 
            this.mshelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmime});
            this.mshelp.Name = "mshelp";
            this.mshelp.Size = new System.Drawing.Size(95, 24);
            this.mshelp.Text = "帮助（&H）";
            // 
            // tsmime
            // 
            this.tsmime.Name = "tsmime";
            this.tsmime.Size = new System.Drawing.Size(193, 26);
            this.tsmime.Text = "关于我们（&A）";
            this.tsmime.Click += new System.EventHandler(this.tsmime_Click);
            // 
            // tszcd
            // 
            this.tszcd.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tszcd.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tszcd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnaddstu,
            this.tsbtncxbyname,
            this.tsbtncxbyage,
            this.cxstulb,
            this.tsbtnkmlb});
            this.tszcd.Location = new System.Drawing.Point(0, 28);
            this.tszcd.Name = "tszcd";
            this.tszcd.Size = new System.Drawing.Size(800, 32);
            this.tszcd.TabIndex = 1;
            this.tszcd.Text = "toolStrip1";
            // 
            // tsbtnaddstu
            // 
            this.tsbtnaddstu.Image = global::MyShool.Properties.Resources.tsbtn5;
            this.tsbtnaddstu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnaddstu.Name = "tsbtnaddstu";
            this.tsbtnaddstu.Size = new System.Drawing.Size(128, 29);
            this.tsbtnaddstu.Text = "新增学生用户";
            this.tsbtnaddstu.Click += new System.EventHandler(this.tsmixzxs_Click);
            // 
            // tsbtncxbyname
            // 
            this.tsbtncxbyname.Image = global::MyShool.Properties.Resources.tsbtn2;
            this.tsbtncxbyname.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtncxbyname.Name = "tsbtncxbyname";
            this.tsbtncxbyname.Size = new System.Drawing.Size(143, 29);
            this.tsbtncxbyname.Text = "按姓名查询学生";
            this.tsbtncxbyname.Click += new System.EventHandler(this.tsbtncxbyname_Click);
            // 
            // tsbtncxbyage
            // 
            this.tsbtncxbyage.Image = global::MyShool.Properties.Resources.tsbtn1;
            this.tsbtncxbyage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtncxbyage.Name = "tsbtncxbyage";
            this.tsbtncxbyage.Size = new System.Drawing.Size(173, 29);
            this.tsbtncxbyage.Text = "按年龄查询学生姓名";
            // 
            // cxstulb
            // 
            this.cxstulb.Image = global::MyShool.Properties.Resources.tsbtn4;
            this.cxstulb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cxstulb.Name = "cxstulb";
            this.cxstulb.Size = new System.Drawing.Size(98, 29);
            this.cxstulb.Text = "学生列表";
            // 
            // tsbtnkmlb
            // 
            this.tsbtnkmlb.Image = global::MyShool.Properties.Resources.tsbtn3;
            this.tsbtnkmlb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnkmlb.Name = "tsbtnkmlb";
            this.tsbtnkmlb.Size = new System.Drawing.Size(98, 29);
            this.tsbtnkmlb.Text = "科目列表";
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tszcd);
            this.Controls.Add(this.mszcd);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mszcd;
            this.Name = "Frmmain";
            this.Text = "Frmmain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmmain_Load);
            this.mszcd.ResumeLayout(false);
            this.mszcd.PerformLayout();
            this.tszcd.ResumeLayout(false);
            this.tszcd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mszcd;
        private System.Windows.Forms.ToolStripMenuItem mszhgl;
        private System.Windows.Forms.ToolStripMenuItem tsmixgmm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmitc;
        private System.Windows.Forms.ToolStripMenuItem msxsgl;
        private System.Windows.Forms.ToolStripMenuItem tsmixzxs;
        private System.Windows.Forms.ToolStripMenuItem tsmisrbyxm;
        private System.Windows.Forms.ToolStripMenuItem tsmicxbybj;
        private System.Windows.Forms.ToolStripMenuItem tsmixslb;
        private System.Windows.Forms.ToolStripMenuItem mskmgl;
        private System.Windows.Forms.ToolStripMenuItem tsmixzkm;
        private System.Windows.Forms.ToolStripMenuItem tsmikmlb;
        private System.Windows.Forms.ToolStripMenuItem mshelp;
        private System.Windows.Forms.ToolStripMenuItem tsmime;
        private System.Windows.Forms.ToolStripMenuItem msck;
        private System.Windows.Forms.ToolStrip tszcd;
        private System.Windows.Forms.ToolStripButton tsbtnaddstu;
        private System.Windows.Forms.ToolStripButton tsbtncxbyname;
        private System.Windows.Forms.ToolStripButton tsbtncxbyage;
        private System.Windows.Forms.ToolStripButton cxstulb;
        private System.Windows.Forms.ToolStripButton tsbtnkmlb;
    }
}