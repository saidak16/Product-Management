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

        public FRM_ٍStockStatus()
        {
            InitializeComponent();

            dataGridView1.DataSource = reporting.GetStockStatus("");
        }

        private void FRM_ٍStockStatus_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_ٍStockStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reporting.GetStockStatus(txtSearch.Text);
        }
    }
}
