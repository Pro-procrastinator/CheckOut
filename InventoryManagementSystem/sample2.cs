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
    public partial class sample2 : sample
    {
        public sample2()
        {
            InitializeComponent();
        }

        public virtual void backbtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            mainclass.showWindow(hs, this, MDI.ActiveForm);
        }




        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        

        public void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        public virtual void addbtn_Click_2(object sender, EventArgs e)
        {

        }

        public virtual void savebtn_Click_1(object sender, EventArgs e)
        {

        }

        public virtual void editbtn_Click_1(object sender, EventArgs e)
        {

        }

        public virtual void dltbtn_Click_1(object sender, EventArgs e)
        {

        }

        public virtual void viewbtn_Click_1(object sender, EventArgs e)
        {

        }

        public virtual void searchtxt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
