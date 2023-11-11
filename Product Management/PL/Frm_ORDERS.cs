using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Product_Management.BL;
using Product_Management.Models;

namespace Product_Management.PL
{
    public partial class Frm_ORDERS : Form
    {
        CLS_ORDERS order = new CLS_ORDERS();
        CLS_Sales_Representative cLS_Sales = new CLS_Sales_Representative();
        FillDropDownList fill = new FillDropDownList();
        DataTable dt = new DataTable();

        void cal()
        {
            if (txtPROQNT.Text != string.Empty && txtPROPrice.Text != string.Empty)
            txtPROAmount.Text = Convert.ToString(Convert.ToInt32(txtPROPrice.Text) * Convert.ToInt32(txtPROQNT.Text));
        }

        void Total()
        {
            if (txtPRODES.Text != string.Empty && txtPROAmount.Text != string.Empty)
            {
                double dis = Convert.ToDouble(txtPRODES.Text);
                double amount = Convert.ToDouble(txtPROAmount.Text);
                double total = amount - (amount * (dis / 100));
                txtPROTotal.Text = total.ToString();
            }
        }

        void CreateColumns()
        {
            dt.Columns.Add("المعرف");
            dt.Columns.Add("رقم المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("الخصم (%)");
            dt.Columns.Add("المبلغ الاجمالي");

            dataGridView1.DataSource = dt;
        }

        void ResizeDGV()
        {
                this.dataGridView1.RowHeadersWidth = 84;
                this.dataGridView1.Columns[0].Width = 80;
                this.dataGridView1.Columns[1].Width = 223;
                this.dataGridView1.Columns[2].Width = 80;
                this.dataGridView1.Columns[3].Width = 96;
                this.dataGridView1.Columns[4].Width = 87;
                this.dataGridView1.Columns[5].Width = 80;
                //this.dataGridView1.Columns[6].Width = 134;
                //this.dataGridView1.Columns[7].Width = 80;
                //this.dataGridView1.Columns[8].Width = 80;
                //this.dataGridView1.Columns[9].Width = 134;
        }

        void clearBoxes()
        {
            txtId.Clear();
            txtIDpro.Clear();
            txtPROName.Clear();
            txtPROPrice.Clear();
            txtPROQNT.Clear();
            txtPROAmount.Clear();
            txtPRODES.Clear();
            txtPROTotal.Clear();
            btnBrows.Focus();
        }
        public Frm_ORDERS()
        {
            InitializeComponent();
            CreateColumns();
            //ResizeDGV();
            txtSalesMan.Text = Program.SalesMan;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            this.txtOrderID.Text = order.OrdersID().Rows[0][0].ToString();
            btn_Print.Enabled = true;
            btn_Save.Enabled = true;
            btn_New.Enabled = false;
            txtOrderDes.Focus();
        }

        private void btnCUS_Click(object sender, EventArgs e)
        {
            FRM_CUST_LIST frm = new FRM_CUST_LIST();
            frm.ShowDialog();

            if(frm.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("عذراً لا يوجد عناصر", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txt_CUS_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCUS_Fname.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCUS_Lname.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCUS_Tel.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCUS_Email.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            byte[] pic = (byte[])frm.dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();

            if (frm.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("عذراً لا يوجد عناصر", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtId.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtIDpro.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPROName.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPROPrice.Text = frm.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPROQNT.Focus();
        }

        private void txtPROQNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPROPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPROQNT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab && txtPROQNT.Text != string.Empty)
            {
                txtPRODES.Focus();
                txtPROAmount.Text = Convert.ToString(Convert.ToInt32( txtPROPrice.Text) *Convert.ToInt32( txtPROQNT.Text));
            }
        }

        private void txtPRODES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            Total();
        }

        private void txtPRODES_KeyDown(object sender, KeyEventArgs e)
        {
            Total();
        }

        private void txtPROQNT_KeyUp(object sender, KeyEventArgs e)
        {
            cal();
        }

        private void txtPRODES_KeyUp(object sender, KeyEventArgs e)
        {
            Total();
        }

        private void txtPROTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (order.Verify_QTY(txtIDpro.Text, Convert.ToInt32(txtPROQNT.Text)).Rows.Count <= 0)
                {
                    MessageBox.Show("الكمية المدخلة غير متوفرة في المخزن", "التحقق من الكمية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPROQNT.Focus();
                    return;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtIDpro.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقاً", "التحقق من الادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clearBoxes();
                        btnBrows.Focus();
                        return;
                    }
                }

                DataRow r = dt.NewRow();

                r[0] = txtId.Text;
                r[1] = txtIDpro.Text;
                r[2] = txtPROName.Text;
                r[3] = txtPROPrice.Text;
                r[4] = txtPROQNT.Text;
                r[5] = txtPROAmount.Text;
                r[6] = txtPRODES.Text;
                r[7] = txtPROTotal.Text;

                dt.Rows.Add(r);
                dataGridView1.DataSource = dt;
                clearBoxes();

                txtSumTotal.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            txtSumTotal.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
        }

        private void txtSumTotal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSumTotal.Text))
            {
                txtTotalItems.Text = (dataGridView1.Rows.Count - 1).ToString();
                txtTotalAmount.Text = txtSumTotal.Text;
            }
        }

        private void txtPROQNT_TabIndexChanged(object sender, EventArgs e)
        {
            txtPRODES.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtIDpro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPROName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPROPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPROQNT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPROAmount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPRODES.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            txtPROTotal.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            txtPROQNT.Focus();
           
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumTotal.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[6].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(txtPaidAmont.Text) == Convert.ToInt32(txtRemAmount.Text))
                {
                    MessageBox.Show("عذراً ... الرجاء التحقق من الدفعيات", "دفعيات الطلبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaidAmont.Focus();
                    return;
                }

                if (cbSalesRepresentative.Checked && !string.IsNullOrEmpty(txtSaleId.Text))
                {
                    CLS_SalesRepresentativePercentage percentage = new CLS_SalesRepresentativePercentage();
                    double per = Convert.ToDouble(txtPercentage.Text) / 100;
                    int amoun = Convert.ToInt32(Convert.ToInt32(txtSumTotal.Text) * per);

                    SalesRepresentativePercentage sales = new SalesRepresentativePercentage()
                    {
                        Id = 0,
                        Amount = amoun,
                        DateOfInvoice = DateTime.Now,
                        orderId = Convert.ToInt32(txtOrderID.Text),
                        SalesRepresentativeId = Convert.ToInt32(txtSaleId.Text)
                    };

                    var isValid = percentage.Add(sales);

                    if (!isValid)
                    {
                        MessageBox.Show("يجب اختيار مندوب مبيعات ", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (txtOrderID.Text == string.Empty || txtTotalAmount.Text == string.Empty || txtOrderDes.Text == string.Empty || txt_CUS_ID.Text == string.Empty || dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("بعض المعلومات الناقصة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                order.Add_Order(Convert.ToInt32(txtOrderID.Text), Order_date.Value, Convert.ToInt32(txt_CUS_ID.Text), txtOrderDes.Text, txtSalesMan.Text, Convert.ToInt32(txtTotalAmount.Text), Convert.ToInt32(txtPaidAmont.Text), Convert.ToInt32(txtRemAmount.Text));

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    order.Order_Det(dataGridView1.Rows[i].Cells[1].Value.ToString(),
                                    Convert.ToInt32(txtOrderID.Text),
                                    Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                                    dataGridView1.Rows[i].Cells[3].Value.ToString(),
                                    Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value),
                                    dataGridView1.Rows[i].Cells[5].Value.ToString(),
                                    dataGridView1.Rows[i].Cells[7].Value.ToString(),
                                    Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                }

                MessageBox.Show("تم حفظ الفاتورة بنجاح", "حفظ الفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_New.Enabled = true;
                btn_Save.Enabled = false;
                btn_Print.Enabled = true;
                btn_Print.Focus();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            RPT.Orders_RPT rep = new RPT.Orders_RPT();
            rep.SetParameterValue("@ID", Convert.ToInt32(txtOrderID.Text));
            RPT.FRM_Single_Product frm = new RPT.FRM_Single_Product();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPaidAmount_KeyUp(object sender, KeyEventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtPaidAmount.Text) || !string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            //{
            //    txtRemainingAmount.Text = (Convert.ToInt32(txtPROTotal.Text) - Convert.ToInt32(txtPaidAmount.Text)).ToString();
            //}
            //else
            //{
            //    txtRemainingAmount.Text = "0";
            //}
        }

        private void cbSalesRepresentative_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSalesRepresentative.Checked)
            {
                lblSaleId.Visible = true;
                txtSaleId.Visible = true;
                btnSalesList.Enabled = true;
                txtName.Visible = true;
                lblAddress.Visible = true;
                lblPercentage.Visible = true;
                lblPhone.Visible = true;

                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtPercentage.Visible = true;
            }
            else
            {
                txtSaleId.Clear();
                txtName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtPercentage.Clear();

                lblSaleId.Visible = false;
                txtSaleId.Visible = false;
                btnSalesList.Enabled = false;
                txtName.Visible = false;
                lblAddress.Visible = false;
                lblPercentage.Visible = false;
                lblPhone.Visible = false;

                txtAddress.Visible = false;
                txtPhone.Visible = false;
                txtPercentage.Visible = false;
            }
        }

        private void cmbSalesRepresentative_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FRM_SalesRepresentative_List frm = new FRM_SalesRepresentative_List();
            frm.ShowDialog();

            if (frm.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("عذراً لا يوجد عناصر", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtSaleId.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPercentage.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtPaidAmont_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTotalAmount.Text) && !string.IsNullOrEmpty(txtPaidAmont.Text))
            {
                txtRemAmount.Text = (Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(txtPaidAmont.Text)).ToString();
            }
        }

        private void Frm_ORDERS_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void Frm_ORDERS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_New_Click( sender, e);
            }

            if (e.KeyCode == Keys.F2 && btn_Save.Enabled == true)
            {
                btn_Save_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3 && btn_Print.Enabled == true)
            {
                btn_Print_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                button2_Click_1(sender, e);
            }

            if (e.KeyCode == Keys.F6)
            {
                btnCUS_Click(sender, e);
            }
        }
    }
}
