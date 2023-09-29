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
    public partial class FRM_SalesRepresentative_List : Form
    {
        CLS_Sales_Representative sales_Representative = new CLS_Sales_Representative();

        public FRM_SalesRepresentative_List()
        {
            InitializeComponent();

            dataGridView1.DataSource = sales_Representative.GetAll();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sales_Representative.Search(txtID.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}