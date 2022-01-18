using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class productPricing : sample2
    {
        update up = new update();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        retrieval ret = new retrieval();
        public productPricing()
        {
            InitializeComponent();
            ret.getList("st_getCategoryList", categoryDD, "Category", "ID");
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                ret.showProductswrtCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()), DataGV, proIDGV, pronameGV, buyingPriceGV, finalpriceGV, discountGV, profitMarginGV);
            }
        }

        private void DataGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGV.Rows[e.RowIndex];
                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {
                    float buyingp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                    float profit = (Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100);
                    float ammToInc = profit * buyingp;
                    float disc;
                    
                    float finalSP = buyingp + ammToInc;
                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        disc = finalSP * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        disc = 0;
                    }
                    row.Cells["finalpriceGV"].Value = finalSP-disc;
                }
                else
                {
                    row.Cells["finalpriceGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                }

            }
        }

           

        public override void addbtn_Click_2(object sender, EventArgs e)
        {

        }

        public override void savebtn_Click_1(object sender, EventArgs e)
        {
            int check=0;
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in DataGV.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        check++;
                        float disc, pm, bp, sp;
                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        pm = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());

                        if (disc == 0 && pm == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalpriceGV"].Value.ToString());
                        }
                        up.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), bp, sp, disc, pm);   
                    }
                }
                if(check>0)
                {
                    mainclass.showMessage("Product Pricing Updated Successfully", "Success", "Success");
                    check = 0;
                }
                else
                {
                    mainclass.showMessage("Please select anything.", "Error", "Error");
                    check = 0;
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

        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void productPricing_Load(object sender, EventArgs e)
        {
            DataGV.AutoGenerateColumns = false;
            base.addbtn.Enabled = false;
            base.viewbtn.Enabled = false;
            base.editbtn.Enabled = false;
            base.dltbtn.Enabled = false;
            base.searchtxt.Enabled = false;
        }
        

        private void DataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (DataGV.CurrentCell.ColumnIndex == 4)
                {
                    DataGV.BeginEdit(true);
                }
            }
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //float finalSP, buyingp, profit, ammToInc, disc;
            //if (e.RowIndex != -1 && e.ColumnIndex != -1)
            //{
            //    DataGridViewRow row = DataGV.Rows[e.RowIndex];
            //    if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
            //    {
            //        buyingp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
            //        profit = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
            //        ammToInc = profit * buyingp;
            //        if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
            //        {
            //            disc = buyingp * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
            //        }
            //        else
            //        {
            //            disc = 0;
            //        }
            //        finalSP = buyingp + ammToInc - disc;
            //        row.Cells["finalpriceGV"].Value = finalSP;
            //    }
            //    else
            //    {
            //        row.Cells["finalpriceGV"].Value = null;
            //        row.Cells["discountGV"].Value = null;
            //        row.Cells["profitMarginGV"].Value = null;
            //    }

        }

        private void DataGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}


    
 
