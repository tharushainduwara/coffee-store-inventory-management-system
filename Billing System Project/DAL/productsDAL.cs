using Billing_System_Project.BILL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System_Project.DAL
{
    internal class productsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Select Method
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Query to select data in products table
                string sql = "SELECT * FROM tbl_products";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }
            return dt;

        }

        //Insert new product
        public bool Insert(productsBILL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to add new product
                string sql = "INSERT INTO tbl_products (name,category,description,rate,qty,added_date,added_by) VALUES (@name,@category,@description,@rate,@qty,@added_date,@added_by)";

                //Creating SQL command to pass value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values through parameter
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                conn.Open();
                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Update method
        public bool Update(productsBILL p)
        {
            bool isSuccess = false;

            //Creating SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to update products
                string sql = "UPDATE tbl_products SET name=@name,category=@category,description=@description," +
                    "rate=@rate,added_date=@added_date,added_by=@added_by WHERE id=@id";

                //SQL command to pass the value on sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Delete Method
        public bool Delete(productsBILL p)
        {
            bool isSuccess = false;

            //Creating SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to delete product
                string sql = "DELETE FROM tbl_products WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        //Method for search functionality
        public DataTable Search(string keywords)
        {
            //Static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //SQL query to get data from database
                String sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";

                //For executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Database connection open
                conn.Open();

                //Fill data in our DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        //Method to search product in transaction module
        public productsBILL GetProductsForTransaction(string keyword)
        {
            //Create an object of productbill and return it
            productsBILL p = new productsBILL();    

            //SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //SQL query to get the deatils
                string sql = "SELECT name, rate, qty FROM tbl_products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                //DataAdapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                //Transfer the data from SqlAdapter to data table
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());               
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return p;
        }

        //Method to get product id based on product name
        public productsBILL GetProductIDFromName(string ProdcutName)
        {
            productsBILL p = new productsBILL();

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //SQL query to get the id based on name
                string sql = "SELECT id FROM tbl_products WHERE name='" + ProdcutName + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return p;
        }

        //Method to get current quantity from the database 
        public decimal GetProductQty(int ProductID)
        {
            //SQL connection first
            SqlConnection conn = new SqlConnection(myconnstrng);
            
            //Create a decimal variable and set its default value to 0
            decimal qty = 0;
            
            //Create Data table to save the data from database temporarily
            DataTable dt = new DataTable();

            try
            { 
                //Write SQL query to get quantity from database
                string sql = "SELECT qty FROM tbl_products WHERE id = "+ProductID;

                SqlCommand cmd = new SqlCommand(sql, conn);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                conn.Open();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return qty;
        }

        //Method to update quantity
        public bool UpdateQuantity(int ProductID, decimal Qty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";               
                
                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id",ProductID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        //Method to increase product
        public bool IncreaseProduct (int ProductID, decimal IncreaseQty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Get the current Qty from database based on id
                decimal currentQty = GetProductQty(ProductID);
                
                //Increase the current quantity by the qty purchased from dealer
                decimal NewQty = currentQty + IncreaseQty;

                success = UpdateQuantity(ProductID, NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        //Method to decrease product
        public bool DecreaseProduct (int ProductID, decimal Qty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //get the current product quantity
                decimal currentQty = GetProductQty(ProductID);

                //Decrease the product Quantity based on product sales
                decimal NewQty = currentQty - Qty;

                //Update product in Database
                success = UpdateQuantity (ProductID, NewQty);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        //Display products based on categories
        public DataTable DisplayProductsByCategory(string category)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_products WHERE category='" + category + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }
            return dt;
        }


    }
}
