using Product_Management.BL;
using Product_Management.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management
{
    public partial class FRM_Customers_List : Form
    {
        CLS_Customers customers = new CLS_Customers();

        public FRM_Customers_List()
        {
            InitializeComponent();

            dataGridView1.DataSource = customers.GetCustomerList("");
        }

        private void FRM_Customers_List_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customers.GetCustomerList(txtSearch.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FRM_Customer_Profile frm = new FRM_Customer_Profile();
            frm.ShowDialog();
        }
    }
}
