using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Product_Management.PL
{
    public partial class FRM_Add_User : Form
    {
        BL.CLS_USERS user = new BL.CLS_USERS();
        public FRM_Add_User()
        {
            InitializeComponent();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (btnADD.Text == "اضافة المستخدم (F2)")
            {
                if (txtPWD.Text != txtPWDConfairm.Text)
                {
                    MessageBox.Show("كلمات المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPWD.Focus();
                    return;
                }
                user.ADD_User(txtID.Text, txtFullName.Text, txtPWD.Text, cmdRole.Text);
                MessageBox.Show("تم اضافة المستخدم بنجاح", "اضافة مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnADD.Text == "تعديل المستخدم (F2)")
            {
                if (txtPWD.Text != txtPWDConfairm.Text)
                {
                    MessageBox.Show("كلمات المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPWD.Focus();
                    return;
                }
                user.EditUser(txtID.Text, txtFullName.Text, txtPWD.Text, cmdRole.Text);
                PL.FRM_User_List frm = new FRM_User_List();
                MessageBox.Show("تم تعديل المستخدم بنجاح", "تعديل المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtID.Clear();
            txtPWD.Clear();
            txtPWDConfairm.Clear();
            txtFullName.Clear();
            txtID.Focus();
        }

        private void txtPWDConfairm_Validated(object sender, EventArgs e)
        {
             if (txtPWD.Text != txtPWDConfairm.Text)
            {
                MessageBox.Show("كلمات المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPWD.Focus();
                return;
            }
        }

        private void FRM_Add_User_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Add_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnADD_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
