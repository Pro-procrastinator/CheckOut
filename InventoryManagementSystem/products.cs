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
    public partial class products : sample2
    {
        retrieval ret = new retrieval();
        int edit = 0; // 0 is indication of save button and 1 is indication of update button
        Int64 productID;
        public products()
        {
            InitializeComponent();
        }
        public override void addbtn_Click_2(object sender, EventArgs e)
        {
            mainclass.enable_reset(leftpanel);
            edit = 0;
           
        }

        public override void editbtn_Click_1(object sender, EventArgs e)
        {
            edit = 1;
            mainclass.enable(leftpanel);
        }

        public override void savebtn_Click_1(object sender, EventArgs e)
        {
            if (productnametxt.Text == "") { prodnameerrorlbl.Visible = true; } else { prodnameerrorlbl.Visible = false; }
            if (barcodetxt.Text == "") { barcodeerrorlbl.Visible = true; } else { barcodeerrorlbl.Visible = false; }
            if (expirypicker.Value < DateTime.Now ) { expiryerrorlbl.Visible = true; expiryerrorlbl.Text = "Invalid Date."; } else { expiryerrorlbl.Visible = false; }
            if (expirypicker.Value.Date == DateTime.Now.Date) { expiryerrorlbl.Visible = false; }
            if (categoryDD.SelectedIndex==-1 || categoryDD.SelectedIndex == 0) { categoryerrorlbl.Visible = true; } else { categoryerrorlbl.Visible = false; }

            if (prodnameerrorlbl.Visible || barcodeerrorlbl.Visible || expiryerrorlbl.Visible ||  categoryerrorlbl.Visible )
            {
                mainclass.showMessage("Fields with the * are mendatory", "Error", "Error"); // error is the type of message
            }
            else
            {

                if (edit == 0) /// save
                {

                    insertion insert = new insertion();
                    if(expirypicker.Value.Date == DateTime.Now.Date)
                    {
                        insert.insertProduct(productnametxt.Text, barcodetxt.Text, Convert.ToInt32(categoryDD.SelectedValue));                    }
                    else
                    {
                        insert.insertProduct(productnametxt.Text, barcodetxt.Text,Convert.ToInt32(categoryDD.SelectedValue), expirypicker.Value);
                      
                    }
                    
                    ret.showProduct(productDataGV, proIDGV, pronameGV, expiryGV, catIDGV, CategoryGV,barcodeGV);
                    mainclass.disable_reset(leftpanel);
                }
                else if (edit == 1) // update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    update up = new update();
                    if (dr == DialogResult.Yes)
                    {
                        if(expirypicker.Value.Date==DateTime.Now.Date)
                        {
                            up.updateProduct(productID, productnametxt.Text, barcodetxt.Text, Convert.ToInt32(categoryDD.SelectedValue));
                        }
                        else
                        {
                            up.updateProduct(productID, productnametxt.Text, barcodetxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expirypicker.Value);
                        }
                          
                        ret.showProduct(productDataGV, proIDGV, pronameGV, expiryGV, catIDGV, CategoryGV,  barcodeGV);
                        mainclass.disable_reset(leftpanel);
                    }
                }

            }
        }

        public override void dltbtn_Click_1(object sender, EventArgs e)
        {
            if (edit == 1) // when click into grid view
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                update up = new update();
                if (dr == DialogResult.Yes)
                {
                    delete dlt = new delete();
                    dlt.deleteUser(productID, "st_deleteProduct", "@id");
                    ret.showProduct(productDataGV, proIDGV, pronameGV, expiryGV, catIDGV, CategoryGV,  barcodeGV);
                    mainclass.disable_reset(leftpanel);
                }
            }

        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {
            
            if (searchtxt.Text != "")
            {
                ret.showProduct(productDataGV, proIDGV, pronameGV, expiryGV, catIDGV, CategoryGV, barcodeGV, searchtxt.Text);
            }
            else
            {
                 ret.showProduct(productDataGV, proIDGV, pronameGV, expiryGV, catIDGV, CategoryGV, barcodeGV);
            }
        
        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            ret.showProduct(productDataGV, proIDGV, pronameGV, expiryGV, catIDGV, CategoryGV, barcodeGV);
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void products_Load(object sender, EventArgs e)
        {
            mainclass.disable_reset(leftpanel);
            ret.getList("st_getCategoryList", categoryDD, "Category", "ID");
        }

        private void productDataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                DataGridViewRow row = productDataGV.Rows[e.RowIndex];
                productID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                productnametxt.Text = row.Cells["pronameGV"].Value.ToString();
                barcodetxt.Text = row.Cells["barcodeGV"].Value.ToString();
                if(row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    expirypicker.Value = DateTime.Now;
                }
                else
                {
                    expirypicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }
                
                categoryDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                mainclass.disable(leftpanel);
            }
        }
    }
}

