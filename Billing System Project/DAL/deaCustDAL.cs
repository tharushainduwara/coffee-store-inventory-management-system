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
    internal class deaCustDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Select Method
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Query to select data in Dealer and Customer table
                string sql = "SELECT * FROM tbl_dea_cust";
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

        //Insert new product
        public bool Insert(deaCustBILL dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to add new dealer and customer
                string sql = "INSERT INTO tbl_dea_cust (type,name,email,contact,address,added_date,added_by) VALUES (@type,@name,@email,@contact,@address,@added_date,@added_by)";

                //Creating SQL command to pass value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values through parameter
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

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
        public bool Update(deaCustBILL dc)
        {
            bool isSuccess = false;

            //Creating SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to update dealer and customer
                string sql = "UPDATE tbl_dea_cust SET type=@type,name=@name,email=@email," +
                    "contact=@contact,address=@address,added_date=@added_date,added_by=@added_by WHERE id=@id";

                //SQL command to pass the value on sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

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
        public bool Delete(deaCustBILL dc)
        {
            bool isSuccess = false;

            //Creating SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to delete dealer and customer
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", dc.id);

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
                String sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR type LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";

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

        //Method to search dealer or customer for transaction module
        public deaCustBILL SearchDealerCustomerForTransaction(string keywords)
        {
            deaCustBILL dc = new deaCustBILL();
            
            //Static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            
            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //SQL query to search dealer or customer based on keywords
                string sql = "SELECT name, email, contact, address FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'"; 
                
                //DataAdapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);

                conn.Open();
                
                //Transfer the data from SqlAdapter to data table
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
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
            return dc;

        }

        //Method to get ID of the dealer or customer based on name
        public deaCustBILL GetDeaCustIDFromName (string Name)
        {
            deaCustBILL dc = new deaCustBILL();

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //SQL query to get the id based on name
                string sql = "SELECT id FROM tbl_dea_cust WHERE name='"+Name+"'";
                
                SqlDataAdapter adapter = new SqlDataAdapter( sql,conn);
                
                conn.Open();
                
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return dc;
        }
    }
}
