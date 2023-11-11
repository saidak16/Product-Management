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
    public partial class FRM_Stock : Form
    {
        CLS_Stock _Stock = new CLS_Stock();
        

        public FRM_Stock()
        {
            InitializeComponent();
            try
            {
                DataTable dt = new DataTable();
                dt = _Stock.GetStockStatuse();

                if (dt.Rows.Count > 0)
                {
                    this.dgvStock.DataSource = dt;
                    this.dgvStock.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
                    this.dgvStock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    var myBoldFont = new Font("Tahoma", 9.75F, FontStyle.Bold);
                    this.dgvStock.Columns[1].DefaultCellStyle.Font = myBoldFont;
                }
                else
                {
                    FRM_Stock frm = new FRM_Stock();
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void FRM_Stock_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Stock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
