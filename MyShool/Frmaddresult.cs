using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShool
{
    public partial class Frmaddresult : Form
    {
        public string stuno = string.Empty;
        public Frmaddresult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frmaddresult_Load(object sender, EventArgs e)
        {
            Bdsub();

            Selectresult();
        }

        /// <summary>
        /// 查询全部的成绩信息
        /// </summary>
        private void Selectresult()
        {

            string sql = string.Format(@" SELECT S1.StudentName,S.SubjectName,R.StudentResult,R.ExamDate FROM Subject S INNER JOIN Result R ON S.SubjectId=R.SubjectId
                                          INNER JOIN Student S1 ON S1.StudentNo=R.StudentNo WHERE S1.StudentNo='{0}'",stuno);
            dgvresult.DataSource = DBHelper.GetTable(sql);
        }

        /// <summary>
        /// 绑定科目
        /// </summary>
        private void Bdsub()
        {
            string sql = ("  SELECT * FROM [dbo].[Subject] UNION SELECT 0 ,'全部',0,1 ORDER BY SubjectId ");
            DataTable table = DBHelper.GetTable(sql);
            cbosubname.DisplayMember = "SubjectName";
            cbosubname.ValueMember = "SubjectId";
            cbosubname.DataSource = table;

        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Addresult();
        }

        /// <summary>
        /// 执行添加操作
        /// </summary>
        private void Addresult()
        {
            if (Fkyz())
            {

                //string sj = dtpcsrq.Value.ToString("yyyy-MM-dd");
                string datetime = dtpexamdate.Value.ToString("yyyy-MM-dd");
                string sql = ($" INSERT INTO [dbo].[Result] (StudentNo,SubjectId,StudentResult,ExamDate)VALUES('{stuno}',{cbosubname.SelectedIndex},{txtresult.Text},'{datetime}')");
                bool res = DBHelper.ExecuteNonQuery(sql);
                if (res)
                {
                    Selectresult();
                    MessageBox.Show("新增学员成绩成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("新增学员成绩失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool Fkyz()
        {
            if (string.IsNullOrEmpty(txtresult.Text))
            {
                MessageBox.Show("请输入学员成绩,学员成绩不能为空!","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
