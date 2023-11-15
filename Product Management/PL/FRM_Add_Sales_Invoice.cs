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
    public partial class FRM_Add_Sales_Invoice : Form
    {
        CLS_Stock stock = new CLS_Stock();

        public FRM_Add_Sales_Invoice()
        {
            InitializeComponent();

            //////////////////////////////////////////Load Items Data/////////////////////////////////////////////////////
            cmbItems.DataSource = stock.GetItems("");
            cmbItems.DisplayMember = "Product_Name";
            cmbItems.ValueMember = "ItemId";
            cmbItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbItems.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void FRM_Add_Sales_Invoice_Load(object sender, EventArgs e)
        {

        }
    }
}
