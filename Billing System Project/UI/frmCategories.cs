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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBILL c = new categoriesBILL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from category form
            c.title = titleText.Text;
            c.description = descriptionText.Text;
            c.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = udal.GetIdFromUsername(loggedUser);

            //Passing the id of logged in user in added by field
            c.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = dal.Insert(c);
            if(success==true)
            {
                MessageBox.Show("New Category Inserted Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("New Category Inserted Failed.");
            }
        }
        public void clear()
        {
            categoryIdText.Text = "";
            titleText.Text = "";
            descriptionText.Text = "";
            searchTxt.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            //display data in the DataGridView
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            categoryIdText.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            titleText.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            descriptionText.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Getting values from the category form
            c.id = int.Parse(categoryIdText.Text);
            c.title = titleText.Text;
            c.description = descriptionText.Text;
            c.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = udal.GetIdFromUsername(loggedUser);

            //Passing the id of logged in user in added by field
            c.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Category Updated Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category Updated Failed.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(categoryIdText.Text);

            //Creating boolean method to insert data into database
            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Category Deleted Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category Deleted Failed.");
            }

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from Text Box
            string keywords = searchTxt.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
