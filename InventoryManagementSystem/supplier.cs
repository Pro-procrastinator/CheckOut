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
    public partial class supplier : sample2
    {
        retrieval ret = new retrieval();
        int edit = 0; // 0 is indication of save button and 1 is indication of update button
        int supplierID;
        short stat; // for status

        public supplier()
        {
            InitializeComponent();
        }

        public override void addbtn_Click_2(object sender, EventArgs e)
        {
            mainclass.enable_reset(leftpanel);
            edit = 0;
        }

        public override void savebtn_Click_1(object sender, EventArgs e)
        {
            if (suppliertxt.Text == "") { suppliererrorlbl.Visible = true; } else { suppliererrorlbl.Visible = false; }
            if (contactpersontxt.Text == "") { personerrorlbl.Visible = true; } else { personerrorlbl.Visible = false; }
            if (phone1txt.Text == "") { p1errorlbl.Visible = true; } else { p1errorlbl.Visible = false; }
            if (addresstxt.Text == "") { addresserrolbl.Visible = true; } else { addresserrolbl.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuserrorlbl.Visible = true; } else { statuserrorlbl.Visible = false; }

            if (suppliererrorlbl.Visible || personerrorlbl.Visible || p1errorlbl.Visible || ntnerrorlbl.Visible ||  statuserrorlbl.Visible)
            {
                mainclass.showMessage("Fields with the * are mendatory", "Error", "Error"); // error is the type of message
            }
            else
            {

                if (edit == 0) /// save
                {

                    insertion insert = new insertion();
                    if (statusDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }
                    if(p2.Text=="" && n.Text !="")
                    {
                        insert.insertSupplier(suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat,null,ntntxt.Text);
                    }
                    else if(p2.Text!="" && n.Text=="")
                    {
                        insert.insertSupplier(suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, null);
                    }
                    else if(p2.Text == "" && n.Text == "")
                    {
                        insert.insertSupplier(suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat, null, null);
                    }
                    else if(p2.Text!="" && n.Text!="")
                    {
                        insert.insertSupplier(suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, ntntxt.Text);
                    }

                    ret.showSuppliers(DataGV, supplierIDGV, CompanyGV, contactPersonGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                    mainclass.disable_reset(leftpanel);
                }
                else if (edit == 1) // update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    update up = new update();
                    if (dr == DialogResult.Yes)
                    {
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (p2.Text == "" && n.Text != "")
                        {
                            up.updateSupplier(supplierID, suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat, null, ntntxt.Text);
                        }
                        else if (p2.Text != "" && n.Text == "")
                        {
                            up.updateSupplier(supplierID, suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, null);
                        }
                        else if (p2.Text == "" && n.Text == "")
                        {
                            up.updateSupplier(supplierID, suppliertxt.Text, contactpersontxt.Text, phone1txt.Text, addresstxt.Text, stat, null, null);
                        }
                        else if (p2.Text != "" && n.Text != "")
                        {
                            up.updateSupplier(supplierID, suppliertxt.Text, contactpersontxt.Text,phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, ntntxt.Text);
                        }
                        
                        ret.showSuppliers(DataGV, supplierIDGV, CompanyGV, contactPersonGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                        mainclass.disable_reset(leftpanel);
                    }
                }

            }
        }

        public override void editbtn_Click_1(object sender, EventArgs e) 
        {
            edit = 1;
            mainclass.enable(leftpanel);
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
                    dlt.deleteUser(supplierID, "st_deleteSupplier", "@suppID");
                    ret.showSuppliers(DataGV, supplierIDGV, CompanyGV, contactPersonGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                }
            }
            
        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            ret.showSuppliers(DataGV, supplierIDGV, CompanyGV, contactPersonGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
                ret.showSuppliers(DataGV, supplierIDGV, CompanyGV, contactPersonGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV, searchtxt.Text);
            }
            else
            {
                ret.showSuppliers(DataGV, supplierIDGV, CompanyGV, contactPersonGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
            }
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            mainclass.disable(leftpanel);
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = DataGV.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["supplierIDGV"].Value.ToString());
                suppliertxt.Text = row.Cells["CompanyGV"].Value.ToString();
                contactpersontxt.Text = row.Cells["contactPersonGV"].Value.ToString();
                phone1txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2txt.Text = row.Cells["phone2GV"].Value.ToString();
                ntntxt.Text = row.Cells["ntnGV"].Value.ToString();
                addresstxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                mainclass.disable(leftpanel);
            }
        }
    }
}
