namespace Product_Management.PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SuppliersReceivables_Details));
            this.dgvSuppliersReceivablesDetails = new System.Windows.Forms.DataGridView();
            this.btnSupplierReceivables = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersReceivablesDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliersReceivablesDetails
            // 
            this.dgvSuppliersReceivablesDetails.AllowUserToAddRows = false;
            this.dgvSuppliersReceivablesDetails.AllowUserToDeleteRows = false;
            this.dgvSuppliersReceivablesDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliersReceivablesDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSuppliersReceivablesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliersReceivablesDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvSuppliersReceivablesDetails.Name = "dgvSuppliersReceivablesDetails";
            this.dgvSuppliersReceivablesDetails.ReadOnly = true;
            this.dgvSuppliersReceivablesDetails.Size = new System.Drawing.Size(1401, 415);
            this.dgvSuppliersReceivablesDetails.TabIndex = 0;
            this.dgvSuppliersReceivablesDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSupplierReceivables
            // 
            this.btnSupplierReceivables.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierReceivables.Image = global::Product_Management.Properties.Resources.Admin_icon;
            this.btnSupplierReceivables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierReceivables.Location = new System.Drawing.Point(517, 421);
            this.btnSupplierReceivables.Name = "btnSupplierReceivables";
            this.btnSupplierReceivables.Size = new System.Drawing.Size(197, 53);
            this.btnSupplierReceivables.TabIndex = 10;
            this.btnSupplierReceivables.Text = "تعديل استحقاق المورد (F2)";
            this.btnSupplierReceivables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupplierReceivables.UseVisualStyleBackColor = true;
            this.btnSupplierReceivables.Click += new System.EventHandler(this.btnSupplierReceivables_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Product_Management.Properties.Resources.icon_Exit1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(720, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 53);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "الخروج (F4)";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FRM_SuppliersReceivables_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 486);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSupplierReceivables);
            this.Controls.Add(this.dgvSuppliersReceivablesDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SuppliersReceivables_Details";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الاستحقاق";
            this.Load += new System.EventHandler(this.FRM_SuppliersReceivables_Details_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_SuppliersReceivables_Details_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersReceivablesDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSuppliersReceivablesDetails;
        private System.Windows.Forms.Button btnSupplierReceivables;
        private System.Windows.Forms.Button btnExit;
    }
}