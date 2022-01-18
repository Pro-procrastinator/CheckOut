using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class saleReturn : sample2
    {
        public saleReturn()
        {
            InitializeComponent();
        }
        retrieval ret = new retrieval();
        private void loadbtn_Click(object sender, EventArgs e)
        {
            if(saletxt.Text!="")
            {
                if(mainclass.rg.Match(saletxt.Text).Success)
                {
                   DataGV.AutoGenerateColumns = false;
                    ret.showSalesDatawrtSaleID(Convert.ToInt64(saletxt.Text),DataGV,saleIDGV,productnameGV,barcodeGV,quantityGV,perproddiscountGV,
                        perprodpriceGV,amountgivenGV,amountreturnGV,totaldiscountGV,totalpriceGV,paymentGV,dateGV,usernameGV,proIDGV,ProducttotalGV);
                    if(DataGV.Rows.Count>0)
                    {
                        foreach (DataGridViewRow row in DataGV.Rows)
                        {
                            row.Cells["ProducttotalGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["ProducttotalGV"].Value));
                            row.Cells["perproddiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perproddiscountGV"].Value));
                            row.Cells["perprodpriceGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perprodpriceGV"].Value));
                        }
                        saletxt.Text = "";
                        float disc = 0;
                        foreach (DataGridViewRow row in DataGV.Rows)
                        {
                            disc += Convert.ToSingle(Convert.ToSingle(row.Cells["perproddiscountGV"].Value));
                        }
                        usernametxt.Text = DataGV.Rows[0].Cells["usernameGV"].Value.ToString();
                        paymenttxt.Text = DataGV.Rows[0].Cells["paymentGV"].Value.ToString();
                        datetime.Value = Convert.ToDateTime(DataGV.Rows[0].Cells["dateGV"].Value);
                        refundtxt.Text = DataGV.Rows[0].Cells["totalpriceGV"].Value.ToString();
                        barcodetxt.Text = Math.Ceiling(Convert.ToSingle(DataGV.Rows[0].Cells["totaldiscountGV"].Value)).ToString();
                        disc = 0;
                    }
                    else
                    {
                        mainclass.showMessage("Sale ID not available.", "Error", "Error");
                        saletxt.Text = "";
                        saletxt.Focus();
                    }
                    
                }
                else
                {
                    saletxt.Text = "";
                    saletxt.Focus();
                    datetime.Value = DateTime.Now;
                    usernametxt.Text = "";
                    paymenttxt.Text = "";
                    refundtxt.Text = "";
                    barcodetxt.Text = "";
                }
            }
            else
            {
                datetime.Value = DateTime.Now;
                usernametxt.Text = "";
                paymenttxt.Text = "";
                refundtxt.Text = "";
                barcodetxt.Text = ""; 
            }
           
        }
        

        private void barcodetxt_Validating(object sender, CancelEventArgs e)
        {
       
        }

        private void saleReturn_Load(object sender, EventArgs e)
        {
            base.addbtn.Enabled = false;
            base.editbtn.Enabled = false;
            base.dltbtn.Enabled = false;
            base.searchtxt.Enabled = false;
            base.groupBox2.Enabled = false;
            base.savebtn.Enabled = false;
            base.viewbtn.Enabled = false;
            saletxt.Focus();
        }
    }
}
