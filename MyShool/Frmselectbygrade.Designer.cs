
namespace MyShool
{
    partial class Frmselectbygrade
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
            this.lblgrade = new System.Windows.Forms.Label();
            this.cbograde = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.dvgstu = new System.Windows.Forms.DataGridView();
            this.stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stusex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsgrade = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiselect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmidelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiadd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvgstu)).BeginInit();
            this.cmsgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblgrade.Location = new System.Drawing.Point(217, 23);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(39, 20);
            this.lblgrade.TabIndex = 0;
            this.lblgrade.Text = "年级";
            // 
            // cbograde
            // 
            this.cbograde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(262, 22);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(182, 23);
            this.cbograde.TabIndex = 1;
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnselect.Location = new System.Drawing.Point(450, 19);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(64, 29);
            this.btnselect.TabIndex = 2;
            this.btnselect.Text = "查  找";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // dvgstu
            // 
            this.dvgstu.AllowUserToAddRows = false;
            this.dvgstu.AllowUserToDeleteRows = false;
            this.dvgstu.AllowUserToResizeColumns = false;
            this.dvgstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgstu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuno,
            this.stuname,
            this.stusex,
            this.BornDate,
            this.address});
            this.dvgstu.ContextMenuStrip = this.cmsgrade;
            this.dvgstu.Location = new System.Drawing.Point(12, 66);
            this.dvgstu.MultiSelect = false;
            this.dvgstu.Name = "dvgstu";
            this.dvgstu.ReadOnly = true;
            this.dvgstu.RowHeadersVisible = false;
            this.dvgstu.RowHeadersWidth = 51;
            this.dvgstu.RowTemplate.Height = 27;
            this.dvgstu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgstu.Size = new System.Drawing.Size(775, 372);
            this.dvgstu.TabIndex = 3;
            // 
            // stuno
            // 
            this.stuno.DataPropertyName = "StudentNo";
            this.stuno.HeaderText = "学生学号";
            this.stuno.MinimumWidth = 6;
            this.stuno.Name = "stuno";
            this.stuno.ReadOnly = true;
            this.stuno.Width = 125;
            // 
            // stuname
            // 
            this.stuname.DataPropertyName = "StudentName";
            this.stuname.HeaderText = "学生姓名";
            this.stuname.MinimumWidth = 6;
            this.stuname.Name = "stuname";
            this.stuname.ReadOnly = true;
            this.stuname.Width = 125;
            // 
            // stusex
            // 
            this.stusex.DataPropertyName = "Sex";
            this.stusex.HeaderText = "性别";
            this.stusex.MinimumWidth = 6;
            this.stusex.Name = "stusex";
            this.stusex.ReadOnly = true;
            this.stusex.Width = 125;
            // 
            // BornDate
            // 
            this.BornDate.DataPropertyName = "BornDate";
            this.BornDate.HeaderText = "出生年月日";
            this.BornDate.MinimumWidth = 6;
            this.BornDate.Name = "BornDate";
            this.BornDate.ReadOnly = true;
            this.BornDate.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "家庭住址";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 250;
            // 
            // cmsgrade
            // 
            this.cmsgrade.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsgrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiselect,
            this.toolStripSeparator1,
            this.tsmidelete,
            this.toolStripSeparator2,
            this.tsmiadd});
            this.cmsgrade.Name = "tsmiupdate";
            this.cmsgrade.Size = new System.Drawing.Size(211, 116);
            // 
            // tsmiselect
            // 
            this.tsmiselect.Name = "tsmiselect";
            this.tsmiselect.Size = new System.Drawing.Size(210, 24);
            this.tsmiselect.Text = "修改";
            this.tsmiselect.Click += new System.EventHandler(this.tsmiselect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmidelete
            // 
            this.tsmidelete.Name = "tsmidelete";
            this.tsmidelete.Size = new System.Drawing.Size(210, 24);
            this.tsmidelete.Text = "删除";
            this.tsmidelete.Click += new System.EventHandler(this.tsmidelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiadd
            // 
            this.tsmiadd.Name = "tsmiadd";
            this.tsmiadd.Size = new System.Drawing.Size(210, 24);
            this.tsmiadd.Text = "添加成绩";
            this.tsmiadd.Click += new System.EventHandler(this.tsmiadd_Click);
            // 
            // Frmselectbygrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgstu);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.cbograde);
            this.Controls.Add(this.lblgrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frmselectbygrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmselectbyname";
            this.Load += new System.EventHandler(this.Frmselectbygrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgstu)).EndInit();
            this.cmsgrade.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.ComboBox cbograde;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.DataGridView dvgstu;
        private System.Windows.Forms.ContextMenuStrip cmsgrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiselect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmidelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stusex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}