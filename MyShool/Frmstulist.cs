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
        public Frmstulist()
        {
            InitializeComponent();
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

    }
}
