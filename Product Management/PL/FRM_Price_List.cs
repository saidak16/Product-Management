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
    public partial class FRM_Price_List : Form
    {
        CLS_Reporting reporting = new CLS_Reporting();

        public FRM_Price_List()
        {
            InitializeComponent();
            dgvPriceList.DataSource = reporting.GetPriceList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dgvPriceList.DataSource = reporting.SearchPriceList(txtID.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rpt_Price_List myrpt = new rpt_Price_List();
            FRM_Single_Product myfrm = new FRM_Single_Product();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }
    }
}