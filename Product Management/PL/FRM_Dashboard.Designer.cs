namespace Product_Management.PL
{
    partial class FRM_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Dashboard));
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            this.pieChart4 = new LiveCharts.WinForms.PieChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTopSale = new System.Windows.Forms.DataGridView();
            this.dgvTopPurchaseItems = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopPurchaseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(2, 2);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(377, 240);
            this.pieChart1.TabIndex = 27;
            this.pieChart1.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(373, 2);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(377, 240);
            this.pieChart2.TabIndex = 28;
            this.pieChart2.Text = "pieChart2";
            // 
            // pieChart3
            // 
            this.pieChart3.Location = new System.Drawing.Point(756, 2);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(377, 240);
            this.pieChart3.TabIndex = 29;
            this.pieChart3.Text = "pieChart3";
            // 
            // pieChart4
            // 
            this.pieChart4.Location = new System.Drawing.Point(1118, 2);
            this.pieChart4.Name = "pieChart4";
            this.pieChart4.Size = new System.Drawing.Size(377, 240);
            this.pieChart4.TabIndex = 30;
            this.pieChart4.Text = "pieChart4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTopSale);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 201);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاكثر مبيعا";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTopPurchaseItems);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(886, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 201);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاكثر شراءً";
            // 
            // dgvTopSale
            // 
            this.dgvTopSale.AllowUserToAddRows = false;
            this.dgvTopSale.AllowUserToDeleteRows = false;
            this.dgvTopSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSale.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTopSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSale.Location = new System.Drawing.Point(3, 22);
            this.dgvTopSale.Name = "dgvTopSale";
            this.dgvTopSale.ReadOnly = true;
            this.dgvTopSale.Size = new System.Drawing.Size(569, 176);
            this.dgvTopSale.TabIndex = 0;
            // 
            // dgvTopPurchaseItems
            // 
            this.dgvTopPurchaseItems.AllowUserToAddRows = false;
            this.dgvTopPurchaseItems.AllowUserToDeleteRows = false;
            this.dgvTopPurchaseItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopPurchaseItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTopPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopPurchaseItems.Location = new System.Drawing.Point(3, 22);
            this.dgvTopPurchaseItems.Name = "dgvTopPurchaseItems";
            this.dgvTopPurchaseItems.ReadOnly = true;
            this.dgvTopPurchaseItems.Size = new System.Drawing.Size(582, 176);
            this.dgvTopPurchaseItems.TabIndex = 0;
            // 
            // FRM_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pieChart4);
            this.Controls.Add(this.pieChart3);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.pieChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Dashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopPurchaseItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart3;
        private LiveCharts.WinForms.PieChart pieChart4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTopSale;
        private System.Windows.Forms.DataGridView dgvTopPurchaseItems;
    }
}