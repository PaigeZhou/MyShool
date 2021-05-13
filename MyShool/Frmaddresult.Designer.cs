namespace MyShool
{
    partial class Frmaddresult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaddresult));
            this.lblsubname = new System.Windows.Forms.Label();
            this.gbosturesult = new System.Windows.Forms.GroupBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dtpexamdate = new System.Windows.Forms.DateTimePicker();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.cbosubname = new System.Windows.Forms.ComboBox();
            this.lblexamdate = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.btnesc = new System.Windows.Forms.Button();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbosturesult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsubname
            // 
            this.lblsubname.AutoSize = true;
            this.lblsubname.Location = new System.Drawing.Point(53, 42);
            this.lblsubname.Name = "lblsubname";
            this.lblsubname.Size = new System.Drawing.Size(39, 20);
            this.lblsubname.TabIndex = 0;
            this.lblsubname.Text = "科目";
            // 
            // gbosturesult
            // 
            this.gbosturesult.Controls.Add(this.btnsubmit);
            this.gbosturesult.Controls.Add(this.dtpexamdate);
            this.gbosturesult.Controls.Add(this.txtresult);
            this.gbosturesult.Controls.Add(this.cbosubname);
            this.gbosturesult.Controls.Add(this.lblexamdate);
            this.gbosturesult.Controls.Add(this.lblresult);
            this.gbosturesult.Controls.Add(this.lblsubname);
            this.gbosturesult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbosturesult.Location = new System.Drawing.Point(12, 12);
            this.gbosturesult.Name = "gbosturesult";
            this.gbosturesult.Size = new System.Drawing.Size(503, 173);
            this.gbosturesult.TabIndex = 1;
            this.gbosturesult.TabStop = false;
            this.gbosturesult.Text = "输入成绩";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(422, 119);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 27);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "添加";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dtpexamdate
            // 
            this.dtpexamdate.Location = new System.Drawing.Point(98, 118);
            this.dtpexamdate.Name = "dtpexamdate";
            this.dtpexamdate.Size = new System.Drawing.Size(317, 27);
            this.dtpexamdate.TabIndex = 5;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(98, 79);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(317, 27);
            this.txtresult.TabIndex = 4;
            // 
            // cbosubname
            // 
            this.cbosubname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosubname.FormattingEnabled = true;
            this.cbosubname.Location = new System.Drawing.Point(98, 39);
            this.cbosubname.Name = "cbosubname";
            this.cbosubname.Size = new System.Drawing.Size(317, 28);
            this.cbosubname.TabIndex = 3;
            // 
            // lblexamdate
            // 
            this.lblexamdate.AutoSize = true;
            this.lblexamdate.Location = new System.Drawing.Point(23, 122);
            this.lblexamdate.Name = "lblexamdate";
            this.lblexamdate.Size = new System.Drawing.Size(69, 20);
            this.lblexamdate.TabIndex = 2;
            this.lblexamdate.Text = "考试时间";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(53, 82);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(39, 20);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "成绩";
            // 
            // dgvresult
            // 
            this.dgvresult.AllowUserToAddRows = false;
            this.dgvresult.AllowUserToDeleteRows = false;
            this.dgvresult.AllowUserToResizeRows = false;
            this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuname,
            this.subname,
            this.result,
            this.examdate});
            this.dgvresult.Location = new System.Drawing.Point(13, 192);
            this.dgvresult.MultiSelect = false;
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.RowHeadersVisible = false;
            this.dgvresult.RowHeadersWidth = 51;
            this.dgvresult.RowTemplate.Height = 27;
            this.dgvresult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvresult.Size = new System.Drawing.Size(496, 246);
            this.dgvresult.TabIndex = 2;
            // 
            // btnesc
            // 
            this.btnesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnesc.Location = new System.Drawing.Point(434, 444);
            this.btnesc.Name = "btnesc";
            this.btnesc.Size = new System.Drawing.Size(75, 27);
            this.btnesc.TabIndex = 7;
            this.btnesc.Text = "返回";
            this.btnesc.UseVisualStyleBackColor = true;
            this.btnesc.Click += new System.EventHandler(this.btnesc_Click);
            // 
            // stuname
            // 
            this.stuname.DataPropertyName = "STUDENTNAME";
            this.stuname.HeaderText = "学生姓名";
            this.stuname.MinimumWidth = 6;
            this.stuname.Name = "stuname";
            this.stuname.ReadOnly = true;
            this.stuname.Width = 125;
            // 
            // subname
            // 
            this.subname.DataPropertyName = "SUBJECTNAME";
            this.subname.HeaderText = "科目名称";
            this.subname.MinimumWidth = 6;
            this.subname.Name = "subname";
            this.subname.ReadOnly = true;
            this.subname.Width = 125;
            // 
            // result
            // 
            this.result.DataPropertyName = "studentresult";
            this.result.HeaderText = "成绩";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 125;
            // 
            // examdate
            // 
            this.examdate.DataPropertyName = "examdate";
            this.examdate.HeaderText = "考试时间";
            this.examdate.MinimumWidth = 6;
            this.examdate.Name = "examdate";
            this.examdate.ReadOnly = true;
            this.examdate.Width = 125;
            // 
            // Frmaddresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 480);
            this.Controls.Add(this.btnesc);
            this.Controls.Add(this.dgvresult);
            this.Controls.Add(this.gbosturesult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmaddresult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生成绩";
            this.Load += new System.EventHandler(this.Frmaddresult_Load);
            this.gbosturesult.ResumeLayout(false);
            this.gbosturesult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsubname;
        private System.Windows.Forms.GroupBox gbosturesult;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DateTimePicker dtpexamdate;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.ComboBox cbosubname;
        private System.Windows.Forms.Label lblexamdate;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.DataGridView dgvresult;
        private System.Windows.Forms.Button btnesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn examdate;
    }
}