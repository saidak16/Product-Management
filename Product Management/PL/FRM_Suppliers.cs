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
    public partial class FRM_Suppliers : Form
    {
        CLS_Suppliers supplier = new CLS_Suppliers();

        public FRM_Suppliers()
        {
            InitializeComponent();

            dataGridView1.DataSource = supplier.GetAllSuppliers();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_Supplier frm = new FRM_Add_Supplier();
            frm.ShowDialog();
        }
    }
}
