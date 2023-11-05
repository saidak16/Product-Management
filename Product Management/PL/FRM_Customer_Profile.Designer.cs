namespace Product_Management.PL
{
    partial class FRM_Customer_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Customer_Profile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalRemaining = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemainAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtTotalInvoices = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCountOfReturnInvoices = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReturnSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvReturnInvoices = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.txtCountOfSaleInvoices = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSaleInvoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnInvoices)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalRemaining);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLastOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCreationDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // txtLastOrder
            // 
            this.txtLastOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastOrder.Location = new System.Drawing.Point(174, 161);
            this.txtLastOrder.Name = "txtLastOrder";
            this.txtLastOrder.ReadOnly = true;
            this.txtLastOrder.Size = new System.Drawing.Size(261, 26);
            this.txtLastOrder.TabIndex = 17;
            this.txtLastOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "اخر معاملة";
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCreationDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreationDate.Location = new System.Drawing.Point(174, 129);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(261, 26);
            this.txtCreationDate.TabIndex = 15;
            this.txtCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "بداية التعامل";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(174, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(261, 26);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(174, 65);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(261, 26);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(174, 30);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(261, 26);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "البريد الالكتروني";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "الهاتف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "الاسم";
            // 
            // txtTotalRemaining
            // 
            this.txtTotalRemaining.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalRemaining.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRemaining.Location = new System.Drawing.Point(174, 193);
            this.txtTotalRemaining.Name = "txtTotalRemaining";
            this.txtTotalRemaining.ReadOnly = true;
            this.txtTotalRemaining.Size = new System.Drawing.Size(261, 26);
            this.txtTotalRemaining.TabIndex = 21;
            this.txtTotalRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "المبلغ المطلوب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRemainAmount);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtTotalAmount);
            this.groupBox2.Controls.Add(this.txtPaid);
            this.groupBox2.Controls.Add(this.txtTotalInvoices);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.pieChart1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 405);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الموقف المالي";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "ج.س";
            // 
            // txtRemainAmount
            // 
            this.txtRemainAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemainAmount.Location = new System.Drawing.Point(111, 369);
            this.txtRemainAmount.Name = "txtRemainAmount";
            this.txtRemainAmount.ReadOnly = true;
            this.txtRemainAmount.Size = new System.Drawing.Size(264, 26);
            this.txtRemainAmount.TabIndex = 42;
            this.txtRemainAmount.Text = "0";
            this.txtRemainAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "جملة الاستحقاقات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "ج.س";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 19);
            this.label14.TabIndex = 39;
            this.label14.Text = "ج.س";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 19);
            this.label15.TabIndex = 38;
            this.label15.Text = "(فاتورة)";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalAmount.Location = new System.Drawing.Point(112, 301);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(264, 26);
            this.txtTotalAmount.TabIndex = 37;
            this.txtTotalAmount.Text = "0";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaid.Location = new System.Drawing.Point(112, 336);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(264, 26);
            this.txtPaid.TabIndex = 36;
            this.txtPaid.Text = "0";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalInvoices
            // 
            this.txtTotalInvoices.Location = new System.Drawing.Point(112, 268);
            this.txtTotalInvoices.Name = "txtTotalInvoices";
            this.txtTotalInvoices.ReadOnly = true;
            this.txtTotalInvoices.Size = new System.Drawing.Size(264, 26);
            this.txtTotalInvoices.TabIndex = 35;
            this.txtTotalInvoices.Text = "0";
            this.txtTotalInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(382, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 34;
            this.label18.Text = "جملة المعاملات";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(382, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 19);
            this.label19.TabIndex = 33;
            this.label19.Text = "جملة الدفعيات";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(382, 268);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 19);
            this.label20.TabIndex = 32;
            this.label20.Text = "اجمالي المعاملات";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(6, 22);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(518, 240);
            this.pieChart1.TabIndex = 26;
            this.pieChart1.Text = "pieChart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtCountOfReturnInvoices);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtReturnSearch);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnSaleInvoice);
            this.groupBox4.Controls.Add(this.dgvReturnInvoices);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(549, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(928, 271);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الفواتير المرتجعة";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "(فاتورة)";
            // 
            // txtCountOfReturnInvoices
            // 
            this.txtCountOfReturnInvoices.Location = new System.Drawing.Point(83, 227);
            this.txtCountOfReturnInvoices.Name = "txtCountOfReturnInvoices";
            this.txtCountOfReturnInvoices.ReadOnly = true;
            this.txtCountOfReturnInvoices.Size = new System.Drawing.Size(137, 26);
            this.txtCountOfReturnInvoices.TabIndex = 36;
            this.txtCountOfReturnInvoices.Text = "0";
            this.txtCountOfReturnInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 19);
            this.label17.TabIndex = 35;
            this.label17.Text = "عدد الفواتير المرتجعة";
            // 
            // txtReturnSearch
            // 
            this.txtReturnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnSearch.Location = new System.Drawing.Point(287, 21);
            this.txtReturnSearch.Name = "txtReturnSearch";
            this.txtReturnSearch.Size = new System.Drawing.Size(282, 22);
            this.txtReturnSearch.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(575, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 14);
            this.label13.TabIndex = 34;
            this.label13.Text = "ابحث هنا :";
            // 
            // dgvReturnInvoices
            // 
            this.dgvReturnInvoices.AllowUserToAddRows = false;
            this.dgvReturnInvoices.AllowUserToDeleteRows = false;
            this.dgvReturnInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnInvoices.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReturnInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnInvoices.Location = new System.Drawing.Point(6, 52);
            this.dgvReturnInvoices.Name = "dgvReturnInvoices";
            this.dgvReturnInvoices.ReadOnly = true;
            this.dgvReturnInvoices.Size = new System.Drawing.Size(910, 160);
            this.dgvReturnInvoices.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dgvInvoices);
            this.groupBox3.Controls.Add(this.txtCountOfSaleInvoices);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.txtInvoiceSearch);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(549, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(928, 352);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الفواتير و الاقساط";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "(فاتورة)";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(6, 50);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.Size = new System.Drawing.Size(910, 244);
            this.dgvInvoices.TabIndex = 1;
            // 
            // txtCountOfSaleInvoices
            // 
            this.txtCountOfSaleInvoices.Location = new System.Drawing.Point(83, 308);
            this.txtCountOfSaleInvoices.Name = "txtCountOfSaleInvoices";
            this.txtCountOfSaleInvoices.ReadOnly = true;
            this.txtCountOfSaleInvoices.Size = new System.Drawing.Size(137, 26);
            this.txtCountOfSaleInvoices.TabIndex = 43;
            this.txtCountOfSaleInvoices.Text = "0";
            this.txtCountOfSaleInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "عدد المعاملات";
            // 
            // txtInvoiceSearch
            // 
            this.txtInvoiceSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceSearch.Location = new System.Drawing.Point(287, 22);
            this.txtInvoiceSearch.Name = "txtInvoiceSearch";
            this.txtInvoiceSearch.Size = new System.Drawing.Size(282, 22);
            this.txtInvoiceSearch.TabIndex = 40;
            this.txtInvoiceSearch.TextChanged += new System.EventHandler(this.txtInvoiceSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 14);
            this.label9.TabIndex = 41;
            this.label9.Text = "ابحث هنا :";
            // 
            // button3
            // 
            this.button3.Image = global::Product_Management.Properties.Resources.Address_Book_Alt_blue1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(639, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 39;
            this.button3.Text = "تفاصيل الاقساط";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Product_Management.Properties.Resources._11081942421898;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(778, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 42);
            this.button4.TabIndex = 38;
            this.button4.Text = "تفاصيل الفاتورة";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSaleInvoice
            // 
            this.btnSaleInvoice.Image = global::Product_Management.Properties.Resources._11081942421898;
            this.btnSaleInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleInvoice.Location = new System.Drawing.Point(778, 220);
            this.btnSaleInvoice.Name = "btnSaleInvoice";
            this.btnSaleInvoice.Size = new System.Drawing.Size(138, 42);
            this.btnSaleInvoice.TabIndex = 31;
            this.btnSaleInvoice.Text = "تفاصيل الفاتورة";
            this.btnSaleInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaleInvoice.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Product_Management.Properties.Resources.client1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Customer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 642);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Customer_Profile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ملف العميل";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnInvoices)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemainAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtTotalInvoices;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCountOfReturnInvoices;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtReturnSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaleInvoice;
        private System.Windows.Forms.DataGridView dgvReturnInvoices;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.TextBox txtCountOfSaleInvoices;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtInvoiceSearch;
        private System.Windows.Forms.Label label9;
    }
}