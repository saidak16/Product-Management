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
    public partial class FRM_Suppliers_List : Form
    {
        CLS_Suppliers suppliers = new CLS_Suppliers();

        public FRM_Suppliers_List()
        {
            InitializeComponent();

            this.dgvSuppliers.DataSource = suppliers.GetSupList("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            FRM_Supplier_Profile frm = new FRM_Supplier_Profile(Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvSuppliers.DataSource = suppliers.GetSupList(txtSearch.Text);
        }

        private void FRM_Suppliers_List_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Suppliers_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                button1_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
