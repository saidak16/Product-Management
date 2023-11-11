using Product_Management.BL;
using Product_Management.Models;
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
    public partial class FRM_Add_MultiPurchase : Form
    {
        FillDropDownList fill = new FillDropDownList();
        CLS_Purchases purchases = new CLS_Purchases();
        DataTable dt = new DataTable();

        public FRM_Add_MultiPurchase()
        {
            InitializeComponent();

            txtPurchaseDate.Text = DateTime.Now.ToShortDateString();

            CreateColumns();

            cmbPaymentMethod.DataSource = fill.FiilPaymentMethods();
            cmbPaymentMethod.ValueMember = "Id";
            cmbPaymentMethod.DisplayMember = "Name";

        }

        void CreateColumns()
        {
            dt.Columns.Add("المعرف");
            dt.Columns.Add(" المنتج");
            dt.Columns.Add("رقم الدفعة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("تاريخ الصلاحية");
            dt.Columns.Add("سعر الشراء");
            dt.Columns.Add("سعر البيع");
            dt.Columns.Add("المبلغ الاجمالي");

            dgvPurchase.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSupList_Click(object sender, EventArgs e)
        {
            FRM_SupList frm = new FRM_SupList();
            frm.ShowDialog();

            txtSupId.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCompany.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentMethod_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbProducts_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtItmeName.Text) || string.IsNullOrEmpty(txtQTY.Text) || string.IsNullOrEmpty(txtSellingPrice.Text)
                    || string.IsNullOrEmpty(txtPurPrice.Text) || string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtPurchaseDate.Text)
                    || string.IsNullOrEmpty(txtBatch.Text))
                {
                    MessageBox.Show("الرجاء ادخال الحقول كاملة", "التحقق من الادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    button2.Focus();
                    return;
                }

                for (int i = 0; i < dgvPurchase.Rows.Count - 1; i++)
                {
                    if (Convert.ToInt32(dgvPurchase.Rows[i].Cells[0].Value.ToString()) == Convert.ToInt32(txtItemId.Text))
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقاً", "التحقق من الادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clearBoxes();
                        btnAdd.Focus();
                        return;
                    }
                }

                DataRow r = dt.NewRow();

                r[0] = txtItemId.Text ;
                r[1] = txtItmeName.Text ;
                r[2] = txtBatch.Text;
                r[3] = txtQTY.Text;
                r[4] = Convert.ToDateTime(dtpExpDate.Text).ToShortDateString();
                r[5] = txtPurPrice.Text;
                r[6] = txtSellingPrice.Text;
                r[7] = txtAmount.Text;

                dt.Rows.Add(r);
                dgvPurchase.DataSource = dt;
                clearBoxes();

                txtTotalAmount.Text = (from DataGridViewRow row in dgvPurchase.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
                txtItemsCount.Text = dgvPurchase.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clearBoxes()
        {
            txtItmeName.Clear();
            txtBatch.Clear();
            txtQTY.Clear();
            txtPurPrice.Clear();
            txtSellingPrice.Clear();
            txtAmount.Clear();
        }

        private void txtPurPrice_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPurPrice.Text))
            {
                txtAmount.Text = (Convert.ToInt32(txtPurPrice.Text) * Convert.ToUInt32(txtQTY.Text)).ToString();
            }
            else
            {
                txtAmount.Text = "0";
            }
        }

        private void txtPurPrice_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPurPrice.Text) && !string.IsNullOrEmpty(txtQTY.Text))
            {
                CalculateAmount();
            }
            else
            {
                txtAmount.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPurchase.Rows.RemoveAt(dgvPurchase.CurrentRow.Index);
            txtTotalAmount.Text = (from DataGridViewRow row in dgvPurchase.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            txtItemsCount.Text = dgvPurchase.Rows.Count.ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txtInvoiceNum.Text = purchases.GetPurchasesId();
            btn_Save.Enabled = true;
            btn_New.Enabled = false;

            if (!string.IsNullOrEmpty(txtItemId.Text))
            {
                if (Convert.ToInt32(txtItemId.Text) != 0)
                {
                    txtBatch.Text = purchases.GetBatchNo(Convert.ToInt32(txtItemId.Text));
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupId.Text) || string.IsNullOrEmpty(txtPaidAmount.Text) || string.IsNullOrEmpty(txtInvoiceNum.Text) || dgvPurchase.Rows.Count == 0)
            {
                MessageBox.Show("الرجاء التحقق من ادخال كافة البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Purchases pur = new Purchases()
            {
                DateOfPurchase = Convert.ToDateTime(txtPurchaseDate.Text),
                InvoiceNumber = Convert.ToInt32(txtInvoiceNum.Text),
                PaidAmount = Convert.ToInt32(txtPaidAmount.Text),
                PaymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue),
                price = Convert.ToInt32(txtTotalAmount.Text),
                RemainingAmount = Convert.ToInt32(txtRemainingAmount.Text),
                SupplierId = Convert.ToInt32(txtSupId.Text)
            };

            var isValid = purchases.AddPurchases(pur);

            if (isValid)
            {
                int PurOrderId = Convert.ToInt32(purchases.GetPurOrderId());

                for (int i = 0; i < dgvPurchase.Rows.Count; i++)
                {
                    PurchaseDetails details = new PurchaseDetails()
                    {
                        Id = 0,
                        BatchNumber = Convert.ToInt32(dgvPurchase.Rows[i].Cells[2].Value.ToString()),
                        productId = Convert.ToInt32(dgvPurchase.Rows[i].Cells[0].Value.ToString()),
                        PurchaseId = PurOrderId,
                        PurchasePrice = Convert.ToInt32(dgvPurchase.Rows[i].Cells[5].Value.ToString()),
                        QTY = Convert.ToInt32(dgvPurchase.Rows[i].Cells[3].Value.ToString()),
                        SellingPrice = Convert.ToInt32(dgvPurchase.Rows[i].Cells[6].Value.ToString()),
                        TotalPrice = Convert.ToInt32(dgvPurchase.Rows[i].Cells[7].Value.ToString()),
                        ExpDate = Convert.ToDateTime(dgvPurchase.Rows[i].Cells[4].Value.ToString())
                    };

                    var check = purchases.AddPurchaseDetails(details);

                    if (check)
                    {
                        //MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       // MessageBox.Show("لم تتم عملية الاضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_Purchases.getMain.DVG();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("لم تتم عملية الاضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemId.Text))
            {
                if (Convert.ToInt32(txtItemId.Text) != 0)
                {
                    txtBatch.Text = purchases.GetBatchNo(Convert.ToInt32(txtItemId.Text));
                }
            }
        }

        private void cmbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(cmbProducts.Text))
            //{
            //    if (Convert.ToInt32(cmbProducts.SelectedValue) != 0)
            //    {
            //        txtBatch.Text = purchases.GetBatchNo(Convert.ToInt32(cmbProducts.SelectedValue));
            //    }
            //}
        }

        private void cmbProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemId.Text))
            {
                if (Convert.ToInt32(txtItemId.Text) != 0)
                {
                    txtBatch.Text = purchases.GetBatchNo(Convert.ToInt32(txtItemId.Text));
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPurPrice.Text) && !string.IsNullOrEmpty(txtQTY.Text))
            {
                CalculateAmount();
            }
            else
            {
                txtAmount.Text = "0";
            }
        }

        void CalculateAmount()
        {
            txtAmount.Text = (Convert.ToInt32(txtQTY.Text) * Convert.ToInt32(txtPurPrice.Text)).ToString();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTotalAmount.Text) && !string.IsNullOrEmpty(txtPaidAmount.Text))
            {
                txtRemainingAmount.Text = (Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
            }
            else
            {
                txtRemainingAmount.Text = "0";
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalAmount.Text) && !string.IsNullOrEmpty(txtPaidAmount.Text))
            {
                txtRemainingAmount.Text = (Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
            }
            else
            {
                txtRemainingAmount.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Items_List frm = new FRM_Items_List();
            frm.ShowDialog();

            txtItemId.Text = frm.dgvItemsList.CurrentRow.Cells[0].Value.ToString();
            txtItmeName.Text = frm.dgvItemsList.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemId.Text))
            {
                if (Convert.ToInt32(txtItemId.Text) != 0)
                {
                    txtBatch.Text = purchases.GetBatchNo(Convert.ToInt32(txtItemId.Text));
                }
            }
        }

        private void FRM_Add_MultiPurchase_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Add_MultiPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_New_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2 && btn_Save.Enabled == true)
            {
                btn_Save_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                btnSupList_Click( sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
