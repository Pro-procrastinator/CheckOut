using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace InventoryManagementSystem
{
    public partial class salesReport : Form
    {
        public salesReport()
        {
            InitializeComponent();
        }
        ReportDocument rd = new ReportDocument();
        retrieval ret = new retrieval();
        private void salesReport_Load(object sender, EventArgs e)
        {
            if(viewSalesInvoices.saleID == 0)
            {
                
                ret.showReport(rd, crystalReportViewer2, "st_getSaleReceipt", "@userID", retrieval.USER_ID);
            }
            else
            {
                ret.showReport(rd, crystalReportViewer2, "st_getSaleReceiptWRTSaleID", "@saleID", viewSalesInvoices.saleID);
            }
            
        }

        private void salesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(rd!=null)
            {
                rd.Close();
            }
        }
    }
}
