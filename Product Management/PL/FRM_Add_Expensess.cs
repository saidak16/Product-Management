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
    public partial class FRM_Add_Expensess : Form
    {
        CLS_Expensess expensess = new CLS_Expensess();
        public string Flag = "Add";

        public FRM_Add_Expensess()
        {
            InitializeComponent();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtAmount.Text) <= 0)
            {
                MessageBox.Show(" يجب ادخال مبلغ صحيح ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }

            if(Flag == "Add")
            {
                Expensess exp = new Expensess()
                {
                    Id = 0,
                    Amount = Convert.ToDouble(txtAmount.Text),
                    DateOfExpense = dateTimePicker1.Value,
                    Discription = txtDiscription.Text
                };

                var isValid = expensess.AddExpensess(exp);

                if (isValid)
                {
                    MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("لم تتم الاضافة ", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Expensess exp = new Expensess()
                {
                    Id = Convert.ToInt32(lblID.Text),
                    Amount = Convert.ToDouble(txtAmount.Text),
                    DateOfExpense = dateTimePicker1.Value,
                    Discription = txtDiscription.Text
                };

                var isValid = expensess.EditExpensess(exp);

                if (isValid)
                {
                    MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            FRM_Expensess.getMain.DGV();
        }

        private void Clear()
        {
            txtAmount.Text = "0";
            txtDiscription.Clear();
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void FRM_Add_Expensess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnAdd_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void FRM_Add_Expensess_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }
    }
}
