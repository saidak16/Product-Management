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
    public partial class FRM_Expensess : Form
    {
        private static FRM_Expensess frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Expensess getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Expensess();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

        CLS_Expensess expensess = new CLS_Expensess();

        public FRM_Expensess()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            DGV();
        }

        public void DGV()
        {
            dataGridView1.DataSource = expensess.GetAllExpensess();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = expensess.SearchExpensess(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_Add_Expensess frm = new FRM_Add_Expensess();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FRM_Add_Expensess frm = new FRM_Add_Expensess();
            frm.Flag = "Update";
            frm.btnAdd.Text = "تحديث";
            frm.lblID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDiscription.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtAmount.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنصرف المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                expensess.DeleteExpensess(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DGV();
            }
            else
            {
                MessageBox.Show("تم إلغاء العملية", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
