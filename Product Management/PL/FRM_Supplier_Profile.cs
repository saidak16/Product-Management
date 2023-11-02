﻿using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class FRM_Supplier_Profile : Form
    {
        CLS_Supplier_Profile profile = new CLS_Supplier_Profile();
        int supId = 0;

        public FRM_Supplier_Profile(int supplierId)
        {
            InitializeComponent();

            supId = supplierId;


            //////////////////////////////////////////////Supplier Info//////////////////////////////////////////////////////////////////
            DataTable dt = profile.GetSupplierById(supId);

            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtCompany.Text = dt.Rows[0]["CompanyName"].ToString();
            txtCreationDate.Text = Convert.ToDateTime(dt.Rows[0]["CreationDate"]).ToShortDateString();
            txtLastOrder.Text = Convert.ToDateTime(dt.Rows[0]["LastOrder"]).ToShortDateString();

            /////////////////////////////////////customer chart/////////////////////////////////////
            SeriesCollection series = new SeriesCollection();

            series.Add(new PieSeries() { Title = " جملة المعاملات", Values = new ChartValues<int> { 3000 }, DataLabels = true });
            series.Add(new PieSeries() { Title = "اجمالي الدفعيات", Values = new ChartValues<int> { 2000 }, DataLabels = true });
            series.Add(new PieSeries() { Title = "اجمالي الاستحفافات", Values = new ChartValues<int> { 3000 }, DataLabels = true });

            pieChart1.Series = series;



            ///////////////////////////////////////// Return Invoices /////////////////////////////////////////////////////////////////////
            dgvReturnInvoices.DataSource = profile.GetReturnPurchases(supId);
            txtCountOfReturnInvoices.Text = dgvReturnInvoices.Rows.Count.ToString();

            ////////////////////////////////////////// Supplier Invoices /////////////////////////////////////////////////////////////////
            dgvInvoices.DataSource = profile.GetSupplierInvoices(supId);
            txtCountOfSaleInvoices.Text = dgvInvoices.Rows.Count.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Supplier_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_SuppliersReceivables_Details frm = new FRM_SuppliersReceivables_Details(supId);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Supplier_Products frm = new FRM_Supplier_Products(supId);
            frm.ShowDialog();
        }

        private void btnSaleInvoice_Click(object sender, EventArgs e)
        {
            if (dgvReturnInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            int orderId = Convert.ToInt32(this.dgvReturnInvoices.CurrentRow.Cells[0].Value);
            FRM_Return_Purchase_Details frm = new FRM_Return_Purchase_Details(orderId);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            int orderId = Convert.ToInt32(this.dgvInvoices.CurrentRow.Cells[0].Value);
            FRM_PurchaseDetails frm = new FRM_PurchaseDetails(orderId);
            frm.groupBox1.Visible = false;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

           
        }
    }
}