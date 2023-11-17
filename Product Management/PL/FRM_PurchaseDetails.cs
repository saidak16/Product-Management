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
    public partial class FRM_PurchaseDetails : Form
    {
        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_PurchaseDetails(int orderId)
        {
            InitializeComponent();

            dgvPurchaseDetails.DataSource = purchases.GetPurchaseDetails(orderId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العنصر المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var isValid =  purchases.DeletePurchasDetails(Convert.ToInt32(this.dgvPurchaseDetails.CurrentRow.Cells[0].Value), Convert.ToInt32(this.dgvPurchaseDetails.CurrentRow.Cells[2].Value), Convert.ToInt32(this.dgvPurchaseDetails.CurrentRow.Cells[1].Value));

                if (isValid)
                {
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_Purchases.getMain.DVG();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" حدث خطأ ما ", " خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_PurchaseDetails_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_PurchaseDetails_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void FRM_PurchaseDetails_KeyDown(object sender, KeyEventArgs e)
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
