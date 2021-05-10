
namespace MyShool
{
    partial class Frmdome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdome));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "windows-SSD(C:)",
            "本地磁盘",
            "256 GB",
            "85 GB"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data（D:）",
            "本地磁盘",
            "128 GB",
            "66 GB"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Date（E:）",
            "本地磁盘",
            "86 GB",
            "19 GB"}, 2);
            this.imglsmall = new System.Windows.Forms.ImageList(this.components);
            this.imglbig = new System.Windows.Forms.ImageList(this.components);
            this.lvdemo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblname = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblzdx = new System.Windows.Forms.Label();
            this.lblkync = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtzdx = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtkycp = new System.Windows.Forms.TextBox();
            this.btntj = new System.Windows.Forms.Button();
            this.cmsyjcd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmlbig = new System.Windows.Forms.ToolStripMenuItem();
            this.tool = new System.Windows.Forms.ToolStripSeparator();
            this.tsmismall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmixxxx = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsyjcd.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglsmall
            // 
            this.imglsmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglsmall.ImageStream")));
            this.imglsmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imglsmall.Images.SetKeyName(0, "yp-1.png");
            this.imglsmall.Images.SetKeyName(1, "yp-2.png");
            this.imglsmall.Images.SetKeyName(2, "yp-3.png");
            this.imglsmall.Images.SetKeyName(3, "yp-4.png");
            this.imglsmall.Images.SetKeyName(4, "yp-5.png");
            this.imglsmall.Images.SetKeyName(5, "yp-6.png");
            // 
            // imglbig
            // 
            this.imglbig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglbig.ImageStream")));
            this.imglbig.TransparentColor = System.Drawing.Color.Transparent;
            this.imglbig.Images.SetKeyName(0, "yp-1.png");
            this.imglbig.Images.SetKeyName(1, "yp-2.png");
            this.imglbig.Images.SetKeyName(2, "yp-3.png");
            this.imglbig.Images.SetKeyName(3, "yp-4.png");
            this.imglbig.Images.SetKeyName(4, "yp-5.png");
            this.imglbig.Images.SetKeyName(5, "yp-6.png");
            // 
            // lvdemo
            // 
            this.lvdemo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvdemo.ContextMenuStrip = this.cmsyjcd;
            this.lvdemo.HideSelection = false;
            this.lvdemo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvdemo.LargeImageList = this.imglbig;
            this.lvdemo.Location = new System.Drawing.Point(0, 1);
            this.lvdemo.Name = "lvdemo";
            this.lvdemo.Size = new System.Drawing.Size(722, 338);
            this.lvdemo.SmallImageList = this.imglsmall;
            this.lvdemo.TabIndex = 0;
            this.lvdemo.UseCompatibleStateImageBehavior = false;
            this.lvdemo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "总大小";
            this.columnHeader3.Width = 173;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "可用内存";
            this.columnHeader4.Width = 550;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname.Location = new System.Drawing.Point(59, 360);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(69, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "磁盘名称";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltype.Location = new System.Drawing.Point(398, 361);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(69, 20);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "磁盘类型";
            // 
            // lblzdx
            // 
            this.lblzdx.AutoSize = true;
            this.lblzdx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblzdx.Location = new System.Drawing.Point(44, 414);
            this.lblzdx.Name = "lblzdx";
            this.lblzdx.Size = new System.Drawing.Size(84, 20);
            this.lblzdx.TabIndex = 3;
            this.lblzdx.Text = "磁盘总大小";
            // 
            // lblkync
            // 
            this.lblkync.AutoSize = true;
            this.lblkync.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblkync.Location = new System.Drawing.Point(368, 413);
            this.lblkync.Name = "lblkync";
            this.lblkync.Size = new System.Drawing.Size(99, 20);
            this.lblkync.TabIndex = 4;
            this.lblkync.Text = "磁盘可用内存";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(134, 358);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 25);
            this.txtname.TabIndex = 5;
            // 
            // txtzdx
            // 
            this.txtzdx.Location = new System.Drawing.Point(134, 413);
            this.txtzdx.Name = "txtzdx";
            this.txtzdx.Size = new System.Drawing.Size(179, 25);
            this.txtzdx.TabIndex = 7;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(473, 359);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(174, 25);
            this.txttype.TabIndex = 8;
            // 
            // txtkycp
            // 
            this.txtkycp.Location = new System.Drawing.Point(473, 409);
            this.txtkycp.Name = "txtkycp";
            this.txtkycp.Size = new System.Drawing.Size(174, 25);
            this.txtkycp.TabIndex = 9;
            // 
            // btntj
            // 
            this.btntj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntj.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btntj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntj.Location = new System.Drawing.Point(526, 458);
            this.btntj.Name = "btntj";
            this.btntj.Size = new System.Drawing.Size(88, 33);
            this.btntj.TabIndex = 10;
            this.btntj.Text = "添加";
            this.btntj.UseVisualStyleBackColor = false;
            this.btntj.Click += new System.EventHandler(this.btntj_Click);
            // 
            // cmsyjcd
            // 
            this.cmsyjcd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsyjcd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlbig,
            this.tool,
            this.tsmismall,
            this.toolStripSeparator2,
            this.tsmixxxx});
            this.cmsyjcd.Name = "contextMenuStrip1";
            this.cmsyjcd.Size = new System.Drawing.Size(211, 116);
            // 
            // tsmlbig
            // 
            this.tsmlbig.Name = "tsmlbig";
            this.tsmlbig.Size = new System.Drawing.Size(210, 24);
            this.tsmlbig.Text = "大图标";
            this.tsmlbig.Click += new System.EventHandler(this.tsmlbig_Click);
            // 
            // tool
            // 
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmismall
            // 
            this.tsmismall.Name = "tsmismall";
            this.tsmismall.Size = new System.Drawing.Size(210, 24);
            this.tsmismall.Text = "小图标";
            this.tsmismall.Click += new System.EventHandler(this.tsmismall_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmixxxx
            // 
            this.tsmixxxx.Name = "tsmixxxx";
            this.tsmixxxx.Size = new System.Drawing.Size(210, 24);
            this.tsmixxxx.Text = "详细信息";
            this.tsmixxxx.Click += new System.EventHandler(this.tsmixxxx_Click);
            // 
            // Frmdome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.Controls.Add(this.btntj);
            this.Controls.Add(this.txtkycp);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtzdx);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblkync);
            this.Controls.Add(this.lblzdx);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lvdemo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmdome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmdome";
            this.cmsyjcd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglsmall;
        private System.Windows.Forms.ImageList imglbig;
        private System.Windows.Forms.ListView lvdemo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblzdx;
        private System.Windows.Forms.Label lblkync;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtzdx;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtkycp;
        private System.Windows.Forms.Button btntj;
        private System.Windows.Forms.ContextMenuStrip cmsyjcd;
        private System.Windows.Forms.ToolStripMenuItem tsmlbig;
        private System.Windows.Forms.ToolStripSeparator tool;
        private System.Windows.Forms.ToolStripMenuItem tsmismall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmixxxx;
    }
}