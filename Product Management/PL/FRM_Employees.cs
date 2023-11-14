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
    public partial class FRM_Employees : Form
    {
        CLS_Employee employee = new CLS_Employee();

        public FRM_Employees()
        {
            InitializeComponent();

            DGV();
        }

        void DGV()
        {
            dgvEmployee.DataSource = employee.GetAllEmployees("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_Employee frm = new FRM_Add_Employee();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            FRM_Add_Employee frm = new FRM_Add_Employee();
            frm.Text = "تعديل بيانات الموظف";
            frm.btnAdd.Text = "تحديث";
            frm.Flag = "Update";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عناصر");
                return;
            }

            if (MessageBox.Show("هل تريد حذف الموظف المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DGV();
            }
            else
            {
                MessageBox.Show("تم إلغاء العملية", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Employees_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = employee.GetAllEmployees(txtSearch.Text);
        }

        private void FRM_Employees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {
                button2_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                button3_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
