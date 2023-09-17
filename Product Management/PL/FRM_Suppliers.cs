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
        private static FRM_Suppliers frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Suppliers getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Suppliers();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Add_Supplier frm = new FRM_Add_Supplier();
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtCompany.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.btnAdd.Text = "تحديث البيانات";
            frm.Text = "تحديث بيانات المورد";
            frm.Flag = "Update";

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المورج المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                supplier.DeleteSupplier(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DGV();
            }
            else
            {
                MessageBox.Show("تم إلغاء العملية", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DGV()
        {
            dataGridView1.DataSource = supplier.GetAllSuppliers();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = supplier.GetAllSuppliers(txtID.Text);
        }
    }
}
