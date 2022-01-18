using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Users : sample2
    {
        retrieval ret = new retrieval();
        int edit = 0; // 0 is indication of save button and 1 is indication of update button
        int userID;
        short stat; // for status

        public Users()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            mainclass.disable(leftpanel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            if (nametxt.Text == "") { nameerrorlbl.Visible = true; } else { nameerrorlbl.Visible = false; }
            if (usernametxt.Text == "") { usernameerrorlbl.Visible = true; } else { usernameerrorlbl.Visible = false; }
            if (passtxt.Text == "") { passworderrorlbl.Visible = true; } else { passworderrorlbl.Visible = false; }
            if (phonetxt.Text == "") { phoneerrorlbl.Visible = true; } else { phoneerrorlbl.Visible = false; }
            if (emailtxt.Text == "") { emailerrorlbl.Visible = true; } else { emailerrorlbl.Visible = false; }
            if (statuscombo.SelectedIndex == -1) { statuserrorlbl.Visible = true; } else { statuserrorlbl.Visible = false; }

            if (nameerrorlbl.Visible || usernameerrorlbl.Visible || passworderrorlbl.Visible || phoneerrorlbl.Visible || emailerrorlbl.Visible || statuserrorlbl.Visible)
            {
                mainclass.showMessage("Fields with the * are mendatory", "Error", "Error"); // error is the type of message
            }
            else
            {

                if (edit == 0) /// save
                {

                    insertion insert = new insertion();
                    if (statuscombo.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (statuscombo.SelectedIndex == 1)
                    {
                        stat = 0;
                    }

                    insert.insertUsers(nametxt.Text, usernametxt.Text, passtxt.Text, phonetxt.Text, emailtxt.Text, stat);
                    ret.showUsers(UsersDataGV, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
                    mainclass.disable_reset(leftpanel);
                }
                else if (edit == 1) // update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    update up = new update();
                    if (dr == DialogResult.Yes)
                    {
                        if (statuscombo.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statuscombo.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        up.UpdatetUsers(userID, nametxt.Text, usernametxt.Text, passtxt.Text, phonetxt.Text, emailtxt.Text, stat);
                        ret.showUsers(UsersDataGV, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
                        mainclass.disable_reset(leftpanel);
                    }
                }

            }
        }

        public override void dltbtn_Click_1(object sender, EventArgs e)
        {
            if(edit == 1) // when click into grid view
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                update up = new update();
                if (dr == DialogResult.Yes)
                {
                    delete dlt = new delete();
                    dlt.deleteUser(userID, "st_deleteUsers", "@id");
                    ret.showUsers(UsersDataGV, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV); 
                }
            }

        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {
            if(searchtxt.Text != "")
            {
                ret.showUsers(UsersDataGV, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV,searchtxt.Text);
            }
            else
            {
                ret.showUsers(UsersDataGV, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
            }
        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            ret.showUsers(UsersDataGV, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsersDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void UsersDataGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = UsersDataGV.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nametxt.Text = row.Cells["NameGV"].Value.ToString();
                passtxt.Text = row.Cells["passwordGV"].Value.ToString();
                usernametxt.Text = row.Cells["UsernameGV"].Value.ToString();
                phonetxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailtxt.Text = row.Cells["EmailGV"].Value.ToString();
                statuscombo.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                mainclass.disable(leftpanel);
            }
        }
    }

}

