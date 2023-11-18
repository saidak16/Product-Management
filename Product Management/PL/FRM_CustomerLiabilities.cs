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
    public partial class FRM_CustomerLiabilities : Form
    {
        CLS_Customer_Profile profile = new CLS_Customer_Profile();
        CLS_ORDERS order = new CLS_ORDERS();

        public FRM_CustomerLiabilities(int customerId)
        {
            InitializeComponent();

            dgvCustomerLiabilities.DataSource = profile.GetLiabilitiesByCustomerId(customerId);
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
                MessageBox.Show("Success!");
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
