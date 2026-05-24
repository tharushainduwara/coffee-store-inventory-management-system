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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        deaCustBILL dc = new deaCustBILL();
        deaCustDAL dcDal = new deaCustDAL();
        userDAL uDal = new userDAL();
        private void btnADD_Click(object sender, EventArgs e)
        {
            //Get the value from category form
            dc.type = typeComboBox.Text;
            dc.name = nametxt.Text;
            dc.email = emailTxt.Text;
            dc.contact = contactTxt.Text;
            dc.address = addressTxt.Text;   
            dc.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = uDal.GetIdFromUsername(loggedUser);

            //Passing the id of logged in user in added by field
            dc.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = dcDal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Added Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add New Dealer or Customer.");
            }
        }
        public void clear()
        {
            deaCutIdTxt.Text = "";
            typeComboBox.Text = "";
            nametxt.Text = "";
            emailTxt.Text = "";
            contactTxt.Text = "";
            addressTxt.Text = "";
            searchTxt.Text = "";
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            //Refresh the datagrid view
            DataTable dt = dcDal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;

            //Display the value on respective textboxes
            deaCutIdTxt.Text = dgvDeaCust.Rows[RowIndex].Cells[0].Value.ToString();
            typeComboBox.Text = dgvDeaCust.Rows[RowIndex].Cells[1].Value.ToString();
            nametxt.Text = dgvDeaCust.Rows[RowIndex].Cells[2].Value.ToString();
            emailTxt.Text = dgvDeaCust.Rows[RowIndex].Cells[3].Value.ToString();
            contactTxt.Text = dgvDeaCust.Rows[RowIndex].Cells[4].Value.ToString();
            addressTxt.Text = dgvDeaCust.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            //Getting values from the dealer and customer form
            dc.id = int.Parse(deaCutIdTxt.Text);
            dc.type = typeComboBox.Text;
            dc.name = nametxt.Text;
            dc.email = emailTxt.Text;
            dc.contact = contactTxt.Text;
            dc.address = addressTxt.Text;
            dc.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = uDal.GetIdFromUsername(loggedUser);

            //Passing the id of logged in user in added by field
            dc.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = dcDal.Update(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Updated Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Dealer or Customer.");
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(deaCutIdTxt.Text);

            //Creating boolean method to insert data into database
            bool success = dcDal.Delete(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Deleted Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Dealer or Customer.");
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from Text Box
            string keywords = searchTxt.Text;

            if (keywords != null)
            {
                DataTable dt = dcDal.Search(keywords);
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
