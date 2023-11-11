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
    public partial class FRM_Supplier_Products : Form
    {
        CLS_Supplier_Profile profile = new CLS_Supplier_Profile();

        public FRM_Supplier_Products(int supplierId)
        {
            InitializeComponent();

            dgvSupplierProducts.DataSource = profile.GetSupplierProducts(supplierId);

            this.Text = "اصناف المورد : " + dgvSupplierProducts.Rows.Count.ToString();
        }

        private void FRM_Supplier_Products_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Supplier_Products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
