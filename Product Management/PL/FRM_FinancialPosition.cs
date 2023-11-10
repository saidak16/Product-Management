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

            try
            {
                var Financial = dashboard.FinancialPosition();

                if (Financial != null)
                {

                    txtExp.Text = Convert.ToInt32(Financial.TotalExp).ToString("C");
                    txtPur.Text = Convert.ToInt32(Financial.TotalPur).ToString("C");
                    txtSeal.Text = Convert.ToInt32(Financial.TotalSeals).ToString("C");
                    txtSup.Text = Convert.ToInt32(Financial.TotalSuplierRemainingAmount).ToString("C");
                    txtCust.Text = Convert.ToInt32(Financial.TotalCustomerRemainingAmount).ToString("C");

                    string sale, exp, pur,sup,cust;
                    sale = Convert.ToInt32(Financial.TotalSeals).ToString();
                    exp = Convert.ToInt32(Financial.TotalExp).ToString();
                    pur = Convert.ToInt32(Financial.TotalPur).ToString();
                    sup = Convert.ToInt32(Financial.TotalSuplierRemainingAmount).ToString();
                    cust = Convert.ToInt32(Financial.TotalCustomerRemainingAmount).ToString();

                    txtProfit.Text = (Convert.ToInt32(sale) - (Convert.ToInt32(exp) + Convert.ToInt32(pur))).ToString("C");

                    try
                    {

                        SeriesCollection series = new SeriesCollection();

                        series.Add(new PieSeries() { Title = "اجمالي المنصرفات", Values = new ChartValues<int> { Convert.ToInt32(exp) }, DataLabels = true });
                        series.Add(new PieSeries() { Title = "اجمالي المشتريات", Values = new ChartValues<int> { Convert.ToInt32(pur) }, DataLabels = true });
                        series.Add(new PieSeries() { Title = "اجمالي المبيعات", Values = new ChartValues<int> { Convert.ToInt32(sale) }, DataLabels = true });

                        pieChart1.Series = series;

                        SeriesCollection series2 = new SeriesCollection();

                        series2.Add(new PieSeries() { Title = "اجمالي استحقاقات الوردين", Values = new ChartValues<int> { Convert.ToInt32(sup) }, DataLabels = true });
                        series2.Add(new PieSeries() { Title = "اجمالي مطلوبات العملاء", Values = new ChartValues<int> { Convert.ToInt32(cust) }, DataLabels = true });

                        pieChart2.Series = series2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("عذراً, لا توجد حركة مالية حتي الان", "الموقف المالي", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_FinancialPosition_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_FinancialPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
