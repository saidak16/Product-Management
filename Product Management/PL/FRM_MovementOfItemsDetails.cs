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
    public partial class FRM_MovementOfItemsDetails : Form
    {
        CLS_Reporting reporting = new CLS_Reporting();

        public FRM_MovementOfItemsDetails(int productId)
        {
            InitializeComponent();

            dataGridView1.DataSource = reporting.GetMovementOfItemsDetails(productId);
        }
    }
}
