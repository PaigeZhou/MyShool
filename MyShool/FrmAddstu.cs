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
    public partial class FrmAddstu : Form
    {
        public FrmAddstu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载事件,只要窗口打开，就会执行此方法里面的所有代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddstu_Load(object sender, EventArgs e)
        {
            GradeInformation();
        }

        /// <summary>
        /// 拿到年级信息
        /// </summary>
        private void GradeInformation()
        {
            string sql = "SELECT * FROM [dbo]. [Grade] UNION SELECT 0 ,'请选择年级'";
            DataTable res = DBHelper.GetTable(sql);
            cbograde.DisplayMember = "GradeName";
            cbograde.ValueMember = "GradeId";
            cbograde.DataSource = res;
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        public bool checkinput()
        {
            //拿到学生信息
            string xh = txtxh.Text;
            string pwd = txtmm.Text;
            string pwd2 = txtqrmm.Text;
            string mz = txtname.Text;
            string xb = rbtnman.Checked ? "男" : "女";//拿到性别
            int grade = Convert.ToInt32(cbograde.SelectedValue);//拿到年级
            string dh = txtphone.Text;
            string dz = txtphone.Text;
            string sj = dtpcsrq.Value.ToString("yyyy-MM-dd");//拿到出生日期
            string email = txtemail.Text;

            //非空验证
            if (string.IsNullOrEmpty(xh))
            {
                MessageBox.Show("学号不能为空","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(pwd2))
            {
                MessageBox.Show("二次密码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(mz))
            {
                MessageBox.Show("姓名不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(xb))
            {
                MessageBox.Show("性别按钮不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (grade==0)
            {
                MessageBox.Show("年级选项为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(dz))
            {
                MessageBox.Show("电话不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(sj))
            {
                MessageBox.Show("出生日期不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("邮箱不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(dh))
            {
                MessageBox.Show("电话不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;


        }

        /// <summary>
        /// 判断学号是否重复
        /// </summary>
        /// <returns></returns>
        public bool checkstuxh()
        {
            string sql = string.Format("SELECT COUNT(0) FROM Student WHERE StudentNo='{0}'",txtxh.Text.Trim());
            int r = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            if (r > 0)
            {
                MessageBox.Show("学生学号出现重复，请重试！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtxh.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存按钮，保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnbc_Click(object sender, EventArgs e)
        {
            if (checkinput() && checkstuxh())
            {
                preserva();
            }
        }

        /// <summary>
        /// 执行保存数据
        /// </summary>
        private void preserva()
        {
            //拿到学生信息
            string xh = txtxh.Text;
            string pwd = txtmm.Text;
            string mz = txtname.Text;
            string xb = rbtnman.Checked ? "男" : "女";//拿到性别
            int grade = Convert.ToInt32(cbograde.SelectedValue);//拿到年级
            string dh = txtphone.Text;
            string dz = txtaddress.Text;//拿到地址
            string sj = dtpcsrq.Value.ToString("yyyy-MM-dd");//拿到出生日期
            string email = txtemail.Text;
            string sql = string.Format("INSERT INTO Student VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",xh,pwd,mz,xb,grade,dh,dz,sj,email);
            bool res = DBHelper.ExecuteNonQuery(sql);
            if (res)
            {
                MessageBox.Show("新增成功!","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("新增失败！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnqx_Click(object sender, EventArgs e)
        {
            clear();
        }

        /// <summary>
        /// 执行清空数据的操作
        /// </summary>
        private void clear()
        {
            txtxh.Clear();
            txtmm.Clear();
            txtqrmm.Clear();
            txtname.Clear();
            rbtnman.Checked=true;
            cbograde.SelectedValue=0;
            txtphone.Clear();
            txtaddress.Clear();
            dtpcsrq.Value = DateTime.Now;
            txtemail.Clear();
        }
    }
}
