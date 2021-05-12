
namespace MyShool
{
    partial class FrmAddstu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddstu));
            this.gbouserzc = new System.Windows.Forms.GroupBox();
            this.txtqrmm = new System.Windows.Forms.TextBox();
            this.txtmm = new System.Windows.Forms.TextBox();
            this.txtxh = new System.Windows.Forms.TextBox();
            this.lblqrzcmm = new System.Windows.Forms.Label();
            this.lblzcmm = new System.Windows.Forms.Label();
            this.lblzcxh = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbojbxx = new System.Windows.Forms.GroupBox();
            this.plxb = new System.Windows.Forms.Panel();
            this.rbtnman = new System.Windows.Forms.RadioButton();
            this.rbtnwomen = new System.Windows.Forms.RadioButton();
            this.dtpcsrq = new System.Windows.Forms.DateTimePicker();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.cbograde = new System.Windows.Forms.ComboBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblcsrq = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.btnbc = new System.Windows.Forms.Button();
            this.btnqx = new System.Windows.Forms.Button();
            this.gbouserzc.SuspendLayout();
            this.gbojbxx.SuspendLayout();
            this.plxb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbouserzc
            // 
            this.gbouserzc.Controls.Add(this.txtqrmm);
            this.gbouserzc.Controls.Add(this.txtmm);
            this.gbouserzc.Controls.Add(this.txtxh);
            this.gbouserzc.Controls.Add(this.lblqrzcmm);
            this.gbouserzc.Controls.Add(this.lblzcmm);
            this.gbouserzc.Controls.Add(this.lblzcxh);
            this.gbouserzc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbouserzc.Location = new System.Drawing.Point(12, 12);
            this.gbouserzc.Name = "gbouserzc";
            this.gbouserzc.Size = new System.Drawing.Size(369, 189);
            this.gbouserzc.TabIndex = 0;
            this.gbouserzc.TabStop = false;
            this.gbouserzc.Text = "用户注册信息";
            // 
            // txtqrmm
            // 
            this.txtqrmm.Location = new System.Drawing.Point(92, 131);
            this.txtqrmm.Name = "txtqrmm";
            this.txtqrmm.Size = new System.Drawing.Size(271, 27);
            this.txtqrmm.TabIndex = 5;
            // 
            // txtmm
            // 
            this.txtmm.Location = new System.Drawing.Point(92, 84);
            this.txtmm.Name = "txtmm";
            this.txtmm.Size = new System.Drawing.Size(271, 27);
            this.txtmm.TabIndex = 4;
            // 
            // txtxh
            // 
            this.txtxh.Location = new System.Drawing.Point(92, 37);
            this.txtxh.Name = "txtxh";
            this.txtxh.Size = new System.Drawing.Size(271, 27);
            this.txtxh.TabIndex = 3;
            // 
            // lblqrzcmm
            // 
            this.lblqrzcmm.AutoSize = true;
            this.lblqrzcmm.Location = new System.Drawing.Point(11, 134);
            this.lblqrzcmm.Name = "lblqrzcmm";
            this.lblqrzcmm.Size = new System.Drawing.Size(84, 20);
            this.lblqrzcmm.TabIndex = 2;
            this.lblqrzcmm.Text = "确认密码：";
            // 
            // lblzcmm
            // 
            this.lblzcmm.AutoSize = true;
            this.lblzcmm.Location = new System.Drawing.Point(41, 87);
            this.lblzcmm.Name = "lblzcmm";
            this.lblzcmm.Size = new System.Drawing.Size(54, 20);
            this.lblzcmm.TabIndex = 1;
            this.lblzcmm.Text = "密码：";
            // 
            // lblzcxh
            // 
            this.lblzcxh.AutoSize = true;
            this.lblzcxh.Location = new System.Drawing.Point(41, 40);
            this.lblzcxh.Name = "lblzcxh";
            this.lblzcxh.Size = new System.Drawing.Size(54, 20);
            this.lblzcxh.TabIndex = 0;
            this.lblzcxh.Text = "学号：";
            // 
            // gbojbxx
            // 
            this.gbojbxx.Controls.Add(this.plxb);
            this.gbojbxx.Controls.Add(this.dtpcsrq);
            this.gbojbxx.Controls.Add(this.lblemail);
            this.gbojbxx.Controls.Add(this.lblgrade);
            this.gbojbxx.Controls.Add(this.cbograde);
            this.gbojbxx.Controls.Add(this.lblsex);
            this.gbojbxx.Controls.Add(this.txtemail);
            this.gbojbxx.Controls.Add(this.txtaddress);
            this.gbojbxx.Controls.Add(this.txtphone);
            this.gbojbxx.Controls.Add(this.lblcsrq);
            this.gbojbxx.Controls.Add(this.lbladdress);
            this.gbojbxx.Controls.Add(this.lblphone);
            this.gbojbxx.Controls.Add(this.txtname);
            this.gbojbxx.Controls.Add(this.lblname);
            this.gbojbxx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbojbxx.Location = new System.Drawing.Point(12, 207);
            this.gbojbxx.Name = "gbojbxx";
            this.gbojbxx.Size = new System.Drawing.Size(369, 435);
            this.gbojbxx.TabIndex = 1;
            this.gbojbxx.TabStop = false;
            this.gbojbxx.Text = "用户基本信息";
            // 
            // plxb
            // 
            this.plxb.Controls.Add(this.rbtnman);
            this.plxb.Controls.Add(this.rbtnwomen);
            this.plxb.Location = new System.Drawing.Point(89, 67);
            this.plxb.Name = "plxb";
            this.plxb.Size = new System.Drawing.Size(200, 29);
            this.plxb.TabIndex = 19;
            // 
            // rbtnman
            // 
            this.rbtnman.AutoSize = true;
            this.rbtnman.Checked = true;
            this.rbtnman.Location = new System.Drawing.Point(12, 3);
            this.rbtnman.Name = "rbtnman";
            this.rbtnman.Size = new System.Drawing.Size(60, 24);
            this.rbtnman.TabIndex = 6;
            this.rbtnman.TabStop = true;
            this.rbtnman.Text = "男生";
            this.rbtnman.UseVisualStyleBackColor = true;
            // 
            // rbtnwomen
            // 
            this.rbtnwomen.AutoSize = true;
            this.rbtnwomen.Location = new System.Drawing.Point(137, 3);
            this.rbtnwomen.Name = "rbtnwomen";
            this.rbtnwomen.Size = new System.Drawing.Size(60, 24);
            this.rbtnwomen.TabIndex = 7;
            this.rbtnwomen.Text = "女生";
            this.rbtnwomen.UseVisualStyleBackColor = true;
            // 
            // dtpcsrq
            // 
            this.dtpcsrq.Location = new System.Drawing.Point(89, 326);
            this.dtpcsrq.Name = "dtpcsrq";
            this.dtpcsrq.Size = new System.Drawing.Size(271, 27);
            this.dtpcsrq.TabIndex = 18;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(26, 370);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 20);
            this.lblemail.TabIndex = 17;
            this.lblemail.Text = "Email:";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Location = new System.Drawing.Point(23, 112);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(54, 20);
            this.lblgrade.TabIndex = 16;
            this.lblgrade.Text = "年级：";
            // 
            // cbograde
            // 
            this.cbograde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(90, 109);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(270, 28);
            this.cbograde.TabIndex = 15;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(23, 74);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(54, 20);
            this.lblsex.TabIndex = 14;
            this.lblsex.Text = "性别：";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(89, 367);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(271, 27);
            this.txtemail.TabIndex = 13;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(89, 201);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(271, 103);
            this.txtaddress.TabIndex = 12;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(89, 159);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(271, 27);
            this.txtphone.TabIndex = 11;
            // 
            // lblcsrq
            // 
            this.lblcsrq.AutoSize = true;
            this.lblcsrq.Location = new System.Drawing.Point(-1, 331);
            this.lblcsrq.Name = "lblcsrq";
            this.lblcsrq.Size = new System.Drawing.Size(84, 20);
            this.lblcsrq.TabIndex = 10;
            this.lblcsrq.Text = "出生日期：";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(23, 201);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(54, 20);
            this.lbladdress.TabIndex = 9;
            this.lbladdress.Text = "地址：";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(23, 162);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(54, 20);
            this.lblphone.TabIndex = 8;
            this.lblphone.Text = "电话：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(90, 34);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(271, 27);
            this.txtname.TabIndex = 5;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(23, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(54, 20);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "姓名：";
            // 
            // btnbc
            // 
            this.btnbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnbc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbc.Location = new System.Drawing.Point(198, 663);
            this.btnbc.Name = "btnbc";
            this.btnbc.Size = new System.Drawing.Size(75, 32);
            this.btnbc.TabIndex = 2;
            this.btnbc.Text = "保存";
            this.btnbc.UseVisualStyleBackColor = false;
            this.btnbc.Click += new System.EventHandler(this.btnbc_Click);
            // 
            // btnqx
            // 
            this.btnqx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnqx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnqx.Location = new System.Drawing.Point(297, 663);
            this.btnqx.Name = "btnqx";
            this.btnqx.Size = new System.Drawing.Size(75, 32);
            this.btnqx.TabIndex = 3;
            this.btnqx.Text = "清空";
            this.btnqx.UseVisualStyleBackColor = false;
            this.btnqx.Click += new System.EventHandler(this.btnqx_Click);
            // 
            // FrmAddstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 698);
            this.Controls.Add(this.btnqx);
            this.Controls.Add(this.btnbc);
            this.Controls.Add(this.gbojbxx);
            this.Controls.Add(this.gbouserzc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddstu";
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.FrmAddstu_Load);
            this.gbouserzc.ResumeLayout(false);
            this.gbouserzc.PerformLayout();
            this.gbojbxx.ResumeLayout(false);
            this.gbojbxx.PerformLayout();
            this.plxb.ResumeLayout(false);
            this.plxb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbouserzc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbojbxx;
        private System.Windows.Forms.TextBox txtqrmm;
        private System.Windows.Forms.TextBox txtmm;
        private System.Windows.Forms.Label lblqrzcmm;
        private System.Windows.Forms.Label lblzcmm;
        private System.Windows.Forms.Label lblzcxh;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton rbtnwomen;
        private System.Windows.Forms.RadioButton rbtnman;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblcsrq;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.DateTimePicker dtpcsrq;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.ComboBox cbograde;
        private System.Windows.Forms.Button btnbc;
        private System.Windows.Forms.Button btnqx;
        private System.Windows.Forms.Panel plxb;
        private System.Windows.Forms.TextBox txtxh;
    }
}