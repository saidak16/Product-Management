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
    public partial class FRM_ProductPrice : Form
    {
        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_ProductPrice()
        {
            InitializeComponent();
        }

        private void FRM_ProductPrice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSealPrice.Text))
                {
                    var isValid = purchases.UpdateProductPrice(Convert.ToInt32(lblProductId.Text), Convert.ToInt32(txtSealPrice.Text));

                    if (isValid)
                    {
                        MessageBox.Show("تمت العملية ينجاح", "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FRM_ProductPriceList.getMain.DGV();
                        FRM_ProductPriceList.getMain.txtID.Clear();
                        FRM_ProductPriceList.getMain.txtID.Focus();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("يجب ادخال سعر البيع بصورة صحيحة", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSealPrice.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSealPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void FRM_ProductPrice_KeyDown(object sender, KeyEventArgs e)
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
