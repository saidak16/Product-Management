using Product_Management.BL;
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
    public partial class FRM_Add_Sales_Invoice : Form
    {
        DataTable dt = new DataTable();
        CLS_Stock stock = new CLS_Stock();
        CLS_ORDERS order = new CLS_ORDERS();
        CLS_Sales_Representative sales = new CLS_Sales_Representative();

        public FRM_Add_Sales_Invoice()
        {
            InitializeComponent();

            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtInvoiceId.Text = order.OrdersID().Rows[0][0].ToString();
            txtUser.Text = Program.SalesMan;
            txtSumTotal.Text = dgvInvoiceItems.Rows.Count.ToString();

            CreateColumns();
            LoadItemsData();
            LoadSalesRepresentative();
            LoadCustomers();
        }

        void CreateColumns()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("سعر الوحدة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("السعر قبل الخصم");
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

        void LoadSalesRepresentative()
        {
            //////////////////////////////////////////Load Sales Representative/////////////////////////////////////////////////////
            cmbSalesRepresentative.DataSource = sales.GetAll();
            cmbSalesRepresentative.DisplayMember = "الاسم";
            cmbSalesRepresentative.ValueMember = "المعرف";
            cmbSalesRepresentative.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSalesRepresentative.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbItems.SelectedItem = null;
            cmbItems.SelectedText = "-----اختر مندوب-----";
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

        private void FRM_Add_Sales_Invoice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FRM_Add_Sales_Invoice_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.F6)
            {
                btnSalesRepresentative_Click(sender, e);
            }
        }

        private void cbSalesRepresentative_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSalesRepresentative.Checked)
            {
                lblSaleName.Visible = true;
                lblSalePer.Visible = true;
                lblSaleSearch.Visible = true;
                txtSaleName.Visible = true;
                txtSalePer.Visible = true;
                cmbSalesRepresentative.Visible = true;
            }
            else
            {
                lblSaleName.Visible = false;
                lblSalePer.Visible = false;
                lblSaleSearch.Visible = false;
                txtSaleName.Visible = false;
                txtSalePer.Visible = false;
                cmbSalesRepresentative.Visible = false;
                txtSalePer.Clear();
                txtSaleName.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadItemsData();
            cmbItems.Focus();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Frm_Customers frm = new Frm_Customers();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalesRepresentative_Click(object sender, EventArgs e)
        {
            FRM_Sales_Representative frm = new FRM_Sales_Representative();
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Orders_RPT rep = new Orders_RPT();
            dt = order.GetOrder_RPT(Convert.ToInt32(txtInvoiceId.Text));
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }
        }
    }
}
