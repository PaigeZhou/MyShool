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
    public partial class Frmdome : Form
    {
        public Frmdome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加一个磁盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntj_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtname.Text.Trim());
            item.ImageIndex = new Random().Next(0, 6);
            item.SubItems.AddRange(new string[]{txttype.Text,txtzdx.Text,txtkycp.Text});
            lvdemo.Items.Add(item);
        }

        private void tsmlbig_Click(object sender, EventArgs e)
        {
            lvdemo.View = View.LargeIcon;
        }

        private void tsmixxxx_Click(object sender, EventArgs e)
        {
            lvdemo.View = View.Details;
        }

        private void tsmismall_Click(object sender, EventArgs e)
        {
            lvdemo.View = View.SmallIcon;
        }
    }
}
