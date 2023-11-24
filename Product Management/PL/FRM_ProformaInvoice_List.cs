using Product_Management.BL;
using Product_Management.RPT;
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
    public partial class FRM_ProformaInvoice_List : Form
    {
        CLS_Proforma_Invoice proforma_Invoice = new CLS_Proforma_Invoice();

        public FRM_ProformaInvoice_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = proforma_Invoice.GetProformaInvoices("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proforma_Invoice.GetProformaInvoices(txtID.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ProformaInvoice_RPT rep = new ProformaInvoice_RPT();
            rep.SetParameterValue("@ID", Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
            FRM_Single_Product frm = new FRM_Single_Product();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }

        private void FRM_ProformaInvoice_List_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_ProformaInvoice_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnPrint_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
