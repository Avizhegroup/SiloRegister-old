namespace RfidConnectRegister.UI
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbKindRegister = new System.Windows.Forms.ComboBox();
            this.chbActiveRegisterFormByOneSerial = new System.Windows.Forms.CheckBox();
            this.chbRegisterCountEvryTimeIsOne = new System.Windows.Forms.CheckBox();
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction = new System.Windows.Forms.CheckBox();
            this.chbGetListSerial = new System.Windows.Forms.CheckBox();
            this.chbAutoDetecteShift = new System.Windows.Forms.CheckBox();
            this.chbLogin = new System.Windows.Forms.CheckBox();
            this.txtSerialLength = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbZpl = new System.Windows.Forms.CheckBox();
            this.chbControlPrintFormatByBrand = new System.Windows.Forms.CheckBox();
            this.chbPrintPreviewBeforePrint = new System.Windows.Forms.CheckBox();
            this.chbMergPrintToPDF = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvShowReportFiles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbPrinterInOperation = new System.Windows.Forms.CheckBox();
            this.rbnShowSaveDialog = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKindPrint = new System.Windows.Forms.ComboBox();
            this.cmbInstalledPrinter = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbNotifApp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnBarCodeProductId = new System.Windows.Forms.RadioButton();
            this.txtDataSpliter = new System.Windows.Forms.TextBox();
            this.lblBarcodeIndex = new System.Windows.Forms.Label();
            this.txtBarcodeIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarcodeLength2 = new System.Windows.Forms.TextBox();
            this.txtBarcodeLength1 = new System.Windows.Forms.TextBox();
            this.lblBarCodeOtherDataSplitter = new System.Windows.Forms.Label();
            this.rbnBarCodeProductSerial = new System.Windows.Forms.RadioButton();
            this.rbnBarCodeProductCode = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReaderPort = new System.Windows.Forms.TextBox();
            this.txtReaderPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeviceModel = new System.Windows.Forms.ComboBox();
            this.pnlComsSetting = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtIgnoreEpcList = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbSetParentForSerials = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowReportFiles)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 110);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(147)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(261, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 87);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ثبت\r\n(Ctrl+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(646, 364);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "تنظیمات نرم افزار";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.cmbKindRegister);
            this.groupBox4.Controls.Add(this.chbActiveRegisterFormByOneSerial);
            this.groupBox4.Controls.Add(this.chbSetParentForSerials);
            this.groupBox4.Controls.Add(this.chbRegisterCountEvryTimeIsOne);
            this.groupBox4.Controls.Add(this.chbAllowShowOnlyPrintFormBeforeSavePrintAction);
            this.groupBox4.Controls.Add(this.chbGetListSerial);
            this.groupBox4.Controls.Add(this.chbAutoDetecteShift);
            this.groupBox4.Controls.Add(this.chbLogin);
            this.groupBox4.Controls.Add(this.txtSerialLength);
            this.groupBox4.Controls.Add(this.txtCompanyName);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtServerIp);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox4.Size = new System.Drawing.Size(646, 364);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تنظیمات نرم افزار";
            // 
            // cmbKindRegister
            // 
            this.cmbKindRegister.FormattingEnabled = true;
            this.cmbKindRegister.Items.AddRange(new object[] {
            "نا مشخص",
            "رجیستر از طریق  RFID Lable Printer",
            "رجیستر  از طریق بارفید",
            "رجیستر با چاپ بارکد",
            "رجیستر تک سریال با ریدر رو میزی"});
            this.cmbKindRegister.Location = new System.Drawing.Point(61, 121);
            this.cmbKindRegister.Name = "cmbKindRegister";
            this.cmbKindRegister.Size = new System.Drawing.Size(463, 35);
            this.cmbKindRegister.TabIndex = 9;
            // 
            // chbActiveRegisterFormByOneSerial
            // 
            this.chbActiveRegisterFormByOneSerial.AutoSize = true;
            this.chbActiveRegisterFormByOneSerial.Location = new System.Drawing.Point(61, 327);
            this.chbActiveRegisterFormByOneSerial.Name = "chbActiveRegisterFormByOneSerial";
            this.chbActiveRegisterFormByOneSerial.Size = new System.Drawing.Size(335, 32);
            this.chbActiveRegisterFormByOneSerial.TabIndex = 8;
            this.chbActiveRegisterFormByOneSerial.Text = "فعال سازی عملیات رجیستر فقط با یک سریال";
            this.chbActiveRegisterFormByOneSerial.UseVisualStyleBackColor = true;
            // 
            // chbRegisterCountEvryTimeIsOne
            // 
            this.chbRegisterCountEvryTimeIsOne.AutoSize = true;
            this.chbRegisterCountEvryTimeIsOne.Location = new System.Drawing.Point(348, 327);
            this.chbRegisterCountEvryTimeIsOne.Name = "chbRegisterCountEvryTimeIsOne";
            this.chbRegisterCountEvryTimeIsOne.Size = new System.Drawing.Size(221, 32);
            this.chbRegisterCountEvryTimeIsOne.TabIndex = 8;
            this.chbRegisterCountEvryTimeIsOne.Text = "تعداد رجیستر همیشه 1 باشد";
            this.chbRegisterCountEvryTimeIsOne.UseVisualStyleBackColor = true;
            // 
            // chbAllowShowOnlyPrintFormBeforeSavePrintAction
            // 
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.AutoSize = true;
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.Location = new System.Drawing.Point(226, 295);
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.Name = "chbAllowShowOnlyPrintFormBeforeSavePrintAction";
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.Size = new System.Drawing.Size(380, 32);
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.TabIndex = 8;
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.Text = "مجوز مشاهده فرم مدیریت چاپ قبل از ثبت عملیات";
            this.chbAllowShowOnlyPrintFormBeforeSavePrintAction.UseVisualStyleBackColor = true;
            // 
            // chbGetListSerial
            // 
            this.chbGetListSerial.AutoSize = true;
            this.chbGetListSerial.Location = new System.Drawing.Point(388, 221);
            this.chbGetListSerial.Name = "chbGetListSerial";
            this.chbGetListSerial.Size = new System.Drawing.Size(173, 32);
            this.chbGetListSerial.TabIndex = 8;
            this.chbGetListSerial.Text = "دریافت لیست سریال";
            this.chbGetListSerial.UseVisualStyleBackColor = true;
            // 
            // chbAutoDetecteShift
            // 
            this.chbAutoDetecteShift.AutoSize = true;
            this.chbAutoDetecteShift.Location = new System.Drawing.Point(344, 189);
            this.chbAutoDetecteShift.Name = "chbAutoDetecteShift";
            this.chbAutoDetecteShift.Size = new System.Drawing.Size(228, 32);
            this.chbAutoDetecteShift.TabIndex = 8;
            this.chbAutoDetecteShift.Text = "تشخیص خودکار شیفت کاری";
            this.chbAutoDetecteShift.UseVisualStyleBackColor = true;
            // 
            // chbLogin
            // 
            this.chbLogin.AutoSize = true;
            this.chbLogin.Location = new System.Drawing.Point(337, 157);
            this.chbLogin.Name = "chbLogin";
            this.chbLogin.Size = new System.Drawing.Size(236, 32);
            this.chbLogin.TabIndex = 8;
            this.chbLogin.Text = "ورود در نرم افزار با اعتبار سنجی";
            this.chbLogin.UseVisualStyleBackColor = true;
            // 
            // txtSerialLength
            // 
            this.txtSerialLength.Location = new System.Drawing.Point(473, 256);
            this.txtSerialLength.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSerialLength.MaxLength = 100;
            this.txtSerialLength.Name = "txtSerialLength";
            this.txtSerialLength.Size = new System.Drawing.Size(51, 35);
            this.txtSerialLength.TabIndex = 7;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(61, 82);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtCompanyName.MaxLength = 100;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(463, 35);
            this.txtCompanyName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "تعداد کارکتر سریال:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "نوع رجیستر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام شرکت:";
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(61, 40);
            this.txtServerIp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtServerIp.MaxLength = 20;
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(463, 35);
            this.txtServerIp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "آی‌پی سرور :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(646, 364);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "تنظیمات چاپ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.chbZpl);
            this.groupBox3.Controls.Add(this.chbControlPrintFormatByBrand);
            this.groupBox3.Controls.Add(this.chbPrintPreviewBeforePrint);
            this.groupBox3.Controls.Add(this.chbMergPrintToPDF);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.chbPrinterInOperation);
            this.groupBox3.Controls.Add(this.rbnShowSaveDialog);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbKindPrint);
            this.groupBox3.Controls.Add(this.cmbInstalledPrinter);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Size = new System.Drawing.Size(646, 364);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // chbZpl
            // 
            this.chbZpl.AutoSize = true;
            this.chbZpl.Checked = true;
            this.chbZpl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbZpl.Location = new System.Drawing.Point(95, 94);
            this.chbZpl.Name = "chbZpl";
            this.chbZpl.Size = new System.Drawing.Size(67, 32);
            this.chbZpl.TabIndex = 10;
            this.chbZpl.Text = "ZPL";
            this.chbZpl.UseVisualStyleBackColor = true;
            // 
            // chbControlPrintFormatByBrand
            // 
            this.chbControlPrintFormatByBrand.AutoSize = true;
            this.chbControlPrintFormatByBrand.Location = new System.Drawing.Point(335, 62);
            this.chbControlPrintFormatByBrand.Name = "chbControlPrintFormatByBrand";
            this.chbControlPrintFormatByBrand.Size = new System.Drawing.Size(272, 32);
            this.chbControlPrintFormatByBrand.TabIndex = 9;
            this.chbControlPrintFormatByBrand.Text = "تظبیق خودکار قالب چاپ با برند کالا";
            this.chbControlPrintFormatByBrand.UseVisualStyleBackColor = true;
            // 
            // chbPrintPreviewBeforePrint
            // 
            this.chbPrintPreviewBeforePrint.AutoSize = true;
            this.chbPrintPreviewBeforePrint.Location = new System.Drawing.Point(331, 128);
            this.chbPrintPreviewBeforePrint.Name = "chbPrintPreviewBeforePrint";
            this.chbPrintPreviewBeforePrint.Size = new System.Drawing.Size(278, 32);
            this.chbPrintPreviewBeforePrint.TabIndex = 9;
            this.chbPrintPreviewBeforePrint.Text = "پیش نمایش اولین ردیف قبل از چاپ";
            this.chbPrintPreviewBeforePrint.UseVisualStyleBackColor = true;
            // 
            // chbMergPrintToPDF
            // 
            this.chbMergPrintToPDF.AutoSize = true;
            this.chbMergPrintToPDF.Location = new System.Drawing.Point(399, 94);
            this.chbMergPrintToPDF.Name = "chbMergPrintToPDF";
            this.chbMergPrintToPDF.Size = new System.Drawing.Size(191, 32);
            this.chbMergPrintToPDF.TabIndex = 9;
            this.chbMergPrintToPDF.Text = "چاپ بصورت فایل PDF";
            this.chbMergPrintToPDF.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvShowReportFiles);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 156);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(640, 202);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "فایل گزارش برای چاپ";
            this.groupBox5.Visible = false;
            // 
            // dgvShowReportFiles
            // 
            this.dgvShowReportFiles.AllowUserToAddRows = false;
            this.dgvShowReportFiles.AllowUserToDeleteRows = false;
            this.dgvShowReportFiles.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvShowReportFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowReportFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvShowReportFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowReportFiles.Location = new System.Drawing.Point(3, 32);
            this.dgvShowReportFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvShowReportFiles.MultiSelect = false;
            this.dgvShowReportFiles.Name = "dgvShowReportFiles";
            this.dgvShowReportFiles.ReadOnly = true;
            this.dgvShowReportFiles.RowHeadersVisible = false;
            this.dgvShowReportFiles.RowHeadersWidth = 51;
            this.dgvShowReportFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowReportFiles.Size = new System.Drawing.Size(634, 166);
            this.dgvShowReportFiles.TabIndex = 13;
            this.dgvShowReportFiles.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowReportFiles_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نام فایل";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 430;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نوع فایل";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // chbPrinterInOperation
            // 
            this.chbPrinterInOperation.AutoSize = true;
            this.chbPrinterInOperation.Location = new System.Drawing.Point(376, 62);
            this.chbPrinterInOperation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbPrinterInOperation.Name = "chbPrinterInOperation";
            this.chbPrinterInOperation.Size = new System.Drawing.Size(218, 32);
            this.chbPrinterInOperation.TabIndex = 5;
            this.chbPrinterInOperation.Text = "وجود پرینت در عملیات ثبت";
            this.chbPrinterInOperation.UseVisualStyleBackColor = true;
            this.chbPrinterInOperation.Visible = false;
            // 
            // rbnShowSaveDialog
            // 
            this.rbnShowSaveDialog.AutoSize = true;
            this.rbnShowSaveDialog.Location = new System.Drawing.Point(328, 95);
            this.rbnShowSaveDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnShowSaveDialog.Name = "rbnShowSaveDialog";
            this.rbnShowSaveDialog.Size = new System.Drawing.Size(281, 32);
            this.rbnShowSaveDialog.TabIndex = 4;
            this.rbnShowSaveDialog.Text = "نمایش دیالوگ بعد از هر عملیات ثبت";
            this.rbnShowSaveDialog.UseVisualStyleBackColor = true;
            this.rbnShowSaveDialog.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "نوع چاپ:";
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "مدل چاپگر :";
            // 
            // cmbKindPrint
            // 
            this.cmbKindPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKindPrint.FormattingEnabled = true;
            this.cmbKindPrint.Items.AddRange(new object[] {
            "A5",
            "A6"});
            this.cmbKindPrint.Location = new System.Drawing.Point(104, 56);
            this.cmbKindPrint.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbKindPrint.Name = "cmbKindPrint";
            this.cmbKindPrint.Size = new System.Drawing.Size(80, 35);
            this.cmbKindPrint.TabIndex = 0;
            this.cmbKindPrint.Visible = false;
            // 
            // cmbInstalledPrinter
            // 
            this.cmbInstalledPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstalledPrinter.FormattingEnabled = true;
            this.cmbInstalledPrinter.Location = new System.Drawing.Point(104, 23);
            this.cmbInstalledPrinter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbInstalledPrinter.Name = "cmbInstalledPrinter";
            this.cmbInstalledPrinter.Size = new System.Drawing.Size(446, 35);
            this.cmbInstalledPrinter.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbNotifApp);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(646, 364);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chbNotifApp
            // 
            this.chbNotifApp.AutoSize = true;
            this.chbNotifApp.Location = new System.Drawing.Point(533, 17);
            this.chbNotifApp.Name = "chbNotifApp";
            this.chbNotifApp.Size = new System.Drawing.Size(131, 32);
            this.chbNotifApp.TabIndex = 2;
            this.chbNotifApp.Text = "نرم افزار نوتیف";
            this.chbNotifApp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.rbnBarCodeProductId);
            this.groupBox2.Controls.Add(this.txtDataSpliter);
            this.groupBox2.Controls.Add(this.lblBarcodeIndex);
            this.groupBox2.Controls.Add(this.txtBarcodeIndex);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBarcodeLength2);
            this.groupBox2.Controls.Add(this.txtBarcodeLength1);
            this.groupBox2.Controls.Add(this.lblBarCodeOtherDataSplitter);
            this.groupBox2.Controls.Add(this.rbnBarCodeProductSerial);
            this.groupBox2.Controls.Add(this.rbnBarCodeProductCode);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Size = new System.Drawing.Size(308, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیمات داده‌های بارکد";
            // 
            // rbnBarCodeProductId
            // 
            this.rbnBarCodeProductId.AutoSize = true;
            this.rbnBarCodeProductId.Location = new System.Drawing.Point(332, 33);
            this.rbnBarCodeProductId.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.rbnBarCodeProductId.Name = "rbnBarCodeProductId";
            this.rbnBarCodeProductId.Size = new System.Drawing.Size(50, 32);
            this.rbnBarCodeProductId.TabIndex = 11;
            this.rbnBarCodeProductId.Text = "ID";
            this.rbnBarCodeProductId.UseVisualStyleBackColor = true;
            // 
            // txtDataSpliter
            // 
            this.txtDataSpliter.Location = new System.Drawing.Point(414, 68);
            this.txtDataSpliter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataSpliter.MaxLength = 1;
            this.txtDataSpliter.Name = "txtDataSpliter";
            this.txtDataSpliter.Size = new System.Drawing.Size(52, 35);
            this.txtDataSpliter.TabIndex = 10;
            this.txtDataSpliter.Text = ",";
            // 
            // lblBarcodeIndex
            // 
            this.lblBarcodeIndex.AutoSize = true;
            this.lblBarcodeIndex.Location = new System.Drawing.Point(468, 110);
            this.lblBarcodeIndex.Name = "lblBarcodeIndex";
            this.lblBarcodeIndex.Size = new System.Drawing.Size(109, 28);
            this.lblBarcodeIndex.TabIndex = 9;
            this.lblBarcodeIndex.Text = "ایندکس اصلی:";
            // 
            // txtBarcodeIndex
            // 
            this.txtBarcodeIndex.Location = new System.Drawing.Point(430, 106);
            this.txtBarcodeIndex.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBarcodeIndex.MaxLength = 1;
            this.txtBarcodeIndex.Name = "txtBarcodeIndex";
            this.txtBarcodeIndex.Size = new System.Drawing.Size(36, 35);
            this.txtBarcodeIndex.TabIndex = 8;
            this.txtBarcodeIndex.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "یا";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "طول بار کد یا QRCode :";
            // 
            // txtBarcodeLength2
            // 
            this.txtBarcodeLength2.Location = new System.Drawing.Point(369, 146);
            this.txtBarcodeLength2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBarcodeLength2.MaxLength = 2;
            this.txtBarcodeLength2.Name = "txtBarcodeLength2";
            this.txtBarcodeLength2.Size = new System.Drawing.Size(36, 35);
            this.txtBarcodeLength2.TabIndex = 5;
            this.txtBarcodeLength2.Text = "0";
            // 
            // txtBarcodeLength1
            // 
            this.txtBarcodeLength1.Location = new System.Drawing.Point(430, 146);
            this.txtBarcodeLength1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBarcodeLength1.MaxLength = 2;
            this.txtBarcodeLength1.Name = "txtBarcodeLength1";
            this.txtBarcodeLength1.Size = new System.Drawing.Size(36, 35);
            this.txtBarcodeLength1.TabIndex = 5;
            this.txtBarcodeLength1.Text = "0";
            // 
            // lblBarCodeOtherDataSplitter
            // 
            this.lblBarCodeOtherDataSplitter.AutoSize = true;
            this.lblBarCodeOtherDataSplitter.Location = new System.Drawing.Point(472, 71);
            this.lblBarCodeOtherDataSplitter.Name = "lblBarCodeOtherDataSplitter";
            this.lblBarCodeOtherDataSplitter.Size = new System.Drawing.Size(218, 28);
            this.lblBarCodeOtherDataSplitter.TabIndex = 4;
            this.lblBarCodeOtherDataSplitter.Text = "کاراکتر جداکننده میان داده ها :";
            // 
            // rbnBarCodeProductSerial
            // 
            this.rbnBarCodeProductSerial.AutoSize = true;
            this.rbnBarCodeProductSerial.Checked = true;
            this.rbnBarCodeProductSerial.Location = new System.Drawing.Point(456, 33);
            this.rbnBarCodeProductSerial.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.rbnBarCodeProductSerial.Name = "rbnBarCodeProductSerial";
            this.rbnBarCodeProductSerial.Size = new System.Drawing.Size(100, 32);
            this.rbnBarCodeProductSerial.TabIndex = 2;
            this.rbnBarCodeProductSerial.TabStop = true;
            this.rbnBarCodeProductSerial.Text = "سریال کالا";
            this.rbnBarCodeProductSerial.UseVisualStyleBackColor = true;
            // 
            // rbnBarCodeProductCode
            // 
            this.rbnBarCodeProductCode.AutoSize = true;
            this.rbnBarCodeProductCode.Location = new System.Drawing.Point(576, 33);
            this.rbnBarCodeProductCode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.rbnBarCodeProductCode.Name = "rbnBarCodeProductCode";
            this.rbnBarCodeProductCode.Size = new System.Drawing.Size(77, 32);
            this.rbnBarCodeProductCode.TabIndex = 0;
            this.rbnBarCodeProductCode.Text = "کد کالا";
            this.rbnBarCodeProductCode.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tabPage2.Size = new System.Drawing.Size(646, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تنظیمات Rfid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIgnoreEpcList);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtReaderPort);
            this.groupBox1.Controls.Add(this.txtReaderPower);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDeviceModel);
            this.groupBox1.Controls.Add(this.pnlComsSetting);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(640, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات RFID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "پورت اتصال:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "قدرت انتشار:";
            // 
            // txtReaderPort
            // 
            this.txtReaderPort.Location = new System.Drawing.Point(6, 40);
            this.txtReaderPort.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtReaderPort.MaxLength = 5;
            this.txtReaderPort.Name = "txtReaderPort";
            this.txtReaderPort.Size = new System.Drawing.Size(75, 35);
            this.txtReaderPort.TabIndex = 10;
            // 
            // txtReaderPower
            // 
            this.txtReaderPower.Location = new System.Drawing.Point(195, 39);
            this.txtReaderPower.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtReaderPower.MaxLength = 2;
            this.txtReaderPower.Name = "txtReaderPower";
            this.txtReaderPower.Size = new System.Drawing.Size(69, 35);
            this.txtReaderPower.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "مدل میز :";
            // 
            // cmbDeviceModel
            // 
            this.cmbDeviceModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceModel.FormattingEnabled = true;
            this.cmbDeviceModel.Items.AddRange(new object[] {
            "6061",
            "Tiny",
            "T64"});
            this.cmbDeviceModel.Location = new System.Drawing.Point(376, 39);
            this.cmbDeviceModel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbDeviceModel.Name = "cmbDeviceModel";
            this.cmbDeviceModel.Size = new System.Drawing.Size(190, 35);
            this.cmbDeviceModel.TabIndex = 0;
            this.cmbDeviceModel.SelectedIndexChanged += new System.EventHandler(this.cmbDeviceModel_SelectedIndexChanged);
            // 
            // pnlComsSetting
            // 
            this.pnlComsSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlComsSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComsSetting.Location = new System.Drawing.Point(3, 212);
            this.pnlComsSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlComsSetting.Name = "pnlComsSetting";
            this.pnlComsSetting.Size = new System.Drawing.Size(634, 125);
            this.pnlComsSetting.TabIndex = 2;
            this.pnlComsSetting.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // txtIgnoreEpcList
            // 
            this.txtIgnoreEpcList.Location = new System.Drawing.Point(6, 89);
            this.txtIgnoreEpcList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtIgnoreEpcList.MaxLength = 5;
            this.txtIgnoreEpcList.Multiline = true;
            this.txtIgnoreEpcList.Name = "txtIgnoreEpcList";
            this.txtIgnoreEpcList.Size = new System.Drawing.Size(511, 85);
            this.txtIgnoreEpcList.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(519, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 28);
            this.label12.TabIndex = 11;
            this.label12.Text = "ignoreEpcList:";
            // 
            // chbSetParentForSerials
            // 
            this.chbSetParentForSerials.AutoSize = true;
            this.chbSetParentForSerials.Location = new System.Drawing.Point(148, 262);
            this.chbSetParentForSerials.Name = "chbSetParentForSerials";
            this.chbSetParentForSerials.Size = new System.Drawing.Size(210, 32);
            this.chbSetParentForSerials.TabIndex = 8;
            this.chbSetParentForSerials.Text = "امکان گروه بندی سریال ها";
            this.chbSetParentForSerials.UseVisualStyleBackColor = true;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 514);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     تنظیمات";
            this.Load += new System.EventHandler(this.formSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSetting_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowReportFiles)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInstalledPrinter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBarCodeOtherDataSplitter;
        private System.Windows.Forms.RadioButton rbnBarCodeProductSerial;
        private System.Windows.Forms.RadioButton rbnBarCodeProductCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeviceModel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlComsSetting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarcodeLength1;
        private System.Windows.Forms.CheckBox chbPrinterInOperation;
        private System.Windows.Forms.CheckBox rbnShowSaveDialog;
        private System.Windows.Forms.Label lblBarcodeIndex;
        private System.Windows.Forms.TextBox txtBarcodeIndex;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvShowReportFiles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtDataSpliter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarcodeLength2;
        private System.Windows.Forms.RadioButton rbnBarCodeProductId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKindPrint;
        private System.Windows.Forms.CheckBox chbLogin;
        private System.Windows.Forms.ComboBox cmbKindRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbMergPrintToPDF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReaderPort;
        private System.Windows.Forms.TextBox txtReaderPower;
        private System.Windows.Forms.CheckBox chbControlPrintFormatByBrand;
        private System.Windows.Forms.CheckBox chbGetListSerial;
        private System.Windows.Forms.CheckBox chbAutoDetecteShift;
        private System.Windows.Forms.TextBox txtSerialLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbNotifApp;
        private System.Windows.Forms.CheckBox chbZpl;
        private System.Windows.Forms.CheckBox chbAllowShowOnlyPrintFormBeforeSavePrintAction;
        private System.Windows.Forms.CheckBox chbRegisterCountEvryTimeIsOne;
        private System.Windows.Forms.CheckBox chbPrintPreviewBeforePrint;
        private System.Windows.Forms.CheckBox chbActiveRegisterFormByOneSerial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIgnoreEpcList;
        private System.Windows.Forms.CheckBox chbSetParentForSerials;
    }
}