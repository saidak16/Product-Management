using Product_Management.BL;
using Product_Management.Models;
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
    public partial class FRM_Add_SalesRepresentative : Form
    {
        CLS_Sales_Representative representative = new CLS_Sales_Representative();
        public string Flag = "Add";

        public FRM_Add_SalesRepresentative()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            txtAddress.Clear();
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Flag == "Add")
            {
                SalesRepresentative sales = new SalesRepresentative()
                {
                    Id = 0,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    PercentageOfSales = Convert.ToInt32(txtPercentageOfSales.Text)
                };

                bool isValid = representative.Add(sales);

                if (isValid)
                {
                    MessageBox.Show("تمت الاضافة بنجاح", "عملية اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SalesRepresentative sales = new SalesRepresentative()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    PercentageOfSales = Convert.ToInt32(txtPercentageOfSales.Text)
                };

                bool isValid = representative.Update(sales);

                if (isValid)
                {
                    MessageBox.Show("تمت العملية بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            FRM_Sales_Representative.getMain.DGV();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
