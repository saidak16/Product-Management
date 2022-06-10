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

namespace Product_Management.PL
{
    public partial class FRM_RESTORE : Form
    {
        SqlConnection cn = new SqlConnection("Server =.; DataBase = Master; Integrated Security = true");
        SqlCommand cmd;
        
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
                btnBackup.Enabled = true;
                btnBackup.Focus();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string strQuery = "Alter Database Product_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Product_DB From Disk = '" + txtFileName.Text + "'; Alter Database Product_DB SET ONLINE WITH ROLLBACK IMMEDIATE;";
            cmd = new SqlCommand(strQuery, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "استعادة نسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBackup.Enabled = false;
            btnBrows.Focus();
        }
    }
}
