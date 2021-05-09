
namespace MyShool
{
    partial class Frmlogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.lblusernmae = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.btodl = new System.Windows.Forms.Button();
            this.btoqx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusernmae
            // 
            this.lblusernmae.AutoSize = true;
            this.lblusernmae.BackColor = System.Drawing.Color.Transparent;
            this.lblusernmae.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblusernmae.Location = new System.Drawing.Point(219, 235);
            this.lblusernmae.Name = "lblusernmae";
            this.lblusernmae.Size = new System.Drawing.Size(58, 19);
            this.lblusernmae.TabIndex = 0;
            this.lblusernmae.Text = "用户名:";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpwd.Location = new System.Drawing.Point(219, 282);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(54, 19);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "密码：";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Transparent;
            this.lbltype.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltype.Location = new System.Drawing.Point(219, 327);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(84, 19);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "登录类型：";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(308, 235);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(180, 25);
            this.txtusername.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(308, 281);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(180, 25);
            this.txtpwd.TabIndex = 4;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // cbotype
            // 
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "学霸",
            "学渣"});
            this.cbotype.Location = new System.Drawing.Point(309, 327);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(179, 23);
            this.cbotype.TabIndex = 5;
            // 
            // btodl
            // 
            this.btodl.BackColor = System.Drawing.Color.Transparent;
            this.btodl.BackgroundImage = global::MyShool.Properties.Resources.button;
            this.btodl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btodl.FlatAppearance.BorderSize = 0;
            this.btodl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btodl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btodl.Location = new System.Drawing.Point(211, 370);
            this.btodl.Name = "btodl";
            this.btodl.Size = new System.Drawing.Size(92, 30);
            this.btodl.TabIndex = 6;
            this.btodl.Text = "登录";
            this.btodl.UseVisualStyleBackColor = false;
            this.btodl.Click += new System.EventHandler(this.btodl_Click);
            // 
            // btoqx
            // 
            this.btoqx.BackColor = System.Drawing.Color.Transparent;
            this.btoqx.BackgroundImage = global::MyShool.Properties.Resources.button;
            this.btoqx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btoqx.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btoqx.FlatAppearance.BorderSize = 0;
            this.btoqx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoqx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btoqx.Location = new System.Drawing.Point(340, 370);
            this.btoqx.Name = "btoqx";
            this.btoqx.Size = new System.Drawing.Size(92, 30);
            this.btoqx.TabIndex = 7;
            this.btoqx.Text = "取消";
            this.btoqx.UseVisualStyleBackColor = false;
            this.btoqx.Click += new System.EventHandler(this.btoqx_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyShool.Properties.Resources.login_bj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btoqx;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.btoqx);
            this.Controls.Add(this.btodl);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblusernmae);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusernmae;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Button btodl;
        private System.Windows.Forms.Button btoqx;
    }
}

