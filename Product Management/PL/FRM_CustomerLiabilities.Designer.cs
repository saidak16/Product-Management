namespace Product_Management.PL
{
    partial class FRM_CustomerLiabilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CustomerLiabilities));
            this.dgvCustomerLiabilities = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmoun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalRemaining = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerLiabilities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerLiabilities
            // 
            this.dgvCustomerLiabilities.AllowUserToAddRows = false;
            this.dgvCustomerLiabilities.AllowUserToDeleteRows = false;
            this.dgvCustomerLiabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerLiabilities.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomerLiabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerLiabilities.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerLiabilities.Name = "dgvCustomerLiabilities";
            this.dgvCustomerLiabilities.ReadOnly = true;
            this.dgvCustomerLiabilities.Size = new System.Drawing.Size(1207, 430);
            this.dgvCustomerLiabilities.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Location = new System.Drawing.Point(322, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Product_Management.Properties.Resources.icons8_send_to_printer_24__2_1;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(365, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 41);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "طباعة القائمة (F1)";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Product_Management.Properties.Resources.icon_Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(43, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "الخروج (F4)";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Product_Management.Properties.Resources.Address_Book_Alt_blue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(168, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "تعديل استحقاق العميل (F2)";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCount.Location = new System.Drawing.Point(56, 439);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(74, 25);
            this.txtCount.TabIndex = 2;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "(فاتورة)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "الفواتير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "اجمالي المطلوبات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "(ج.س)";
            // 
            // txtTotalAmoun
            // 
            this.txtTotalAmoun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotalAmoun.Location = new System.Drawing.Point(309, 438);
            this.txtTotalAmoun.Name = "txtTotalAmoun";
            this.txtTotalAmoun.ReadOnly = true;
            this.txtTotalAmoun.Size = new System.Drawing.Size(176, 25);
            this.txtTotalAmoun.TabIndex = 5;
            this.txtTotalAmoun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "اجمالي المدفوع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "(ج.س)";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.BackColor = System.Drawing.Color.Lime;
            this.txtTotalPaid.Location = new System.Drawing.Point(651, 438);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(176, 25);
            this.txtTotalPaid.TabIndex = 8;
            this.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(893, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "اجمالي المتبقي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1163, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "(ج.س)";
            // 
            // txtTotalRemaining
            // 
            this.txtTotalRemaining.BackColor = System.Drawing.Color.Red;
            this.txtTotalRemaining.Location = new System.Drawing.Point(981, 438);
            this.txtTotalRemaining.Name = "txtTotalRemaining";
            this.txtTotalRemaining.ReadOnly = true;
            this.txtTotalRemaining.Size = new System.Drawing.Size(176, 25);
            this.txtTotalRemaining.TabIndex = 11;
            this.txtTotalRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_CustomerLiabilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalRemaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalAmoun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomerLiabilities);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CustomerLiabilities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مطلوبات العميل";
            this.Load += new System.EventHandler(this.FRM_CustomerLiabilities_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_CustomerLiabilities_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerLiabilities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerLiabilities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmoun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalRemaining;
    }
}