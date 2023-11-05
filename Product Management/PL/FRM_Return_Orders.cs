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
    public partial class FRM_Return_Orders : Form
    {
        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_Return_Orders()
        {
            InitializeComponent();

            dgvReturnInvoices.DataSource = purchases.GetAllReturnPurchases("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvReturnInvoices.DataSource = purchases.GetAllReturnPurchases(txtSearch.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvReturnInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            int orderId = Convert.ToInt32(this.dgvReturnInvoices.CurrentRow.Cells[0].Value);
            FRM_Return_Purchase_Details frm = new FRM_Return_Purchase_Details(orderId);
            frm.ShowDialog();
        }
    }
}
