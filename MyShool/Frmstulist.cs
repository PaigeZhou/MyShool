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
    public partial class Frmstulist : Form
    {
        public static Frmstulist frmstulist;
        public Frmstulist()
        {
            InitializeComponent();
            frmstulist = this;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frmstulist_Load(object sender, EventArgs e)
        {
            cx();

        }

        /// <summary>
        /// 点击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncx_Click(object sender, EventArgs e)
        {
            cx();
        }

        /// <summary>
        /// 执行查询操作
        /// </summary>
        public void cx()
        {
            lvstulist.Items.Clear();
            string mz = txtname.Text;
            string sql = string.Format("SELECT S.StudentNo,S.StudentName,G.GradeName,S.Sex,S.Phone,S.Address FROM Student S INNER JOIN Grade G ON S.GradeId=G.GradeId  WHERE S.StudentName LIKE '%{0}%'", mz);
            SqlDataReader s = DBHelper.ExecuteReader(sql);
            if (s != null && !s.HasRows)
            {
                MessageBox.Show("抱歉，在系统中未找到该学员", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                s.Close();
            }

            while (s != null && s.Read() && s.HasRows)
            {
                ListViewItem lvi = new ListViewItem(s["StudentNo"].ToString());
                lvi.SubItems.Add(s["StudentName"].ToString());
                lvi.SubItems.Add(s["GradeName"].ToString());
                lvi.SubItems.Add(s["Sex"].ToString());
                lvi.SubItems.Add(s["Phone"].ToString());
                lvi.SubItems.Add(s["Address"].ToString());
                lvstulist.Items.Add(lvi);
            }
            if (s != null)
            {
                s.Close();
            }
        }

        /// <summary>
        /// 执行修改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiselect_Click(object sender, EventArgs e)
        {
            if (lvstulist.SelectedItems.Count > 0)
            {
                string xh = lvstulist.SelectedItems[0].SubItems[0].Text;
                FrmAddstu frm = new FrmAddstu();
                frm.EditStuno= xh;
                frm.ShowDialog();
                 
            }
            else
            {
                MessageBox.Show("请选择您要进行修改的学员！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 执行删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidelect_Click(object sender, EventArgs e)
        {
            if (lvstulist.SelectedItems.Count > 0)
            {
                MessageBox.Show("是否删除此学员","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                string xh = lvstulist.SelectedItems[0].SubItems[0].Text;
                string sql = string.Format("DELETE FROM [dbo].[Result] WHERE [StudentNo]='{0}'", xh);
                bool res = DBHelper.ExecuteNonQuery(sql);
                if (res)
                {
                    string sql1 = string.Format("DELETE FROM [dbo].[Student] WHERE [StudentNo]='{0}'",xh);
                    bool res1 = DBHelper.ExecuteNonQuery(sql1);
                    if (res1)
                    {
                        cx();
                        MessageBox.Show("删除学员成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                
            }
        }
    }
}
