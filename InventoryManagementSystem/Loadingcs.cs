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
    public partial class Loadingcs : Form
    {
        public Loadingcs()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelFill.Width += 3;
            if (panelFill.Width >= 700)
            {
                timer1.Stop();
                MDI mdi = new MDI();
                mdi.Show();
                this.Hide();
            }
        }
    }
}
