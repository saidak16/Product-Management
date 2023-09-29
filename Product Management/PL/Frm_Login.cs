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
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), "نظام ادارة الاعمال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المنصرفاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المشترياتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.التقاريرToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.مناديبالمبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.toolStripMenuItem1.Enabled = true;
                    Frm_Main.getMain.toolStripMenuItem3.Enabled = true;
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;

                }
                else if (dt.Rows[0][2].ToString() == "Store Manager")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), "نظام ادارة الاعمال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
                }
                else if (dt.Rows[0][2].ToString() == "Storekeeper")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), "نظام ادارة الاعمال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
                }
                else if (dt.Rows[0][2].ToString() == "Sales Officer")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), "نظام ادارة الاعمال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.استعادةنسخةمحفوظةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Frm_Main.getMain.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Frm_Main.getMain.الخروجToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
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
