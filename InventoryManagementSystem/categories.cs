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
    public partial class categories : sample2
    {
        retrieval ret = new retrieval();
        int edit = 0; // 0 is indication of save button and 1 is indication of update button
        int catID;
        short stat; // for status

        public categories()
        {
            InitializeComponent();
        }

        private void sample21_Load(object sender, EventArgs e)
        {
            mainclass.disable(leftpanel);
        }

        public override void addbtn_Click_2(object sender, EventArgs e)
        {
            mainclass.enable_reset(leftpanel);
            edit = 0;
        }

        public override void savebtn_Click_1(object sender, EventArgs e)
        {
            if (catnametxt.Text == "") { catnameerrorlbl.Visible = true; } else { catnameerrorlbl.Visible = false; }
            if (isactiveDD.SelectedIndex == -1) { isactiveerrorlbl.Visible = true; } else { isactiveerrorlbl.Visible = false; }


            if (catnameerrorlbl.Visible || isactiveerrorlbl.Visible)
            {
                mainclass.showMessage("Fields with the * are mendatory", "Error", "Error"); // error is the type of message
            }
            else
            {

                if (edit == 0) /// save
                {

                    insertion insert = new insertion();
                    if (isactiveDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (isactiveDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }

                    insert.insertCategory(catnametxt.Text, stat);
                    ret.showCategories(CatGridView, catIDGV, catnameGV, StatusGV);
                    mainclass.disable_reset(leftpanel);
                }
                else if (edit == 1) // update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    update up = new update();
                    if (dr == DialogResult.Yes)
                    {
                        if (isactiveDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (isactiveDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        up.updateCategory(catID, catnametxt.Text, stat);
                        ret.showCategories(CatGridView, catIDGV, catnameGV, StatusGV);
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
                    dlt.deleteUser(catID, "st_deleteCategory", "@id");
                    ret.showCategories(CatGridView, catIDGV, catnameGV, StatusGV);
                }
            }
        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            ret.showCategories(CatGridView, catIDGV, catnameGV, StatusGV);
        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
                ret.showCategories(CatGridView, catIDGV, catnameGV, StatusGV, searchtxt.Text);
            }
            else
            {
                ret.showCategories(CatGridView, catIDGV, catnameGV, StatusGV);
            }
        }

        private void CatGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = CatGridView.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catnametxt.Text = row.Cells["catnameGV"].Value.ToString();
                isactiveDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                mainclass.disable(leftpanel);
            }
        }
    }
}
