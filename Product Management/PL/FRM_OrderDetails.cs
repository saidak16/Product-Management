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
    public partial class FRM_OrderDetails : Form
    {
        CLS_ORDERS orders = new CLS_ORDERS();

        public FRM_OrderDetails(int orderId)
        {
            InitializeComponent();

            dataGridView1.DataSource = orders.GetOrderDetails("", orderId);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.DataSource = orders.GetOrderDetails(txtID.Text, Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            }
            else
            {
                MessageBox.Show("لا يوجد عناصر", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("هل تريد استرجاع العنصر المحدد ؟؟", "عملية قيد عكسي", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var isValid = orders.DeleteOrderDetails(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value.ToString()));

                    if (isValid)
                    {
                        MessageBox.Show("تمت العملية بنجاح", "عملية قيد عكسي", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = orders.GetOrderDetails("", Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء العملية", "عملية قيد عكسي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("تم إلغاء العملية", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد عناصر", "");
            }
        }
    }
}
