using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventoryManagementSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(@path + "\\connect"))
            {
                login log = new login();
                mainclass.showWindow(log,this);
            }
            else
            { 
                settings set = new settings();
                set.MdiParent = MDI.ActiveForm;
                set.WindowState = FormWindowState.Maximized;
                set.Show();
                var myFile = File.Create(@path + "\\connect");
                myFile.Close();
            }
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            mainclass.showWindow(set, this);
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logoutToolStripMenuItem.Enabled = false;
            login set = new login();
            set.usernamelbl.Text = "";
            mainclass.showWindow(set, this);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
