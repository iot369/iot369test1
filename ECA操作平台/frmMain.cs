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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tmrSys.Interval = 1000;
            tmrSys.Start();
            sLblSysTmr.Text = System.DateTime.Now.ToString();
            sLblUserId.Text = frmLogIn.loginUserId;
        }

        private void tmrSys_Tick(object sender, EventArgs e)
        {
            sLblSysTmr.Text = System.DateTime.Now.ToString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmA = new frmAbout();
            frmA.ShowDialog();
        }

        private void btnMeas_Click(object sender, EventArgs e)
        {
            btnMeas.Enabled = false;
            btnMeasStart.Text = "开始测量";
            btnMeasStart.Enabled = true;
            
        }

        private void btnMeasStart_Click(object sender, EventArgs e)
        {
            btnMeasStart.Text = "正在测量中...";
            btnMeasStart.Enabled = false;
            btnMeasStop.Enabled = true;
        }

        private void btnMeasStop_Click(object sender, EventArgs e)
        {
            btnMeasStart.Text = "开始测量";
            btnMeas.Enabled = true;
            btnMeasStop.Enabled = false;
        }
    }
}
