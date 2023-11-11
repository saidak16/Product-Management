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
            myrpt.Refresh();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }

        private void FRM_Customers_Liabilities_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Customers_Liabilities_KeyDown(object sender, KeyEventArgs e)
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
