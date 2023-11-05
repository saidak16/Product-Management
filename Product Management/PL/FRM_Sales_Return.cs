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
    public partial class FRM_Sales_Return : Form
    {
        CLS_ORDERS order = new CLS_ORDERS();

        public FRM_Sales_Return()
        {
            InitializeComponent();

            dgvReturnInvoices.DataSource = order.GetSaleReturn("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReturnInvoices.DataSource = order.GetSaleReturn(txtSearch.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvReturnInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            int orderId = Convert.ToInt32(this.dgvReturnInvoices.CurrentRow.Cells[2].Value);
            FRM_Order_Return_Items frm = new FRM_Order_Return_Items(orderId);
            frm.ShowDialog();
        }
    }
}
