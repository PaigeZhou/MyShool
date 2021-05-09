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
    public partial class Frmlogin : Form
    {
        public static Frmlogin main;
        public string userId = string.Empty;
        public Frmlogin()
        {
            main = this;
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btodl_Click(object sender, EventArgs e)
        {
            string name = txtusername.Text;
            string pwd = txtpwd.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("用户名不能为空","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string sql = string.Format("SELECT COUNT(0) FROM [dbo].[User] WHERE UserName='{0}' AND Password='{1}'",name,pwd);
            int res = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            if (res>0)
            {
                MessageBox.Show("登录成功!");
                userId = name;
                this.Hide();
                Frmmain zcd = new Frmmain();
                zcd.Show();
            }
            else
            {
                MessageBox.Show("请核对你的用户名或密码是否输入有误","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoqx_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
         }
    }
}
