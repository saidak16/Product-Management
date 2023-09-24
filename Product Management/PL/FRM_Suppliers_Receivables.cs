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
    public partial class FRM_Suppliers_Receivables : Form
    {
        CLS_Suppliers suppliers = new CLS_Suppliers();

        public FRM_Suppliers_Receivables()
        {
            InitializeComponent();
            dgvSuppliersReceivables.DataSource = suppliers.GetSuppliersReceivables();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SupplierId = Convert.ToInt32(this.dgvSuppliersReceivables.CurrentRow.Cells[0].Value.ToString());
            FRM_SuppliersReceivables_Details frm = new FRM_SuppliersReceivables_Details(SupplierId);
            frm.ShowDialog();
        }

        private void FRM_Suppliers_Receivables_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dgvSuppliersReceivables.DataSource = suppliers.SearchSuppliersReceivables(txtID.Text);
        }

        private void dgvSuppliersReceivables_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SupplierId = Convert.ToInt32(this.dgvSuppliersReceivables.CurrentRow.Cells[0].Value.ToString());
            FRM_SuppliersReceivables_Details frm = new FRM_SuppliersReceivables_Details(SupplierId);
            frm.ShowDialog();
        }
    }
}
