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
            this.dataGridView1.DataSource = prd.Get_Pro();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
