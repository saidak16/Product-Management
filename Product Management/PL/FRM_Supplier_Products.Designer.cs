namespace Product_Management.PL
{
    partial class FRM_Supplier_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Supplier_Products));
            this.dgvSupplierProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplierProducts
            // 
            this.dgvSupplierProducts.AllowUserToAddRows = false;
            this.dgvSupplierProducts.AllowUserToDeleteRows = false;
            this.dgvSupplierProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSupplierProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvSupplierProducts.Name = "dgvSupplierProducts";
            this.dgvSupplierProducts.ReadOnly = true;
            this.dgvSupplierProducts.Size = new System.Drawing.Size(1288, 606);
            this.dgvSupplierProducts.TabIndex = 0;
            // 
            // FRM_Supplier_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 606);
            this.Controls.Add(this.dgvSupplierProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Supplier_Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اصناف المورد";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplierProducts;
    }
}