using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class sales : sample2
    {
        retrieval ret = new retrieval();
        public sales()
        {
            InitializeComponent();
        }

        public override void addbtn_Click_2(object sender, EventArgs e)
        {

        }

        public override void savebtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void editbtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void dltbtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            viewSalesInvoices view = new viewSalesInvoices();
            mainclass.showWindow(view, this, MDI.ActiveForm);
        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {

        }
        float gross=0;
        private string[] product = new string[6];
       

        bool proCheck;
        private void barcodetxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodetxt.Text != "" && mainclass.rg.Match(barcodetxt.Text).Success )
            {
                grosstxt.Text = "";
                amountgiventxt.Text = "";
                totaldiscounttxt.Text = "";
                changetogivetxt.Text = "";
                int quanCount = 0, stockQuan = 0 ,nCOunt = 0;
                product = ret.getProductListByBarcode(barcodetxt.Text);
                if(product[0]!= null && product[1] != null && product[2] != null  && product[3] != null && product[5] != null || product[4] != null)
                {
                    foreach (DataGridViewRow row in DataGV.Rows)
                    {
                        if (product[0] == row.Cells["proIDGV"].Value.ToString())
                        {
                            quanCount = quanCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());

                        }
                    }
                    stockQuan = Convert.ToInt32(ret.getProductQuantity(Convert.ToInt64(product[0])));
                    nCOunt = stockQuan - quanCount; // set the stock quantity in stock window
                    // Checking Quantity
                    if (nCOunt <= 0)
                    {
                        mainclass.showMessage("Out of Stock..", "Error", "Error");
                        barcodetxt.Text = "";
                        barcodetxt.Focus();
                    }
                    else
                    {
                        if (DataGV.Rows.Count == 0)
                        {
                            DataGV.Rows.Add(Convert.ToInt32(product[0]), product[1], 1, Convert.ToSingle(product[3]), Math.Round(Convert.ToSingle(product[4]),2), Convert.ToSingle(product[3]));
                        }
                        else
                        {
                            foreach (DataGridViewRow row in DataGV.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == product[0])
                                {
                                    proCheck = true;
                                    break;
                                }
                                else
                                {
                                    proCheck = false;
                                }
                            }
                            if (proCheck == true)
                            {
                                float disc = Convert.ToSingle(product[4]);
                                foreach (DataGridViewRow row in DataGV.Rows)
                                {
                                    if (row.Cells["proIDGV"].Value.ToString() == product[0])
                                    {
                                        row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                        if (row.Cells["discountGV"].Value.ToString() != null)
                                        {
                                            disc += Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                                            row.Cells["discountGV"].Value = disc;
                                        }
                                        float total = Convert.ToSingle(row.Cells["perUniPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) - Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                                        row.Cells["totalamountGV"].Value = total;
                                    }

                                }
                            }
                            else
                            {
                                DataGV.Rows.Add(Convert.ToInt32(product[0]), product[1], 1, Convert.ToSingle(product[3]), product[4], Convert.ToSingle(product[5]));
                            }
                        }
                        foreach (DataGridViewRow item in DataGV.Rows)
                        {
                            gross += Convert.ToSingle(item.Cells["totalamountGV"].Value.ToString());
                        }
                        grosslbl.Text = Math.Round(gross, 0).ToString();
                        gross = 0;
                        barcodetxt.Text = "";
                        barcodetxt.Focus();
                    }

                }
                else
                {
                    mainclass.showMessage("Please enter correct barcode.", "Error", "Error");
                    barcodetxt.Text = "";
                    barcodetxt.Focus();
                }
            }
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            float grandTotal, total, disc=0;
            if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                if(e.ColumnIndex==6)
                {
                    grosstxt.Text = "";
                    amountgiventxt.Text = "";
                    totaldiscounttxt.Text = "";
                    changetogivetxt.Text="";
                    DataGridViewRow row = DataGV.Rows[e.RowIndex];
                    int quantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    if(quantity==1)
                    {
                        grandTotal = Convert.ToSingle(grosslbl.Text);
                        grandTotal = grandTotal - Convert.ToSingle(row.Cells["totalamountGV"].Value.ToString());
                        grosslbl.Text = grandTotal.ToString();
                        DataGV.Rows.Remove(row);
                    }
                    else if(quantity>1)
                    {
                        quantity--;
                        row.Cells["quantityGV"].Value = quantity;
                        if(Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) != 0)
                        {
                            disc = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) - Convert.ToSingle(product[4]);
                        }else
                        {
                            disc = 0;
                        }
                        
                        row.Cells["discountGV"].Value = disc;
                        total =( Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perUniPriceGV"].Value.ToString()))-disc;
                        row.Cells["totalamountGV"].Value = total;
                        foreach (DataGridViewRow item in DataGV.Rows)
                        {
                            gross += Convert.ToSingle(item.Cells["totalamountGV"].Value.ToString());
                        }
                        grosslbl.Text = gross.ToString();
                        gross = 0;
                    }
                }
            }
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            float disc = 0, grosst=0;
            if(DataGV.Rows.Count>0)
            {
                foreach(DataGridViewRow row in DataGV.Rows)
                {
                    disc += Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                    grosst += Convert.ToSingle(row.Cells["totalamountGV"].Value.ToString());
                    grosstxt.Text = Math.Round(grosst, 0).ToString();
                    totaldiscounttxt.Text = Math.Round(disc ,0).ToString();
                }
            }
        }

        private void amountgiventxt_TextChanged(object sender, EventArgs e)
        {
            if(amountgiventxt.Text != "")
                {
                if(!mainclass.rg.Match(amountgiventxt.Text).Success)
                {
                    amountgiventxt.Text = "";
                    amountgiventxt.Focus();
                }
                else
                {

                }
            }
            else
            {
                changetogivetxt.Text = "";
            }
        }

        private void amountgiventxt_Validating(object sender, CancelEventArgs e)
        {
            if(amountgiventxt.Text!="" && grosstxt.Text!="")
            {
                if (Convert.ToSingle(grosstxt.Text) <= Convert.ToSingle(amountgiventxt.Text))
                {
                    float amountGiven = Convert.ToSingle(amountgiventxt.Text);
                    float returnAmount = amountGiven - Convert.ToSingle(grosstxt.Text);
                    changetogivetxt.Text = Math.Round(returnAmount,0).ToString();
                }
                else
                {
                    amountgiventxt.Text = "";
                    changetogivetxt.Text = "";
                    amountgiventxt.Focus();
                }
            }
            
        }
        insertion i = new insertion();
        private void paybtn_Click(object sender, EventArgs e)
        {
            if (amountgiventxt.Text != "" && totaldiscounttxt.Text != "" && grosstxt.Text != "" && paymentDD.SelectedIndex!=-1 && changetogivetxt.Text!="")
            {
                DialogResult dr = MessageBox.Show("\n\tTotal Amount: "+ grosstxt.Text+"\n\tTotal Discount: "+totaldiscounttxt.Text+"\n\tAmount Given: "+amountgiventxt.Text+"\n\tAmount Return: "+changetogivetxt.Text+ "\n\nAre you sure to submit current sale?\n", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(DataGV, "proIDGV", "quantityGV", retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grosstxt.Text), Convert.ToSingle(totaldiscounttxt.Text),
                        Convert.ToSingle(amountgiventxt.Text), Convert.ToSingle(changetogivetxt.Text),paymentDD.SelectedItem.ToString());
                    mainclass.enable_reset(groupPay);
                    barcodetxt.Text = "";
                    DataGV.Rows.Clear();
                    grosslbl.Text = "0.00";
                    salesReport sr = new salesReport();
                    sr.Show();
                }

            }
        }

        private void sales_Load(object sender, EventArgs e)
        {
            base.addbtn.Enabled = false;
            base.editbtn.Enabled = false;
            base.dltbtn.Enabled = false;
            base.searchtxt.Enabled = false;
            base.groupBox2.Enabled = false;
        }

        private void barcodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void grosstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void totaldiscounttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
