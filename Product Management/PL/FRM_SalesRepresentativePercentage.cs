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
    public partial class FRM_SalesRepresentativePercentage : Form
    {
        CLS_SalesRepresentativePercentage representativePercentage = new CLS_SalesRepresentativePercentage();

        public FRM_SalesRepresentativePercentage()
        {
            InitializeComponent();
        }

        void DGV()
        {
            this.dataGridView1.DataSource = representativePercentage.GetAll();
        }
    }
}
