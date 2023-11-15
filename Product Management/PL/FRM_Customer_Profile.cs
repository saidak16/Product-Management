using LiveCharts;
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
    public partial class FRM_Customer_Profile : Form
    {
        int customerId = 0;
        CLS_Customer_Profile profile = new CLS_Customer_Profile();

        public FRM_Customer_Profile(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;

            ///////////////////////////////////////////////Customer Info///////////////////////////////////////////////////////////////////
            DataTable dt = new DataTable();
            dt = profile.GetCustomerInfo(customerId);

            txtName.Text = dt.Rows[0]["customerName"].ToString();
            txtPhone.Text = dt.Rows[0]["TEL"].ToString();
            txtEmail.Text = dt.Rows[0]["E_Mail"].ToString();
            txtCreationDate.Text = Convert.ToDateTime(dt.Rows[0]["Creation_Date"]).ToShortDateString();
            txtLastOrder.Text = Convert.ToDateTime(dt.Rows[0]["LastOrder"]).ToShortDateString();
            txtTotalRemaining.Text = Convert.ToInt32(dt.Rows[0]["TotalRemaining"]).ToString("C");

            ///////////////////////////////////////////////////Customer Invoices//////////////////////////////////////////////////////////////////////////////////////////
            dgvInvoices.DataSource = profile.GetCustomerInvoices(customerId, "");
            txtCountOfSaleInvoices.Text = dgvInvoices.Rows.Count.ToString();

            ///////////////////////////////////////////////////Customer Return Invoices/////////////////////////////////////////////////////////////////////////////////////
            dgvReturnInvoices.DataSource = profile.GetCustomerReturnOrder(customerId, "");
            txtCountOfReturnInvoices.Text = dgvReturnInvoices.Rows.Count.ToString();

            /////////////////////////////////////customer chart/////////////////////////////////////
            SeriesCollection series = new SeriesCollection();

            series.Add(new PieSeries() { Title = " جملة المعاملات", Values = new ChartValues<int> { profile.GetCustomerTotalAmount(customerId) }, DataLabels = true });
            series.Add(new PieSeries() { Title = "اجمالي الدفعيات", Values = new ChartValues<int> { profile.GetCustomerPaidAmount(customerId) }, DataLabels = true });
            series.Add(new PieSeries() { Title = "اجمالي الاستحفافات", Values = new ChartValues<int> { profile.GetCustomerRemainingAmount(customerId) }, DataLabels = true });

            pieChart1.Series = series;


            ///////////////////////////////////////////////////Customer Counter///////////////////////////////////////////////////////////////////////////////////////////
            txtTotalInvoices.Text = profile.GetCustomerTotalInvoices(customerId).ToString();
            txtTotalAmount.Text = profile.GetCustomerTotalAmount(customerId).ToString("C");
            txtPaid.Text = profile.GetCustomerPaidAmount(customerId).ToString("C");
            txtRemainAmount.Text = profile.GetCustomerRemainingAmount(customerId).ToString("C");


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtInvoiceSearch_TextChanged(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = profile.GetCustomerInvoices(customerId, txtInvoiceSearch.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            FRM_OrderDetails frm = new FRM_OrderDetails(Convert.ToInt32(this.dgvInvoices.CurrentRow.Cells[0].Value.ToString()));
            frm.groupBox1.Visible = false;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Order_Installment frm = new FRM_Order_Installment(Convert.ToInt32(this.dgvInvoices.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
        }

        private void FRM_Customer_Profile_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void txtReturnSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReturnInvoices.DataSource = profile.GetCustomerReturnOrder(customerId, txtReturnSearch.Text);
        }

        private void btnSaleInvoice_Click(object sender, EventArgs e)
        {
            if (dgvReturnInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            int orderId = Convert.ToInt32(this.dgvReturnInvoices.CurrentRow.Cells[2].Value);
            FRM_Order_Return_Items frm = new FRM_Order_Return_Items(orderId);
            frm.ShowDialog();
        }

        private void FRM_Customer_Profile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
