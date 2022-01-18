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
    public partial class login : sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "") { usernamerrorlbl.Visible = true; } else { usernamerrorlbl.Visible = false; }
            if (passtxt.Text == "") { passerrorlbl.Visible = true; } else { passerrorlbl.Visible = false; }

            if (usernamerrorlbl.Visible || passerrorlbl.Visible)
            {
                mainclass.showMessage("Fields with the * are mendatory", "Error", "Error");
            }
            else
            {
                if (retrieval.getuserdetails(usernametxt.Text, passtxt.Text))
                {
                    HomeScreen hs = new HomeScreen();
                    mainclass.showWindow(hs, this, MDI.ActiveForm);
                }
                else
                {
                    mainclass.showMessage("Invalid Username or Password.", "Error", "Error");
                    passtxt.Text = "";
                    passtxt.Focus();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (usernametxt.Text == "") { usernamerrorlbl.Visible = true; } else { usernamerrorlbl.Visible = false; }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (passtxt.Text == "") { passerrorlbl.Visible = true; } else { passerrorlbl.Visible = false; }
        }

        private void login_Load(object sender, EventArgs e)
        {
           
            usernamelbl.Text = "";
            
        }
    }
}
