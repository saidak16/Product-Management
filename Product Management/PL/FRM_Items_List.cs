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
    public partial class FRM_Items_List : Form
    {
        CLS_Products products = new CLS_Products();

        public FRM_Items_List()
        {
            InitializeComponent();

            dgvItemsList.DataSource = products.GetItemsList("");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dgvItemsList.DataSource = products.GetItemsList(txtID.Text);
        }

        private void dgvItemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItemsList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
