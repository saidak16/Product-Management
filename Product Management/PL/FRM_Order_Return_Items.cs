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
    }
}
