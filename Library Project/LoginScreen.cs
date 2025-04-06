using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Project;

namespace frmLogin
{
    public partial class LoginScreen : DevExpress.XtraEditors.XtraForm
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void radCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMainScreen Main = new frmMainScreen();
           
            Main.ShowDialog();
            this.Close();

        }
    }
}
