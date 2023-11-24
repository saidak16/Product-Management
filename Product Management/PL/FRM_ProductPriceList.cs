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
    public partial class FRM_ProductPriceList : Form
    {
        private static FRM_ProductPriceList frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_ProductPriceList getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_ProductPriceList();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

        CLS_Purchases purchases = new CLS_Purchases();

        public FRM_ProductPriceList()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            DGV();
        }

        public void DGV()
        {
            dataGridView1.DataSource = purchases.GetProductPrice("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = purchases.GetProductPrice(txtID.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = purchases.GetProductPriceById(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                if (dt.Rows.Count > 0)
                {
                    FRM_ProductPrice frm = new FRM_ProductPrice();

                    frm.txtId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    frm.lblProductId.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    frm.txtProductName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    frm.txtSupName.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    frm.txtBatchNo.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    frm.txtPurPrice.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    frm.txtSealPrice.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_ProductPriceList_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_ProductPriceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                button1_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
