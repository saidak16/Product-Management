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
    public partial class FRM_Purchases : Form
    {
        private static FRM_Purchases frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Purchases getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Purchases();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_Purchases()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            DVG();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DVG()
        {
            dvgPurchases.DataSource = purchases.GetAllPurchases();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dvgPurchases.DataSource = purchases.SearchPurchases(txtID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_MultiPurchase _Purchases = new FRM_Add_MultiPurchase();
            _Purchases.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المورج المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                purchases.DeletePurchases(Convert.ToInt32(this.dvgPurchases.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DVG();
            }
            else
            {
                MessageBox.Show("تم إلغاء العملية", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_PurchaseDetails frm = new FRM_PurchaseDetails(Convert.ToInt32(this.dvgPurchases.CurrentRow.Cells[0].Value.ToString()));
            //frm.txtId.Text = this.dvgPurchases.CurrentRow.Cells[0].Value.ToString();
            //frm.cmbSuppiers.Text = this.dvgPurchases.CurrentRow.Cells[1].Value.ToString();
            //frm.cmbProducts.Text = this.dvgPurchases.CurrentRow.Cells[2].Value.ToString();
            //frm.dtpPurchaseDate.Text = this.dvgPurchases.CurrentRow.Cells[3].Value.ToString();
            //frm.dtpExpDate.Text = this.dvgPurchases.CurrentRow.Cells[4].Value.ToString();
            //frm.txtQTY.Text = this.dvgPurchases.CurrentRow.Cells[5].Value.ToString();
            //frm.txtPurchasingPrice.Text = this.dvgPurchases.CurrentRow.Cells[6].Value.ToString();
            //frm.txtSellingPrice.Text = this.dvgPurchases.CurrentRow.Cells[7].Value.ToString();
            //frm.txtPrice.Text = this.dvgPurchases.CurrentRow.Cells[8].Value.ToString();
            //frm.txtPaidAmount.Text = this.dvgPurchases.CurrentRow.Cells[9].Value.ToString();
            //frm.txtRemainingAmount.Text = this.dvgPurchases.CurrentRow.Cells[10].Value.ToString();
            //frm.cmbPaymentMethod.Text = this.dvgPurchases.CurrentRow.Cells[11].Value.ToString();
            //frm.txtInvoiceNumber.Text = this.dvgPurchases.CurrentRow.Cells[12].Value.ToString();
            //frm.txtBatchNumber.Text = this.dvgPurchases.CurrentRow.Cells[13].Value.ToString();
            //frm.Text = "تحديث البيانات";
            //frm.btnAdd.Text = "تحديث";
            //frm.Flag = "Update";

            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Update_SupplierReceivables frm = new FRM_Update_SupplierReceivables();

            DataTable dt = purchases.GetPurchaseOrderById(Convert.ToInt32(this.dvgPurchases.CurrentRow.Cells[0].Value.ToString()));

            if(dt.Rows.Count > 0)
            {
                frm.txtId.Text = dt.Rows[0][0].ToString();
                frm.txtName.Text = dt.Rows[0][1].ToString();
                frm.txtInvoiceDate.Text = dt.Rows[0][2].ToString();
                frm.txtTotalAmount.Text = dt.Rows[0][3].ToString();
                frm.txtPaidAmount.Text = dt.Rows[0][4].ToString();
                frm.txtRemainingAmount.Text = dt.Rows[0][5].ToString();

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FRM_Purchases_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Purchases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {
                button4_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                button3_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
