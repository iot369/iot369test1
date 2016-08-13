using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECA操作平台
{
    public partial class frmLogIn : Form
    {
        public static string loginUserId = string.Empty;
        public frmLogIn()
        {
            InitializeComponent();
            loginUserId = _loginUserId;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxLoginUserId.Text == "")
            {
                MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBoxPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBoxLoginUserId.Text == txtBoxPwd.Text)
            {
                loginUserId = _loginUserId;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string _loginUserId
        {
            get { return this.txtBoxLoginUserId.Text; }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
