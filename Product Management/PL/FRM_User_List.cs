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
    public partial class FRM_User_List : Form
    {
        BL.CLS_USERS user = new BL.CLS_USERS();
        public FRM_User_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = user.Select_Users("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FRM_Add_User frm = new FRM_Add_User();
            frm.btnADD.Text = "اضافة المستخدم";
            frm.ShowDialog();
            dataGridView1.DataSource = user.Select_Users("");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = user.Select_Users(txtID.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Add_User frm = new FRM_Add_User();
            frm.btnADD.Text = "تعديل المستخدم";
            frm.Text = "تعديل بيانات المستخدم";
            frm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtFullName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPWD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPWDConfairm.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.cmdRole.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
            dataGridView1.DataSource = user.Select_Users("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف بيانات المستخدم المحدد ؟؟", "حذف بيانات المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                user.Delete_User(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم حذف المستخدم المحدد بنجاح", "حذف المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = user.Select_Users("");
            }
        }
    }
}
