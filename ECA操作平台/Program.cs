using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECA操作平台
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogIn frmlogin = new frmLogIn();
            frmlogin.ShowDialog();
            if (frmlogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
