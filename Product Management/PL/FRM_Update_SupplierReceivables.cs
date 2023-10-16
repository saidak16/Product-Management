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
    public partial class FRM_Update_SupplierReceivables : Form
    {
        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_Update_SupplierReceivables()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReceivedAmount.Text))
            {
                MessageBox.Show("يجب ادخال المبلغ الصحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReceivedAmount.Focus();
                return;
            }


            if (!string.IsNullOrEmpty(txtReceivedAmount.Text))
            {
                if (Convert.ToInt32(txtReceivedAmount.Text) > Convert.ToInt32(txtRemainingAmount.Text))
                {
                    MessageBox.Show("المبلغ المدخل اكبر من المبلغ المطلوب", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReceivedAmount.Text = "0";
                    return;
                }
            }

            var isValid = purchases.UpdateSupplierReceivables(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtReceivedAmount.Text));

            if (isValid)
            {
                MessageBox.Show("تم التحديث بنجاح","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FRM_Purchases.getMain.DVG();
                this.Close();
            }
            else
            {
                MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtTotalAmount.Text) && !string.IsNullOrEmpty(txtPaidAmount.Text))
            //{
            //    txtRemainingAmount.Text = (Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
            //}
            //else
            //{
            //    txtRemainingAmount.Text = "0";
            //}

            if (!string.IsNullOrEmpty(txtReceivedAmount.Text))
            {
                if (Convert.ToInt32(txtReceivedAmount.Text) > Convert.ToInt32(txtRemainingAmount.Text))
                {
                    MessageBox.Show("المبلغ المدخل اكبر من المبلغ المطلوب", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReceivedAmount.Text = "0";
                    txtReceivedAmount.Focus();
                    return;
                }
            }
        }

        private void txtReceivedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
