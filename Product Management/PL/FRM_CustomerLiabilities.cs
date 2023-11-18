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
    public partial class FRM_CustomerLiabilities : Form
    {
        CLS_Customer_Profile profile = new CLS_Customer_Profile();
        CLS_ORDERS order = new CLS_ORDERS();

        public FRM_CustomerLiabilities(int customerId)
        {
            InitializeComponent();

            dgvCustomerLiabilities.DataSource = profile.GetLiabilitiesByCustomerId(customerId);
            txtCount.Text = dgvCustomerLiabilities.Rows.Count.ToString();

            if (dgvCustomerLiabilities.Rows.Count > 0)
            {
                txtTotalAmoun.Text = dgvCustomerLiabilities.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[6].Value)).ToString("C");
                txtTotalPaid.Text = dgvCustomerLiabilities.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[7].Value)).ToString("C");
                txtTotalRemaining.Text = dgvCustomerLiabilities.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[8].Value)).ToString("C");
            }
            else
            {
                txtTotalAmoun.Text = "0";
                txtTotalPaid.Text = "0";
                txtTotalRemaining.Text = "0";
            }
        }

        private void FRM_CustomerLiabilities_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_CustomerLiabilities_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnPrint_Click(sender, e);
            }
            
            if (e.KeyCode == Keys.F2)
            {
                button2_Click(sender, e);
            }
            
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomerLiabilities.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد عناصر");
                    return;
                }

                DataTable dt = new DataTable();
                dt = profile.GetLiabilitiesByCustomerId(Convert.ToInt32(this.dgvCustomerLiabilities.CurrentRow.Cells[0].Value.ToString()));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("تعذر طباعة التقرير", "عفواً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rpt_CustomerLiabilities rep = new rpt_CustomerLiabilities();
                rep.SetDataSource(dt);
                FRM_Single_Product frm = new FRM_Single_Product();
                frm.crystalReportViewer1.ReportSource = rep;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "حدث خطأ ما", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomerLiabilities.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد عناصر");
                    return;
                }

                DataTable dt = order.GetCustomersLiabilities(Convert.ToInt32(this.dgvCustomerLiabilities.CurrentRow.Cells[2].Value.ToString()));

                FRM_UpdateCustomersLiabilities frm = new FRM_UpdateCustomersLiabilities();

                frm.txtId.Text = dt.Rows[0][0].ToString();
                frm.txtTotal.Text = dt.Rows[0][2].ToString();
                frm.txtPaid.Text = dt.Rows[0][3].ToString();
                frm.txtRemain.Text = dt.Rows[0][4].ToString();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "حدث خطأ ما", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
