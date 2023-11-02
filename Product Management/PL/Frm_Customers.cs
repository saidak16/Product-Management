using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Product_Management.PL
{
    public partial class Frm_Customers : Form
    {
        BL.CLS_Customers bu = new BL.CLS_Customers();
        DataTable dt = new DataTable();
        int id,pos;

        public Frm_Customers()
        {
            InitializeComponent();
            dt = bu.Select_Customers(); 
            this.dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();

            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            bu.Add_Customer(txtFname.Text, txtLname.Text, txtTel.Text, txtEmail.Text, img);
            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFname.Clear();
            txtLname.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            pictureBox1.Image = Product_Management.Properties.Resources.Add_Male_User_icon;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            dt.Clear();
            dt = bu.Select_Customers();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور |*.jpg; *.png; *.gif; *.bmp";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            pictureBox1.Image = Product_Management.Properties.Resources.Add_Male_User_icon;
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
            txtFname.Focus();
        }

        private void txtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLname.Focus();
            }
        }

        private void txtLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العميل المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (id == 0)
                {
                    MessageBox.Show("حدث خطأ ما", "تحديد المعرف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                bu.Delete_Customer(id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dt.Clear();
                dt = bu.Select_Customers();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Product_Management.Properties.Resources.Add_Male_User_icon;
            txtFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MemoryStream ms = new MemoryStream();
            id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            bu.Update_Customer(id, txtFname.Text, txtLname.Text, txtTel.Text, txtEmail.Text, img);
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dt.Clear();
            dt = bu.Select_Customers();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dataGridView1.DataSource = bu.Search_Customers(txtSearch.Text);
            }
        }

        void navg(int index)
        {
            pictureBox1.Image = Product_Management.Properties.Resources.Add_Male_User_icon;
            DataTable dt = bu.Select_Customers();
            id = Convert.ToInt32(dt.Rows[index][0].ToString());
            txtFname.Text = dt.Rows[index][1].ToString();
            txtLname.Text = dt.Rows[index][2].ToString();
            txtTel.Text = dt.Rows[index][3].ToString();
            txtEmail.Text = dt.Rows[index][4].ToString();
            byte[] img = (byte[])dt.Rows[index][5];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navg(0);
            lblPos.Text = pos.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = bu.Select_Customers().Rows.Count - 1;
            navg(pos);
            lblPos.Text = pos.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pos == 0)
            {
                MessageBox.Show("هذا هو أول عنصر", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pos -= 1;
            navg(pos);
            lblPos.Text = pos.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pos == bu.Select_Customers().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو اخر عنصر", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pos += 1;
            navg(pos);
            lblPos.Text = pos.ToString();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = bu.Search_Customers(txtSearch.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
