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
using System.Windows.Forms.DataVisualization.Charting;

namespace Product_Management.PL
{
    public partial class FRM_Dashboard : Form
    {
        CLS_Dashboard dashboard = new CLS_Dashboard();

        public FRM_Dashboard()
        {
            InitializeComponent();

            fillChart();
            dgvTopSale.DataSource = dashboard.GetTopSaleItems();
            dgvTopPurchaseItems.DataSource = dashboard.GetTopPurchaseItems();
            dgvTopCustomers.DataSource = dashboard.GetTopCustomers();

            /////////////////////////////////////Dashboard chart/////////////////////////////////////
            LiveCharts.SeriesCollection seriesSales = new LiveCharts.SeriesCollection();
            LiveCharts.SeriesCollection seriesPurchase = new LiveCharts.SeriesCollection();

            DataTable dtSales = new DataTable();
            DataTable dtPurchase = new DataTable();

            dtSales = dashboard.GetPieChartSales();
            dtPurchase = dashboard.GetPieChartPurchase();

            seriesSales.Add(new PieSeries() { Title = "اجمالي المدفوعات", Values = new ChartValues<int> { Convert.ToInt32(dtSales.Rows[0][0]) }, DataLabels = true });
            seriesSales.Add(new PieSeries() { Title = " اجمالي المستحقات", Values = new ChartValues<int> { Convert.ToInt32(dtSales.Rows[0][1]) }, DataLabels = true });

            seriesPurchase.Add(new PieSeries() { Title = "اجمالي المدفوعات", Values = new ChartValues<int> { Convert.ToInt32(dtPurchase.Rows[0][0]) }, DataLabels = true });
            seriesPurchase.Add(new PieSeries() { Title = "اجمالي المستحقات", Values = new ChartValues<int> { Convert.ToInt32(dtPurchase.Rows[0][1]) }, DataLabels = true });

            pieChartSales.Series = seriesSales;
            pieChartPurchase.Series = seriesPurchase;


        }

        private void fillChart()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            dt = dashboard.GetsalesChars();
            dt2 = dashboard.PurchaseChars();

            //AddXY value in chart1 in series named as Salary  
            foreach (DataRow dr in dt.Rows)
            {
                chart1.Series["المبيعات"].Points.AddXY(dr["Month"], dr["TotaleSales"]);
            }

            foreach (DataRow dr in dt2.Rows)
            {
                chart1.Series["المشتريات"].Points.AddXY(dr["Month"], dr["TotalePurchase"]);
            }

            //chart1.Series["المبيعات"].ChartType = SeriesChartType.FastLine;
            //chart1.Series["المشتريات"].ChartType = SeriesChartType.FastLine;
            //chart1.Series["المبيعات"].ChartType = SeriesChartType.Bar;
            //chart1.Series["المشتريات"].ChartType = SeriesChartType.Bar;

            //chart title  
            chart1.Titles.Add(" حجم المبيعات و المشتريات الشهرية");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_FinancialPosition frm = new FRM_FinancialPosition();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_MovementOfItems frm = new FRM_MovementOfItems();
            frm.ShowDialog();
        }
    }
}
