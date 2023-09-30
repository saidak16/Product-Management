using Product_Management.BL;
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
    public partial class FRM_SupList : Form
    {
        CLS_Suppliers suppliers = new CLS_Suppliers();

        public FRM_SupList()
        {
            InitializeComponent();
            dataGridView1.DataSource = suppliers.GetSupList("");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = suppliers.GetSupList(txtID.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
