namespace Product_Management.PL
{
    partial class FRM_Add_Purchase_Invoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Add_Purchase_Invoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvoiceDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtRemainingAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSumTotal = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpExpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalePrice);
            this.groupBox1.Controls.Add(this.txtItemId);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.cmbItems);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الاصناف";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(482, 101);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(177, 25);
            this.dtpExpDate.TabIndex = 41;
            this.dtpExpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpExpDate_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "سعر البيع";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(199, 101);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(90, 25);
            this.txtSalePrice.TabIndex = 39;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalePrice_KeyDown);
            // 
            // txtItemId
            // 
            this.txtItemId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtItemId.Location = new System.Drawing.Point(936, 101);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(79, 25);
            this.txtItemId.TabIndex = 38;
            this.txtItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(932, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 19);
            this.label20.TabIndex = 37;
            this.label20.Text = "معرف الصنف";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = global::Product_Management.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(4, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 40);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAmount.Location = new System.Drawing.Point(49, 101);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(150, 25);
            this.txtAmount.TabIndex = 35;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "اجمالي المبلغ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "الكمية";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(290, 101);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(90, 25);
            this.txtQty.TabIndex = 30;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Location = new System.Drawing.Point(382, 101);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(97, 25);
            this.txtPrice.TabIndex = 29;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "سعر الشراء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "تاريخ الصلاحية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "اسم الصنف";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtItemName.Location = new System.Drawing.Point(663, 101);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(271, 25);
            this.txtItemName.TabIndex = 24;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(305, 28);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(305, 25);
            this.cmbItems.TabIndex = 23;
            this.cmbItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItems_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(616, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "بحث باسم الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbPaymentMethod);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtInvoiceDesc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtInvoiceId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 562);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الفاتورة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "طريقة الدفع";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(8, 185);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(201, 25);
            this.cmbPaymentMethod.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Product_Management.Properties.Resources._4011821;
            this.pictureBox1.Location = new System.Drawing.Point(8, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUser.Location = new System.Drawing.Point(8, 241);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(203, 25);
            this.txtUser.TabIndex = 44;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 43;
            this.label12.Text = "اسم المستخدم";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTime.Location = new System.Drawing.Point(8, 349);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(203, 25);
            this.txtTime.TabIndex = 42;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "زمن الفاتورة";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDate.Location = new System.Drawing.Point(8, 295);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(203, 25);
            this.txtDate.TabIndex = 40;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "تاريخ الفاتورة";
            // 
            // txtInvoiceDesc
            // 
            this.txtInvoiceDesc.Location = new System.Drawing.Point(6, 93);
            this.txtInvoiceDesc.Multiline = true;
            this.txtInvoiceDesc.Name = "txtInvoiceDesc";
            this.txtInvoiceDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInvoiceDesc.Size = new System.Drawing.Size(203, 65);
            this.txtInvoiceDesc.TabIndex = 37;
            this.txtInvoiceDesc.Text = "فاتورة مشتريات";
            this.txtInvoiceDesc.TextChanged += new System.EventHandler(this.txtInvoiceDesc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "وصف الفاتورة";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInvoiceId.Location = new System.Drawing.Point(6, 41);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.ReadOnly = true;
            this.txtInvoiceId.Size = new System.Drawing.Size(203, 25);
            this.txtInvoiceId.TabIndex = 37;
            this.txtInvoiceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "رقم الفاتورة";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSupplierId);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txtSupplierName);
            this.groupBox4.Controls.Add(this.cmbSuppliers);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(804, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 562);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات العملية";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierId.Location = new System.Drawing.Point(30, 129);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(94, 19);
            this.lblSupplierId.TabIndex = 52;
            this.lblSupplierId.Text = "lblSupplierId";
            this.lblSupplierId.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStock);
            this.groupBox6.Controls.Add(this.btnExit);
            this.groupBox6.Controls.Add(this.btnSuppliers);
            this.groupBox6.Controls.Add(this.btnPrint);
            this.groupBox6.Controls.Add(this.btnSave);
            this.groupBox6.Location = new System.Drawing.Point(6, 315);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 235);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "العمليات";
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Image = global::Product_Management.Properties.Resources.search;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(24, 102);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(157, 38);
            this.btnStock.TabIndex = 8;
            this.btnStock.Text = "عرض المخزن (F3)";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Product_Management.Properties.Resources.icon_Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(41, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "الخروج (F4)";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Image = global::Product_Management.Properties.Resources.icons8_gallery_24;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(24, 142);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(157, 38);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "بيانات الموردين (F5)";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::Product_Management.Properties.Resources.icons8_send_to_printer_24__2_1;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(24, 61);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 38);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "طباعة الفاتورة (F2)";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Product_Management.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(24, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ الفاتورة (F1)";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtRemainingAmount);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtPaidAmount);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtInvoiceAmount);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(6, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 183);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "الدفعية";
            // 
            // txtRemainingAmount
            // 
            this.txtRemainingAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRemainingAmount.Location = new System.Drawing.Point(5, 148);
            this.txtRemainingAmount.Name = "txtRemainingAmount";
            this.txtRemainingAmount.ReadOnly = true;
            this.txtRemainingAmount.Size = new System.Drawing.Size(195, 25);
            this.txtRemainingAmount.TabIndex = 57;
            this.txtRemainingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(62, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 19);
            this.label18.TabIndex = 56;
            this.label18.Text = "المبلغ المتبقي";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaidAmount.Location = new System.Drawing.Point(5, 94);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(195, 25);
            this.txtPaidAmount.TabIndex = 55;
            this.txtPaidAmount.Text = "0";
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(60, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 19);
            this.label17.TabIndex = 54;
            this.label17.Text = "المبلغ المدفوع";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInvoiceAmount.Location = new System.Drawing.Point(4, 40);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.ReadOnly = true;
            this.txtInvoiceAmount.Size = new System.Drawing.Size(195, 25);
            this.txtInvoiceAmount.TabIndex = 53;
            this.txtInvoiceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoiceAmount.TextChanged += new System.EventHandler(this.txtInvoiceAmount_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 19);
            this.label16.TabIndex = 52;
            this.label16.Text = "اجمالي الفاتورة";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSupplierName.Location = new System.Drawing.Point(2, 101);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(211, 25);
            this.txtSupplierName.TabIndex = 51;
            this.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(4, 44);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(207, 25);
            this.cmbSuppliers.TabIndex = 37;
            this.cmbSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSuppliers_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(76, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 19);
            this.label15.TabIndex = 50;
            this.label15.Text = "اسم المورد";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(61, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "بحث باسم المورد";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.txtSumTotal);
            this.groupBox7.Controls.Add(this.btnDeleteItem);
            this.groupBox7.Controls.Add(this.dgvInvoiceItems);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(218, 144);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(586, 562);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "اصناف الفاتورة";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(94, 487);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "عدد الاصناف";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 486);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "(صنف)";
            // 
            // txtSumTotal
            // 
            this.txtSumTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumTotal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumTotal.Location = new System.Drawing.Point(53, 483);
            this.txtSumTotal.Name = "txtSumTotal";
            this.txtSumTotal.ReadOnly = true;
            this.txtSumTotal.Size = new System.Drawing.Size(36, 25);
            this.txtSumTotal.TabIndex = 29;
            this.txtSumTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Image = global::Product_Management.Properties.Resources.Actions_edit_clear_icon1;
            this.btnDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteItem.Location = new System.Drawing.Point(435, 480);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(139, 32);
            this.btnDeleteItem.TabIndex = 8;
            this.btnDeleteItem.Text = "حذف الصنف المحدد";
            this.btnDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(6, 19);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(568, 459);
            this.dgvInvoiceItems.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_Add_Purchase_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 706);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Add_Purchase_Invoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " فاتورة مشتريات";
            this.Load += new System.EventHandler(this.FRM_Add_Purchase_Invoice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_Add_Purchase_Invoice_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvoiceDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtRemainingAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSumTotal;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
    }
}