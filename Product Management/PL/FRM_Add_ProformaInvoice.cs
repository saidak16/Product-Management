﻿using Product_Management.BL;
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
    public partial class FRM_Add_ProformaInvoice : Form
    {
        CLS_Proforma_Invoice proforma_Invoice = new CLS_Proforma_Invoice();
        CLS_Stock stock = new CLS_Stock();
        CLS_ORDERS order = new CLS_ORDERS();
        DataTable dt = new DataTable();

        public FRM_Add_ProformaInvoice()
        {
            InitializeComponent();

            txtInvoiceId.Text = proforma_Invoice.GetProformaInvoiceId().Rows[0][0].ToString();
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtUser.Text = Program.SalesMan;
            txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();

            CreateColumns();
            LoadItemsData();
            LoadCustomers();
        }

        void clearBoxes()
        {
            txtItemId.Clear();
            txtItemName.Clear();
            txtStockQty.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtDiscount.Text = "0";
            txtAmount.Clear();
        }

        void clearForm()
        {
            clearBoxes();
            LoadItemsData();
            LoadCustomers();
            dgvInvoiceItems.Rows.Clear();
            dgvInvoiceItems.Refresh();
            btnAdd.Enabled = false;
        }

        void Total()
        {
            if (!string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtDiscount.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                int qty = Convert.ToInt32(txtQty.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                double price = Convert.ToDouble(txtPrice.Text);

                double amount = (price * qty);

                txtAmount.Text = (amount - (amount * (discount / 100))).ToString();
            }
        }

        void CreateColumns()
        {
            dt.Columns.Add("معرف الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("سعر الوحدة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("الخصم (%)");
            dt.Columns.Add("المبلغ الاجمالي");

            dgvInvoiceItems.DataSource = dt;
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

        void LoadCustomers()
        {
            //////////////////////////////////////////Load Customers/////////////////////////////////////////////////////
            cmbCustomers.DataSource = order.GetCustomersData();
            cmbCustomers.DisplayMember = "CustomerName";
            cmbCustomers.ValueMember = "Id";
            cmbCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomers.SelectedItem = null;
            cmbCustomers.SelectedText = "-----اختر عميل-----";
        }


        private void FRM_Add_ProformaInvoice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Add_ProformaInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnSave_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2 && btnPrint.Enabled == true)
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
                btnCustomers_Click(sender, e);
            }
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

                if (string.IsNullOrEmpty(lblCustomerId.Text) || string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    MessageBox.Show("رجاء قم باختيار العميل");
                    cmbCustomers.Focus();
                    return;
                }

                //if (Convert.ToInt32(txtPaidAmount.Text) == Convert.ToInt32(txtRemainingAmount.Text))
                //{
                //    MessageBox.Show("عذراً ... الرجاء التحقق من الدفعيات", "دفعيات الطلبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtPaidAmount.Focus();
                //    return;
                //}

                if (txtInvoiceId.Text == string.Empty || txtInvoiceAmount.Text == string.Empty || txtInvoiceDesc.Text == string.Empty || lblCustomerId.Text == string.Empty || dgvInvoiceItems.Rows.Count == 0)
                {
                    MessageBox.Show("بعض المعلومات الناقصة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var isAdded = proforma_Invoice.Add_Proforma_Invoice(Convert.ToInt32(txtInvoiceId.Text), DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", null), Convert.ToInt32(lblCustomerId.Text), txtInvoiceDesc.Text, txtUser.Text);

                if (isAdded)
                {
                    for (int i = 0; i < dgvInvoiceItems.Rows.Count; i++)
                    {
                        proforma_Invoice.Proforma_Invoice_Det(dgvInvoiceItems.Rows[i].Cells[0].Value.ToString(),
                                        Convert.ToInt32(txtInvoiceId.Text),
                                        Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[3].Value),
                                        dgvInvoiceItems.Rows[i].Cells[2].Value.ToString(),
                                        Convert.ToDouble(dgvInvoiceItems.Rows[i].Cells[4].Value),
                                        (Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvInvoiceItems.Rows[i].Cells[3].Value)).ToString(),
                                        dgvInvoiceItems.Rows[i].Cells[5].Value.ToString());
                    }

                    MessageBox.Show("تم حفظ الفاتورة بنجاح", "حفظ الفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    btnPrint.Enabled = true;
                    //clearForm();
                    btnPrint.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ProformaInvoice_RPT rep = new ProformaInvoice_RPT();
            rep.SetParameterValue("@ID", Convert.ToInt32(txtInvoiceId.Text));
            FRM_Single_Product frm = new FRM_Single_Product();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FRM_ٍStockStatus frm = new FRM_ٍStockStatus();
            frm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Frm_Customers frm = new Frm_Customers();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt = new DataTable();
                    dt = order.GetItemData(Convert.ToInt32(cmbItems.SelectedValue));

                    if (dt.Rows.Count > 0)
                    {
                        txtItemId.Text = dt.Rows[0]["ItemId"].ToString();
                        txtItemName.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtStockQty.Text = dt.Rows[0]["QTY"].ToString();
                        txtPrice.Text = dt.Rows[0]["SellingPrice"].ToString();
                    }

                    if (Convert.ToInt32(dt.Rows[0]["QTY"].ToString()) == 0)
                    {
                        cmbItems.Focus();
                    }
                    else
                    {
                        txtQty.Focus();
                    }
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
                if (string.IsNullOrEmpty(txtQty.Text) || Convert.ToInt32(txtQty.Text) == 0)
                {
                    MessageBox.Show("تحقق من الكمية");
                    txtQty.Focus();
                    return;
                }

                if (btnAdd.Enabled == true)
                {
                    for (int i = 0; i < dgvInvoiceItems.Rows.Count; i++)
                    {
                        if (dgvInvoiceItems.Rows[i].Cells[0].Value.ToString() == txtItemId.Text)
                        {
                            MessageBox.Show("هذا الصنف تم ادخاله مسبقاً", "التحقق من الادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            clearBoxes();
                            cmbItems.Focus();
                            return;
                        }
                    }

                    DataRow r = dt.NewRow();

                    r[0] = txtItemId.Text;
                    r[1] = txtItemName.Text;
                    r[2] = txtPrice.Text;
                    r[3] = txtQty.Text;
                    r[4] = txtDiscount.Text;
                    r[5] = txtAmount.Text;

                    dt.Rows.Add(r);
                    dgvInvoiceItems.DataSource = dt;

                    txtInvoiceAmount.Text = (from DataGridViewRow row in dgvInvoiceItems.Rows where row.Cells[5].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    LoadItemsData();
                    clearBoxes();
                    txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();
                    cmbItems.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                if (Convert.ToInt32(txtStockQty.Text) == 0)
                {
                    MessageBox.Show("الكمية الحالية بالمخزن: " + txtStockQty.Text, "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbItems.Focus();
                    return;
                }

                Total();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                Total();
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            dgvInvoiceItems.Rows.RemoveAt(dgvInvoiceItems.CurrentRow.Index);
            txtInvoiceAmount.Text = (from DataGridViewRow row in dgvInvoiceItems.Rows where row.Cells[5].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();
            cmbItems.Focus();
        }

        private void cmbCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCustomerName.Text = cmbCustomers.SelectedText.ToString();
                    lblCustomerId.Text = cmbCustomers.SelectedValue.ToString();
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaidAmount.Text))
            {
                txtPaidAmount.Text = "0";
            }

            if (Convert.ToInt32(txtPaidAmount.Text) > Convert.ToInt32(txtInvoiceAmount.Text))
            {
                MessageBox.Show("لا يمكن ان يكون المبلغ المدفوع اكبر من المبلغ الاجالي", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmount.Text = "0";
                return;
            }

            txtRemainingAmount.Text = (Convert.ToInt32(txtInvoiceAmount.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
        }

        private void txtInvoiceAmount_TextChanged(object sender, EventArgs e)
        {
            txtRemainingAmount.Text = txtInvoiceAmount.Text;
            txtPaidAmount.Text = "0";
        }
    }
}