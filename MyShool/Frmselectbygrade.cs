using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyShool
{
    public partial class Frmselectbygrade : Form
    {
        /// <summary>
        /// 方便跨窗口调用
        /// </summary>
        public static Frmselectbygrade frmselectbygrade;
        public Frmselectbygrade()
        {
            InitializeComponent();
            frmselectbygrade = this;
        }

        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frmselectbygrade_Load(object sender, EventArgs e)
        {
            Selectstugrade();
            Selectstu();
        }

        /// <summary>
        /// 绑定年级信息
        /// </summary>
        private void Selectstugrade()
        {
            //是否允许系统自创建列
            dvgstu.AutoGenerateColumns = false;
            string sql = "SELECT * FROM [dbo]. [Grade] UNION SELECT 0 ,'全部'";
            DataTable res = DBHelper.GetTable(sql);
            cbograde.DisplayMember = "GradeName";
            cbograde.ValueMember = "GradeId";
            cbograde.DataSource = res;
        }

        /// <summary>
        /// 查询学生信息
        /// </summary>
        public void Selectstu()
        {
            string sql = string.Format("SELECT StudentNo,StudentName,Sex,BornDate,Address FROM Student WHERE 1=1");
            int res = Convert.ToInt32(cbograde.SelectedIndex);
            if (res>0)
            {
                sql += string.Format("AND GradeId={0}", res);
            }
            dvgstu.DataSource = DBHelper.GetTable(sql);
            
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnselect_Click(object sender, EventArgs e)
        {
            Selectstu();
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiselect_Click(object sender, EventArgs e)
        {
            if (dvgstu.SelectedRows.Count > 0)
            {
                FrmAddstu frm = new FrmAddstu();
                frm.EditStuno = dvgstu.SelectedCells[0].Value.ToString();
                frm.ShowDialog();
            } 
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidelete_Click(object sender, EventArgs e)
        {
            if (dvgstu.SelectedRows.Count>0)
            {
                MessageBox.Show("是否删除此学员", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                string xh = dvgstu.SelectedCells[0].Value.ToString();
                string sql = string.Format("DELETE FROM [dbo].[Result] WHERE [StudentNo]='{0}'", xh);
                bool res = DBHelper.ExecuteNonQuery(sql);
                string sql1 = string.Format("DELETE FROM [dbo].[Student] WHERE [StudentNo]='{0}'", xh);
                bool res1 = DBHelper.ExecuteNonQuery(sql1);
                if (res1)
                {
                    MessageBox.Show("删除学员成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Selectstu();
                }
            }
        }

        /// <summary>
        /// 添加成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiadd_Click(object sender, EventArgs e)
        {
            Frmaddresult frm = new Frmaddresult();
            frm.stuno = dvgstu.SelectedCells[0].Value.ToString();
            frm.ShowDialog();

        }
    }
}
