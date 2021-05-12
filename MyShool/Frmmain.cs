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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 主菜单顶部那个欢迎你加用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frmmain_Load(object sender, EventArgs e)
        {
           // Text = "欢迎您," + Frmlogin.main.userId;
        }

        /// <summary>
        /// 退出整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmitc_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出整个程序的方法
        }

        /// <summary>
        /// 新增学生操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmixzxs_Click(object sender, EventArgs e)
        {
            FrmAddstu frm = new FrmAddstu();
            frm.MdiParent = this;//设置frmaddstu窗口为当前窗口
            frm.Show();
        }

        /// <summary>
        /// 按名字查询学生列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtncxbyname_Click(object sender, EventArgs e)
        {
            Frmstulist cx = new Frmstulist();
            cx.MdiParent = this;
            cx.Show();
        }

        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmime_Click(object sender, EventArgs e)
        {
            Frmaboutours frmaboutours = new Frmaboutours();
            frmaboutours.ShowDialog();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmixgmm_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 按年级查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmicxbybj_Click(object sender, EventArgs e)
        {

        }
    }
}
