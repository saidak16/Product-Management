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
    public partial class FRM_Return_Purchase_Details : Form
    {
        CLS_Supplier_Profile profile = new CLS_Supplier_Profile();

        public FRM_Return_Purchase_Details(int orderId)
        {
            InitializeComponent();

            dataGridView1.DataSource = profile.GetReturnPurchaseDetails(orderId);
        }

        private void FRM_Return_Purchase_Details_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Return_Purchase_Details_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
