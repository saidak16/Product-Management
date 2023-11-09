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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Dashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTopSale = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTopPurchaseItems = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTopCustomers = new System.Windows.Forms.DataGridView();
            this.pieChartSales = new LiveCharts.WinForms.PieChart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pieChartPurchase = new LiveCharts.WinForms.PieChart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSale)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopPurchaseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTopSale);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 184);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاكثر مبيعا";
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
            this.dgvTopSale.Size = new System.Drawing.Size(469, 159);
            this.dgvTopSale.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTopPurchaseItems);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1009, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 184);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاكثر شراءً";
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
            this.dgvTopPurchaseItems.Size = new System.Drawing.Size(469, 159);
            this.dgvTopPurchaseItems.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightBlue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(447, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "المبيعات";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "المشتريات";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(592, 265);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTopCustomers);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(493, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 184);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العملاء المميزين";
            // 
            // dgvTopCustomers
            // 
            this.dgvTopCustomers.AllowUserToAddRows = false;
            this.dgvTopCustomers.AllowUserToDeleteRows = false;
            this.dgvTopCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopCustomers.Location = new System.Drawing.Point(3, 22);
            this.dgvTopCustomers.Name = "dgvTopCustomers";
            this.dgvTopCustomers.ReadOnly = true;
            this.dgvTopCustomers.Size = new System.Drawing.Size(501, 159);
            this.dgvTopCustomers.TabIndex = 0;
            // 
            // pieChartSales
            // 
            this.pieChartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartSales.Location = new System.Drawing.Point(3, 22);
            this.pieChartSales.Name = "pieChartSales";
            this.pieChartSales.Size = new System.Drawing.Size(420, 240);
            this.pieChartSales.TabIndex = 34;
            this.pieChartSales.Text = "pieChart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pieChartSales);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 265);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "المبيعات";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pieChartPurchase);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1045, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 265);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "المشتريات";
            // 
            // pieChartPurchase
            // 
            this.pieChartPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartPurchase.Location = new System.Drawing.Point(3, 22);
            this.pieChartPurchase.Name = "pieChartPurchase";
            this.pieChartPurchase.Size = new System.Drawing.Size(430, 240);
            this.pieChartPurchase.TabIndex = 34;
            this.pieChartPurchase.Text = "pieChart2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(15, 463);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(472, 184);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "العملاء الاقل سداداً";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(466, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView2);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(1006, 463);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(475, 184);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "الموردين الاكثر استحقاقاً";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(469, 159);
            this.dataGridView2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Product_Management.Properties.Resources.box_search_product_ean_barcode_icon_148907;
            this.button2.Location = new System.Drawing.Point(746, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 168);
            this.button2.TabIndex = 37;
            this.button2.Text = "استعراض حركة الاصناف";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Product_Management.Properties.Resources.money_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(511, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 168);
            this.button1.TabIndex = 36;
            this.button1.Text = "استعراض الموقف المالي";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSale)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopPurchaseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTopSale;
        private System.Windows.Forms.DataGridView dgvTopPurchaseItems;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTopCustomers;
        private LiveCharts.WinForms.PieChart pieChartSales;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private LiveCharts.WinForms.PieChart pieChartPurchase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}