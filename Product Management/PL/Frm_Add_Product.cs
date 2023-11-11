using Product_Management.BL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Product_Management.PL
{
    public partial class Frm_Add_Product : Form
    {
        public string Flag = "Add";
        CLS_Products cat = new CLS_Products();
        CLS_Suppliers supplier = new CLS_Suppliers();

        public Frm_Add_Product()
        {
            InitializeComponent();

            cmb_Cat.DataSource = cat.Get_Cat();
            cmb_Cat.DisplayMember = "Description_CAT";
            cmb_Cat.ValueMember = "ID_CAT";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور |*.jpg; *.png; *.gif; *.bmp";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                Frm_Products frm = new Frm_Products();
                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                byte[] img = ms.ToArray();

                cat.Add_Product(txt_Des.Text, img, Convert.ToInt32(cmb_Cat.SelectedValue));

                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Clear();
                txt_Des.Clear();
                txtID.Focus();
                pictureBox1.Image = Product_Management.Properties.Resources.Save_icon;
                
            }
            else
            {
                Frm_Products frm = new Frm_Products();
                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                byte[] img = ms.ToArray();

                cat.Update_Product(Convert.ToInt32(txtID.Text), txt_Des.Text, img, Convert.ToInt32(cmb_Cat.SelectedValue));

                MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                
            }

            Frm_Products.getMain.dataGridView1.DataSource = cat.Get_Pro();
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                DataTable dt = new DataTable();
                dt = cat.Verify(txtID.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("رقم المنتج موجود مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtID.Focus();
                    txtID.SelectionStart = 0;
                    txtID.SelectionLength = txtID.TextLength;
                    btnAdd.Enabled = false;
                }
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Add_Product_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void Frm_Add_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnLogin_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
