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
    public partial class Frmaboutours : Form
    {
        public Frmaboutours()
        {
            InitializeComponent();
        }

        private void Frmaboutours_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击ok，关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        int i = -1;
        private void tjsq_Tick(object sender, EventArgs e)
        {
            i++;
            if (i>3)
            {
                i = 0;
            }
            pickd.Image = imglji.Images[i];

        }
    }
}
