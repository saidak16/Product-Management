using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Product_Management.PL
{
    public partial class FRM_Categories : Form
    {
        SqlConnection con = new SqlConnection("Server =.; DataBase = Product_DB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmd;

        public FRM_Categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("Select ID_CAT as 'معرف الصنف' , Description_CAT as 'الصنف' from Category", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtID.DataBindings.Add("Text", dt, "معرف الصنف");
            txtName.DataBindings.Add("Text", dt, "الصنف");
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0])+1;
            txtID.Text = id.ToString();
            lblPosition.Text = "     ";
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت الاضافة بنجاح", "اضافة صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الصنف المحدد ؟", "حذف الصنف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cmd = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم حذف الصنف", "حذف صنف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت التعديل بنجاح", "تعديل بيانات صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPraintAll_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_all_cat cat = new RPT.rpt_all_cat();
                RPT.FRM_Single_Product frm = new RPT.FRM_Single_Product();
                cat.Refresh();
                frm.crystalReportViewer1.ReportSource = cat;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnPrintCurrent_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_cal rpt = new RPT.rpt_single_cal();
            RPT.FRM_Single_Product frm = new RPT.FRM_Single_Product();
            rpt.SetParameterValue("@ID", Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_cat myrpt = new RPT.rpt_all_cat();

            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions disk = new DiskFileDestinationOptions();
            PdfFormatOptions pdf = new PdfFormatOptions();

            disk.DiskFileName = @"E:\CAT_List.pdf";
            export = myrpt.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdf;
            export.ExportDestinationOptions = disk;
            myrpt.Refresh();
            myrpt.Export();

            MessageBox.Show(" E تم تصدير اللائحة بنجاح للقرص ", "لائحة الأصناف", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_cal myrpt = new RPT.rpt_single_cal();

            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions disk = new DiskFileDestinationOptions();
            PdfFormatOptions pdf = new PdfFormatOptions();

            disk.DiskFileName = @"E:\Single_CAT.pdf";
            export = myrpt.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdf;
            export.ExportDestinationOptions = disk;
            myrpt.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            myrpt.Export();

            MessageBox.Show(" E تم تصدير الصنف بنجاح للقرص ", "لائحة الأصناف", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FRM_Categories_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(FRM_POS_KeyDown);
        }

        private void FRM_Categories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNew_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {
                btnAdd_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                btnDelete_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                btnUpdate_Click(sender, e);
            }
        }
    }
}
