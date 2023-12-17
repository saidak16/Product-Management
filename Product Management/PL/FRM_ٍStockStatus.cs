﻿using Product_Management.BL;
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
    public partial class FRM_ٍStockStatus : Form
    {
        CLS_Reporting reporting = new CLS_Reporting();
        CLS_Stock stock = new CLS_Stock();

        public FRM_ٍStockStatus()
        {
            InitializeComponent();

            dataGridView1.DataSource = reporting.GetStockStatus("");
            txtItemsCount.Text = stock.GetTotalStockCount().ToString();

            //var foundRows = this.dataGridView1.Rows.Cast<DataGridViewRow>();

            //var finishedItems = foundRows.Where(row => Convert.ToInt32(row.Cells[2].Value) == 0);
            //var avilableItems = foundRows.Where(row => Convert.ToInt32(row.Cells[2].Value) > 0);

            txtAvilableItems.Text = stock.GetAvilableStockCount().ToString(); //avilableItems.Count().ToString();
            txtFinishedItems.Text = stock.GetEndStockCount().ToString(); //finishedItems.Count().ToString();

            //txtStockValue.Text = reporting.GetStockValue();
            txtStockValue.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[4].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString("N");
        }

        private void FRM_ٍStockStatus_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_ٍStockStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnPrint_Click(sender, e);
            }
            
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reporting.GetStockStatus(txtSearch.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            RPT.rpt_StockStatus rep = new RPT.rpt_StockStatus();
            dt = reporting.GetStockStatusRpt();
            rep.SetDataSource(dt);
            RPT.FRM_Single_Product frm = new RPT.FRM_Single_Product();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }
    }
}
