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
    public partial class FRM_CUST_LIST : Form
    {
        BL.CLS_Customers cust = new BL.CLS_Customers();
        public FRM_CUST_LIST()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.Select_Customers();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cust.Search_Customers(txtID.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
    }
}
