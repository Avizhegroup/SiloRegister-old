using DocumentFormat.OpenXml.Wordprocessing;
using Syncfusion.Pdf.Graphics;
using System.Web.UI.WebControls;

namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmStoreRegisterTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreRegisterTags));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlDynamicFeilds = new System.Windows.Forms.Panel();
            this.btnPrintRegisterTags = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bntComputeProductPackCount = new System.Windows.Forms.PictureBox();
            this.txtProductCountInPack = new System.Windows.Forms.MaskedTextBox();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.PictureBox();
            this.txtProductCode = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductSize = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPackValue = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductRegCode = new System.Windows.Forms.MaskedTextBox();
            this.txtProductValue = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProductENTitle = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbProductStatus = new System.Windows.Forms.ComboBox();
            this.txtProductUnit = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPackWeight = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPackVolume = new System.Windows.Forms.MaskedTextBox();
            this.txtProductType = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblShiftTitle = new System.Windows.Forms.Label();
            this.lblDayName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchDoc = new System.Windows.Forms.PictureBox();
            this.btnGetSerialsList = new System.Windows.Forms.Button();
            this.lblPrintActionId = new System.Windows.Forms.Label();
            this.lblPrintActionStatus = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNextActionId = new System.Windows.Forms.Button();
            this.btnPreviousActionId = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSetParrents = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.cmbProductionLine = new System.Windows.Forms.ComboBox();
            this.cmbProductionShift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumentId = new System.Windows.Forms.MaskedTextBox();
            this.txtCount = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.btnChangeRegisterDate = new System.Windows.Forms.Button();
            this.btnRepCancelRegisterTag = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRepRegisterTag = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDefineProductType = new System.Windows.Forms.Button();
            this.btnDefineProduct = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlComputeConvertWeightToProductPackValue = new System.Windows.Forms.Panel();
            this.txtAllWeightForConvert = new System.Windows.Forms.MaskedTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.lblAverageWeight = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnConfirmpnlComputeConvertWeightToProductPackValue = new System.Windows.Forms.Label();
            this.btnComputepnlComputeConvertWeightToProductPackValue = new System.Windows.Forms.Label();
            this.btnCancelpnlComputeConvertWeightToProductPackValue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pnlDocs = new System.Windows.Forms.Panel();
            this.txtSearchDocInlist = new System.Windows.Forms.TextBox();
            this.dgvDocsList = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbtnSelectDoc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelPnlDocs = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlGetSerialList = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.dgvTempSerialList = new System.Windows.Forms.DataGridView();
            this.NewSerialTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGetSerialListCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGetSerialListSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnComputeSerialsList = new System.Windows.Forms.Button();
            this.txtToSerial = new System.Windows.Forms.MaskedTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDeleteCharTo = new System.Windows.Forms.MaskedTextBox();
            this.txtDeleteCharFrom = new System.Windows.Forms.MaskedTextBox();
            this.txtFromSerial = new System.Windows.Forms.MaskedTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblExcelFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetExcel = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.btnConfirmMultiProductInOnePrintActionId = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCountMultiProductInOnePrintActionId = new System.Windows.Forms.Label();
            this.btnCancelMultiProductInOnePrintActionId = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dgvMultiProductInOnePrintActionId = new System.Windows.Forms.DataGridView();
            this.dgvMultiProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductRegCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductItemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductCountInPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductFlagSave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiDocCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMultiProductbtnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMultiProductInOnePrintActionId = new System.Windows.Forms.Panel();
            this.pnlProductTechnicalData = new System.Windows.Forms.Panel();
            this.btnClosepnlDocumentInfo = new System.Windows.Forms.Label();
            this.dgvDocumentItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentItemProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentItemRemain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbtnSelectProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDocumentHeader = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCancelpnlDocumentInfo = new System.Windows.Forms.Label();
            this.pnlDocumentInfo = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntComputeProductPackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchProduct)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchDoc)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlComputeConvertWeightToProductPackValue.SuspendLayout();
            this.pnlDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocsList)).BeginInit();
            this.pnlGetSerialList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempSerialList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiProductInOnePrintActionId)).BeginInit();
            this.pnlMultiProductInOnePrintActionId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentHeader)).BeginInit();
            this.pnlDocumentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "6.png");
            this.imageList2.Images.SetKeyName(1, "7.png");
            this.imageList2.Images.SetKeyName(2, "8.png");
            this.imageList2.Images.SetKeyName(3, "4 copy.PNG");
            this.imageList2.Images.SetKeyName(4, "5 copy.PNG");
            this.imageList2.Images.SetKeyName(5, "printer.png");
            this.imageList2.Images.SetKeyName(6, "settings.png");
            this.imageList2.Images.SetKeyName(7, "PngItem_2560255.png");
            this.imageList2.Images.SetKeyName(8, "serial.png");
            this.imageList2.Images.SetKeyName(9, "43533-200.png");
            this.imageList2.Images.SetKeyName(10, "cancel-131964784714462788.png");
            this.imageList2.Images.SetKeyName(11, "Untitled-1.png");
            this.imageList2.Images.SetKeyName(12, "256-256-5948f81b64e21ca7f2fdb97148a03f12-note.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save_iconsss.png");
            this.imageList1.Images.SetKeyName(1, "printer-512.png");
            this.imageList1.Images.SetKeyName(2, "Organic-Search-Icon.png");
            this.imageList1.Images.SetKeyName(3, "message.png");
            this.imageList1.Images.SetKeyName(4, "brand2.0_feature_icon_management_setting.png");
            this.imageList1.Images.SetKeyName(5, "Search-Icon.PNG");
            this.imageList1.Images.SetKeyName(6, "printer.png");
            this.imageList1.Images.SetKeyName(7, "settings.png");
            this.imageList1.Images.SetKeyName(8, "useer.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_clock
            // 
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlDynamicFeilds
            // 
            this.pnlDynamicFeilds.BackColor = System.Drawing.Color.White;
            this.pnlDynamicFeilds.Location = new System.Drawing.Point(988, 629);
            this.pnlDynamicFeilds.Name = "pnlDynamicFeilds";
            this.pnlDynamicFeilds.Size = new System.Drawing.Size(376, 109);
            this.pnlDynamicFeilds.TabIndex = 56;
            // 
            // btnPrintRegisterTags
            // 
            this.btnPrintRegisterTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintRegisterTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnPrintRegisterTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintRegisterTags.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintRegisterTags.FlatAppearance.BorderSize = 0;
            this.btnPrintRegisterTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintRegisterTags.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnPrintRegisterTags.ForeColor = System.Drawing.Color.Black;
            this.btnPrintRegisterTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintRegisterTags.ImageKey = "5 copy.PNG";
            this.btnPrintRegisterTags.Location = new System.Drawing.Point(4, 0);
            this.btnPrintRegisterTags.Name = "btnPrintRegisterTags";
            this.btnPrintRegisterTags.Size = new System.Drawing.Size(170, 683);
            this.btnPrintRegisterTags.TabIndex = 51;
            this.btnPrintRegisterTags.TabStop = false;
            this.btnPrintRegisterTags.Text = "  چاپ لیبل >>\r\n(F7)";
            this.btnPrintRegisterTags.UseVisualStyleBackColor = false;
            this.btnPrintRegisterTags.Click += new System.EventHandler(this.btnPrintRegisterTags_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::RfidConnectRegister.Properties.Resources._9_9;
            this.pictureBox3.Location = new System.Drawing.Point(179, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(469, 682);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.bntComputeProductPackCount);
            this.panel4.Controls.Add(this.txtProductCountInPack);
            this.panel4.Controls.Add(this.txtProductTitle);
            this.panel4.Controls.Add(this.btnSearchProduct);
            this.panel4.Controls.Add(this.txtProductCode);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtProductSize);
            this.panel4.Controls.Add(this.txtProductPackValue);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtProductRegCode);
            this.panel4.Controls.Add(this.txtProductValue);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtProductENTitle);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.x);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.cmbProductStatus);
            this.panel4.Controls.Add(this.txtProductUnit);
            this.panel4.Controls.Add(this.txtProductPackWeight);
            this.panel4.Controls.Add(this.txtProductPackVolume);
            this.panel4.Controls.Add(this.txtProductType);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(735, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 342);
            this.panel4.TabIndex = 52;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // bntComputeProductPackCount
            // 
            this.bntComputeProductPackCount.Image = global::RfidConnectRegister.Properties.Resources.iconfinder_refresh_430112;
            this.bntComputeProductPackCount.Location = new System.Drawing.Point(323, 300);
            this.bntComputeProductPackCount.Name = "bntComputeProductPackCount";
            this.bntComputeProductPackCount.Size = new System.Drawing.Size(38, 34);
            this.bntComputeProductPackCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntComputeProductPackCount.TabIndex = 51;
            this.bntComputeProductPackCount.TabStop = false;
            this.bntComputeProductPackCount.Click += new System.EventHandler(this.bntComputeProductPackCount_Click);
            // 
            // txtProductCountInPack
            // 
            this.txtProductCountInPack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCountInPack.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductCountInPack.Location = new System.Drawing.Point(321, 298);
            this.txtProductCountInPack.Name = "txtProductCountInPack";
            this.txtProductCountInPack.Size = new System.Drawing.Size(167, 47);
            this.txtProductCountInPack.TabIndex = 35;
            this.txtProductCountInPack.Leave += new System.EventHandler(this.txtProductCountInPack_Leave);
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductTitle.Location = new System.Drawing.Point(4, 64);
            this.txtProductTitle.Multiline = true;
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.ReadOnly = true;
            this.txtProductTitle.Size = new System.Drawing.Size(484, 86);
            this.txtProductTitle.TabIndex = 52;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Image = global::RfidConnectRegister.Properties.Resources.Search_Icon;
            this.btnSearchProduct.Location = new System.Drawing.Point(6, 6);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(59, 51);
            this.btnSearchProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchProduct.TabIndex = 50;
            this.btnSearchProduct.TabStop = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 21F);
            this.txtProductCode.Location = new System.Drawing.Point(4, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(484, 67);
            this.txtProductCode.TabIndex = 3;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttxtProductCode_KeyDown);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label15.Location = new System.Drawing.Point(488, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 31);
            this.label15.TabIndex = 2;
            this.label15.Text = "عنوان کالا:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label5.Location = new System.Drawing.Point(491, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "کد کالا:";
            // 
            // txtProductSize
            // 
            this.txtProductSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProductSize.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductSize.Location = new System.Drawing.Point(4, 249);
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.ReadOnly = true;
            this.txtProductSize.Size = new System.Drawing.Size(189, 47);
            this.txtProductSize.TabIndex = 32;
            // 
            // txtProductPackValue
            // 
            this.txtProductPackValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProductPackValue.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductPackValue.Location = new System.Drawing.Point(4, 294);
            this.txtProductPackValue.Name = "txtProductPackValue";
            this.txtProductPackValue.Size = new System.Drawing.Size(189, 47);
            this.txtProductPackValue.TabIndex = 36;
            this.txtProductPackValue.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtProductPackValue_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label6.Location = new System.Drawing.Point(191, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "سایز کالا:";
            // 
            // txtProductRegCode
            // 
            this.txtProductRegCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductRegCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductRegCode.Location = new System.Drawing.Point(4, 156);
            this.txtProductRegCode.Name = "txtProductRegCode";
            this.txtProductRegCode.ReadOnly = true;
            this.txtProductRegCode.Size = new System.Drawing.Size(484, 47);
            this.txtProductRegCode.TabIndex = 28;
            this.txtProductRegCode.TextChanged += new System.EventHandler(this.txtProductTechnicalCode_TextChanged);
            // 
            // txtProductValue
            // 
            this.txtProductValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductValue.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductValue.Location = new System.Drawing.Point(7, 326);
            this.txtProductValue.Name = "txtProductValue";
            this.txtProductValue.ReadOnly = true;
            this.txtProductValue.Size = new System.Drawing.Size(113, 47);
            this.txtProductValue.TabIndex = 34;
            this.txtProductValue.Visible = false;
            this.txtProductValue.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtProductValue_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label14.Location = new System.Drawing.Point(218, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 33);
            this.label14.TabIndex = 48;
            this.label14.Text = "مقدار کالا:";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtProductENTitle
            // 
            this.txtProductENTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductENTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductENTitle.Location = new System.Drawing.Point(4, 161);
            this.txtProductENTitle.Name = "txtProductENTitle";
            this.txtProductENTitle.ReadOnly = true;
            this.txtProductENTitle.Size = new System.Drawing.Size(242, 47);
            this.txtProductENTitle.TabIndex = 30;
            this.txtProductENTitle.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label9.Location = new System.Drawing.Point(195, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 33);
            this.label9.TabIndex = 43;
            this.label9.Text = "حجم محموله:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label26.Location = new System.Drawing.Point(489, 251);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(117, 31);
            this.label26.TabIndex = 46;
            this.label26.Text = "رنگ کالا:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // x
            // 
            this.x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.x.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.x.Location = new System.Drawing.Point(491, 206);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(103, 31);
            this.x.TabIndex = 42;
            this.x.Text = "سالن تولید:";
            this.x.Click += new System.EventHandler(this.label11_Click);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label25.Location = new System.Drawing.Point(197, 211);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 33);
            this.label25.TabIndex = 45;
            this.label25.Text = "واحد کالا:";
            this.label25.Visible = false;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label12.Location = new System.Drawing.Point(196, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 33);
            this.label12.TabIndex = 42;
            this.label12.Text = "وزن محموله:";
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.5F);
            this.label13.Location = new System.Drawing.Point(483, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 31);
            this.label13.TabIndex = 44;
            this.label13.Text = "تعداد در محموله:";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label23.Location = new System.Drawing.Point(491, 160);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 31);
            this.label23.TabIndex = 47;
            this.label23.Text = "کد طرح:";
            // 
            // cmbProductStatus
            // 
            this.cmbProductStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProductStatus.Enabled = false;
            this.cmbProductStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.cmbProductStatus.FormattingEnabled = true;
            this.cmbProductStatus.Location = new System.Drawing.Point(321, 248);
            this.cmbProductStatus.Name = "cmbProductStatus";
            this.cmbProductStatus.Size = new System.Drawing.Size(167, 47);
            this.cmbProductStatus.TabIndex = 31;
            // 
            // txtProductUnit
            // 
            this.txtProductUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductUnit.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductUnit.Location = new System.Drawing.Point(242, 323);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.ReadOnly = true;
            this.txtProductUnit.Size = new System.Drawing.Size(112, 47);
            this.txtProductUnit.TabIndex = 33;
            this.txtProductUnit.Visible = false;
            // 
            // txtProductPackWeight
            // 
            this.txtProductPackWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductPackWeight.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductPackWeight.Location = new System.Drawing.Point(5, 338);
            this.txtProductPackWeight.Name = "txtProductPackWeight";
            this.txtProductPackWeight.ReadOnly = true;
            this.txtProductPackWeight.Size = new System.Drawing.Size(112, 47);
            this.txtProductPackWeight.TabIndex = 37;
            this.txtProductPackWeight.Visible = false;
            // 
            // txtProductPackVolume
            // 
            this.txtProductPackVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProductPackVolume.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductPackVolume.Location = new System.Drawing.Point(4, 201);
            this.txtProductPackVolume.Name = "txtProductPackVolume";
            this.txtProductPackVolume.ReadOnly = true;
            this.txtProductPackVolume.Size = new System.Drawing.Size(189, 47);
            this.txtProductPackVolume.TabIndex = 38;
            // 
            // txtProductType
            // 
            this.txtProductType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductType.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtProductType.Location = new System.Drawing.Point(321, 202);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.ReadOnly = true;
            this.txtProductType.Size = new System.Drawing.Size(167, 47);
            this.txtProductType.TabIndex = 37;
            this.txtProductType.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label24.Location = new System.Drawing.Point(194, 297);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(122, 31);
            this.label24.TabIndex = 41;
            this.label24.Text = "متراژ :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.lblUserName);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.lblTime);
            this.panel6.Controls.Add(this.lblShiftTitle);
            this.panel6.Controls.Add(this.lblDayName);
            this.panel6.Controls.Add(this.lblDate);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(3, 682);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(729, 43);
            this.panel6.TabIndex = 64;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUserName.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(618, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 28);
            this.lblUserName.TabIndex = 65;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.ImageKey = "PngItem_2560255.png";
            this.button8.ImageList = this.imageList2;
            this.button8.Location = new System.Drawing.Point(574, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(153, 36);
            this.button8.TabIndex = 64;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTime.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(310, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(110, 28);
            this.lblTime.TabIndex = 59;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShiftTitle
            // 
            this.lblShiftTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShiftTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.lblShiftTitle.ForeColor = System.Drawing.Color.White;
            this.lblShiftTitle.Location = new System.Drawing.Point(469, 7);
            this.lblShiftTitle.Name = "lblShiftTitle";
            this.lblShiftTitle.Size = new System.Drawing.Size(98, 28);
            this.lblShiftTitle.TabIndex = 58;
            // 
            // lblDayName
            // 
            this.lblDayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDayName.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.lblDayName.ForeColor = System.Drawing.Color.White;
            this.lblDayName.Location = new System.Drawing.Point(157, 7);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(103, 28);
            this.lblDayName.TabIndex = 57;
            this.lblDayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(48, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 28);
            this.lblDate.TabIndex = 60;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.ImageKey = "8.png";
            this.button7.ImageList = this.imageList2;
            this.button7.Location = new System.Drawing.Point(424, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 36);
            this.button7.TabIndex = 54;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.ImageKey = "7.png";
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(267, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 36);
            this.button6.TabIndex = 63;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "6.png";
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 36);
            this.button1.TabIndex = 54;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btnSearchDoc);
            this.panel5.Controls.Add(this.btnGetSerialsList);
            this.panel5.Controls.Add(this.lblPrintActionId);
            this.panel5.Controls.Add(this.lblPrintActionStatus);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.btnNextActionId);
            this.panel5.Controls.Add(this.btnPreviousActionId);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnSetParrents);
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cmbStore);
            this.panel5.Controls.Add(this.cmbProductionLine);
            this.panel5.Controls.Add(this.cmbProductionShift);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtDocumentId);
            this.panel5.Controls.Add(this.txtCount);
            this.panel5.Location = new System.Drawing.Point(735, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(627, 334);
            this.panel5.TabIndex = 53;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RfidConnectRegister.Properties.Resources._654116;
            this.pictureBox1.Location = new System.Drawing.Point(253, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnSearchDoc
            // 
            this.btnSearchDoc.Image = global::RfidConnectRegister.Properties.Resources.Search_Icon;
            this.btnSearchDoc.Location = new System.Drawing.Point(288, 56);
            this.btnSearchDoc.Name = "btnSearchDoc";
            this.btnSearchDoc.Size = new System.Drawing.Size(34, 36);
            this.btnSearchDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchDoc.TabIndex = 56;
            this.btnSearchDoc.TabStop = false;
            this.btnSearchDoc.Click += new System.EventHandler(this.btnSearchDoc_Click);
            // 
            // btnGetSerialsList
            // 
            this.btnGetSerialsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGetSerialsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetSerialsList.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGetSerialsList.FlatAppearance.BorderSize = 0;
            this.btnGetSerialsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSerialsList.Font = new System.Drawing.Font("IRANSans(FaNum)", 8F);
            this.btnGetSerialsList.ForeColor = System.Drawing.Color.White;
            this.btnGetSerialsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetSerialsList.ImageKey = "4 copy.PNG";
            this.btnGetSerialsList.Location = new System.Drawing.Point(253, 10);
            this.btnGetSerialsList.Name = "btnGetSerialsList";
            this.btnGetSerialsList.Size = new System.Drawing.Size(79, 35);
            this.btnGetSerialsList.TabIndex = 54;
            this.btnGetSerialsList.TabStop = false;
            this.btnGetSerialsList.Text = "دریافت لیست";
            this.btnGetSerialsList.UseVisualStyleBackColor = false;
            this.btnGetSerialsList.Click += new System.EventHandler(this.btnGetSerialsList_Click);
            // 
            // lblPrintActionId
            // 
            this.lblPrintActionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPrintActionId.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.lblPrintActionId.ForeColor = System.Drawing.Color.White;
            this.lblPrintActionId.Location = new System.Drawing.Point(81, 10);
            this.lblPrintActionId.Name = "lblPrintActionId";
            this.lblPrintActionId.Size = new System.Drawing.Size(79, 39);
            this.lblPrintActionId.TabIndex = 52;
            this.lblPrintActionId.Text = "0";
            this.lblPrintActionId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrintActionStatus
            // 
            this.lblPrintActionStatus.AutoSize = true;
            this.lblPrintActionStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.5F);
            this.lblPrintActionStatus.Location = new System.Drawing.Point(165, -6);
            this.lblPrintActionStatus.Name = "lblPrintActionStatus";
            this.lblPrintActionStatus.Size = new System.Drawing.Size(0, 36);
            this.lblPrintActionStatus.TabIndex = 53;
            this.lblPrintActionStatus.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.5F);
            this.label16.Location = new System.Drawing.Point(165, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 36);
            this.label16.TabIndex = 53;
            this.label16.Text = "کد عملیات:";
            // 
            // btnNextActionId
            // 
            this.btnNextActionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNextActionId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextActionId.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNextActionId.FlatAppearance.BorderSize = 0;
            this.btnNextActionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextActionId.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnNextActionId.ForeColor = System.Drawing.Color.White;
            this.btnNextActionId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextActionId.ImageKey = "4 copy.PNG";
            this.btnNextActionId.Location = new System.Drawing.Point(43, 10);
            this.btnNextActionId.Name = "btnNextActionId";
            this.btnNextActionId.Size = new System.Drawing.Size(36, 39);
            this.btnNextActionId.TabIndex = 50;
            this.btnNextActionId.TabStop = false;
            this.btnNextActionId.Text = "<";
            this.btnNextActionId.UseVisualStyleBackColor = false;
            this.btnNextActionId.Click += new System.EventHandler(this.btnNextActionId_Click);
            // 
            // btnPreviousActionId
            // 
            this.btnPreviousActionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPreviousActionId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousActionId.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPreviousActionId.FlatAppearance.BorderSize = 0;
            this.btnPreviousActionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousActionId.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnPreviousActionId.ForeColor = System.Drawing.Color.White;
            this.btnPreviousActionId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviousActionId.ImageKey = "4 copy.PNG";
            this.btnPreviousActionId.Location = new System.Drawing.Point(5, 10);
            this.btnPreviousActionId.Name = "btnPreviousActionId";
            this.btnPreviousActionId.Size = new System.Drawing.Size(36, 39);
            this.btnPreviousActionId.TabIndex = 50;
            this.btnPreviousActionId.TabStop = false;
            this.btnPreviousActionId.Text = ">";
            this.btnPreviousActionId.UseVisualStyleBackColor = false;
            this.btnPreviousActionId.Click += new System.EventHandler(this.btnPreviousActionId_Click);
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
            this.btnSave.ImageList = this.imageList2;
            this.btnSave.Location = new System.Drawing.Point(5, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 166);
            this.btnSave.TabIndex = 50;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "ثبت (F6)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label7.Location = new System.Drawing.Point(509, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "خط تولید:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetParrents
            // 
            this.btnSetParrents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnSetParrents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetParrents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSetParrents.FlatAppearance.BorderSize = 0;
            this.btnSetParrents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetParrents.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnSetParrents.ForeColor = System.Drawing.Color.Black;
            this.btnSetParrents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetParrents.ImageKey = "5 copy.PNG";
            this.btnSetParrents.Location = new System.Drawing.Point(5, 227);
            this.btnSetParrents.Name = "btnSetParrents";
            this.btnSetParrents.Size = new System.Drawing.Size(71, 92);
            this.btnSetParrents.TabIndex = 51;
            this.btnSetParrents.TabStop = false;
            this.btnSetParrents.Text = "گروه بندی";
            this.btnSetParrents.UseVisualStyleBackColor = false;
            this.btnSetParrents.Click += new System.EventHandler(this.btnSetParrents_Click);
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
            this.btnNew.ImageList = this.imageList2;
            this.btnNew.Location = new System.Drawing.Point(81, 227);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(164, 92);
            this.btnNew.TabIndex = 51;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "جدید (F5)";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label1.Location = new System.Drawing.Point(511, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "انبار تولید:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label8.Location = new System.Drawing.Point(511, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "شیفت تولید:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbStore
            // 
            this.cmbStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStore.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(252, 183);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(256, 45);
            this.cmbStore.TabIndex = 7;
            // 
            // cmbProductionLine
            // 
            this.cmbProductionLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductionLine.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.cmbProductionLine.FormattingEnabled = true;
            this.cmbProductionLine.Location = new System.Drawing.Point(252, 99);
            this.cmbProductionLine.Name = "cmbProductionLine";
            this.cmbProductionLine.Size = new System.Drawing.Size(256, 45);
            this.cmbProductionLine.TabIndex = 7;
            // 
            // cmbProductionShift
            // 
            this.cmbProductionShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductionShift.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.cmbProductionShift.FormattingEnabled = true;
            this.cmbProductionShift.Location = new System.Drawing.Point(252, 141);
            this.cmbProductionShift.Name = "cmbProductionShift";
            this.cmbProductionShift.Size = new System.Drawing.Size(256, 45);
            this.cmbProductionShift.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.5F);
            this.label4.Location = new System.Drawing.Point(509, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "شماره سند:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label10.Location = new System.Drawing.Point(513, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 31);
            this.label10.TabIndex = 9;
            this.label10.Text = "تعداد برگه:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDocumentId
            // 
            this.txtDocumentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentId.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtDocumentId.Location = new System.Drawing.Point(251, 54);
            this.txtDocumentId.Name = "txtDocumentId";
            this.txtDocumentId.Size = new System.Drawing.Size(257, 47);
            this.txtDocumentId.TabIndex = 10;
            this.txtDocumentId.TextChanged += new System.EventHandler(this.txtDocumentId_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtCount.Location = new System.Drawing.Point(251, 8);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(257, 47);
            this.txtCount.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnCancelRegister);
            this.panel3.Controls.Add(this.btnChangeRegisterDate);
            this.panel3.Controls.Add(this.btnRepCancelRegisterTag);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btnRepRegisterTag);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnDefineProductType);
            this.panel3.Controls.Add(this.btnDefineProduct);
            this.panel3.Location = new System.Drawing.Point(742, 743);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 10);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.ImageKey = "settings.png";
            this.button5.ImageList = this.imageList2;
            this.button5.Location = new System.Drawing.Point(217, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 111);
            this.button5.TabIndex = 88;
            this.button5.Text = "تنظیمات";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnCancelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelRegister.FlatAppearance.BorderSize = 0;
            this.btnCancelRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRegister.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnCancelRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelRegister.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelRegister.ImageKey = "cancel-131964784714462788.png";
            this.btnCancelRegister.ImageList = this.imageList2;
            this.btnCancelRegister.Location = new System.Drawing.Point(459, 3);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(75, 111);
            this.btnCancelRegister.TabIndex = 92;
            this.btnCancelRegister.Text = "ابطال رجیستر تگ";
            this.btnCancelRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelRegister.UseVisualStyleBackColor = false;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // btnChangeRegisterDate
            // 
            this.btnChangeRegisterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeRegisterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnChangeRegisterDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRegisterDate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChangeRegisterDate.FlatAppearance.BorderSize = 0;
            this.btnChangeRegisterDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangeRegisterDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangeRegisterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRegisterDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnChangeRegisterDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeRegisterDate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeRegisterDate.ImageKey = "256-256-5948f81b64e21ca7f2fdb97148a03f12-note.png";
            this.btnChangeRegisterDate.ImageList = this.imageList2;
            this.btnChangeRegisterDate.Location = new System.Drawing.Point(298, 3);
            this.btnChangeRegisterDate.Name = "btnChangeRegisterDate";
            this.btnChangeRegisterDate.Size = new System.Drawing.Size(75, 111);
            this.btnChangeRegisterDate.TabIndex = 90;
            this.btnChangeRegisterDate.Text = "تغییر تاریخ ثبت";
            this.btnChangeRegisterDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeRegisterDate.UseVisualStyleBackColor = false;
            this.btnChangeRegisterDate.Visible = false;
            this.btnChangeRegisterDate.Click += new System.EventHandler(this.btnChangeRegisterDate_Click);
            // 
            // btnRepCancelRegisterTag
            // 
            this.btnRepCancelRegisterTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepCancelRegisterTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnRepCancelRegisterTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepCancelRegisterTag.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRepCancelRegisterTag.FlatAppearance.BorderSize = 0;
            this.btnRepCancelRegisterTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRepCancelRegisterTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRepCancelRegisterTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepCancelRegisterTag.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnRepCancelRegisterTag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRepCancelRegisterTag.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepCancelRegisterTag.ImageKey = "43533-200.png";
            this.btnRepCancelRegisterTag.ImageList = this.imageList2;
            this.btnRepCancelRegisterTag.Location = new System.Drawing.Point(378, 3);
            this.btnRepCancelRegisterTag.Name = "btnRepCancelRegisterTag";
            this.btnRepCancelRegisterTag.Size = new System.Drawing.Size(75, 111);
            this.btnRepCancelRegisterTag.TabIndex = 90;
            this.btnRepCancelRegisterTag.Text = "تست رجیستر تگ";
            this.btnRepCancelRegisterTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRepCancelRegisterTag.UseVisualStyleBackColor = false;
            this.btnRepCancelRegisterTag.Click += new System.EventHandler(this.btnRepCancelRegisterTag_Click_1);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.ImageKey = "43533-200.png";
            this.button10.ImageList = this.imageList2;
            this.button10.Location = new System.Drawing.Point(136, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 111);
            this.button10.TabIndex = 89;
            this.button10.Text = "گزارش خطاهای رجیستر";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.ImageKey = "serial.png";
            this.button11.ImageList = this.imageList2;
            this.button11.Location = new System.Drawing.Point(7, -105);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(16, 40);
            this.button11.TabIndex = 93;
            this.button11.Text = "تست رجیستر تگ";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.button4.Location = new System.Drawing.Point(13, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 73);
            this.button4.TabIndex = 0;
            this.button4.Text = "تعریف وضعیت های کنترل کیفی ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.btnDefineProduct_Click);
            // 
            // btnRepRegisterTag
            // 
            this.btnRepRegisterTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepRegisterTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnRepRegisterTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepRegisterTag.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRepRegisterTag.FlatAppearance.BorderSize = 0;
            this.btnRepRegisterTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRepRegisterTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRepRegisterTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepRegisterTag.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnRepRegisterTag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRepRegisterTag.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepRegisterTag.ImageKey = "43533-200.png";
            this.btnRepRegisterTag.ImageList = this.imageList2;
            this.btnRepRegisterTag.Location = new System.Drawing.Point(540, 3);
            this.btnRepRegisterTag.Name = "btnRepRegisterTag";
            this.btnRepRegisterTag.Size = new System.Drawing.Size(75, 111);
            this.btnRepRegisterTag.TabIndex = 91;
            this.btnRepRegisterTag.Text = "گزارش رجیستر تگ ها";
            this.btnRepRegisterTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRepRegisterTag.UseVisualStyleBackColor = false;
            this.btnRepRegisterTag.Click += new System.EventHandler(this.btnRepRegisterTag_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.button3.Location = new System.Drawing.Point(136, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 73);
            this.button3.TabIndex = 0;
            this.button3.Text = "تعریف شیفت های تولید";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.btnDefineProduct_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.button2.Location = new System.Drawing.Point(248, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 73);
            this.button2.TabIndex = 0;
            this.button2.Text = "تعریف خطوط تولید";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.btnDefineProduct_Click);
            // 
            // btnDefineProductType
            // 
            this.btnDefineProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefineProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDefineProductType.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDefineProductType.FlatAppearance.BorderSize = 0;
            this.btnDefineProductType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDefineProductType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDefineProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefineProductType.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnDefineProductType.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDefineProductType.ImageKey = "256-256-5948f81b64e21ca7f2fdb97148a03f12-note.png";
            this.btnDefineProductType.ImageList = this.imageList2;
            this.btnDefineProductType.Location = new System.Drawing.Point(315, 144);
            this.btnDefineProductType.Name = "btnDefineProductType";
            this.btnDefineProductType.Size = new System.Drawing.Size(75, 111);
            this.btnDefineProductType.TabIndex = 0;
            this.btnDefineProductType.Text = "تعریف سالن تولید";
            this.btnDefineProductType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDefineProductType.UseVisualStyleBackColor = false;
            this.btnDefineProductType.Visible = false;
            this.btnDefineProductType.Click += new System.EventHandler(this.btnDefineProductType_Click);
            // 
            // btnDefineProduct
            // 
            this.btnDefineProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefineProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDefineProduct.FlatAppearance.BorderSize = 0;
            this.btnDefineProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDefineProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDefineProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefineProduct.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnDefineProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDefineProduct.ImageKey = "256-256-5948f81b64e21ca7f2fdb97148a03f12-note.png";
            this.btnDefineProduct.ImageList = this.imageList2;
            this.btnDefineProduct.Location = new System.Drawing.Point(234, 144);
            this.btnDefineProduct.Name = "btnDefineProduct";
            this.btnDefineProduct.Size = new System.Drawing.Size(75, 111);
            this.btnDefineProduct.TabIndex = 0;
            this.btnDefineProduct.Text = "تعریف کالا";
            this.btnDefineProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDefineProduct.UseVisualStyleBackColor = false;
            this.btnDefineProduct.Visible = false;
            this.btnDefineProduct.Click += new System.EventHandler(this.btnDefineProduct_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = global::RfidConnectRegister.Properties.Resources.images__6_2;
            this.pictureBox5.Location = new System.Drawing.Point(746, 726);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.Controls.Add(this.pnlComputeConvertWeightToProductPackValue);
            this.pnlData.Controls.Add(this.pnlDocs);
            this.pnlData.Controls.Add(this.pnlGetSerialList);
            this.pnlData.Controls.Add(this.pictureBox5);
            this.pnlData.Controls.Add(this.panel3);
            this.pnlData.Controls.Add(this.panel5);
            this.pnlData.Controls.Add(this.panel6);
            this.pnlData.Controls.Add(this.panel4);
            this.pnlData.Controls.Add(this.pictureBox3);
            this.pnlData.Controls.Add(this.btnPrintRegisterTags);
            this.pnlData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlData.Enabled = false;
            this.pnlData.Location = new System.Drawing.Point(3, 1);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1365, 747);
            this.pnlData.TabIndex = 4;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // pnlComputeConvertWeightToProductPackValue
            // 
            this.pnlComputeConvertWeightToProductPackValue.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlComputeConvertWeightToProductPackValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.txtAllWeightForConvert);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label37);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.lblAverageWeight);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label36);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label28);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label40);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label32);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label35);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label31);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label27);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.btnConfirmpnlComputeConvertWeightToProductPackValue);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.btnComputepnlComputeConvertWeightToProductPackValue);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.btnCancelpnlComputeConvertWeightToProductPackValue);
            this.pnlComputeConvertWeightToProductPackValue.Controls.Add(this.label22);
            this.pnlComputeConvertWeightToProductPackValue.Location = new System.Drawing.Point(765, 256);
            this.pnlComputeConvertWeightToProductPackValue.Name = "pnlComputeConvertWeightToProductPackValue";
            this.pnlComputeConvertWeightToProductPackValue.Size = new System.Drawing.Size(593, 216);
            this.pnlComputeConvertWeightToProductPackValue.TabIndex = 85;
            this.pnlComputeConvertWeightToProductPackValue.Visible = false;
            // 
            // txtAllWeightForConvert
            // 
            this.txtAllWeightForConvert.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
            this.txtAllWeightForConvert.Location = new System.Drawing.Point(367, 160);
            this.txtAllWeightForConvert.Name = "txtAllWeightForConvert";
            this.txtAllWeightForConvert.Size = new System.Drawing.Size(124, 45);
            this.txtAllWeightForConvert.TabIndex = 59;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label37.Location = new System.Drawing.Point(367, 119);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(124, 37);
            this.label37.TabIndex = 58;
            this.label37.Text = "0";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageWeight
            // 
            this.lblAverageWeight.BackColor = System.Drawing.Color.White;
            this.lblAverageWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageWeight.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.lblAverageWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAverageWeight.Location = new System.Drawing.Point(87, 161);
            this.lblAverageWeight.Name = "lblAverageWeight";
            this.lblAverageWeight.Size = new System.Drawing.Size(141, 37);
            this.lblAverageWeight.TabIndex = 58;
            this.lblAverageWeight.Text = "0";
            this.lblAverageWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label36.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label36.Location = new System.Drawing.Point(87, 119);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(141, 37);
            this.label36.TabIndex = 58;
            this.label36.Text = "0";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label28.Location = new System.Drawing.Point(86, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(405, 68);
            this.label28.TabIndex = 58;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label40.Location = new System.Drawing.Point(493, 122);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 31);
            this.label40.TabIndex = 57;
            this.label40.Text = "تعداد :";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label32.Location = new System.Drawing.Point(493, 162);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 31);
            this.label32.TabIndex = 57;
            this.label32.Text = "وزن کل:";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label35.Location = new System.Drawing.Point(228, 167);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(113, 31);
            this.label35.TabIndex = 57;
            this.label35.Text = "وزن میانگین:";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label31.Location = new System.Drawing.Point(228, 122);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(137, 31);
            this.label31.TabIndex = 57;
            this.label31.Text = "وزن پیش فرض:";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label27.Location = new System.Drawing.Point(491, 53);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 54);
            this.label27.TabIndex = 57;
            this.label27.Text = "عنوان کالا:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmpnlComputeConvertWeightToProductPackValue
            // 
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.Location = new System.Drawing.Point(8, 144);
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.Name = "btnConfirmpnlComputeConvertWeightToProductPackValue";
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.Size = new System.Drawing.Size(68, 54);
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.TabIndex = 55;
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.Text = "تأیید";
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmpnlComputeConvertWeightToProductPackValue.Click += new System.EventHandler(this.btnConfirmpnlComputeConvertWeightToProductPackValue_Click);
            // 
            // btnComputepnlComputeConvertWeightToProductPackValue
            // 
            this.btnComputepnlComputeConvertWeightToProductPackValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnComputepnlComputeConvertWeightToProductPackValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnComputepnlComputeConvertWeightToProductPackValue.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.btnComputepnlComputeConvertWeightToProductPackValue.Location = new System.Drawing.Point(8, 50);
            this.btnComputepnlComputeConvertWeightToProductPackValue.Name = "btnComputepnlComputeConvertWeightToProductPackValue";
            this.btnComputepnlComputeConvertWeightToProductPackValue.Size = new System.Drawing.Size(68, 84);
            this.btnComputepnlComputeConvertWeightToProductPackValue.TabIndex = 55;
            this.btnComputepnlComputeConvertWeightToProductPackValue.Text = "محاسبه وزن میانگین";
            this.btnComputepnlComputeConvertWeightToProductPackValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComputepnlComputeConvertWeightToProductPackValue.Click += new System.EventHandler(this.btnComputepnlComputeConvertWeightToProductPackValue_Click);
            // 
            // btnCancelpnlComputeConvertWeightToProductPackValue
            // 
            this.btnCancelpnlComputeConvertWeightToProductPackValue.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelpnlComputeConvertWeightToProductPackValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancelpnlComputeConvertWeightToProductPackValue.Location = new System.Drawing.Point(-1, 0);
            this.btnCancelpnlComputeConvertWeightToProductPackValue.Name = "btnCancelpnlComputeConvertWeightToProductPackValue";
            this.btnCancelpnlComputeConvertWeightToProductPackValue.Size = new System.Drawing.Size(49, 42);
            this.btnCancelpnlComputeConvertWeightToProductPackValue.TabIndex = 55;
            this.btnCancelpnlComputeConvertWeightToProductPackValue.Text = "بستن پنجره";
            this.btnCancelpnlComputeConvertWeightToProductPackValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelpnlComputeConvertWeightToProductPackValue.Click += new System.EventHandler(this.btnCancelpnlComputeConvertWeightToProductPackValue_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Lavender;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(591, 41);
            this.label22.TabIndex = 56;
            this.label22.Text = "محاسبه مقدار هر سریال بر اساس میانگین وزن کل";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDocs
            // 
            this.pnlDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDocs.Controls.Add(this.txtSearchDocInlist);
            this.pnlDocs.Controls.Add(this.dgvDocsList);
            this.pnlDocs.Controls.Add(this.btnCancelPnlDocs);
            this.pnlDocs.Controls.Add(this.label18);
            this.pnlDocs.Controls.Add(this.label20);
            this.pnlDocs.Location = new System.Drawing.Point(960, 178);
            this.pnlDocs.Name = "pnlDocs";
            this.pnlDocs.Size = new System.Drawing.Size(391, 474);
            this.pnlDocs.TabIndex = 84;
            this.pnlDocs.Visible = false;
            // 
            // txtSearchDocInlist
            // 
            this.txtSearchDocInlist.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.txtSearchDocInlist.Location = new System.Drawing.Point(8, 48);
            this.txtSearchDocInlist.Name = "txtSearchDocInlist";
            this.txtSearchDocInlist.Size = new System.Drawing.Size(243, 47);
            this.txtSearchDocInlist.TabIndex = 59;
            this.txtSearchDocInlist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvDocsList
            // 
            this.dgvDocsList.AllowUserToAddRows = false;
            this.dgvDocsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.dgvDocsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDocsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column14,
            this.colbtnSelectDoc});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocsList.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDocsList.Location = new System.Drawing.Point(0, 92);
            this.dgvDocsList.Name = "dgvDocsList";
            this.dgvDocsList.ReadOnly = true;
            this.dgvDocsList.RowHeadersWidth = 10;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.dgvDocsList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDocsList.RowTemplate.Height = 45;
            this.dgvDocsList.Size = new System.Drawing.Size(389, 380);
            this.dgvDocsList.TabIndex = 58;
            this.dgvDocsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocsList_CellClick);
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "کد سند";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.HeaderText = "توضیحات سند";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // colbtnSelectDoc
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = "انتخاب";
            this.colbtnSelectDoc.DefaultCellStyle = dataGridViewCellStyle13;
            this.colbtnSelectDoc.HeaderText = "انتخاب";
            this.colbtnSelectDoc.MinimumWidth = 6;
            this.colbtnSelectDoc.Name = "colbtnSelectDoc";
            this.colbtnSelectDoc.ReadOnly = true;
            this.colbtnSelectDoc.Width = 60;
            // 
            // btnCancelPnlDocs
            // 
            this.btnCancelPnlDocs.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelPnlDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancelPnlDocs.Location = new System.Drawing.Point(-1, 0);
            this.btnCancelPnlDocs.Name = "btnCancelPnlDocs";
            this.btnCancelPnlDocs.Size = new System.Drawing.Size(49, 42);
            this.btnCancelPnlDocs.TabIndex = 54;
            this.btnCancelPnlDocs.Text = "بستن پنجره";
            this.btnCancelPnlDocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelPnlDocs.Click += new System.EventHandler(this.btnCancelPnlDocs_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Lavender;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(389, 44);
            this.label18.TabIndex = 39;
            this.label18.Text = "لیست سند ها";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label20.Location = new System.Drawing.Point(242, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 31);
            this.label20.TabIndex = 2;
            this.label20.Text = "جستجوی سند:";
            // 
            // pnlGetSerialList
            // 
            this.pnlGetSerialList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGetSerialList.Controls.Add(this.button13);
            this.pnlGetSerialList.Controls.Add(this.dgvTempSerialList);
            this.pnlGetSerialList.Controls.Add(this.txtGetSerialListCount);
            this.pnlGetSerialList.Controls.Add(this.label11);
            this.pnlGetSerialList.Controls.Add(this.btnGetSerialListSave);
            this.pnlGetSerialList.Controls.Add(this.tabControl1);
            this.pnlGetSerialList.Location = new System.Drawing.Point(183, 23);
            this.pnlGetSerialList.Name = "pnlGetSerialList";
            this.pnlGetSerialList.Size = new System.Drawing.Size(711, 473);
            this.pnlGetSerialList.TabIndex = 65;
            this.pnlGetSerialList.Visible = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.ImageKey = "cancel-131964784714462788.png";
            this.button13.ImageList = this.imageList2;
            this.button13.Location = new System.Drawing.Point(4, 429);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(126, 36);
            this.button13.TabIndex = 51;
            this.button13.TabStop = false;
            this.button13.Text = "انصراف";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dgvTempSerialList
            // 
            this.dgvTempSerialList.AllowUserToAddRows = false;
            this.dgvTempSerialList.AllowUserToDeleteRows = false;
            this.dgvTempSerialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempSerialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NewSerialTemp});
            this.dgvTempSerialList.Location = new System.Drawing.Point(3, 154);
            this.dgvTempSerialList.Name = "dgvTempSerialList";
            this.dgvTempSerialList.ReadOnly = true;
            this.dgvTempSerialList.RowHeadersWidth = 51;
            this.dgvTempSerialList.Size = new System.Drawing.Size(704, 267);
            this.dgvTempSerialList.TabIndex = 0;
            // 
            // NewSerialTemp
            // 
            this.NewSerialTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewSerialTemp.HeaderText = "سریال";
            this.NewSerialTemp.MinimumWidth = 6;
            this.NewSerialTemp.Name = "NewSerialTemp";
            this.NewSerialTemp.ReadOnly = true;
            // 
            // txtGetSerialListCount
            // 
            this.txtGetSerialListCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetSerialListCount.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.5F);
            this.txtGetSerialListCount.Location = new System.Drawing.Point(264, 432);
            this.txtGetSerialListCount.Name = "txtGetSerialListCount";
            this.txtGetSerialListCount.Size = new System.Drawing.Size(79, 31);
            this.txtGetSerialListCount.TabIndex = 9;
            this.txtGetSerialListCount.Text = "0";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.5F);
            this.label11.Location = new System.Drawing.Point(273, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "تعداد :";
            // 
            // btnGetSerialListSave
            // 
            this.btnGetSerialListSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnGetSerialListSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetSerialListSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGetSerialListSave.FlatAppearance.BorderSize = 0;
            this.btnGetSerialListSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSerialListSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnGetSerialListSave.ForeColor = System.Drawing.Color.Black;
            this.btnGetSerialListSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetSerialListSave.ImageKey = "4 copy.PNG";
            this.btnGetSerialListSave.ImageList = this.imageList2;
            this.btnGetSerialListSave.Location = new System.Drawing.Point(131, 429);
            this.btnGetSerialListSave.Name = "btnGetSerialListSave";
            this.btnGetSerialListSave.Size = new System.Drawing.Size(127, 36);
            this.btnGetSerialListSave.TabIndex = 50;
            this.btnGetSerialListSave.TabStop = false;
            this.btnGetSerialListSave.Text = "تأیید";
            this.btnGetSerialListSave.UseVisualStyleBackColor = false;
            this.btnGetSerialListSave.Click += new System.EventHandler(this.btnGetSerialListSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(73, 14);
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 155);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btnComputeSerialsList);
            this.tabPage1.Controls.Add(this.txtToSerial);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.txtDeleteCharTo);
            this.tabPage1.Controls.Add(this.txtDeleteCharFrom);
            this.tabPage1.Controls.Add(this.txtFromSerial);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Location = new System.Drawing.Point(4, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "معرفی بازه سریال ها";
            // 
            // btnComputeSerialsList
            // 
            this.btnComputeSerialsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnComputeSerialsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComputeSerialsList.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnComputeSerialsList.FlatAppearance.BorderSize = 0;
            this.btnComputeSerialsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputeSerialsList.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.btnComputeSerialsList.ForeColor = System.Drawing.Color.Black;
            this.btnComputeSerialsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputeSerialsList.ImageKey = "256-256-5948f81b64e21ca7f2fdb97148a03f12-note.png";
            this.btnComputeSerialsList.ImageList = this.imageList2;
            this.btnComputeSerialsList.Location = new System.Drawing.Point(21, 12);
            this.btnComputeSerialsList.Name = "btnComputeSerialsList";
            this.btnComputeSerialsList.Size = new System.Drawing.Size(217, 76);
            this.btnComputeSerialsList.TabIndex = 4;
            this.btnComputeSerialsList.TabStop = false;
            this.btnComputeSerialsList.Text = "تهیه لیست سریال ها";
            this.btnComputeSerialsList.UseVisualStyleBackColor = false;
            this.btnComputeSerialsList.Click += new System.EventHandler(this.btnComputeSerialsList_Click);
            // 
            // txtToSerial
            // 
            this.txtToSerial.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtToSerial.Location = new System.Drawing.Point(255, 12);
            this.txtToSerial.Name = "txtToSerial";
            this.txtToSerial.Size = new System.Drawing.Size(143, 41);
            this.txtToSerial.TabIndex = 1;
            this.txtToSerial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected_1);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.5F);
            this.label30.Location = new System.Drawing.Point(382, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 31);
            this.label30.TabIndex = 46;
            this.label30.Text = "تا سریال:";
            // 
            // txtDeleteCharTo
            // 
            this.txtDeleteCharTo.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtDeleteCharTo.Location = new System.Drawing.Point(255, 50);
            this.txtDeleteCharTo.Name = "txtDeleteCharTo";
            this.txtDeleteCharTo.Size = new System.Drawing.Size(57, 41);
            this.txtDeleteCharTo.TabIndex = 3;
            this.txtDeleteCharTo.Text = "0";
            this.txtDeleteCharTo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected_1);
            // 
            // txtDeleteCharFrom
            // 
            this.txtDeleteCharFrom.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtDeleteCharFrom.Location = new System.Drawing.Point(340, 50);
            this.txtDeleteCharFrom.Name = "txtDeleteCharFrom";
            this.txtDeleteCharFrom.Size = new System.Drawing.Size(58, 41);
            this.txtDeleteCharFrom.TabIndex = 2;
            this.txtDeleteCharFrom.Text = "0";
            this.txtDeleteCharFrom.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected_1);
            // 
            // txtFromSerial
            // 
            this.txtFromSerial.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtFromSerial.Location = new System.Drawing.Point(478, 13);
            this.txtFromSerial.Name = "txtFromSerial";
            this.txtFromSerial.Size = new System.Drawing.Size(144, 41);
            this.txtFromSerial.TabIndex = 0;
            this.txtFromSerial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected_1);
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.5F);
            this.label34.Location = new System.Drawing.Point(306, 54);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(31, 31);
            this.label34.TabIndex = 46;
            this.label34.Text = "تا";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.5F);
            this.label33.Location = new System.Drawing.Point(399, 53);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(165, 31);
            this.label33.TabIndex = 46;
            this.label33.Text = "حذف کاراکتر از ایندکس:";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.5F);
            this.label29.Location = new System.Drawing.Point(606, 19);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 31);
            this.label29.TabIndex = 46;
            this.label29.Text = "از سریال:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.lblExcelFileName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnGetExcel);
            this.tabPage2.Location = new System.Drawing.Point(4, 55);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "دریافت فایل Excel";
            // 
            // lblExcelFileName
            // 
            this.lblExcelFileName.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.5F);
            this.lblExcelFileName.Location = new System.Drawing.Point(6, 29);
            this.lblExcelFileName.Name = "lblExcelFileName";
            this.lblExcelFileName.Size = new System.Drawing.Size(284, 31);
            this.lblExcelFileName.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.5F);
            this.label2.Location = new System.Drawing.Point(286, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "عنوان فایل انتخاب شده :";
            // 
            // btnGetExcel
            // 
            this.btnGetExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnGetExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExcel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGetExcel.FlatAppearance.BorderSize = 0;
            this.btnGetExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetExcel.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.btnGetExcel.ForeColor = System.Drawing.Color.Black;
            this.btnGetExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetExcel.ImageKey = "Untitled-1.png";
            this.btnGetExcel.ImageList = this.imageList2;
            this.btnGetExcel.Location = new System.Drawing.Point(468, 12);
            this.btnGetExcel.Name = "btnGetExcel";
            this.btnGetExcel.Size = new System.Drawing.Size(217, 76);
            this.btnGetExcel.TabIndex = 51;
            this.btnGetExcel.TabStop = false;
            this.btnGetExcel.Text = "دریافت فایل اکسل";
            this.btnGetExcel.UseVisualStyleBackColor = false;
            this.btnGetExcel.Click += new System.EventHandler(this.btnGetExcel_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Location = new System.Drawing.Point(4, 55);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(701, 96);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "دریافت از طریق Api";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.ImageKey = "Untitled-1.png";
            this.button16.ImageList = this.imageList2;
            this.button16.Location = new System.Drawing.Point(23, 16);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(217, 76);
            this.button16.TabIndex = 52;
            this.button16.TabStop = false;
            this.button16.Text = "دریافت از API";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // btnConfirmMultiProductInOnePrintActionId
            // 
            this.btnConfirmMultiProductInOnePrintActionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmMultiProductInOnePrintActionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmMultiProductInOnePrintActionId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmMultiProductInOnePrintActionId.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirmMultiProductInOnePrintActionId.FlatAppearance.BorderSize = 0;
            this.btnConfirmMultiProductInOnePrintActionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmMultiProductInOnePrintActionId.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnConfirmMultiProductInOnePrintActionId.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmMultiProductInOnePrintActionId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmMultiProductInOnePrintActionId.ImageKey = "4 copy.PNG";
            this.btnConfirmMultiProductInOnePrintActionId.ImageList = this.imageList2;
            this.btnConfirmMultiProductInOnePrintActionId.Location = new System.Drawing.Point(273, 603);
            this.btnConfirmMultiProductInOnePrintActionId.Name = "btnConfirmMultiProductInOnePrintActionId";
            this.btnConfirmMultiProductInOnePrintActionId.Size = new System.Drawing.Size(271, 70);
            this.btnConfirmMultiProductInOnePrintActionId.TabIndex = 54;
            this.btnConfirmMultiProductInOnePrintActionId.TabStop = false;
            this.btnConfirmMultiProductInOnePrintActionId.Text = "تأیید لیست و چاپ تگ ها";
            this.btnConfirmMultiProductInOnePrintActionId.UseVisualStyleBackColor = false;
            this.btnConfirmMultiProductInOnePrintActionId.Click += new System.EventHandler(this.btnConfirmMultiProductInOnePrintActionId_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.5F);
            this.label17.Location = new System.Drawing.Point(550, 609);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 31);
            this.label17.TabIndex = 53;
            this.label17.Text = "تعداد کل :";
            // 
            // lblCountMultiProductInOnePrintActionId
            // 
            this.lblCountMultiProductInOnePrintActionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountMultiProductInOnePrintActionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountMultiProductInOnePrintActionId.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.5F);
            this.lblCountMultiProductInOnePrintActionId.Location = new System.Drawing.Point(550, 640);
            this.lblCountMultiProductInOnePrintActionId.Name = "lblCountMultiProductInOnePrintActionId";
            this.lblCountMultiProductInOnePrintActionId.Size = new System.Drawing.Size(161, 31);
            this.lblCountMultiProductInOnePrintActionId.TabIndex = 52;
            this.lblCountMultiProductInOnePrintActionId.Text = "0";
            // 
            // btnCancelMultiProductInOnePrintActionId
            // 
            this.btnCancelMultiProductInOnePrintActionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelMultiProductInOnePrintActionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelMultiProductInOnePrintActionId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMultiProductInOnePrintActionId.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCancelMultiProductInOnePrintActionId.FlatAppearance.BorderSize = 0;
            this.btnCancelMultiProductInOnePrintActionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMultiProductInOnePrintActionId.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnCancelMultiProductInOnePrintActionId.ForeColor = System.Drawing.Color.Black;
            this.btnCancelMultiProductInOnePrintActionId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelMultiProductInOnePrintActionId.ImageKey = "cancel-131964784714462788.png";
            this.btnCancelMultiProductInOnePrintActionId.ImageList = this.imageList2;
            this.btnCancelMultiProductInOnePrintActionId.Location = new System.Drawing.Point(105, 605);
            this.btnCancelMultiProductInOnePrintActionId.Name = "btnCancelMultiProductInOnePrintActionId";
            this.btnCancelMultiProductInOnePrintActionId.Size = new System.Drawing.Size(162, 70);
            this.btnCancelMultiProductInOnePrintActionId.TabIndex = 55;
            this.btnCancelMultiProductInOnePrintActionId.TabStop = false;
            this.btnCancelMultiProductInOnePrintActionId.Text = "حذف لیست و شروع مجدد";
            this.btnCancelMultiProductInOnePrintActionId.UseVisualStyleBackColor = false;
            this.btnCancelMultiProductInOnePrintActionId.Click += new System.EventHandler(this.btnCancelMultiProductInOnePrintActionId_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageKey = "cancel-131964784714462788.png";
            this.button9.Location = new System.Drawing.Point(4, 605);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 70);
            this.button9.TabIndex = 55;
            this.button9.TabStop = false;
            this.button9.Text = "انتقال به فرم چاپ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgvMultiProductInOnePrintActionId
            // 
            this.dgvMultiProductInOnePrintActionId.AllowUserToAddRows = false;
            this.dgvMultiProductInOnePrintActionId.AllowUserToDeleteRows = false;
            this.dgvMultiProductInOnePrintActionId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMultiProductInOnePrintActionId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiProductInOnePrintActionId.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMultiProductCode,
            this.dgvMultiProductRegCode,
            this.dgvMultiProductTitle,
            this.dgvMultiCount,
            this.dgvMultiProductItemCount,
            this.dgvMultiProductCountInPack,
            this.dgvMultiProductCount,
            this.dgvMultiProductFlagSave,
            this.Column1,
            this.dgvMultiDocCode,
            this.dgvMultiProductbtnDelete});
            this.dgvMultiProductInOnePrintActionId.Location = new System.Drawing.Point(3, 49);
            this.dgvMultiProductInOnePrintActionId.Name = "dgvMultiProductInOnePrintActionId";
            this.dgvMultiProductInOnePrintActionId.ReadOnly = true;
            this.dgvMultiProductInOnePrintActionId.RowHeadersWidth = 10;
            this.dgvMultiProductInOnePrintActionId.Size = new System.Drawing.Size(719, 548);
            this.dgvMultiProductInOnePrintActionId.TabIndex = 56;
            this.dgvMultiProductInOnePrintActionId.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultiProductInOnePrintActionId_CellClick);
            // 
            // dgvMultiProductCode
            // 
            this.dgvMultiProductCode.HeaderText = "کد کالا";
            this.dgvMultiProductCode.MinimumWidth = 6;
            this.dgvMultiProductCode.Name = "dgvMultiProductCode";
            this.dgvMultiProductCode.ReadOnly = true;
            this.dgvMultiProductCode.Width = 160;
            // 
            // dgvMultiProductRegCode
            // 
            this.dgvMultiProductRegCode.HeaderText = "کد طرح";
            this.dgvMultiProductRegCode.MinimumWidth = 6;
            this.dgvMultiProductRegCode.Name = "dgvMultiProductRegCode";
            this.dgvMultiProductRegCode.ReadOnly = true;
            this.dgvMultiProductRegCode.Width = 120;
            // 
            // dgvMultiProductTitle
            // 
            this.dgvMultiProductTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMultiProductTitle.HeaderText = "شرح کالا";
            this.dgvMultiProductTitle.MinimumWidth = 6;
            this.dgvMultiProductTitle.Name = "dgvMultiProductTitle";
            this.dgvMultiProductTitle.ReadOnly = true;
            // 
            // dgvMultiCount
            // 
            this.dgvMultiCount.HeaderText = "تعداد تگ";
            this.dgvMultiCount.MinimumWidth = 6;
            this.dgvMultiCount.Name = "dgvMultiCount";
            this.dgvMultiCount.ReadOnly = true;
            this.dgvMultiCount.Width = 45;
            // 
            // dgvMultiProductItemCount
            // 
            this.dgvMultiProductItemCount.HeaderText = "dgvMultiProductItemCount";
            this.dgvMultiProductItemCount.MinimumWidth = 6;
            this.dgvMultiProductItemCount.Name = "dgvMultiProductItemCount";
            this.dgvMultiProductItemCount.ReadOnly = true;
            this.dgvMultiProductItemCount.Visible = false;
            this.dgvMultiProductItemCount.Width = 125;
            // 
            // dgvMultiProductCountInPack
            // 
            this.dgvMultiProductCountInPack.HeaderText = "تعداد کالا در هر تگ";
            this.dgvMultiProductCountInPack.MinimumWidth = 6;
            this.dgvMultiProductCountInPack.Name = "dgvMultiProductCountInPack";
            this.dgvMultiProductCountInPack.ReadOnly = true;
            this.dgvMultiProductCountInPack.Width = 78;
            // 
            // dgvMultiProductCount
            // 
            this.dgvMultiProductCount.HeaderText = "متراژ هر کالا";
            this.dgvMultiProductCount.MinimumWidth = 6;
            this.dgvMultiProductCount.Name = "dgvMultiProductCount";
            this.dgvMultiProductCount.ReadOnly = true;
            this.dgvMultiProductCount.Width = 50;
            // 
            // dgvMultiProductFlagSave
            // 
            this.dgvMultiProductFlagSave.HeaderText = "dgvMultiProductFlagSave";
            this.dgvMultiProductFlagSave.MinimumWidth = 6;
            this.dgvMultiProductFlagSave.Name = "dgvMultiProductFlagSave";
            this.dgvMultiProductFlagSave.ReadOnly = true;
            this.dgvMultiProductFlagSave.Visible = false;
            this.dgvMultiProductFlagSave.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "متراژ کل تگ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // dgvMultiDocCode
            // 
            this.dgvMultiDocCode.HeaderText = "کد سند";
            this.dgvMultiDocCode.MinimumWidth = 6;
            this.dgvMultiDocCode.Name = "dgvMultiDocCode";
            this.dgvMultiDocCode.ReadOnly = true;
            this.dgvMultiDocCode.Width = 60;
            // 
            // dgvMultiProductbtnDelete
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.NullValue = "حذف";
            this.dgvMultiProductbtnDelete.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMultiProductbtnDelete.HeaderText = "....";
            this.dgvMultiProductbtnDelete.MinimumWidth = 6;
            this.dgvMultiProductbtnDelete.Name = "dgvMultiProductbtnDelete";
            this.dgvMultiProductbtnDelete.ReadOnly = true;
            this.dgvMultiProductbtnDelete.Width = 50;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 22.25F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(724, 46);
            this.label3.TabIndex = 57;
            this.label3.Text = "لیست تگ های تعریف شده ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMultiProductInOnePrintActionId
            // 
            this.pnlMultiProductInOnePrintActionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMultiProductInOnePrintActionId.BackColor = System.Drawing.Color.White;
            this.pnlMultiProductInOnePrintActionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.label3);
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.dgvMultiProductInOnePrintActionId);
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.button9);
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.btnCancelMultiProductInOnePrintActionId);
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.lblCountMultiProductInOnePrintActionId);
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.label17);
            this.pnlMultiProductInOnePrintActionId.Controls.Add(this.btnConfirmMultiProductInOnePrintActionId);
            this.pnlMultiProductInOnePrintActionId.Location = new System.Drawing.Point(3, 1);
            this.pnlMultiProductInOnePrintActionId.Name = "pnlMultiProductInOnePrintActionId";
            this.pnlMultiProductInOnePrintActionId.Size = new System.Drawing.Size(726, 684);
            this.pnlMultiProductInOnePrintActionId.TabIndex = 5;
            this.pnlMultiProductInOnePrintActionId.Visible = false;
            // 
            // pnlProductTechnicalData
            // 
            this.pnlProductTechnicalData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductTechnicalData.BackColor = System.Drawing.Color.White;
            this.pnlProductTechnicalData.Location = new System.Drawing.Point(988, 629);
            this.pnlProductTechnicalData.Name = "pnlProductTechnicalData";
            this.pnlProductTechnicalData.Size = new System.Drawing.Size(376, 109);
            this.pnlProductTechnicalData.TabIndex = 56;
            this.pnlProductTechnicalData.Visible = false;
            // 
            // btnClosepnlDocumentInfo
            // 
            this.btnClosepnlDocumentInfo.BackColor = System.Drawing.Color.LightCoral;
            this.btnClosepnlDocumentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClosepnlDocumentInfo.Location = new System.Drawing.Point(-1, -1);
            this.btnClosepnlDocumentInfo.Name = "btnClosepnlDocumentInfo";
            this.btnClosepnlDocumentInfo.Size = new System.Drawing.Size(49, 42);
            this.btnClosepnlDocumentInfo.TabIndex = 55;
            this.btnClosepnlDocumentInfo.Text = "بستن پنجره";
            this.btnClosepnlDocumentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDocumentItems
            // 
            this.dgvDocumentItems.AllowUserToAddRows = false;
            this.dgvDocumentItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.dgvDocumentItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDocumentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.colDocumentItemProductCode,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.colDocumentItemRemain,
            this.colbtnSelectProduct});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentItems.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDocumentItems.Location = new System.Drawing.Point(1, 43);
            this.dgvDocumentItems.Name = "dgvDocumentItems";
            this.dgvDocumentItems.ReadOnly = true;
            this.dgvDocumentItems.RowHeadersWidth = 10;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.dgvDocumentItems.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDocumentItems.RowTemplate.Height = 32;
            this.dgvDocumentItems.Size = new System.Drawing.Size(864, 535);
            this.dgvDocumentItems.TabIndex = 56;
            this.dgvDocumentItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentItems_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "ردیف";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 45;
            // 
            // colDocumentItemProductCode
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDocumentItemProductCode.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDocumentItemProductCode.HeaderText = "کد کالا";
            this.colDocumentItemProductCode.MinimumWidth = 6;
            this.colDocumentItemProductCode.Name = "colDocumentItemProductCode";
            this.colDocumentItemProductCode.ReadOnly = true;
            this.colDocumentItemProductCode.Width = 140;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F);
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn12.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "مقدار درخواست";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 110;
            // 
            // colDocumentItemRemain
            // 
            this.colDocumentItemRemain.HeaderText = "باقی مانده";
            this.colDocumentItemRemain.MinimumWidth = 6;
            this.colDocumentItemRemain.Name = "colDocumentItemRemain";
            this.colDocumentItemRemain.ReadOnly = true;
            this.colDocumentItemRemain.Width = 90;
            // 
            // colbtnSelectProduct
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "انتخاب";
            this.colbtnSelectProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.colbtnSelectProduct.HeaderText = "...";
            this.colbtnSelectProduct.MinimumWidth = 6;
            this.colbtnSelectProduct.Name = "colbtnSelectProduct";
            this.colbtnSelectProduct.ReadOnly = true;
            this.colbtnSelectProduct.Width = 50;
            // 
            // dgvDocumentHeader
            // 
            this.dgvDocumentHeader.AllowUserToAddRows = false;
            this.dgvDocumentHeader.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.dgvDocumentHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentHeader.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentHeader.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentHeader.Location = new System.Drawing.Point(866, 42);
            this.dgvDocumentHeader.Name = "dgvDocumentHeader";
            this.dgvDocumentHeader.ReadOnly = true;
            this.dgvDocumentHeader.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            this.dgvDocumentHeader.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocumentHeader.RowTemplate.Height = 32;
            this.dgvDocumentHeader.Size = new System.Drawing.Size(412, 535);
            this.dgvDocumentHeader.TabIndex = 57;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "عنوان ";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 185;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "مقدار";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Lavender;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("IRANSans(FaNum)", 17F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1278, 43);
            this.label19.TabIndex = 39;
            this.label19.Text = "اطلاعات و اقلام سند درخواست تولید";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelpnlDocumentInfo
            // 
            this.btnCancelpnlDocumentInfo.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelpnlDocumentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancelpnlDocumentInfo.Location = new System.Drawing.Point(0, 1);
            this.btnCancelpnlDocumentInfo.Name = "btnCancelpnlDocumentInfo";
            this.btnCancelpnlDocumentInfo.Size = new System.Drawing.Size(49, 42);
            this.btnCancelpnlDocumentInfo.TabIndex = 54;
            this.btnCancelpnlDocumentInfo.Text = "بستن پنجره";
            this.btnCancelpnlDocumentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelpnlDocumentInfo.Click += new System.EventHandler(this.btnCancelpnlDocumentInfo_Click);
            // 
            // pnlDocumentInfo
            // 
            this.pnlDocumentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDocumentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDocumentInfo.Controls.Add(this.btnCancelpnlDocumentInfo);
            this.pnlDocumentInfo.Controls.Add(this.label19);
            this.pnlDocumentInfo.Controls.Add(this.dgvDocumentHeader);
            this.pnlDocumentInfo.Controls.Add(this.dgvDocumentItems);
            this.pnlDocumentInfo.Controls.Add(this.btnClosepnlDocumentInfo);
            this.pnlDocumentInfo.Location = new System.Drawing.Point(57, 42);
            this.pnlDocumentInfo.Name = "pnlDocumentInfo";
            this.pnlDocumentInfo.Size = new System.Drawing.Size(1280, 581);
            this.pnlDocumentInfo.TabIndex = 9;
            this.pnlDocumentInfo.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "label21";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(0, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(100, 23);
            this.label38.TabIndex = 0;
            this.label38.Text = "label38";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(0, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 23);
            this.label39.TabIndex = 0;
            this.label39.Text = "label39";
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label41.Location = new System.Drawing.Point(491, 16);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(73, 31);
            this.label41.TabIndex = 2;
            this.label41.Text = "کد کالا:";
            // 
            // lblWaiting
            // 
            this.lblWaiting.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblWaiting.Location = new System.Drawing.Point(251, 12);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(73, 31);
            this.lblWaiting.TabIndex = 57;
            this.lblWaiting.Text = "سامانه در حال دریافت اطلاعات از سرور می باشد \r\nلطفا صبر کنید ...";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStoreRegisterTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.pnlProductTechnicalData);
            this.Controls.Add(this.pnlDynamicFeilds);
            this.Controls.Add(this.pnlDocumentInfo);
            this.Controls.Add(this.pnlMultiProductInOnePrintActionId);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStoreRegisterTags";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایستگاه رجیستر تگ - سامانه مدیریت هوشمند انبار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStoreRegisterTags_FormClosed);
            this.Load += new System.EventHandler(this.frmStoreRegisterTags_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStoreRegisterTags_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntComputeProductPackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchProduct)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchDoc)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlComputeConvertWeightToProductPackValue.ResumeLayout(false);
            this.pnlComputeConvertWeightToProductPackValue.PerformLayout();
            this.pnlDocs.ResumeLayout(false);
            this.pnlDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocsList)).EndInit();
            this.pnlGetSerialList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempSerialList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiProductInOnePrintActionId)).EndInit();
            this.pnlMultiProductInOnePrintActionId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentHeader)).EndInit();
            this.pnlDocumentInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlDynamicFeilds;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Button btnChangeRegisterDate;
        private System.Windows.Forms.Button btnRepCancelRegisterTag;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRepRegisterTag;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDefineProductType;
        private System.Windows.Forms.Button btnDefineProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnSearchDoc;
        private System.Windows.Forms.Button btnGetSerialsList;
        private System.Windows.Forms.Label lblPrintActionId;
        private System.Windows.Forms.Label lblPrintActionStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNextActionId;
        private System.Windows.Forms.Button btnPreviousActionId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.ComboBox cmbProductionLine;
        private System.Windows.Forms.ComboBox cmbProductionShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDocumentId;
        private System.Windows.Forms.MaskedTextBox txtCount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblShiftTitle;
        private System.Windows.Forms.Label lblDayName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox bntComputeProductPackCount;
        private System.Windows.Forms.MaskedTextBox txtProductCountInPack;
        private System.Windows.Forms.TextBox txtProductTitle;
        private System.Windows.Forms.PictureBox btnSearchProduct;
        private System.Windows.Forms.MaskedTextBox txtProductCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtProductSize;
        private System.Windows.Forms.MaskedTextBox txtProductPackValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtProductRegCode;
        private System.Windows.Forms.MaskedTextBox txtProductValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtProductENTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbProductStatus;
        private System.Windows.Forms.MaskedTextBox txtProductUnit;
        private System.Windows.Forms.MaskedTextBox txtProductPackWeight;
        private System.Windows.Forms.MaskedTextBox txtProductPackVolume;
        private System.Windows.Forms.MaskedTextBox txtProductType;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPrintRegisterTags;
        private System.Windows.Forms.Panel pnlMultiProductInOnePrintActionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMultiProductInOnePrintActionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductRegCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductItemCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductCountInPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductFlagSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiDocCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMultiProductbtnDelete;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnCancelMultiProductInOnePrintActionId;
        private System.Windows.Forms.Label lblCountMultiProductInOnePrintActionId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnConfirmMultiProductInOnePrintActionId;
        private System.Windows.Forms.Panel pnlProductTechnicalData;
        private System.Windows.Forms.Panel pnlDocumentInfo;
        private System.Windows.Forms.Label btnCancelpnlDocumentInfo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvDocumentHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridView dgvDocumentItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentItemProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentItemRemain;
        private System.Windows.Forms.DataGridViewButtonColumn colbtnSelectProduct;
        private System.Windows.Forms.Label btnClosepnlDocumentInfo;
        private System.Windows.Forms.Panel pnlComputeConvertWeightToProductPackValue;
        private System.Windows.Forms.MaskedTextBox txtAllWeightForConvert;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblAverageWeight;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label btnConfirmpnlComputeConvertWeightToProductPackValue;
        private System.Windows.Forms.Label btnComputepnlComputeConvertWeightToProductPackValue;
        private System.Windows.Forms.Label btnCancelpnlComputeConvertWeightToProductPackValue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pnlDocs;
        private System.Windows.Forms.TextBox txtSearchDocInlist;
        private System.Windows.Forms.DataGridView dgvDocsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewButtonColumn colbtnSelectDoc;
        private System.Windows.Forms.Label btnCancelPnlDocs;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlGetSerialList;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dgvTempSerialList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewSerialTemp;
        private System.Windows.Forms.Label txtGetSerialListCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGetSerialListSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnComputeSerialsList;
        private System.Windows.Forms.MaskedTextBox txtToSerial;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.MaskedTextBox txtDeleteCharTo;
        private System.Windows.Forms.MaskedTextBox txtDeleteCharFrom;
        private System.Windows.Forms.MaskedTextBox txtFromSerial;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblExcelFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetExcel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnSetParrents;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblWaiting;
    }
}