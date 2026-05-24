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
    internal class categoriesDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Select Method
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Query to select data in category table
                string sql = "SELECT * FROM tbl_categories";
                SqlCommand cmd = new SqlCommand(sql,conn);

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

        //Insert new category
        public bool Insert(categoriesBILL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to add new category
                string sql = "INSERT INTO tbl_categories (title,description,added_date,added_by) VALUES (@title,@description,@added_date,@added_by)";
                
                //Creating SQL command to pass value in our query
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Passing the values through parameter
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                
                conn.Open();
                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch(Exception ex)
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
        public bool Update(categoriesBILL c)
        {
            bool isSuccess = false;
            
            //Creating SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to update category
                string sql = "UPDATE tbl_categories SET title=@title,description=@description,added_date=@added_date,added_by=@added_by WHERE id=@id";

                //SQL command to pass the value on sql query
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description); 
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                conn.Open();
                
                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess= false;
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
        public bool Delete(categoriesBILL c)
        {
            bool isSuccess = false;

            //Creating SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to delete category
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql,conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                conn.Open() ;
                
                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess= false;
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
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";

                //For executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Database connection open
                conn.Open();

                //Fill data in our DataTable
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
    }
}
