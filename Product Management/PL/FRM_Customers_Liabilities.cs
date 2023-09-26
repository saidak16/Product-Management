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
    public partial class FRM_Customers_Liabilities : Form
    {
        CLS_Customers customers = new CLS_Customers();

        public FRM_Customers_Liabilities()
        {
            InitializeComponent();
            dgvCustomersLiabilities.DataSource = customers.GetCustomersLiabilities();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dgvCustomersLiabilities.DataSource = customers.SearchCustomersLiabilities(txtID.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rpt_CustomersLiabilities myrpt = new rpt_CustomersLiabilities();
            FRM_Single_Product myfrm = new FRM_Single_Product();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }
    }
}
