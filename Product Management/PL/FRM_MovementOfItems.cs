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
    public partial class FRM_MovementOfItems : Form
    {
        CLS_Reporting reporting = new CLS_Reporting();

        public FRM_MovementOfItems()
        {
            InitializeComponent();

            dataGridView1.DataSource = reporting.GetMovementOfItems("");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reporting.GetMovementOfItems(txtID.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_MovementOfItemsDetails frm = new FRM_MovementOfItemsDetails(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
        }

        private void FRM_MovementOfItems_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_MovementOfItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
