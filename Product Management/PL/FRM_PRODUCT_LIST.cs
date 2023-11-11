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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_Products prd = new BL.CLS_Products();
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GetProductsList();


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = prd.Search_Product(txtID.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_PRODUCT_LIST_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_PRODUCT_LIST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
