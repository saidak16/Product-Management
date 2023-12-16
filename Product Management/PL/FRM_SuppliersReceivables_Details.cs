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
    public partial class FRM_SuppliersReceivables_Details : Form
    {
        CLS_Suppliers suppliers = new CLS_Suppliers();
        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_SuppliersReceivables_Details(int SupplierId)
        {
            InitializeComponent();

            dgvSuppliersReceivablesDetails.DataSource = suppliers.GetSuppliersReceivablesById(SupplierId);
            this.dgvSuppliersReceivablesDetails.Columns[6].DefaultCellStyle.ForeColor = Color.Black;
            this.dgvSuppliersReceivablesDetails.Columns[6].DefaultCellStyle.BackColor = Color.Gray;
            this.dgvSuppliersReceivablesDetails.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            var myBoldFont = new Font("Tahoma", 9.75F, FontStyle.Bold);
            this.dgvSuppliersReceivablesDetails.Columns[6].DefaultCellStyle.Font = myBoldFont;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_SuppliersReceivables_Details_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_SuppliersReceivables_Details_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnSupplierReceivables_Click(sender, e);
            }
            
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void btnSupplierReceivables_Click(object sender, EventArgs e)
        {
            FRM_Update_SupplierReceivables frm = new FRM_Update_SupplierReceivables();

            DataTable dt = purchases.GetPurchaseOrderById(Convert.ToInt32(this.dgvSuppliersReceivablesDetails.CurrentRow.Cells[0].Value.ToString()));

            if (dt.Rows.Count > 0)
            {
                frm.txtId.Text = dt.Rows[0][0].ToString();
                frm.txtName.Text = dt.Rows[0][1].ToString();
                frm.txtInvoiceDate.Text = dt.Rows[0][2].ToString();
                frm.txtTotalAmount.Text = dt.Rows[0][3].ToString();
                frm.txtPaidAmount.Text = dt.Rows[0][4].ToString();
                frm.txtRemainingAmount.Text = dt.Rows[0][5].ToString();

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
