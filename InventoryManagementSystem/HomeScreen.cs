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
    public partial class HomeScreen : sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            mainclass.showWindow(user, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            categories cat = new categories();
            mainclass.showWindow(cat, this, MDI.ActiveForm);
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            products prod = new products();
            mainclass.showWindow(prod, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = true;
            usernamelbl.Text = retrieval.EMP_NAME;
        }

        private void Suppbtn_Click(object sender, EventArgs e)
        {
            supplier sp = new supplier();
            mainclass.showWindow(sp, this, MDI.ActiveForm);
        }

        private void purchaseInvoice_Click(object sender, EventArgs e)
        {
            purchaseInvoice pi = new purchaseInvoice();
            mainclass.showWindow(pi, this, MDI.ActiveForm);
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            stock stk = new stock();
            mainclass.showWindow(stk, this, MDI.ActiveForm);
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            sales sale = new sales();
            mainclass.showWindow(sale, this, MDI.ActiveForm);
        }

        private void productpricingbtn_Click(object sender, EventArgs e)
        {
            productPricing pp = new productPricing();
            mainclass.showWindow(pp, this, MDI.ActiveForm);
        }

        private void saleReturnbtn_Click(object sender, EventArgs e)
        {
            saleReturn sr = new saleReturn();
            mainclass.showWindow(sr, this, MDI.ActiveForm);
        }
    }
}
