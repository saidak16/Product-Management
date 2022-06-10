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
    public partial class FRM_BACKUP : Form
    {
        SqlConnection cn = new SqlConnection("Server =.; DataBase = Product_DB; Integrated Security = true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
                btnBackup.Enabled = true;
                btnBackup.Focus();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text + "\\Product_DB" + DateTime.Now.ToShortDateString().Replace('/', '-')
                              + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string strQuery = "Backup Database Product_DB to Disk='" + fileName + ".bak'";
            cmd = new SqlCommand(strQuery, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBackup.Enabled = false;
            btnBrows.Focus();
        }
    }
}
