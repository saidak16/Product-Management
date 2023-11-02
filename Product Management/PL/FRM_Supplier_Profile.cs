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
    public partial class FRM_Supplier_Profile : Form
    {
        CLS_Supplier_Profile profile = new CLS_Supplier_Profile();
        int supId = 0;

        public FRM_Supplier_Profile(int supplierId)
        {
            InitializeComponent();

            supId = supplierId;


            //////////////////////////////////////////////Supplier Info//////////////////////////////////////////////////////////////////
            DataTable dt = profile.GetSupplierById(supId);

            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtCompany.Text = dt.Rows[0]["CompanyName"].ToString();
            txtCreationDate.Text = Convert.ToDateTime(dt.Rows[0]["CreationDate"]).ToShortDateString();
            txtLastOrder.Text = Convert.ToDateTime(dt.Rows[0]["LastOrder"]).ToShortDateString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Supplier_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_SuppliersReceivables_Details frm = new FRM_SuppliersReceivables_Details(supId);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Supplier_Products frm = new FRM_Supplier_Products(supId);
            frm.ShowDialog();
        }
    }
}
