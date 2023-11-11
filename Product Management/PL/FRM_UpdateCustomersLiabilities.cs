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
    public partial class FRM_UpdateCustomersLiabilities : Form
    {
        CLS_ORDERS order = new CLS_ORDERS();

        public FRM_UpdateCustomersLiabilities()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAmount.Text))
                {
                    MessageBox.Show("يجب ادخال المبلغ الصحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }

                if (Convert.ToInt32(txtAmount.Text) > Convert.ToInt32(txtRemain.Text))
                {
                    MessageBox.Show("المبلغ المدخل اكبر من المبلغ المطلوب", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Text = "0";
                    return;
                }

                var isValid = order.UpdateCustomersLiabilities(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtAmount.Text));

                if (isValid)
                {
                    MessageBox.Show("تمت العملية بنجاح", "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FRM_Orders_List.getMain.dataGridView1.DataSource = order.GetAllOrders("");
                }
                else
                {
                    MessageBox.Show("لم تتم العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtAmount.Text) > Convert.ToInt32(txtRemain.Text))
            {
                MessageBox.Show("المبلغ المدخل اكبر من المبلغ المطلوب", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Text = "0";
                return;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void FRM_UpdateCustomersLiabilities_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_UpdateCustomersLiabilities_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnUpdate_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
