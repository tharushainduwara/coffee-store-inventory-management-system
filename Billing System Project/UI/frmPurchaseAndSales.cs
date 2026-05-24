using Billing_System_Project.BILL;
using Billing_System_Project.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Billing_System_Project.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        deaCustDAL dcDAL = new deaCustDAL();
        productsDAL pDAL = new productsDAL();
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactionDetailsDAL tdDAL = new transactionDetailsDAL();
        DataTable transactionDT = new DataTable();
        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = frmUserDashboard.transactionType;
            purSalLblHeader.Text = type;

            //Specify columns for TransactionDataTable
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from textbox
            string keyword = textBoxSearch.Text;

            if (keyword == "")
            {
                textBoxName.Text = "";
                textBoxEmail.Text = "";
                textBoxContact.Text = "";
                textBoxAddress.Text = "";
                return;
            }

            //Write the code to get the details and set the value on text box
            deaCustBILL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

            //Now transfer or set the value from deacustBILL to textboxes
            textBoxName.Text = dc.name;
            textBoxEmail.Text = dc.email;
            textBoxContact.Text = dc.contact;
            textBoxAddress.Text = dc.address;
        }

        private void searchTxt2_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from textbox
            string keyword = searchTxt2.Text;

            if(keyword == "")
            {
                nameTxt2.Text = "";
                inventoryTxt.Text = "";
                rateTxt2.Text = "";
                qtyTxt2.Text = "";
                return ;
            }
           
            //Write the code to get the details and set the value on text box
            productsBILL p = pDAL.GetProductsForTransaction(keyword);

            //Now transfer or set the value from deacustBILL to textboxes
            nameTxt2.Text = p.name;
            inventoryTxt.Text = p.qty.ToString();
            rateTxt2.Text = p.rate.ToString();
            
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            //Get product name, rate and qty customer want to buy
            string productName = nameTxt2.Text;
            decimal Rate = decimal.Parse(rateTxt2.Text);
            decimal Qty = decimal.Parse(qtyTxt2.Text);
            decimal Total = Rate * Qty;

            //Display the subtotal
            //Get the subtotal value from textbox
            decimal subTotal = decimal.Parse(subTotalTxt.Text);
            subTotal = subTotal + Total;

            if (productName == "")
            {
                //Display error message
                MessageBox.Show("Select the product first.Try Again.");
            }
            else
            {
                //Add product to the data to DataGrid View
                transactionDT.Rows.Add(productName, Rate, Qty, Total);

                //Show in DataGrid View
                dgvAddedProducts.DataSource = transactionDT;

                //display subtotal in textbox
                subTotalTxt.Text = subTotal.ToString();

                //Clear the textboxes
                searchTxt2.Text = "";
                nameTxt2.Text = "";
                inventoryTxt.Text = "0";
                rateTxt2.Text = "0";
                qtyTxt2.Text = "0";


            }
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textbox
            string value = discountTxt.Text;

            if (value == "")
            {
                //Display error message
                MessageBox.Show("Please add discount first.");

            }
            else
            {
                //Get the discount in decimal value
                decimal subTotal = decimal.Parse(subTotalTxt.Text);
                decimal discount = decimal.Parse(discountTxt.Text);

                //Calculate the grand total based on discount
                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                //Display the grandTotal
                grandTotalTxt.Text = grandTotal.ToString();


            }
        }

        private void vatTxt_TextChanged(object sender, EventArgs e)
        {
            string check = vatTxt.Text;

            if (check == "")
            {
                //Display error message
                MessageBox.Show("Calculate the discount and set the Grand Total first.");
            }
            else
            {
                //Calculate VAT
                //Getting the VAT percent first
                decimal previousGT = decimal.Parse(grandTotalTxt.Text);
                decimal vat = decimal.Parse(vatTxt.Text);
                decimal grandTotalWithVAT = ((100 + vat) / 100) * previousGT;

                //Display new grandTotal with vat
                grandTotalTxt.Text = grandTotalWithVAT.ToString();

            }
        }

        private void paidAmountTxt_TextChanged(object sender, EventArgs e)
        {
            //Get the paid amount and grand total
            decimal grandTotal = decimal.Parse(grandTotalTxt.Text);
            decimal paidAmount = decimal.Parse(paidAmountTxt.Text);

            decimal returnAmount = paidAmount - grandTotal;

            //Display the return amount as well
            returnAmountTxt.Text = returnAmount.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Get the value from PurchaseSale form first
            transactionBILL transaction = new transactionBILL();

            transaction.type = purSalLblHeader.Text;

            //Get the ID of Dealer or Customer more
            //Lets get name of the dealer or customer first
            string deaCustName = textBoxName.Text; 
            deaCustBILL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(grandTotalTxt.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(vatTxt.Text);
            transaction.discount = decimal.Parse(discountTxt.Text);

            //Get the username of loogedin user
            string username = frmLogin.loggedIn;
            userBILL u = uDAL.GetIdFromUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            //Lets create a boolen variable and set its value to false
            bool success = false;

            //Actual code to insert transaction and transaction details
            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //Create a boolean value and insert transaction
                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                //Use for loop to insert transaction details
                for(int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Get all the details of the product
                    transactionDetailsBILL transactionDetail = new transactionDetailsBILL();
                    
                    //Get the product name and convert it to id
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    productsBILL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                    //Increase or Decrease product quantity based on purchase or sales
                    string transactionType = purSalLblHeader.Text;


                    //Lets check whether we are on purchase or sales
                    bool x = false;
                    if ( transactionType == "Purchase")
                    {
                        x = pDAL.IncreaseProduct(transactionDetail.product_id,transactionDetail.qty);
                    }
                    else if ( transactionType == "Sales")
                    {
                        x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                        
                    }

                    //Insert transaction details inside the database
                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;

                }
                if (success == true)
                {
                    
                    //Transaction Complete
                    scope.Complete();

                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n\r\n CoffeStore PVT.LTD.\r\n\r\n";
                    printer.SubTitle = "Colombo,Sri Lanka \r\n Phone: +94-7052XXXX \r\n\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount: " + discountTxt.Text + "%\r\n" + "VAT: " + vatTxt.Text + "%\r\n"+"Grand Total: " +grandTotalTxt.Text+ "\r\n\r\n" + "Thank you for doing business with us.";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgvAddedProducts);


                    MessageBox.Show("Transaction Completed Successfully");

                    //Clear
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    textBoxSearch.Text = "";
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxContact.Text = "";
                    textBoxAddress.Text = "";

                    searchTxt2.Text = "";
                    nameTxt2.Text = "";
                    inventoryTxt.Text = "0";
                    rateTxt2.Text = "0";
                    qtyTxt2.Text = "0";
                    subTotalTxt.Text = "0";
                    discountTxt.Text = "0";
                    vatTxt.Text = "0";
                    grandTotalTxt.Text = "0";
                    paidAmountTxt.Text = "0";
                    returnAmountTxt.Text = "0";


                }
                else
                {
                    MessageBox.Show("Transaction Failed.");

                }
            }

        }
    }
}
