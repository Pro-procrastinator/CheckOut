using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace InventoryManagementSystem
{
    class insertion
    {
        public void insertUsers(string name, string username, string pass, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully added.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isactive", status);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully added.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertProduct(string product, string barcode, int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProduct", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully added.", "Success..", "Success");
            }
            catch (Exception)
            {
                mainclass.con.Close();
                mainclass.showMessage("This name or barcode already exist. Please enter unique name or barcode.", "Error", "Error");
            }
        }

        public void insertSupplier(string companyName, string personName, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", mainclass.con); // stored procedure
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
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data successfully added.", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        private Int64 purID; // purchase invoice id
        public Int64 insertPurchaseInvoice(string date, int doneBy, int suppID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@suppID", suppID);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseID";
                cmd.Parameters.Clear();
                purID =Convert.ToInt64(cmd.ExecuteScalar());
                mainclass.con.Close();
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
            return purID;
        }

        int purCount; // purchase count
        public int insertPurchaseInvoiceDetails(Int64 purID, Int64 proID, int quantity, float totalPrice)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", purID);
                cmd.Parameters.AddWithValue("@prodID", proID);
                cmd.Parameters.AddWithValue("@proQuan", quantity);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                mainclass.con.Open();
                purCount = cmd.ExecuteNonQuery();
                mainclass.con.Close();
            }
            catch (Exception)
            {
                mainclass.con.Close();
            }
            return purCount;
        }

        public void insertSock(Int64 proID, int quantity)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertStock", mainclass.con); // stored procedure
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


        public void insertDeletedItem(Int64 pid, Int64 proid,int quantity,int usrID,DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@usrid", usrID);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quan", quantity);
                cmd.Parameters.AddWithValue("@date", date);
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertProductPrice(Int64 proID,float? buyingPrice = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@proID", proID);
                if(buyingPrice != 0 && buyingPrice != null)
                {
                    cmd.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                }
                
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
            }
            catch (Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }
        retrieval ret = new retrieval();
        update up = new update();
        int saleCount;
        Int64 saleID;
        public void insertSales(DataGridView gv,string proIDGV,string quanGV,int doneBy, DateTime dt, float totalAm, float totalDisc, float amountGiven, float amountReturn,string payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", mainclass.con); // stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAm);
                    cmd.Parameters.AddWithValue("@totalDiscount", totalDisc);
                    cmd.Parameters.AddWithValue("@given", amountGiven);
                    cmd.Parameters.AddWithValue("@return", amountReturn);
                    
                    if(payType=="Cash")
                    {
                        cmd.Parameters.AddWithValue("@payType", 0);
                    }
                    else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 1);
                    }
                    else if(payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 2);
                    }
                    mainclass.con.Open();
                    saleCount = cmd.ExecuteNonQuery();
                    if (saleCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", mainclass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        saleID = Convert.ToInt64(cmd2.ExecuteScalar());
                        
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSaleDetails", mainclass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", saleID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[quanGV].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int stockOfProd = Convert.ToInt32(ret.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString())));
                            int currentQuanOfProduct = Convert.ToInt32(row.Cells[quanGV].Value.ToString());
                            int finalQuanOfProd = stockOfProd - currentQuanOfProduct;
                            up.updateStockWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString()), finalQuanOfProd);
                        }

                    }

                    mainclass.con.Close();
                    mainclass.showMessage("Sale Succesfull", "Success", "Success");
                    sc.Complete();
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mainclass.con.Close();
            }
        }   
    }
}
