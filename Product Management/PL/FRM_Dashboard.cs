using Product_Management.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management.PL
{
    public partial class FRM_Dashboard : Form
    {
        CLS_Dashboard dashboard = new CLS_Dashboard();

        public FRM_Dashboard()
        {
            InitializeComponent();

            dgvTopSale.DataSource = dashboard.GetTopSaleItems();
            dgvTopPurchaseItems.DataSource = dashboard.GetTopPurchaseItems();
        }
    }
}
