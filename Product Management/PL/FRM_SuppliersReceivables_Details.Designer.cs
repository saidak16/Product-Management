﻿namespace Product_Management.PL
{
    partial class FRM_SuppliersReceivables_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSuppliersReceivablesDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersReceivablesDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliersReceivablesDetails
            // 
            this.dgvSuppliersReceivablesDetails.AllowUserToAddRows = false;
            this.dgvSuppliersReceivablesDetails.AllowUserToDeleteRows = false;
            this.dgvSuppliersReceivablesDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliersReceivablesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliersReceivablesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliersReceivablesDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvSuppliersReceivablesDetails.Name = "dgvSuppliersReceivablesDetails";
            this.dgvSuppliersReceivablesDetails.ReadOnly = true;
            this.dgvSuppliersReceivablesDetails.Size = new System.Drawing.Size(1496, 486);
            this.dgvSuppliersReceivablesDetails.TabIndex = 0;
            this.dgvSuppliersReceivablesDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FRM_SuppliersReceivables_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 486);
            this.Controls.Add(this.dgvSuppliersReceivablesDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SuppliersReceivables_Details";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الاستحقاق";
            this.Load += new System.EventHandler(this.FRM_SuppliersReceivables_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersReceivablesDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSuppliersReceivablesDetails;
    }
}