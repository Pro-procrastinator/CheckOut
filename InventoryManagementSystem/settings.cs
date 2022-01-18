using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class settings : sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(securitycheck.Checked)
            {
                if (servertxt.Text != "" && databasetxt.Text != "")
                {
                    // connection string for cinnectivity
                    s = "Data Source=" + servertxt.Text + "; Initial Catalog=" + databasetxt.Text + ";Intergerated Security=true;MultipleActiveResultSets=True";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings saved successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dr==DialogResult.OK)
                    {
                    login log = new login();
                    mainclass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide complete data to continue");
                }
            }
            else
            {
                if (servertxt.Text != "" && databasetxt.Text != "" && passwordtxt.Text!="" && usertext.Text!="")
                {
                    
                    s = "Data Source=" + servertxt.Text + "; Initial Catalog=" + databasetxt.Text + ";User ID="+usertext.Text +";Password="+passwordtxt.Text+ ";MultipleActiveResultSets=True";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings saved successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        mainclass.showWindow(log, this, MDI.ActiveForm);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please provide complete data to continue");
                }
                
            }
            
        }

        private void securitycheck_CheckedChanged(object sender, EventArgs e)
        {
            if(securitycheck.Checked)
            {
                usertext.Enabled = false;
                passwordtxt.Enabled = false;
                usertext.Text = "";
                passwordtxt.Text = "";
            }
            else
            {
                usertext.Enabled = true;
                passwordtxt.Enabled = true;
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }
    }
}
