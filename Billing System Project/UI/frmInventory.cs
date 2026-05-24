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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL(); 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable cDt = cdal.Select();

            categoryCB.DataSource = cDt;

            categoryCB.DisplayMember = "title";
            categoryCB.ValueMember = "title";

            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = categoryCB.Text;

            DataTable dt = pdal.DisplayProductsByCategory(category);
            dgvInventory.DataSource = dt;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvInventory.DataSource = dt;
        }
    }
}
