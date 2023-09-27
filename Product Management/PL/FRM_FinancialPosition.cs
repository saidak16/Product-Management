using LiveCharts;
using LiveCharts.WinForms;
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
    public partial class FRM_FinancialPosition : Form
    {
        CLS_Dashboard dashboard = new CLS_Dashboard();

        public FRM_FinancialPosition()
        {
            InitializeComponent();

            var Financial = dashboard.FinancialPosition();
            
            txtExp.Text = Financial.TotalExp.ToString();
            txtPur.Text = Financial.TotalPur.ToString();
            txtSeal.Text = Financial.TotalSeals.ToString();
            txtSup.Text = Financial.TotalSuplierRemainingAmount.ToString();
            txtCust.Text = Financial.TotalCustomerRemainingAmount.ToString();
            try
            {

                SeriesCollection series = new SeriesCollection();

                series.Add(new PieSeries() { Title = "اجمالي المنصرفات", Values = new ChartValues<int> { Convert.ToInt32(txtExp.Text) }, DataLabels = true });
                series.Add(new PieSeries() { Title = "اجمالي المشتريات", Values = new ChartValues<int> { Convert.ToInt32(txtPur.Text) }, DataLabels = true });
                series.Add(new PieSeries() { Title = "اجمالي المبيعات", Values = new ChartValues<int> { Convert.ToInt32(txtSeal.Text) }, DataLabels = true });

                pieChart1.Series = series;

                SeriesCollection series2 = new SeriesCollection();

                series2.Add(new PieSeries() { Title = "اجمالي استحقاقات الوردين", Values = new ChartValues<int> { Convert.ToInt32(txtSup.Text) }, DataLabels = true });
                series2.Add(new PieSeries() { Title = "اجمالي مطلوبات العملاء", Values = new ChartValues<int> { Convert.ToInt32(txtCust.Text) }, DataLabels = true });

                pieChart2.Series = series2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
