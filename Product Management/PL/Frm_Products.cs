using CrystalDecisions.Shared;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Product_Management.PL
{
    public partial class Frm_Products : Form
    {
        private static Frm_Products frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Frm_Products getMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Products();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

        BL.CLS_Products prd = new BL.CLS_Products();

        public void DGV()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = prd.Get_Pro();
            this.dataGridView1.DataSource = dt; 
        }

        public Frm_Products()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.Get_Pro();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Add_Product frm = new Frm_Add_Product();
            frm.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.Search_Pro(txtID.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج المحدد ؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                prd.Delete_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DGV();
            }
            else
            {
                MessageBox.Show("تم إلغاء العملية", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Add_Product frm = new Frm_Add_Product();
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txt_Des.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.cmb_Cat.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.Text = "تحديث المنتج :" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnAdd.Text = "تحديث";
            frm.Flag = "Update";
            frm.txtID.ReadOnly = true;

            byte[] img = (byte[])prd.ImagePro(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);

            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Preview frm = new Frm_Preview();
            byte[] img = (byte[])prd.ImagePro(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.Text = "صورة المنتج : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.rpd_prd_single pr = new RPT.rpd_prd_single();
            RPT.FRM_Single_Product FrmRp = new RPT.FRM_Single_Product();

            pr.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            FrmRp.crystalReportViewer1.ReportSource = pr;

            FrmRp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_pro myrpt = new RPT.rpt_all_pro();
            RPT.FRM_Single_Product myfrm = new RPT.FRM_Single_Product();
            myfrm.crystalReportViewer1.ReportSource = myrpt;
            myfrm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_pro myrpt = new RPT.rpt_all_pro();

            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions disk = new DiskFileDestinationOptions();
            ExcelFormatOptions exl = new ExcelFormatOptions();

            disk.DiskFileName = @"E:\Pro.xls";
            export = myrpt.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = exl;
            export.ExportDestinationOptions = disk;
            myrpt.Export();

            MessageBox.Show("تم تصدير اللائحة بنجاح", "لائحة المنتجات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frm_Products_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void Frm_Products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
