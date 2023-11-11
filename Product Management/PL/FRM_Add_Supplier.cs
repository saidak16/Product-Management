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
    public partial class FRM_Add_Supplier : Form
    {
        public string Flag = "Add";
        CLS_Suppliers supplier = new CLS_Suppliers();

        public FRM_Add_Supplier()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                Supplier sup = new Supplier()
                {
                    Id = 0,
                    Name = txtName.Text,
                    CompanyName = txtCompany.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text
                };

                var isValid = supplier.AddSupplier(sup);

                if (isValid)
                {
                    MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();
                    txtCompany.Clear();
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Supplier sup = new Supplier()
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    CompanyName = txtCompany.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text
                };

                var isValid = supplier.UpdateSupplier(sup);

                if (isValid)
                {
                    MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            FRM_Suppliers.getMain.dataGridView1.DataSource = supplier.GetAllSuppliers();
        }

        private void FRM_Add_Supplier_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Add_Supplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnAdd_Click( sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
