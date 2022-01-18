using System;
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
    public partial class purchaseInvoiceDetails : sample2
    {
        retrieval ret = new retrieval();
        public purchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            ret.getListwithTwoParam("st_getPurchaseInvoiceList", purchaseInvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
                 
        }
        public override void backbtn_Click(object sender, EventArgs e)
        {
            purchaseInvoice pi = new purchaseInvoice();
            mainclass.showWindow(pi, this, MDI.ActiveForm);
        }

        private void purchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            DataGV.AutoGenerateColumns = false;
            ret.getListwithTwoParam("st_getPurchaseInvoiceList", purchaseInvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);

        }
        delete dlt = new delete();
        private void purchaseInvoiceDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            float gt=0;
            if(purchaseInvoiceDD.SelectedIndex!=-1 && purchaseInvoiceDD.SelectedIndex!=0)
            {
                ret.showPurchaseInvoiceDeatils(Convert.ToInt64(purchaseInvoiceDD.SelectedValue.ToString()),DataGV, proIDGV,mPIDGV, pronameGV, quantityGV, totalamountGV, perUniPriceGV);
                foreach(DataGridViewRow row in DataGV.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalamountGV"].Value.ToString());
                }
                grosslbl.Text = gt.ToString();
                gt = 0;
            }
        }
        insertion i = new insertion();
        update up = new update();
        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int q;
            if (e.RowIndex != -1 && e.ColumnIndex!=-1)
            {
                if(e.ColumnIndex==6)
                {
                    DataGridViewRow row = DataGV.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete " + row.Cells["pronameGV"].Value.ToString() + " from purchase invoice?\n\t\t\tWARNING\nDELETE OF PRODUCT WILL EFFECT IN STCOK", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dr==DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItem(Convert.ToInt64(purchaseInvoiceDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), retrieval.USER_ID, DateTime.Today);

                            object ob = ret.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                if(q>= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()))
                                {
                                    q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                    if (q > 0)
                                    {
                                        up.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                    }
                                    else
                                    {
                                        up.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), 0);
                                    }
                                    float total = Convert.ToSingle(grosslbl.Text) - Convert.ToSingle(row.Cells["totalamountGV"].Value.ToString());
                                    grosslbl.Text = total.ToString();
                                    dlt.deleteUser(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFROMPI", "@mPID");
                                    DataGV.Rows.Remove(row);
                                }
                                else
                                {
                                    mainclass.showMessage("You can't delete it because you already sales some products.","Error","Error");
                                }
                            }
                            sc.Complete();
                        } 
                    }
                }
            }
        }
    }
}
