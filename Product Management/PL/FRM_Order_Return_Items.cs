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
    public partial class FRM_Order_Return_Items : Form
    {
        CLS_Customer_Profile profile = new CLS_Customer_Profile();

        public FRM_Order_Return_Items(int orderId)
        {
            InitializeComponent();

            dataGridView1.DataSource = profile.GetOrderReturnItems(orderId);
            this.Text = "الاصناف المرتجعة : " + dataGridView1.Rows.Count.ToString();
        }

        private void FRM_Order_Return_Items_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Order_Return_Items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
