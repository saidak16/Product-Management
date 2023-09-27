namespace Product_Management.PL
{
    partial class FRM_FinancialPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_FinancialPosition));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPur = new System.Windows.Forms.TextBox();
            this.txtSeal = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pieChart1);
            this.groupBox1.Controls.Add(this.txtPur);
            this.groupBox1.Controls.Add(this.txtSeal);
            this.groupBox1.Controls.Add(this.txtExp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حجم الاموال المتاحة";
            // 
            // txtPur
            // 
            this.txtPur.Enabled = false;
            this.txtPur.Location = new System.Drawing.Point(606, 94);
            this.txtPur.Name = "txtPur";
            this.txtPur.Size = new System.Drawing.Size(264, 23);
            this.txtPur.TabIndex = 11;
            // 
            // txtSeal
            // 
            this.txtSeal.Enabled = false;
            this.txtSeal.Location = new System.Drawing.Point(606, 129);
            this.txtSeal.Name = "txtSeal";
            this.txtSeal.Size = new System.Drawing.Size(264, 23);
            this.txtSeal.TabIndex = 10;
            // 
            // txtExp
            // 
            this.txtExp.Enabled = false;
            this.txtExp.Location = new System.Drawing.Point(606, 61);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(264, 23);
            this.txtExp.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "جملة المشتريات\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "جملة المبيعات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "جملة المنصرفات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pieChart2);
            this.groupBox2.Controls.Add(this.txtCust);
            this.groupBox2.Controls.Add(this.txtSup);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حركة الاموال";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "اجمالي استحقاقات الموردين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "اجمالي مطلوبات العملاء";
            // 
            // txtSup
            // 
            this.txtSup.Enabled = false;
            this.txtSup.Location = new System.Drawing.Point(521, 47);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(264, 23);
            this.txtSup.TabIndex = 12;
            // 
            // txtCust
            // 
            this.txtCust.Enabled = false;
            this.txtCust.Location = new System.Drawing.Point(521, 88);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(264, 23);
            this.txtCust.TabIndex = 14;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(252, 22);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(318, 172);
            this.pieChart1.TabIndex = 12;
            this.pieChart1.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(240, 21);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(275, 132);
            this.pieChart2.TabIndex = 13;
            this.pieChart2.Text = "pieChart2";
            // 
            // FRM_FinancialPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_FinancialPosition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموقف المالي";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPur;
        private System.Windows.Forms.TextBox txtSeal;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
    }
}