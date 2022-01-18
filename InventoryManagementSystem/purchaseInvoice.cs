using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class purchaseInvoice : sample2
    {
        float grossTotal; 
        retrieval ret = new retrieval();
        public purchaseInvoice()
        {
            InitializeComponent();
        }

        private void purchaseInvoice_Load(object sender, EventArgs e)
        {
             mainclass.disable_reset(leftpanel);
            ret.getList("st_getSupplierList", selectsupplierDD, "Company", "ID");
          
            base.editbtn.Enabled = false;
            base.dltbtn.Enabled = false;
            base.searchtxt.Enabled = false;
            base.groupBox2.Enabled = false;
        }

     
        public override void addbtn_Click_2(object sender, EventArgs e)
        {
            mainclass.enable_reset(leftpanel);
        }

        int co;
        update up = new update();
        public override void savebtn_Click_1(object sender, EventArgs e)
        {
            Int64 purID;
            if (DataGV.Rows.Count>0)
            {
                insertion i = new insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purID = i.insertPurchaseInvoice(DateTime.Today.ToString(), retrieval.USER_ID, Convert.ToInt32(selectsupplierDD.SelectedValue));
                    foreach (DataGridViewRow row in DataGV.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purID, Convert.ToInt64(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalamountGV"].Value.ToString()));
                        if(ret.checkProductPriceExist(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                        {
                            up.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perUniPriceGV"].Value.ToString()));
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perUniPriceGV"].Value.ToString()));
                        }
                        
                        int q;
                        object ob = ret.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        
                        if(ob!=null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()); // when updating its just increase in quantity if you buy already purchased item
                            up.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertSock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }
                    }
                    if (co > 0)
                    {
                        mainclass.showMessage("Purcshase Invoice created successfully.", "Success", "Success");
                    }
                    else
                    {
                        mainclass.showMessage("Unable to create Purchase Invoice.", "Error", "Error");
                    }
                    mainclass.enable_reset(leftpanel);
                    sc.Complete();
                }
                   
            }
        }

        public override void editbtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void dltbtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            purchaseInvoiceDetails pid = new purchaseInvoiceDetails();
            mainclass.showWindow(pid, this, MDI.ActiveForm);
        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private Int64 proID;
        private string[] product = new string[3];
       
        private void barcodetxt_Validated(object sender, EventArgs e)
        {
            if (barcodetxt.Text != "")
            {
                product = ret.getProductListByBarcode1(barcodetxt.Text);
                if(product[0]!=null && product[1]!=null && product[2]!=null)
                {
                    proID = Convert.ToInt32(product[0]);
                    producttxt.Text = product[1];
                    producttxt.Enabled = false;
                    string barco = product[2];
                    if (barco != null)
                    {
                        pricetxt.Focus();
                    }
                }
                else
                {
                    mainclass.showMessage("Please enter correct barcode.", "Error", "Error");
                    barcodetxt.Text = "";
                    barcodetxt.Focus();
                }
               
            }
            else
            {
                proID = 0;
                producttxt.Text = "";
                pricetxt.Text = "";
                Array.Clear(product, 0, product.Length);
            }
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            if(selectsupplierDD.SelectedIndex==-1) { selectsuppliererrorlbl.Visible = true; } else { selectsuppliererrorlbl.Visible = false; }
            if (quantitytxt.Text=="") { quantitylbl.Visible = true; } else { quantitylbl.Visible = false; }
            if (pricetxt.Text == "") { priceerrorlbl.Visible = true; } else { priceerrorlbl.Visible = false; }
            if (barcodetxt.Text == "") { barcodeerrorlbl.Visible = true; } else { barcodeerrorlbl.Visible = false; }
            if(selectsuppliererrorlbl.Visible || quantitylbl.Visible || priceerrorlbl.Visible || barcodeerrorlbl.Visible)
            {
                mainclass.showMessage("Fields with * are mendatory.", "Error", "Error");
            }
            else
            {
                DataGV.Rows.Add(proID, producttxt.Text, quantitytxt.Text, pricetxt.Text, amountlbl.Text);
                grossTotal += Convert.ToSingle(amountlbl.Text);
                grosslbl.Text = grossTotal.ToString();
                proID = 0;
                producttxt.Text = "";
                pricetxt.Text = "";
                barcodetxt.Text = "";
                amountlbl.Text = "0.00";
                quantitytxt.Text = "";
                Array.Clear(product, 0, product.Length);
            }
            barcodetxt.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$"); 
        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if(quantitytxt.Text!="" )
            {
                if(rg.Match(quantitytxt.Text).Success)
                {
                    float quan, price, total;
                    quan = Convert.ToSingle(quantitytxt.Text);
                    price = Convert.ToSingle(pricetxt.Text);
                    total = price * quan;
                    amountlbl.Text = total.ToString("##########.##");
                }
                else
                {
                    quantitytxt.SelectAll();
                }
            }
            else
            {
                amountlbl.Text = "0.00";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e) // e specify current position
        {
            if(e.RowIndex != -1 && e.ColumnIndex !=-1)
            {
                if(e.ColumnIndex==5)
                {
                    DataGridViewRow row = DataGV.Rows[e.RowIndex];
                    grossTotal -= Convert.ToSingle(row.Cells["totalamountGV"].Value.ToString());
                    grosslbl.Text = grossTotal.ToString();
                    DataGV.Rows.Remove(row);
                }
            }
        }
        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            if(pricetxt.Text!="")
            {
                if(!rg.Match(pricetxt.Text).Success)
                {
                    pricetxt.Text = "";
                    pricetxt.Focus();
                }
            }
        }
    }
}
