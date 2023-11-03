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
    public partial class FRM_Customer_Profile : Form
    {
        int customerId = 0;
        CLS_Customer_Profile profile = new CLS_Customer_Profile();

        public FRM_Customer_Profile(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;

            ///////////////////////////////////////////////Customer Info///////////////////////////////////////////////////////////////////
            DataTable dt = new DataTable();
            dt = profile.GetCustomerInfo(customerId);

            txtName.Text = dt.Rows[0]["customerName"].ToString();
            txtPhone.Text = dt.Rows[0]["TEL"].ToString();
            txtEmail.Text = dt.Rows[0]["E_Mail"].ToString();
            txtCreationDate.Text = Convert.ToDateTime(dt.Rows[0]["Creation_Date"]).ToShortDateString();
            txtLastOrder.Text = Convert.ToDateTime(dt.Rows[0]["LastOrder"]).ToShortDateString();
        }
    }
}
