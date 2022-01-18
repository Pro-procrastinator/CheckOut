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
    public partial class stock : sample2
    {
        public stock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {
            base.addbtn.Enabled = false;
            base.editbtn.Enabled = false;
            base.savebtn.Enabled = false;
            base.dltbtn.Enabled = false;
            DataGV.AutoGenerateColumns = false;

        }

        retrieval ret = new retrieval();
        public override void addbtn_Click_2(object sender, EventArgs e)
        {

        }

        public override void savebtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void editbtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void dltbtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void viewbtn_Click_1(object sender, EventArgs e)
        {
            ret.showStockDetails(DataGV, proIDGV, pronameGV, barcodeGV, expiryGV, buyingpriceGV,sellingpriceGV, totalamGV, categoryGV, quantityGV, StatusGV);
        }

        public override void searchtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
                ret.showStockDetails(DataGV, proIDGV, pronameGV, barcodeGV, expiryGV, buyingpriceGV, sellingpriceGV, totalamGV, categoryGV, quantityGV, StatusGV,searchtxt.Text);
            }
            else
            {
                ret.showStockDetails(DataGV, proIDGV, pronameGV, barcodeGV, expiryGV, buyingpriceGV, sellingpriceGV, totalamGV, categoryGV, quantityGV, StatusGV);
            }
        }

    }
}
