using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
        //登录
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {

            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }
        //非空验证
        private bool CheckInput()
        {
            if(textName.Text.Trim()==""||textPwd.Text.Trim()=="")
            {
                MessageBox.Show("请输入用户名和密码")；
                return false;
            }
            return true;
         }
        public void Login()
        {
            string name = textName.Text.Trim();
            string pwd = textPwd.Text.Trim();
            string sql
        }
    }
}
