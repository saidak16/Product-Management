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
    public partial class FRM_CHECK : Form
    {
        int Try;
        public FRM_CHECK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPWD.Text == "Admin123")
            {
                Frm_Main fr = new Frm_Main();
                FRM_CONFIG frm = new FRM_CONFIG();
                this.Hide();
                fr.Show();
                frm.ShowDialog();
            }
            else
            {
                if (Try >= 3)
                {
                    MessageBox.Show("محاولة دخول خاطئة لاعدادات السيرفر \n الرجاء التحقق من كلمة المرور المحاولة لاحقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("سيتم اغلاق البرنامج", "اغلاق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Frm_Main.getMain.Close();
                }
                else
                {
                    MessageBox.Show("تحقق من كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPWD.Clear();
                    txtPWD.Focus();
                }
                Try++;
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
