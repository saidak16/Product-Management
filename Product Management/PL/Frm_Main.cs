using Product_Management.BL;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Product_Management.PL
{
    public partial class Frm_Main : Form
    {
        private static Frm_Main frm;
        CLS_Stock _Stock = new CLS_Stock();
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Frm_Main getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            
            }
        }

        public Frm_Main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.الخروجToolStripMenuItem.Enabled = false;
            this.toolStripMenuItem1.Visible = false;

            DataTable dt = new DataTable();
            dt = _Stock.GetStockStatuse();

            if(dt.Rows.Count > 0)
            {
                this.toolStripMenuItem1.Visible = true;
                this.toolStripMenuItem1.BackColor = Color.Yellow;
                this.toolStripMenuItem1.Text = "تنبيه المخزون : " + dt.Rows.Count.ToString();
                SystemSounds.Asterisk.Play();
                
            }
            else
            {
                this.toolStripMenuItem1.Visible = false;
            }
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.toolStripMenuItem1.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Visible = true;
            this.المستخدمينToolStripMenuItem.Visible = true;
            this.المنتجاتToolStripMenuItem.Visible = true;
            this.المبيعاتToolStripMenuItem.Visible = true;
            this.العملاءToolStripMenuItem.Visible = true;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Visible = true;
           
            
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Product frm = new Frm_Add_Product();
            frm.ShowDialog();
        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Products frm = new Frm_Products();
            frm.ShowDialog();
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Categories frm = new FRM_Categories();
            frm.ShowDialog();
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Customers frm = new Frm_Customers();
            frm.ShowDialog();
        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Orders_List frm = new FRM_Orders_List();
            frm.ShowDialog();
        }

        private void اضافةعمليةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ORDERS frm = new Frm_ORDERS();
            frm.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_User frm = new FRM_Add_User();
            frm.ShowDialog();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_User_List frm = new FRM_User_List();
            frm.ShowDialog();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORE frm = new FRM_RESTORE();
            frm.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CHECK frm = new FRM_CHECK();
            frm.ShowDialog();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Stock stock = new FRM_Stock();
            stock.ShowDialog();
        }
    }
}
