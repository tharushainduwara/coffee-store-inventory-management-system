using Billing_System_Project.BILL;
using Billing_System_Project.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System_Project.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBILL l = new loginBILL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            l.username = usernametxt.Text.Trim();
            l.password = passwordtxt.Text.Trim();
            l.user_type = userComboBox.Text.Trim();

            bool success = dal.loginCheck(l);
            if (success == true)
            {
                MessageBox.Show("Login Succesfull.");
                loggedIn = l.username;

                switch(l.user_type)
                {
                    case "Admin":
                        {
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Invalid User Type.");
                        }
                        break ;
                }
            }
            else
            {
                MessageBox.Show("Login Failed.Try Again.");
            }

        }
    }
}
