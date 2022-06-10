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
    public partial class FRM_Orders_List : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public FRM_Orders_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = order.Order_Del("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = order.Order_Del(txtID.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.Orders_RPT rep = new RPT.Orders_RPT();
            rep.SetParameterValue("@ID", Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
            RPT.FRM_Single_Product frm = new RPT.FRM_Single_Product();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }
    }
}
