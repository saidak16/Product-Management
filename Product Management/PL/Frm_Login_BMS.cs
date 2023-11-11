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
    public partial class Frm_Login_BMS : Form
    {
        int Try;
        BL.ClS_Login lgn = new BL.ClS_Login();

        public Frm_Login_BMS()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Main frm = new Frm_Main();
            DataTable dt = new DataTable();

            dt = lgn.LOGIN(txtID.Text, txtPWD.Text);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "Admin")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), "(V 2.0.1) نظام ادارة الاعمال ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Frm_Main.getMain.العملاءToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المنصرفاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.المشترياتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.التقاريرToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.مناديبالمبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
                    Frm_Main.getMain.ShowDialog();

                }
                else if (dt.Rows[0][2].ToString() == "Store Manager")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), " (V 2.0.1) نظام ادارة الاعمال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = true;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
                    Frm_Main.getMain.ShowDialog();
                }
                else if (dt.Rows[0][2].ToString() == "Storekeeper")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), " (V 2.0.1) نظام ادارة الاعمال ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
                    Frm_Main.getMain.ShowDialog();
                }
                else if (dt.Rows[0][2].ToString() == "Sales Officer")
                {
                    MessageBox.Show(" \n مرحباً بك يا:  " + dt.Rows[0]["FullName"].ToString(), "(V 2.0.1) نظام ادارة الاعمال ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Main.getMain.المبيعاتToolStripMenuItem.Enabled = true;
                    Frm_Main.getMain.الموردينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.العملاءToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المستخدمينToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.المنتجاتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.الاعداداتToolStripMenuItem.Visible = false;
                    Frm_Main.getMain.pictureBox1.Visible = true;
                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Text = dt.Rows[0]["FullName"].ToString();
                    Frm_Main.getMain.lblUser.Visible = true;
                    Frm_Main.getMain.picUser.Visible = true;
                    Frm_Main.getMain.ShowDialog();
                }
                this.Close();
            }
            else
            {
                if (Try >= 3)
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور خطأ \n الرجاء المحاولة لاحقاً", "نظام ادارة الاعمال (V 2.0.1)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    Frm_Main.getMain.Close();
                }
                else
                {
                    MessageBox.Show("تحقق من اسم المستخدم او كلمة المرور", "نظام ادارة الاعمال (V 2.0.1)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPWD.Clear();
                    txtID.Focus();
                }
                Try++;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
