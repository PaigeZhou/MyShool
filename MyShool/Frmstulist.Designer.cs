
namespace MyShool
{
    partial class Frmstulist
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblmhcx = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btncx = new System.Windows.Forms.Button();
            this.lvstulist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname.Location = new System.Drawing.Point(122, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "姓名";
            // 
            // lblmhcx
            // 
            this.lblmhcx.AutoSize = true;
            this.lblmhcx.Location = new System.Drawing.Point(458, 27);
            this.lblmhcx.Name = "lblmhcx";
            this.lblmhcx.Size = new System.Drawing.Size(127, 15);
            this.lblmhcx.TabIndex = 1;
            this.lblmhcx.Text = "（支持模糊查询）";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(165, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(206, 25);
            this.txtname.TabIndex = 2;
            // 
            // btncx
            // 
            this.btncx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncx.Location = new System.Drawing.Point(377, 23);
            this.btncx.Name = "btncx";
            this.btncx.Size = new System.Drawing.Size(75, 23);
            this.btncx.TabIndex = 3;
            this.btncx.Text = "查询";
            this.btncx.UseVisualStyleBackColor = true;
            this.btncx.Click += new System.EventHandler(this.btncx_Click);
            // 
            // lvstulist
            // 
            this.lvstulist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvstulist.FullRowSelect = true;
            this.lvstulist.GridLines = true;
            this.lvstulist.HideSelection = false;
            this.lvstulist.Location = new System.Drawing.Point(12, 63);
            this.lvstulist.Name = "lvstulist";
            this.lvstulist.Size = new System.Drawing.Size(776, 414);
            this.lvstulist.TabIndex = 4;
            this.lvstulist.UseCompatibleStateImageBehavior = false;
            this.lvstulist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "学员姓名";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "所属年级";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "联系电话";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "家庭住址";
            this.columnHeader6.Width = 449;
            // 
            // Frmstulist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.lvstulist);
            this.Controls.Add(this.btncx);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblmhcx);
            this.Controls.Add(this.lblname);
            this.Name = "Frmstulist";
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.Frmstulist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblmhcx;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btncx;
        private System.Windows.Forms.ListView lvstulist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}