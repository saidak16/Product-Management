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
            DGV();
        }

        void DGV()
        {
            this.dataGridView1.DataSource = representativePercentage.GetAll();
        }

        private void FRM_SalesRepresentativePercentage_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_SalesRepresentativePercentage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
