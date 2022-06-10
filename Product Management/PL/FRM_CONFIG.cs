﻿using System;
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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtID.Text = Properties.Settings.Default.ID;
            txtPWD.Text = Properties.Settings.Default.Password;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FRM_CHECK frm = new FRM_CHECK();
            frm.Close();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Mode = rbWindows.Checked == true? "Windows" : "SQL";
            Properties.Settings.Default.ID = txtID.Text;
            Properties.Settings.Default.Password = txtPWD.Text;
            MessageBox.Show("تم حفظ الاعدادات بنجاح", "اعدادات السيرفر", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Visible = true;
            lblPWD.Visible = true;
            txtID.Visible = true;
            txtPWD.Visible = true;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Visible = false;
            lblPWD.Visible = false;
            txtID.Visible = false;
            txtPWD.Visible = false;
        }
    }
}
