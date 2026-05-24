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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userBILL u = new userBILL();
        userDAL dal = new userDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Refreshing DataGridView
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            u.first_name = firstNameText.Text;
            u.last_name = lastNameText.Text;
            u.email = emailText.Text;
            u.username = usernameText.Text;
            u.password = passwordText.Text;
            u.contact = contactText.Text;
            u.address = addressText.Text;
            u.gender = genderComboBox.Text;
            u.user_type = userTypeComboBox.Text;
            u.added_date =DateTime.Now;
            
            //Getting username of the logged in user
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = dal.GetIdFromUsername(loggedUser);
            u.added_by = usr.id;

            //inserting data into database
            bool success = dal.Insert(u);
            if (success=true)
            {
                MessageBox.Show("User successfully created.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user.");
            }

            //Refreshing DataGridView
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;

        }

        private void clear()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            emailText.Text = "";
            usernameText.Text = "";
            passwordText.Text = "";
            contactText.Text = "";
            addressText.Text = "";
            genderComboBox.Text = "";
            userTypeComboBox.Text = "";
        }

        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            userIdText.Text = dataGridViewUsers.Rows[rowIndex].Cells[0].Value.ToString();
            firstNameText.Text = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            lastNameText.Text = dataGridViewUsers.Rows[rowIndex].Cells[2].Value.ToString();
            emailText.Text = dataGridViewUsers.Rows[rowIndex].Cells[3].Value.ToString();
            usernameText.Text = dataGridViewUsers.Rows[rowIndex].Cells[4].Value.ToString();
            passwordText.Text = dataGridViewUsers.Rows[rowIndex].Cells[5].Value.ToString();
            contactText.Text = dataGridViewUsers.Rows[rowIndex].Cells[6].Value.ToString();
            addressText.Text = dataGridViewUsers.Rows[rowIndex].Cells[7].Value.ToString();
            genderComboBox.Text = dataGridViewUsers.Rows[rowIndex].Cells[8].Value.ToString();
            userTypeComboBox.Text = dataGridViewUsers.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Get the value from User UI
            u.id = Convert.ToInt32(userIdText.Text);
            u.first_name = firstNameText.Text;
            u.last_name = lastNameText.Text; 
            u.email = emailText.Text;
            u.username = usernameText.Text;
            u.password = passwordText.Text;
            u.contact = contactText.Text;
            u.address = addressText.Text;
            u.gender = genderComboBox.Text;
            u.user_type = userTypeComboBox.Text;
            u.added_date = DateTime.Now;
            
            //Getting username of the logged in user
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = dal.GetIdFromUsername(loggedUser);
            u.added_by = usr.id;

            //Updating data into Database
            bool success = dal.Update(u);
            if(success == true)
            {
                MessageBox.Show("User successfully updated");
                clear();
            }
            else
            {
                MessageBox.Show("User update failed");
            }

            //Refreshing DataGridView
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Getting user id from form
            u.id = Convert.ToInt32(userIdText.Text);
            
            bool success = dal.Delete(u);
            if(success == true)
            {
                MessageBox.Show("User deleted successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("User deleted failed.");
            }

            //Refreshing DataGridView
            DataTable dt = dal.Select();
            dataGridViewUsers.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from Text Box
            string keywords = searchText.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dataGridViewUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dataGridViewUsers.DataSource = dt;
            }
        }
        
    }
}
