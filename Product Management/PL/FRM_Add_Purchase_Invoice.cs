using Product_Management.BL;
using Product_Management.Models;
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
    public partial class FRM_Add_Purchase_Invoice : Form
    {
        FillDropDownList fill = new FillDropDownList();
        DataTable dt = new DataTable();
        CLS_Purchases purchases = new CLS_Purchases();
        CLS_Stock stock = new CLS_Stock();

        public FRM_Add_Purchase_Invoice()
        {
            InitializeComponent();

            txtInvoiceId.Text = purchases.GetPurchasesId();
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtUser.Text = Program.SalesMan;
            txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();

            CreateColumns();
            LoadItemsData();
            LoadSuppliersDate();
            LoadPaymentMethodDate();
        }

        void clearBoxes()
        {
            txtItemId.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtAmount.Clear();
            txtSalePrice.Clear();
        }

        void CreateColumns()
        {
            dt.Columns.Add("المعرف");
            dt.Columns.Add(" الصنف");
            dt.Columns.Add("رقم الدفعة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("تاريخ الصلاحية");
            dt.Columns.Add("سعر الشراء");
            dt.Columns.Add("سعر البيع");
            dt.Columns.Add("المبلغ الاجمالي");

            dgvInvoiceItems.DataSource = dt;
        }

        void LoadPaymentMethodDate()
        {
            cmbPaymentMethod.DataSource = fill.FiilPaymentMethods();
            cmbPaymentMethod.ValueMember = "Id";
            cmbPaymentMethod.DisplayMember = "Name";
        }

        void LoadItemsData()
        {
            //////////////////////////////////////////Load Items Data/////////////////////////////////////////////////////
            cmbItems.DataSource = stock.GetItems("");
            cmbItems.DisplayMember = "Product_Name";
            cmbItems.ValueMember = "ItemId";
            cmbItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbItems.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbItems.SelectedItem = null;
            cmbItems.SelectedText = "---------------اختر صنف----------------";
        }

        void LoadSuppliersDate()
        {
            //////////////////////////////////////////Load Suppliers Date/////////////////////////////////////////////////////
            cmbSuppliers.DataSource = purchases.GetSuppliersDate();
            cmbSuppliers.DisplayMember = "Name";
            cmbSuppliers.ValueMember = "ID";
            cmbSuppliers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSuppliers.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSuppliers.SelectedItem = null;
            cmbSuppliers.SelectedText = "---------------اختر مورد----------------";
        }

        private void txtInvoiceDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Add_Purchase_Invoice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Add_Purchase_Invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnSave_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {
                btnPrint_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                btnStock_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                btnSuppliers_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoiceItems.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد عناصر");
                    return;
                }

                if (string.IsNullOrEmpty(lblSupplierId.Text) || string.IsNullOrEmpty(txtSupplierName.Text))
                {
                    MessageBox.Show("رجاءً قم باختيار مورد", "المورد",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSuppliers.Focus();
                    return;
                }

                Purchases pur = new Purchases()
                {
                    DateOfPurchase = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", null),
                    InvoiceNumber = Convert.ToInt32(txtInvoiceId.Text),
                    PaidAmount = Convert.ToInt32(txtPaidAmount.Text),
                    PaymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue),
                    price = Convert.ToInt32(txtInvoiceAmount.Text),
                    RemainingAmount = Convert.ToInt32(txtRemainingAmount.Text),
                    SupplierId = Convert.ToInt32(lblSupplierId.Text)
                };

                var isValid = purchases.AddPurchases(pur);

                if (isValid)
                {
                    int PurOrderId = Convert.ToInt32(purchases.GetPurOrderId());

                    for (int i = 0; i < dgvInvoiceItems.Rows.Count; i++)
                    {
                        PurchaseDetails details = new PurchaseDetails()
                        {
                            Id = 0,
                            BatchNumber = Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[2].Value.ToString()),
                            productId = Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[0].Value.ToString()),
                            PurchaseId = PurOrderId,
                            PurchasePrice = Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[5].Value.ToString()),
                            QTY = Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[3].Value.ToString()),
                            SellingPrice = Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[6].Value.ToString()),
                            TotalPrice = Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[7].Value.ToString()),
                            ExpDate = Convert.ToDateTime(dgvInvoiceItems.Rows[i].Cells[4].Value.ToString())
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
                    btnSave.Enabled = false;
                    btnPrint.Enabled = true;
                    btnPrint.Focus();
                }
                else
                {
                    MessageBox.Show("لم تتم عملية الاضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            rpt_Purchase_Invoice rep = new rpt_Purchase_Invoice();
            dt = purchases.GetPurchaseInvoiceRpt(Convert.ToInt32(txtInvoiceId.Text));
            rep.SetDataSource(dt);
            FRM_Single_Product frm = new FRM_Single_Product();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FRM_ٍStockStatus frm = new FRM_ٍStockStatus();
            frm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FRM_Suppliers frm = new FRM_Suppliers();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmbSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblSupplierId.Text = cmbSuppliers.SelectedValue.ToString();
                txtSupplierName.Text = cmbSuppliers.SelectedText.ToString();

                txtPaidAmount.Focus();
            }
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrice.Focus();
            }
        }

        void Calculate()
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQty.Text))
            {
                txtAmount.Text = (Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt = new DataTable();
                    dt = purchases.GetItemData(Convert.ToInt32(cmbItems.SelectedValue));

                    if (dt.Rows.Count > 0)
                    {
                        txtItemId.Text = dt.Rows[0]["ItemId"].ToString();
                        txtItemName.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtSalePrice.Text = dt.Rows[0]["SellingPrice"].ToString();
                        txtPrice.Text = purchases.GetProductPriceData(Convert.ToInt32(dt.Rows[0]["ItemId"]));
                    }

                    dtpExpDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(dtpExpDate.Value) <= DateTime.Now)
                {
                    MessageBox.Show("تحقق من تاريخ الصلاحية", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpExpDate.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("قم بادخال الكمية");
                    txtQty.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("قم بادخال سعر الشراء");
                    txtPrice.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtSalePrice.Text))
                {
                    MessageBox.Show("قم بادخال سعر البيع");
                    txtSalePrice.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtQty.Text) || string.IsNullOrEmpty(txtSalePrice.Text)
                    || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtDate.Text))
                {
                    MessageBox.Show("الرجاء ادخال الحقول كاملة", "التحقق من الادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtQty.Focus();
                    return;
                }

                for (int i = 0; i < dgvInvoiceItems.Rows.Count - 1; i++)
                {
                    if (Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[0].Value.ToString()) == Convert.ToInt32(txtItemId.Text))
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقاً", "التحقق من الادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clearBoxes();
                        cmbItems.Focus();
                        return;
                    }
                }

                DataRow r = dt.NewRow();

                r[0] = txtItemId.Text;
                r[1] = txtItemName.Text;
                r[2] = purchases.GetBatchNo(Convert.ToInt32(txtItemId.Text));
                r[3] = txtQty.Text;
                r[4] = Convert.ToDateTime(dtpExpDate.Text).ToShortDateString();
                r[5] = txtPrice.Text;
                r[6] = txtSalePrice.Text;
                r[7] = txtAmount.Text;

                dt.Rows.Add(r);
                dgvInvoiceItems.DataSource = dt;
                clearBoxes();

                txtInvoiceAmount.Text = (from DataGridViewRow row in dgvInvoiceItems.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
                txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();

                cmbItems.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtInvoiceAmount_TextChanged(object sender, EventArgs e)
        {
            txtRemainingAmount.Text = txtInvoiceAmount.Text;
            txtPaidAmount.Text = "0";
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPaidAmount.Text) > Convert.ToInt32(txtInvoiceAmount.Text))
            {
                MessageBox.Show("لا يمكن ان يكون المبلغ المدفوع اكبر من المبلغ الاجالي", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmount.Text = "0";
                return;
            }

            txtRemainingAmount.Text = (Convert.ToInt32(txtInvoiceAmount.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalePrice.Focus();
            }
        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            dgvInvoiceItems.Rows.RemoveAt(dgvInvoiceItems.CurrentRow.Index);
            txtInvoiceAmount.Text = (from DataGridViewRow row in dgvInvoiceItems.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();
        }
    }
}
