using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace InventoryManagementSystem
{
    class retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV,DataGridViewColumn statusGV,string data = null)
        {
            try
            {
                SqlCommand cmd;
                if(data == null)
                {
                    cmd = new SqlCommand("st_getUserData", mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLike", mainclass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }catch(Exception)
            {
                 
            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catnameGV, DataGridViewColumn catstatusGV,string data = null)
        {
        
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoryData", mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getCategoryDataLike", mainclass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                
                catstatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                catnameGV.DataPropertyName = dt.Columns["Name"].ToString(); 

                gv.DataSource = dt;
            }   

            catch (Exception ex)
            {
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void getList(string proc,ComboBox cb,string displaymember,string valuemember)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray=new object[] { 0, "Select.." };
                dt.Rows.InsertAt(dr,0);
                cb.DataSource = dt;
                cb.DisplayMember = displaymember;
                cb.ValueMember = valuemember;
            }
            catch(Exception)
            {

            }
        }

        public void getListwithTwoParam(string proc, ComboBox cb, string displaymember, string valuemember, 
            string param1, object value1, string param2, object value2)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, value1);
                cmd.Parameters.AddWithValue(param2, value2);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select.." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displaymember;
                cb.ValueMember = valuemember;
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void showProduct(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn expiryGV, DataGridViewColumn catIDGV, DataGridViewColumn categoryGV, DataGridViewColumn barcodeGV, string data = null)
        {

            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductData", mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductDataLike", mainclass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();

                gv.DataSource = dt;
            }

            catch (Exception ex)
            {
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static int USER_ID
        {
            get;
            private set;
        }

        public static string EMP_NAME
        {
            get;
            private set;
        }
        private static string user_Name=null, pass=null;
        private static bool checkLogin;

        public static bool getuserdetails(string username,string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails",mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",username);
                cmd.Parameters.AddWithValue("@pass",password);
                mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    checkLogin = true;
                    while(dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_Name = dr["Username"].ToString();
                        pass = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false; 
                }

                mainclass.con.Close();
            }
            catch(Exception ex)
            {
                mainclass.con.Close();
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
            return checkLogin;
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn companyNameGV,
            DataGridViewColumn personNameGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV, string data = null)
        {

            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSupplierData", mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getSupplierDataLike", mainclass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                suppIDGV.DataPropertyName      = dt.Columns["ID"].ToString();
                companyNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personNameGV.DataPropertyName  = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName      = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName      = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName     = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName         = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName      = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }

            catch (Exception ex)
            {
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }


        private string[] productsData = new string[6];

        public string[] getProductListByBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        productsData[0] = dr[0].ToString();     //Product ID
                        productsData[1] = dr[1].ToString();     // Pr0duct name
                        productsData[2] = dr[2].ToString();     //barcode
                        productsData[3] = dr[3].ToString();     // Selling Price
                        productsData[4] = dr[4].ToString();     // Discount
                        productsData[5] = dr[5].ToString();     // FInal Selling Price
                   }
                }
                else
                {
                    Array.Clear(productsData, 0, productsData.Length);
                }
                mainclass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mainclass.con.Close();
            }

            return productsData;
        }

        public string[] getProductListByBarcode1(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode1", mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString();     //Product ID
                        productsData[1] = dr[1].ToString();     // Pr0duct name
                        productsData[2] = dr[2].ToString();     //barcodee
                    }
                }
                else
                {
                    Array.Clear(productsData, 0, productsData.Length);
                }
                mainclass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mainclass.con.Close();
            }

            return productsData;
        }

        public void showPurchaseInvoiceDeatils(Int64 proID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn mPIDGV, DataGridViewColumn pronameGV, DataGridViewColumn quantityGV, DataGridViewColumn priceGV, DataGridViewColumn pupGV)
        {

            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_getPurchaseInvoiceDeatils", mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", proID);
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                priceGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                gv.DataSource = dt;
            }catch(Exception)
            {
                mainclass.showMessage("Uanble to load show Data", "Error", "Error"); 
            }
        }

        public void showProductswrtCategory(int catID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn buyGV,
            DataGridViewColumn spGV, DataGridViewColumn discGV, DataGridViewColumn profitGV)
        {

            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_getProdutswrtCategory", mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                buyGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                discGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitGV.DataPropertyName = dt.Columns["Profit Margin"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                mainclass.showMessage("Uanble to load products Data", "Error", "Error");
            }
        }

        private object prodStock = 0;
        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                mainclass.con.Open();
                prodStock = cmd.ExecuteScalar();
                mainclass.con.Close();
            }
            catch(Exception)
            {

            }
            return prodStock;
        }

        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                prodStock = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

            }
            return prodStock;
        }

        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV,
           DataGridViewColumn proBarcodeGV, DataGridViewColumn expiryGV, DataGridViewColumn bpriceGV, DataGridViewColumn spriceGV, DataGridViewColumn totAmGV, DataGridViewColumn categoryGV, DataGridViewColumn availStockGV, DataGridViewColumn statusGV,string data = null)
        {
            try
            {
                SqlCommand cmd;
                DataTable dt = new DataTable();
                if (data == null)
                {
                    cmd = new SqlCommand("st_getAllStock", mainclass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                    adap.Fill(dt); // show in data grid view
                    statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                    totAmGV.DataPropertyName = dt.Columns["Total Amount"].ToString();

                }
                else
                {
                    cmd = new SqlCommand("st_getAllStockLike", mainclass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                    adap.Fill(dt); // show in data grid view
                }
                
                proBarcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                bpriceGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spriceGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                availStockGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                
                
                gv.DataSource = dt;
            }

            catch (Exception)
            {
                mainclass.showMessage("Unable to load Stock.", "Error", "Error");
            }
        }


        private bool checkPPExist;
        public bool checkProductPriceExist(Int64 proID)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_checkProductPriceExist", mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    checkPPExist = true;
                }
                else
                {
                    checkPPExist = false;
                }
                mainclass.con.Close();

            }
            catch(Exception)
            {
                mainclass.con.Close();
            }
            return checkPPExist;
        }
        
        public void showReport(ReportDocument rd,CrystalReportViewer crv,string proc,string param1,object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                rd.Load(Application.StartupPath+"\\Reports\\saleReceipt.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }catch(Exception)
            {
                mainclass.showMessage("Sorry,Need SAP Crystal Report to view sale receipt!", "Error", "Error");
            }
        }

        public void showDailySaleDetails(DateTime date,DataGridView gv, DataGridViewColumn salIDGV, DataGridViewColumn usernameGV, 
            DataGridViewColumn totalammGV, DataGridViewColumn totalDiscGV, DataGridViewColumn amountGivenGV,
            DataGridViewColumn amountReturnGV, DataGridViewColumn userIDGV)
        {

            try
            {
                SqlCommand cmd;
                
                cmd = new SqlCommand("st_getDailySales", mainclass.con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                salIDGV.DataPropertyName = dt.Columns["Sale ID"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                usernameGV.DataPropertyName = dt.Columns["User"].ToString();
                totalammGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                totalDiscGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                amountReturnGV.DataPropertyName = dt.Columns["Amount Return"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();

                gv.DataSource = dt;
            }

            catch (Exception ex)
            {
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void showSalesDatawrtSaleID(Int64 saleID,DataGridView gv, DataGridViewColumn salIDGV, DataGridViewColumn pronameGV, DataGridViewColumn barcodeGv, DataGridViewColumn quanitytGV, DataGridViewColumn ppdiscGv, 
            DataGridViewColumn pppriceGV, DataGridViewColumn amountgivenGV, DataGridViewColumn amountreturnGv, DataGridViewColumn totaldiscGv, DataGridViewColumn totalamountGv,
            DataGridViewColumn paymentGV, DataGridViewColumn dateGV, DataGridViewColumn userGV, DataGridViewColumn proIDGV, DataGridViewColumn propriceGV)
        {

            try
            {
                SqlCommand cmd;
                
                    cmd = new SqlCommand("st_getSaleReceiptWRTSaleID", mainclass.con);
                    cmd.Parameters.AddWithValue("@saleID", saleID);
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd); // get data from database
                DataTable dt = new DataTable();
                adap.Fill(dt); // show in data grid view
                pronameGV.DataPropertyName        = dt.Columns["Product Name"].ToString();
                salIDGV.DataPropertyName        = dt.Columns["Sale ID"].ToString();
                barcodeGv.DataPropertyName      = dt.Columns["Barcode"].ToString();
                quanitytGV.DataPropertyName     = dt.Columns["Quantity"].ToString();
                pppriceGV.DataPropertyName      = dt.Columns["Per Product Total"].ToString();
                amountgivenGV.DataPropertyName  = dt.Columns["Amount Given"].ToString();
                amountreturnGv.DataPropertyName = dt.Columns["Amount Return"].ToString();
                dateGV.DataPropertyName         = dt.Columns["Date"].ToString();
                proIDGV.DataPropertyName        = dt.Columns["Product ID"].ToString();
                userGV.DataPropertyName         = dt.Columns["User Name"].ToString();
                ppdiscGv.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                totaldiscGv.DataPropertyName = dt.Columns["Total Discount"].ToString();
                totalamountGv.DataPropertyName = dt.Columns["Total Amount"].ToString();
                paymentGV.DataPropertyName = dt.Columns["Pay Type"].ToString();
                propriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                gv.DataSource = dt;
            }

            catch (Exception ex)
            {
                mainclass.showMessage(ex.Message, "Error", "Error");
            }
        }
    }
}
