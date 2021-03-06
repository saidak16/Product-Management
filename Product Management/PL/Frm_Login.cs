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
    public partial class Frm_Login : Form
    {
        int Try;
        BL.ClS_Login lgn = new BL.ClS_Login();
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = true;
            Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = false;
            this.Close();
            Frm_Main.getMain.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            dt = lgn.LOGIN(txtID.Text , txtPWD.Text);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "Admin")
                {
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = true;
                }
                else if (dt.Rows[0][2].ToString() == "Store Manager")
                {
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                }
                else if (dt.Rows[0][2].ToString() == "Storekeeper")
                {
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                }
                else if (dt.Rows[0][2].ToString() == "Sales Officer")
                {
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                }
                this.Close();
            }
            else 
            {
                if (Try >= 3)
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور خطأ \n الرجاء المحاولة لاحقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Frm_Main.getMain.Close();
                }
                else
                {
                    MessageBox.Show("تحقق من اسم المستخدم او كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPWD.Clear();
                    txtID.Focus();
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
