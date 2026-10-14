namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmDefineProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProductValue = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProductCountInPack = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPackValue = new System.Windows.Forms.MaskedTextBox();
            this.txtProductTechnicalCode = new System.Windows.Forms.MaskedTextBox();
            this.txtProductCode = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.cmbProductStatus = new System.Windows.Forms.ComboBox();
            this.txtProductUnit = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPackVolume = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPackWeight = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductENTitle = new System.Windows.Forms.MaskedTextBox();
            this.txtProductTitle = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPrintQueue = new System.Windows.Forms.DataGridView();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlWaiting = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pbxWaitingLogo = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerErrorClear = new System.Windows.Forms.Timer(this.components);
            this.pnlSerachInWMS = new System.Windows.Forms.Panel();
            this.btnCancelppnlWMS = new System.Windows.Forms.Button();
            this.dgvCusWMS = new System.Windows.Forms.DataGridView();
            this.btnChoose = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvCodekala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitleKala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintQueue)).BeginInit();
            this.pnlWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWaitingLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlSerachInWMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusWMS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductValue
            // 
            this.txtProductValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductValue.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductValue.Location = new System.Drawing.Point(120, 177);
            this.txtProductValue.Name = "txtProductValue";
            this.txtProductValue.Size = new System.Drawing.Size(308, 32);
            this.txtProductValue.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label14.Location = new System.Drawing.Point(431, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "مقدار هر کارتن:";
            // 
            // txtProductCountInPack
            // 
            this.txtProductCountInPack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCountInPack.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductCountInPack.Location = new System.Drawing.Point(120, 215);
            this.txtProductCountInPack.Name = "txtProductCountInPack";
            this.txtProductCountInPack.Size = new System.Drawing.Size(308, 32);
            this.txtProductCountInPack.TabIndex = 10;
            // 
            // txtProductPackValue
            // 
            this.txtProductPackValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductPackValue.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductPackValue.Location = new System.Drawing.Point(595, 254);
            this.txtProductPackValue.Name = "txtProductPackValue";
            this.txtProductPackValue.Size = new System.Drawing.Size(226, 32);
            this.txtProductPackValue.TabIndex = 7;
            // 
            // txtProductTechnicalCode
            // 
            this.txtProductTechnicalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductTechnicalCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductTechnicalCode.Location = new System.Drawing.Point(120, 19);
            this.txtProductTechnicalCode.Name = "txtProductTechnicalCode";
            this.txtProductTechnicalCode.Size = new System.Drawing.Size(304, 32);
            this.txtProductTechnicalCode.TabIndex = 1;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductCode.Location = new System.Drawing.Point(599, 19);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(222, 32);
            this.txtProductCode.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label13.Location = new System.Drawing.Point(431, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "تعداد کارتن در محموله:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label12.Location = new System.Drawing.Point(824, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "مقدار محموله:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label6.Location = new System.Drawing.Point(427, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "کد تولید:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label5.Location = new System.Drawing.Point(824, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "کد کالا:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtProductSize);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProductValue);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbProductType);
            this.groupBox1.Controls.Add(this.cmbProductStatus);
            this.groupBox1.Controls.Add(this.txtProductUnit);
            this.groupBox1.Controls.Add(this.txtProductPackVolume);
            this.groupBox1.Controls.Add(this.txtProductPackWeight);
            this.groupBox1.Controls.Add(this.txtProductCountInPack);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtProductENTitle);
            this.groupBox1.Controls.Add(this.txtProductTitle);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.txtProductTechnicalCode);
            this.groupBox1.Controls.Add(this.txtProductPackValue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کالا";
            // 
            // txtProductSize
            // 
            this.txtProductSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSize.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtProductSize.FormattingEnabled = true;
            this.txtProductSize.Location = new System.Drawing.Point(120, 138);
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.Size = new System.Drawing.Size(308, 35);
            this.txtProductSize.TabIndex = 8;
            this.txtProductSize.SelectedIndexChanged += new System.EventHandler(this.txtProductSize_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "جستجو در نوسا";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(12, 239);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 47);
            this.btnNew.TabIndex = 15;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(12, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 47);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(12, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 157);
            this.btnSave.TabIndex = 13;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label4.Location = new System.Drawing.Point(431, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "سایز کالا:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label8.Location = new System.Drawing.Point(231, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "حجم محموله:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label7.Location = new System.Drawing.Point(434, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "وزن محموله:";
            // 
            // cmbProductType
            // 
            this.cmbProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductType.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(595, 214);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(226, 33);
            this.cmbProductType.TabIndex = 6;
            // 
            // cmbProductStatus
            // 
            this.cmbProductStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.cmbProductStatus.FormattingEnabled = true;
            this.cmbProductStatus.Location = new System.Drawing.Point(595, 139);
            this.cmbProductStatus.Name = "cmbProductStatus";
            this.cmbProductStatus.Size = new System.Drawing.Size(226, 33);
            this.cmbProductStatus.TabIndex = 4;
            // 
            // txtProductUnit
            // 
            this.txtProductUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductUnit.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductUnit.Location = new System.Drawing.Point(595, 177);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.Size = new System.Drawing.Size(226, 32);
            this.txtProductUnit.TabIndex = 5;
            // 
            // txtProductPackVolume
            // 
            this.txtProductPackVolume.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductPackVolume.Location = new System.Drawing.Point(120, 254);
            this.txtProductPackVolume.Name = "txtProductPackVolume";
            this.txtProductPackVolume.Size = new System.Drawing.Size(109, 32);
            this.txtProductPackVolume.TabIndex = 12;
            // 
            // txtProductPackWeight
            // 
            this.txtProductPackWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductPackWeight.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductPackWeight.Location = new System.Drawing.Point(329, 254);
            this.txtProductPackWeight.Name = "txtProductPackWeight";
            this.txtProductPackWeight.Size = new System.Drawing.Size(99, 32);
            this.txtProductPackWeight.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label2.Location = new System.Drawing.Point(824, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "شرح کالا لاتین:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label1.Location = new System.Drawing.Point(824, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "شرح کالا فارسی:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label16.Location = new System.Drawing.Point(824, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "سالن تولید:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label3.Location = new System.Drawing.Point(824, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "واحد کالا:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label9.Location = new System.Drawing.Point(824, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "رنگ کالا:";
            // 
            // txtProductENTitle
            // 
            this.txtProductENTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductENTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductENTitle.Location = new System.Drawing.Point(120, 101);
            this.txtProductENTitle.Name = "txtProductENTitle";
            this.txtProductENTitle.Size = new System.Drawing.Size(701, 32);
            this.txtProductENTitle.TabIndex = 3;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductTitle.Location = new System.Drawing.Point(120, 60);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(701, 32);
            this.txtProductTitle.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvPrintQueue);
            this.groupBox2.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات کالا";
            // 
            // dgvPrintQueue
            // 
            this.dgvPrintQueue.AllowUserToAddRows = false;
            this.dgvPrintQueue.AllowUserToDeleteRows = false;
            this.dgvPrintQueue.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPrintQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.ProductTitle,
            this.ProductDegree});
            this.dgvPrintQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrintQueue.Location = new System.Drawing.Point(3, 22);
            this.dgvPrintQueue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrintQueue.MultiSelect = false;
            this.dgvPrintQueue.Name = "dgvPrintQueue";
            this.dgvPrintQueue.ReadOnly = true;
            this.dgvPrintQueue.RowHeadersVisible = false;
            this.dgvPrintQueue.RowHeadersWidth = 15;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrintQueue.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrintQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrintQueue.Size = new System.Drawing.Size(933, 174);
            this.dgvPrintQueue.TabIndex = 0;
            this.dgvPrintQueue.TabStop = false;
            this.dgvPrintQueue.SelectionChanged += new System.EventHandler(this.dgvPrintQueue_SelectionChanged);
            this.dgvPrintQueue.Enter += new System.EventHandler(this.dgvPrintQueue_Enter);
            this.dgvPrintQueue.Leave += new System.EventHandler(this.dgvPrintQueue_Leave);
            // 
            // productCode
            // 
            this.productCode.HeaderText = "کد کالا";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Width = 150;
            // 
            // ProductTitle
            // 
            this.ProductTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductTitle.HeaderText = "عنوان";
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.ReadOnly = true;
            // 
            // ProductDegree
            // 
            this.ProductDegree.HeaderText = "رنگ کالا";
            this.ProductDegree.Name = "ProductDegree";
            this.ProductDegree.ReadOnly = true;
            this.ProductDegree.Width = 150;
            // 
            // pnlWaiting
            // 
            this.pnlWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.pnlWaiting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWaiting.Controls.Add(this.label11);
            this.pnlWaiting.Controls.Add(this.pbxWaitingLogo);
            this.pnlWaiting.Location = new System.Drawing.Point(340, 58);
            this.pnlWaiting.Name = "pnlWaiting";
            this.pnlWaiting.Size = new System.Drawing.Size(258, 114);
            this.pnlWaiting.TabIndex = 40;
            this.pnlWaiting.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "لطفا چند لحظه صبر کنید ..";
            // 
            // pbxWaitingLogo
            // 
            this.pbxWaitingLogo.Image = global::RfidConnectRegister.Properties.Resources._585e4831cb11b227491c338e;
            this.pbxWaitingLogo.Location = new System.Drawing.Point(102, 11);
            this.pbxWaitingLogo.Name = "pbxWaitingLogo";
            this.pbxWaitingLogo.Size = new System.Drawing.Size(60, 58);
            this.pbxWaitingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWaitingLogo.TabIndex = 0;
            this.pbxWaitingLogo.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // timerErrorClear
            // 
            this.timerErrorClear.Interval = 7000;
            // 
            // pnlSerachInWMS
            // 
            this.pnlSerachInWMS.Controls.Add(this.btnCancelppnlWMS);
            this.pnlSerachInWMS.Controls.Add(this.dgvCusWMS);
            this.pnlSerachInWMS.Controls.Add(this.label15);
            this.pnlSerachInWMS.Controls.Add(this.txtSearchTitle);
            this.pnlSerachInWMS.Controls.Add(this.label10);
            this.pnlSerachInWMS.Controls.Add(this.txtSearchCode);
            this.pnlSerachInWMS.Location = new System.Drawing.Point(89, 131);
            this.pnlSerachInWMS.Name = "pnlSerachInWMS";
            this.pnlSerachInWMS.Size = new System.Drawing.Size(839, 440);
            this.pnlSerachInWMS.TabIndex = 41;
            this.pnlSerachInWMS.Visible = false;
            // 
            // btnCancelppnlWMS
            // 
            this.btnCancelppnlWMS.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancelppnlWMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelppnlWMS.FlatAppearance.BorderSize = 0;
            this.btnCancelppnlWMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelppnlWMS.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.25F);
            this.btnCancelppnlWMS.ForeColor = System.Drawing.Color.Black;
            this.btnCancelppnlWMS.Location = new System.Drawing.Point(10, 15);
            this.btnCancelppnlWMS.Name = "btnCancelppnlWMS";
            this.btnCancelppnlWMS.Size = new System.Drawing.Size(111, 66);
            this.btnCancelppnlWMS.TabIndex = 18;
            this.btnCancelppnlWMS.TabStop = false;
            this.btnCancelppnlWMS.Text = "انصراف";
            this.btnCancelppnlWMS.UseVisualStyleBackColor = false;
            this.btnCancelppnlWMS.Click += new System.EventHandler(this.btnCancelppnlWMS_Click);
            // 
            // dgvCusWMS
            // 
            this.dgvCusWMS.AllowUserToAddRows = false;
            this.dgvCusWMS.AllowUserToDeleteRows = false;
            this.dgvCusWMS.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCusWMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusWMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnChoose,
            this.dgvCodekala,
            this.dgvTitleKala});
            this.dgvCusWMS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCusWMS.Location = new System.Drawing.Point(0, 88);
            this.dgvCusWMS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCusWMS.MultiSelect = false;
            this.dgvCusWMS.Name = "dgvCusWMS";
            this.dgvCusWMS.ReadOnly = true;
            this.dgvCusWMS.RowHeadersVisible = false;
            this.dgvCusWMS.RowHeadersWidth = 15;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCusWMS.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCusWMS.RowTemplate.Height = 25;
            this.dgvCusWMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCusWMS.Size = new System.Drawing.Size(839, 352);
            this.dgvCusWMS.TabIndex = 17;
            this.dgvCusWMS.TabStop = false;
            this.dgvCusWMS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusWMS_CellClick);
            this.dgvCusWMS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusWMS_CellDoubleClick);
            // 
            // btnChoose
            // 
            this.btnChoose.HeaderText = "انتخاب";
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.ReadOnly = true;
            this.btnChoose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnChoose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnChoose.Width = 50;
            // 
            // dgvCodekala
            // 
            this.dgvCodekala.HeaderText = "کد کالا";
            this.dgvCodekala.Name = "dgvCodekala";
            this.dgvCodekala.ReadOnly = true;
            this.dgvCodekala.Width = 180;
            // 
            // dgvTitleKala
            // 
            this.dgvTitleKala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTitleKala.HeaderText = "عنوان";
            this.dgvTitleKala.Name = "dgvTitleKala";
            this.dgvTitleKala.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label15.Location = new System.Drawing.Point(759, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "عنوان کالا:";
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtSearchTitle.Location = new System.Drawing.Point(371, 50);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(383, 32);
            this.txtSearchTitle.TabIndex = 15;
            this.txtSearchTitle.TextChanged += new System.EventHandler(this.txtSearchTitle_TextChanged);
            this.txtSearchTitle.Enter += new System.EventHandler(this.txtSearchTitle_Enter);
            this.txtSearchTitle.Leave += new System.EventHandler(this.txtSearchTitle_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label10.Location = new System.Drawing.Point(757, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "کد کالا:";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtSearchCode.Location = new System.Drawing.Point(565, 15);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(189, 32);
            this.txtSearchCode.TabIndex = 13;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchCode_TextChanged);
            this.txtSearchCode.Enter += new System.EventHandler(this.txtSearchCode_Enter);
            this.txtSearchCode.Leave += new System.EventHandler(this.txtSearchCode_Leave);
            // 
            // frmDefineProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 495);
            this.Controls.Add(this.pnlSerachInWMS);
            this.Controls.Add(this.pnlWaiting);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDefineProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تعریف کالا";
            this.Load += new System.EventHandler(this.frmDefineProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintQueue)).EndInit();
            this.pnlWaiting.ResumeLayout(false);
            this.pnlWaiting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWaitingLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlSerachInWMS.ResumeLayout(false);
            this.pnlSerachInWMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusWMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtProductValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtProductCountInPack;
        private System.Windows.Forms.MaskedTextBox txtProductPackValue;
        private System.Windows.Forms.MaskedTextBox txtProductTechnicalCode;
        private System.Windows.Forms.MaskedTextBox txtProductCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProductStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtProductENTitle;
        private System.Windows.Forms.MaskedTextBox txtProductTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPrintQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtProductUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtProductPackVolume;
        private System.Windows.Forms.MaskedTextBox txtProductPackWeight;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlWaiting;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbxWaitingLogo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Timer timerErrorClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSerachInWMS;
        private System.Windows.Forms.Button btnCancelppnlWMS;
        private System.Windows.Forms.DataGridView dgvCusWMS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtSearchTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtSearchCode;
        private System.Windows.Forms.DataGridViewButtonColumn btnChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodekala;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitleKala;
        private System.Windows.Forms.ComboBox txtProductSize;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label16;
    }
}