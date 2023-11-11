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
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
