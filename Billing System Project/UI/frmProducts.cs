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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        productsBILL p = new productsBILL();
        userDAL udal = new userDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            //Creating Data Table to hold the categories from Database
            DataTable categoriesDT = cdal.Select();

            //Specify DataSource for Category combobox
            categoryComboBox.DataSource = categoriesDT;

            //Specify display member and value member for combobox
            categoryComboBox.DisplayMember = "title";
            categoryComboBox.ValueMember = "title";

            //Load all the Products in datagrid view
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Get the value from category form
            p.name = nameText.Text;
            p.category = categoryComboBox.Text;
            p.description = descriptionTxt.Text;
            p.rate = decimal.Parse(rateText.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;


            //Getting ID in added by field
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = udal.GetIdFromUsername(loggedUser);

            //Passing the id of logged in user in added by field
            p.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product Added Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add New Product.");
            }
        }
        public void clear()
        {
            productIdText.Text = "";
            nameText.Text = "";
            descriptionTxt.Text = "";
            rateText.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            
            //Display the value on respective textboxes
            productIdText.Text = dgvProducts.Rows[RowIndex].Cells[0].Value.ToString();
            nameText.Text = dgvProducts.Rows[RowIndex].Cells[1].Value.ToString();
            categoryComboBox.Text = dgvProducts.Rows[RowIndex].Cells[2].Value.ToString();
            descriptionTxt.Text = dgvProducts.Rows[RowIndex].Cells[3].Value.ToString();
            rateText.Text = dgvProducts.Rows[RowIndex].Cells[4].Value.ToString();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Getting values from the category form
            p.id = int.Parse(productIdText.Text);
            p.name = nameText.Text;
            p.category = categoryComboBox.Text;
            p.description = descriptionTxt.Text;
            p.rate = decimal.Parse(rateText.Text);
            p.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggedUser = frmLogin.loggedIn;
            userBILL usr = udal.GetIdFromUsername(loggedUser);

            //Passing the id of logged in user in added by field
            p.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Product Updated Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Product.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(productIdText.Text);

            //Creating boolean method to insert data into database
            bool success = pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Product Deleted Successfully.");
                clear();

                //Refresh the datagrid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Product.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from Text Box
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
