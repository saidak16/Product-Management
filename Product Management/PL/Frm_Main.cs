using Product_Management.BL;
using Product_Management.RPT;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
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

        public void StartForm()
        {
            Application.Run(new FRM_SplashScreen());
        }

        public Frm_Main()
        {
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();
            //Thread.Sleep(2000);
          
            InitializeComponent();
            //t.Abort();

            if (frm == null)
                frm = this;

            //this.المستخدمينToolStripMenuItem.Enabled = false;
            //this.المنتجاتToolStripMenuItem.Enabled = false;
            //this.المبيعاتToolStripMenuItem.Enabled = false;
            //this.العملاءToolStripMenuItem.Enabled = false;
            //this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            //this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            //this.الخروجToolStripMenuItem.Enabled = false;
            //this.الموردينToolStripMenuItem.Enabled = false;
            //this.الاعداداتToolStripMenuItem.Enabled = false;
            //this.المنصرفاتToolStripMenuItem.Enabled = false;
            //this.المشترياتToolStripMenuItem.Enabled = false;
            //this.التقاريرToolStripMenuItem.Enabled = false;
            //this.مناديبالمبيعاتToolStripMenuItem.Enabled = false;
            //this.toolStripMenuItem1.Enabled = false;
            //this.toolStripMenuItem3.Enabled = false;

            DataTable dt = new DataTable();
            dt = _Stock.GetStockStatuse();

            if(dt.Rows.Count > 0)
            {
                this.lblStock.Visible = true;
                this.lblStock.BackColor = Color.Yellow;
                this.lblStock.Text = " المخزون : " + dt.Rows.Count.ToString();
                picStock.Visible = true;
                SystemSounds.Asterisk.Play();
                
            }

            DataTable dt2 = new DataTable();
            dt2 = _Stock.GetExpDateStore();

            if (dt2.Rows.Count > 0)
            {
                this.lblExpDate.Visible = true;
                this.lblExpDate.BackColor = Color.Red;
                this.lblExpDate.Text = " التوالف : " + dt2.Rows.Count.ToString();
                picExpDate.Visible = true;
                SystemSounds.Asterisk.Play();

            }
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.الموردينToolStripMenuItem.Enabled = false;
            this.الاعداداتToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Visible = true;
            this.المستخدمينToolStripMenuItem.Visible = true;
            this.المنتجاتToolStripMenuItem.Visible = true;
            this.المبيعاتToolStripMenuItem.Visible = true;
            this.العملاءToolStripMenuItem.Visible = true;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Visible = true;
            //this.toolStripMenuItem1.Visible = false;
            //this.toolStripMenuItem3.Visible = false;
            this.المشترياتToolStripMenuItem.Enabled = false;
            this.التقاريرToolStripMenuItem.Enabled = false;
            this.المنصرفاتToolStripMenuItem.Enabled = false;
            this.مناديبالمبيعاتToolStripMenuItem.Enabled = false;
            this.lblUser.Visible = false;
            this.picUser.Visible = false;

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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Expiry_Date exp = new Frm_Expiry_Date();
            exp.ShowDialog();
        }

        private void اضافةموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_Supplier sup = new FRM_Add_Supplier();
            sup.ShowDialog();
        }

        private void الموردينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Suppliers fRM_Suppliers = new FRM_Suppliers();
            fRM_Suppliers.ShowDialog();
        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_About frm = new FRM_About();
            frm.ShowDialog(this);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void تنبيهالمخزونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_System_Alerts frm = new FRM_System_Alerts();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void المشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةعمليةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_MultiPurchase frm = new FRM_Add_MultiPurchase();
            //FRM_Add_Purchases frm = new FRM_Add_Purchases();
            frm.ShowDialog();
        }

        private void ادارةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Purchases frm = new FRM_Purchases();
            frm.ShowDialog();
        }

        private void مستحقاتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Suppliers_Receivables frm = new FRM_Suppliers_Receivables();
            frm.ShowDialog();
        }

        private void قائمةالاسعارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Price_List frm = new FRM_Price_List();
            frm.ShowDialog();
        }

        private void استخراجفاتورةمبدئيةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Proforma_Invoice frm = new FRM_Proforma_Invoice();
            frm.ShowDialog();
        }

        private void ادارةالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ProformaInvoice_List frm = new FRM_ProformaInvoice_List();
            frm.ShowDialog();
        }

        private void اضافةمنصرفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_Expensess frm = new FRM_Add_Expensess();
            frm.ShowDialog();
        }

        private void ادارةالمنصرفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Expensess frm = new FRM_Expensess();
            frm.ShowDialog();
        }

        private void مستحقاتالموردينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rpt_Suppliers_Receivables myrpt = new rpt_Suppliers_Receivables();
            FRM_Single_Product myfrm = new FRM_Single_Product();
            myrpt.Refresh();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }

        private void مطلوباتالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpt_CustomersLiabilities myrpt = new rpt_CustomersLiabilities();
            FRM_Single_Product myfrm = new FRM_Single_Product();
            myrpt.Refresh();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }

        private void مطلوباتالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Customers_Liabilities frm = new FRM_Customers_Liabilities();
            frm.ShowDialog();
        }

        private void الموقفالماليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_FinancialPosition frm = new FRM_FinancialPosition();
            frm.ShowDialog();
        }

        private void اضافةمندوبجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_SalesRepresentative frm = new FRM_Add_SalesRepresentative();
            frm.ShowDialog();
        }

        private void ادارةالمناديبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Sales_Representative frm = new FRM_Sales_Representative();
            frm.ShowDialog();
        }

        private void نسبمناديبالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SalesRepresentativePercentage frm = new FRM_SalesRepresentativePercentage();
            frm.ShowDialog();
        }

        private void جردعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ٍStockStatus frm = new FRM_ٍStockStatus();
            frm.ShowDialog();
        }

        private void جردمفصلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
        }

        private void تقريرالمنصرفانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpt_Expensess myrpt = new rpt_Expensess();
            FRM_Single_Product myfrm = new FRM_Single_Product();
            myrpt.Refresh();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }

        private void حركةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_MovementOfItems frm = new FRM_MovementOfItems();
            frm.ShowDialog();
        }

        private void تسعيرالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ProductPriceList frm = new FRM_ProductPriceList();
            frm.ShowDialog();
        }

        private void picSales_Click(object sender, EventArgs e)
        {
            Frm_ORDERS frm = new Frm_ORDERS();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Frm_ORDERS frm = new Frm_ORDERS();
            frm.ShowDialog();
        }

        private void picPurchase_Click(object sender, EventArgs e)
        {
            FRM_Add_MultiPurchase frm = new FRM_Add_MultiPurchase();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FRM_Add_MultiPurchase frm = new FRM_Add_MultiPurchase();
            frm.ShowDialog();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picContact_Click(object sender, EventArgs e)
        {
            FRM_Contact frm = new FRM_Contact();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FRM_Contact frm = new FRM_Contact();
            frm.ShowDialog();
        }

        private void picStock_Click(object sender, EventArgs e)
        {
            FRM_Stock frm = new FRM_Stock();
            frm.ShowDialog();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            FRM_Stock frm = new FRM_Stock();
            frm.ShowDialog();
        }

        private void picExpDate_Click(object sender, EventArgs e)
        {
            Frm_Expiry_Date frm = new Frm_Expiry_Date();
            frm.ShowDialog();
        }

        private void lblExpDate_Click(object sender, EventArgs e)
        {
            Frm_Expiry_Date frm = new Frm_Expiry_Date();
            frm.ShowDialog();
        }

        private void قائمةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Suppliers_List frm = new FRM_Suppliers_List();
            frm.ShowDialog();
        }

        private void قائمةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Customers_List frm = new FRM_Customers_List();
            frm.ShowDialog();
        }
    }
}
