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
    public partial class viewSalesInvoices : sample
    {
        public viewSalesInvoices()
        {
            InitializeComponent();
        }
        retrieval ret = new retrieval();

        private void loadbtn_Click(object sender, EventArgs e)
        {
            ret.showDailySaleDetails(dateTimePicker1.Value, DataGV, saleIDGV, userGV, totalamountGV, totalDiscountGV, amountgivenGV, amountreturnGV,userIDGV);
            foreach (DataGridViewRow row in DataGV.Rows)
            {
                row.Cells["totalamountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalamountGV"].Value));
                row.Cells["totalDiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalDiscountGV"].Value));
                row.Cells["amountgivenGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountgivenGV"].Value));
                row.Cells["amountreturnGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountreturnGV"].Value));
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            sales s = new sales();
            mainclass.showWindow(s, this, MDI.ActiveForm);
        }

        public static int saleID;
        private void DataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                DataGridViewRow row = DataGV.Rows[e.RowIndex];
                saleID = Convert.ToInt32(row.Cells["saleIDGV"].Value.ToString());
                salesReport sr = new salesReport();
                sr.Show();
            }
        }
    }
}
