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
    public partial class FRM_Sales_Representative : Form
    {
        private static FRM_Sales_Representative frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Sales_Representative getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Sales_Representative();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

        CLS_Sales_Representative representative = new CLS_Sales_Representative();

        public FRM_Sales_Representative()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            DGV();
        }

        public void DGV()
        {
            this.dataGridView1.DataSource = representative.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_Add_SalesRepresentative frm = new FRM_Add_SalesRepresentative();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = representative.Search(txtID.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المندوب المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                representative.Delete(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Clear();
                DGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_SalesRepresentative frm = new FRM_Add_SalesRepresentative();
            frm.Text = "تحديث بيانات المندوب";
            frm.txtId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtAddress.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtPercentageOfSales.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.btnAdd.Text = "تحديث";
            frm.Flag = "Update";

            frm.ShowDialog();
        }
    }
}
