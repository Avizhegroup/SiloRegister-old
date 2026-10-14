namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmSearchProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbRegDocumrnt = new System.Windows.Forms.CheckBox();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductTitle = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegDocument = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtProductRegCode = new System.Windows.Forms.ComboBox();
            this.cmbProductBrand = new System.Windows.Forms.ComboBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.cmbProductStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proudctTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTechnicalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chbRegDocumrnt);
            this.groupBox1.Controls.Add(this.cmbProductGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRegDocument);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtProductRegCode);
            this.groupBox1.Controls.Add(this.cmbProductBrand);
            this.groupBox1.Controls.Add(this.cmbProductSize);
            this.groupBox1.Controls.Add(this.cmbProductType);
            this.groupBox1.Controls.Add(this.cmbProductStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1417, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر های جستجو";
            // 
            // chbRegDocumrnt
            // 
            this.chbRegDocumrnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbRegDocumrnt.AutoSize = true;
            this.chbRegDocumrnt.Checked = true;
            this.chbRegDocumrnt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRegDocumrnt.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.chbRegDocumrnt.Location = new System.Drawing.Point(512, 121);
            this.chbRegDocumrnt.Name = "chbRegDocumrnt";
            this.chbRegDocumrnt.Size = new System.Drawing.Size(107, 38);
            this.chbRegDocumrnt.TabIndex = 60;
            this.chbRegDocumrnt.Text = "کد بسته:";
            this.chbRegDocumrnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRegDocumrnt.UseVisualStyleBackColor = true;
            this.chbRegDocumrnt.Visible = false;
            this.chbRegDocumrnt.CheckedChanged += new System.EventHandler(this.chbRegDocumrnt_CheckedChanged);
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductGroup.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(641, 118);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(279, 42);
            this.cmbProductGroup.TabIndex = 7;
            this.cmbProductGroup.SelectedIndexChanged += new System.EventHandler(this.cmbProductGroup_SelectedIndexChanged);
            this.cmbProductGroup.TextChanged += new System.EventHandler(this.cmbProductGroup_TextChanged);
            this.cmbProductGroup.Enter += new System.EventHandler(this.cmbProductGroup_Enter);
            this.cmbProductGroup.Leave += new System.EventHandler(this.cmbProductGroup_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label3.Location = new System.Drawing.Point(920, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "شانه کالا:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "4 copy.PNG";
            this.btnSave.Location = new System.Drawing.Point(116, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "جستجو";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.ImageKey = "5 copy.PNG";
            this.btnNew.Location = new System.Drawing.Point(8, 105);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(246, 40);
            this.btnNew.TabIndex = 10;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtProductCode.Location = new System.Drawing.Point(275, 71);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(235, 41);
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            this.txtProductCode.Enter += new System.EventHandler(this.txtProductCode_Enter);
            this.txtProductCode.Leave += new System.EventHandler(this.txtProductCode_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label5.Location = new System.Drawing.Point(522, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 50;
            this.label5.Text = "کد کالا:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtProductTitle.Location = new System.Drawing.Point(641, 25);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(279, 41);
            this.txtProductTitle.TabIndex = 1;
            this.txtProductTitle.TextChanged += new System.EventHandler(this.txtProductTitle_TextChanged);
            this.txtProductTitle.Enter += new System.EventHandler(this.txtProductTitle_Enter);
            this.txtProductTitle.Leave += new System.EventHandler(this.txtProductTitle_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label1.Location = new System.Drawing.Point(920, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "عنوان کالا:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label2.Location = new System.Drawing.Point(1286, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 57;
            this.label2.Text = "برند کالا:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label6.Location = new System.Drawing.Point(920, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 31);
            this.label6.TabIndex = 57;
            this.label6.Text = "سایز کالا:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegDocument
            // 
            this.txtRegDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegDocument.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtRegDocument.Location = new System.Drawing.Point(276, 119);
            this.txtRegDocument.Name = "txtRegDocument";
            this.txtRegDocument.Size = new System.Drawing.Size(234, 41);
            this.txtRegDocument.TabIndex = 8;
            this.txtRegDocument.Visible = false;
            this.txtRegDocument.TextChanged += new System.EventHandler(this.txtProductRegCode_TextChanged);
            this.txtRegDocument.Enter += new System.EventHandler(this.txtProductRegCode_Enter);
            this.txtRegDocument.Leave += new System.EventHandler(this.txtProductRegCode_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label4.Location = new System.Drawing.Point(1286, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 55;
            this.label4.Text = "نوع محصول:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label26.Location = new System.Drawing.Point(522, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 31);
            this.label26.TabIndex = 55;
            this.label26.Text = "رنگ کالا:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label23.Location = new System.Drawing.Point(1288, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 31);
            this.label23.TabIndex = 56;
            this.label23.Text = "کد طرح:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductRegCode
            // 
            this.txtProductRegCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductRegCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtProductRegCode.FormattingEnabled = true;
            this.txtProductRegCode.Location = new System.Drawing.Point(1020, 71);
            this.txtProductRegCode.Name = "txtProductRegCode";
            this.txtProductRegCode.Size = new System.Drawing.Size(266, 42);
            this.txtProductRegCode.TabIndex = 3;
            this.txtProductRegCode.SelectedIndexChanged += new System.EventHandler(this.txtProductRegCode_SelectedIndexChanged);
            this.txtProductRegCode.TextChanged += new System.EventHandler(this.txtProductRegCode_TextChanged);
            this.txtProductRegCode.Enter += new System.EventHandler(this.txtProductRegCode_Enter);
            this.txtProductRegCode.Leave += new System.EventHandler(this.txtProductRegCode_Leave);
            // 
            // cmbProductBrand
            // 
            this.cmbProductBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductBrand.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.cmbProductBrand.FormattingEnabled = true;
            this.cmbProductBrand.Location = new System.Drawing.Point(1020, 118);
            this.cmbProductBrand.Name = "cmbProductBrand";
            this.cmbProductBrand.Size = new System.Drawing.Size(266, 42);
            this.cmbProductBrand.TabIndex = 6;
            this.cmbProductBrand.SelectedIndexChanged += new System.EventHandler(this.cmbProductBrand_SelectedIndexChanged);
            this.cmbProductBrand.TextChanged += new System.EventHandler(this.cmbProductBrand_TextChanged);
            this.cmbProductBrand.Enter += new System.EventHandler(this.cmbProductBrand_Enter);
            this.cmbProductBrand.Leave += new System.EventHandler(this.cmbProductBrand_Leave);
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductSize.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.Location = new System.Drawing.Point(641, 71);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(279, 42);
            this.cmbProductSize.TabIndex = 4;
            this.cmbProductSize.SelectedIndexChanged += new System.EventHandler(this.cmbProductSize_SelectedIndexChanged);
            this.cmbProductSize.TextChanged += new System.EventHandler(this.cmbProductSize_TextChanged);
            this.cmbProductSize.Enter += new System.EventHandler(this.cmbProductSize_Enter);
            this.cmbProductSize.Leave += new System.EventHandler(this.cmbProductSize_Leave);
            // 
            // cmbProductType
            // 
            this.cmbProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductType.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(1020, 24);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(266, 42);
            this.cmbProductType.TabIndex = 0;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            this.cmbProductType.TextChanged += new System.EventHandler(this.cmbProductType_TextChanged);
            this.cmbProductType.Enter += new System.EventHandler(this.cmbProductType_Enter);
            this.cmbProductType.Leave += new System.EventHandler(this.cmbProductType_Leave);
            // 
            // cmbProductStatus
            // 
            this.cmbProductStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.cmbProductStatus.FormattingEnabled = true;
            this.cmbProductStatus.Location = new System.Drawing.Point(276, 24);
            this.cmbProductStatus.Name = "cmbProductStatus";
            this.cmbProductStatus.Size = new System.Drawing.Size(235, 42);
            this.cmbProductStatus.TabIndex = 2;
            this.cmbProductStatus.SelectedIndexChanged += new System.EventHandler(this.cmbProductStatus_SelectedIndexChanged);
            this.cmbProductStatus.TextChanged += new System.EventHandler(this.cmbProductStatus_TextChanged);
            this.cmbProductStatus.Enter += new System.EventHandler(this.cmbProductStatus_Enter);
            this.cmbProductStatus.Leave += new System.EventHandler(this.cmbProductStatus_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.dgvSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1417, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelect,
            this.productCode,
            this.proudctTitle,
            this.productSize,
            this.productTechnicalCode,
            this.ProductStatus,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearch.Location = new System.Drawing.Point(3, 29);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 15;
            this.dgvSearch.RowTemplate.Height = 36;
            this.dgvSearch.Size = new System.Drawing.Size(1411, 479);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            this.dgvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellDoubleClick);
            // 
            // btnSelect
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "انتخاب";
            this.btnSelect.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnSelect.HeaderText = "انتخاب";
            this.btnSelect.MinimumWidth = 6;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ReadOnly = true;
            this.btnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSelect.Width = 70;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "کد کالا";
            this.productCode.MinimumWidth = 6;
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Width = 140;
            // 
            // proudctTitle
            // 
            this.proudctTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proudctTitle.HeaderText = "عنوان کالا";
            this.proudctTitle.MinimumWidth = 6;
            this.proudctTitle.Name = "proudctTitle";
            this.proudctTitle.ReadOnly = true;
            // 
            // productSize
            // 
            this.productSize.HeaderText = "سایز کالا";
            this.productSize.MinimumWidth = 6;
            this.productSize.Name = "productSize";
            this.productSize.ReadOnly = true;
            this.productSize.Width = 150;
            // 
            // productTechnicalCode
            // 
            this.productTechnicalCode.HeaderText = "کد طرح";
            this.productTechnicalCode.MinimumWidth = 6;
            this.productTechnicalCode.Name = "productTechnicalCode";
            this.productTechnicalCode.ReadOnly = true;
            this.productTechnicalCode.Width = 120;
            // 
            // ProductStatus
            // 
            this.ProductStatus.HeaderText = "رنگ کالا";
            this.ProductStatus.MinimumWidth = 6;
            this.ProductStatus.Name = "ProductStatus";
            this.ProductStatus.ReadOnly = true;
            this.ProductStatus.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "برند";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "شانه کالا";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "سالن تولید";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "4 copy.PNG";
            this.btnUpdate.Location = new System.Drawing.Point(8, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 77);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "بروزرسانی لیست از سرور";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmSearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSearchProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی کالا";
            this.Load += new System.EventHandler(this.frmSearchProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtProductCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtProductTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbProductSize;
        private System.Windows.Forms.ComboBox cmbProductStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox chbRegDocumrnt;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtRegDocument;
        private System.Windows.Forms.ComboBox cmbProductBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn proudctTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTechnicalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox txtProductRegCode;
        private System.Windows.Forms.Button btnUpdate;
    }
}