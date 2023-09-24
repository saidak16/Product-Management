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
    public partial class FRM_Add_Purchases : Form
    {
        public string Flag = "Add";
        CLS_Purchases purchases = new CLS_Purchases();
        FillDropDownList fillDrop = new FillDropDownList();
        CLS_Helper helper = new CLS_Helper();

        public FRM_Add_Purchases()
        {
            InitializeComponent();

            cmbPaymentMethod.DataSource = fillDrop.FiilPaymentMethods();
            cmbPaymentMethod.DisplayMember = "Name";
            cmbPaymentMethod.ValueMember = "Id";

            cmbSuppiers.DataSource = fillDrop.FillSuppliersDDL();
            cmbSuppiers.DisplayMember = "Name";
            cmbSuppiers.ValueMember = "Id";

            cmbProducts.DataSource = fillDrop.FillProductsDDL();
            cmbProducts.DisplayMember = "Product_Name";
            cmbProducts.ValueMember = "ID_Product";

            if(Flag == "Add")
            {
                txtBatchNumber.Text = helper.GetBatchNumber().ToString();
                txtInvoiceNumber.Text = helper.GetInvoiceNumber().ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Flag == "Add")
                {
                    Purchases pur = new Purchases()
                    {
                        BatchNumber = Convert.ToInt32(txtBatchNumber.Text),
                        DateOfPurchase = dtpPurchaseDate.Value,
                        ExpirationDate = dtpExpDate.Value, 
                        InvoiceNumber = Convert.ToInt32(txtInvoiceNumber.Text),
                        PaidAmount = Convert.ToInt32(txtPaidAmount.Text),
                        PaymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue),
                        price = Convert.ToInt32(txtPrice.Text),
                        ProductId = Convert.ToInt32(cmbProducts.SelectedValue),
                        PurchasingPrice = Convert.ToInt32(txtPurchasingPrice.Text),
                        QTY = Convert.ToInt32(txtQTY.Text),
                        RemainingAmount = Convert.ToInt32(txtRemainingAmount.Text),
                        SellingPrice = Convert.ToInt32(txtSellingPrice.Text),
                        SupplierId = Convert.ToInt32(cmbSuppiers.SelectedValue)
                    };

                    var isValid = purchases.AddPurchases(pur);

                    if (isValid)
                    {
                        MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear();
                    }
                    else
                    {
                        MessageBox.Show("لم تتم عملية الاضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Purchases pur = new Purchases()
                    {
                        Id = Convert.ToInt32(txtId.Text),
                        BatchNumber = Convert.ToInt32(txtBatchNumber.Text),
                        DateOfPurchase = dtpPurchaseDate.Value,
                        ExpirationDate = dtpExpDate.Value,
                        InvoiceNumber = Convert.ToInt32(txtInvoiceNumber.Text),
                        PaidAmount = Convert.ToInt32(txtPaidAmount.Text),
                        PaymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue),
                        price = Convert.ToInt32(txtPrice.Text),
                        ProductId = Convert.ToInt32(cmbProducts.SelectedValue),
                        PurchasingPrice = Convert.ToInt32(txtPurchasingPrice.Text),
                        QTY = Convert.ToInt32(txtQTY.Text),
                        RemainingAmount = Convert.ToInt32(txtRemainingAmount.Text),
                        SellingPrice = Convert.ToInt32(txtSellingPrice.Text),
                        SupplierId = Convert.ToInt32(cmbSuppiers.SelectedValue)
                    };

                    var isValid = purchases.UpdatePurchases(pur);

                    if (isValid)
                    {
                        MessageBox.Show("تمت التحديث بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("لم تتم عملية التعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                FRM_Purchases.getMain.dvgPurchases.DataSource = purchases.GetAllPurchases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FRM_Purchases.getMain.dvgPurchases.DataSource = purchases.GetAllPurchases();
            this.Close();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            txtRemainingAmount.Text = (Convert.ToInt32(txtPrice.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
        }

        private void clear()
        {
            txtBatchNumber.Clear();
            txtId.Clear();
            txtInvoiceNumber.Clear();
            txtPaidAmount.Clear();
            txtPrice.Clear();
            txtPurchasingPrice.Clear();
            txtQTY.Clear();
            txtRemainingAmount.Clear();
            txtSellingPrice.Clear();
        }
    }
}
