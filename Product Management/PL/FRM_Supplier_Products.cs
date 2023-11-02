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
    public partial class FRM_Supplier_Products : Form
    {
        CLS_Supplier_Profile profile = new CLS_Supplier_Profile();

        public FRM_Supplier_Products(int supplierId)
        {
            InitializeComponent();

            dgvSupplierProducts.DataSource = profile.GetSupplierProducts(supplierId);

            this.Text = "اصناف المورد : " + dgvSupplierProducts.Rows.Count.ToString();
        }
    }
}