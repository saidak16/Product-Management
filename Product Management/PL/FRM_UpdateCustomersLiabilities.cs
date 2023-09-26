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
    public partial class FRM_UpdateCustomersLiabilities : Form
    {
        CLS_ORDERS order = new CLS_ORDERS();

        public FRM_UpdateCustomersLiabilities()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = order.UpdateCustomersLiabilities(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtAmount.Text));

                if (isValid)
                {
                    MessageBox.Show("تمت العملية بنجاح", "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FRM_Orders_List.getMain.dataGridView1.DataSource = order.Order_Del("");
                }
                else
                {
                    MessageBox.Show("لم تتم العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}