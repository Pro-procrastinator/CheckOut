using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class update
    {
        public void UpdatetUsers(int id,string name, string username, string pass, string phone, string email,Int16 status)
        {
      
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully Updated.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }


        public void updateCategory(int id,string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isactive", status);
                cmd.Parameters.AddWithValue("@id", id);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data Updated Successfully.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateProduct(Int64 proID, string product, string barcode, int catID, DateTime? expiry=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if(expiry==null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@id", proID);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully Updated.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateSupplier(int suppID, string companyName, string personName, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@company", companyName);
                cmd.Parameters.AddWithValue("@conPerson", personName);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                cmd.Parameters.AddWithValue("@address", address);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@@suppID", suppID);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully Updated.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateStock(Int64 proID, int quantity)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateStock", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
            }
            catch (Exception)
            {
                mainclass.con.Close();
            }
         }

        public void updateStockWithoutConnection(Int64 proID, int quantity)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateStock", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                mainclass.con.Close();
            }
        }

        public void updateProductPrice(Int64 proID, float bp,float sp=0,float discount=0,float profit=0)
        {
            try
            {
                SqlCommand cmd;
                if (sp==0 && discount==0 && profit==0)
                {
                    cmd = new SqlCommand("st_updateProductPrice1", mainclass.con); // stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@buyingPrice", bp);
                }
                else
                {
                    cmd = new SqlCommand("st_updateProductPrice", mainclass.con); // stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@buyingPrice", bp);
                    cmd.Parameters.AddWithValue("@sp", sp);
                    cmd.Parameters.AddWithValue("@disc", discount);
                    cmd.Parameters.AddWithValue("@profit", profit);
                }
                
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
            }
            catch (Exception)
            {
                mainclass.con.Close();
            }
        }

    }
}
