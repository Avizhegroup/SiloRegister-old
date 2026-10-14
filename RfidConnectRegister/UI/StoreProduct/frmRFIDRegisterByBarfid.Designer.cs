namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmRFIDRegisterByBarfid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRFIDRegisterByBarfid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlbtnRegister = new System.Windows.Forms.Panel();
            this.lblbtnRegister = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.PictureBox();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button11 = new System.Windows.Forms.Button();
            this.lblShowBarcode = new System.Windows.Forms.Label();
            this.lblShowEpc = new System.Windows.Forms.Label();
            this.txtEpc = new System.Windows.Forms.TextBox();
            this.txtSerialCode = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxBarcode = new System.Windows.Forms.PictureBox();
            this.pbxRfid = new System.Windows.Forms.PictureBox();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMessages = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerCheckFillings = new System.Windows.Forms.Timer(this.components);
            this.timerTextboxBarcode = new System.Windows.Forms.Timer(this.components);
            this.timerClearBarcodWhenDontReadTag = new System.Windows.Forms.Timer(this.components);
            this.timerClearEPCWhenDontReadBarcode = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblConnectToReaderStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlbtnRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRfid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbtnRegister
            // 
            this.pnlbtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlbtnRegister.BackColor = System.Drawing.Color.Black;
            this.pnlbtnRegister.Controls.Add(this.lblbtnRegister);
            this.pnlbtnRegister.Controls.Add(this.label15);
            this.pnlbtnRegister.Controls.Add(this.label17);
            this.pnlbtnRegister.Controls.Add(this.label18);
            this.pnlbtnRegister.Location = new System.Drawing.Point(1171, 17);
            this.pnlbtnRegister.Name = "pnlbtnRegister";
            this.pnlbtnRegister.Size = new System.Drawing.Size(129, 71);
            this.pnlbtnRegister.TabIndex = 11;
            // 
            // lblbtnRegister
            // 
            this.lblbtnRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblbtnRegister.Font = new System.Drawing.Font("IRANSans(FaNum)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnRegister.ForeColor = System.Drawing.Color.Gray;
            this.lblbtnRegister.Location = new System.Drawing.Point(4, 2);
            this.lblbtnRegister.Name = "lblbtnRegister";
            this.lblbtnRegister.Size = new System.Drawing.Size(122, 35);
            this.lblbtnRegister.TabIndex = 11;
            this.lblbtnRegister.Text = "رجیستر تگ";
            this.lblbtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("IRANSans(FaNum)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(71, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 36);
            this.label15.TabIndex = 1;
            this.label15.Text = "0";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("IRANSans(FaNum)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(13, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 36);
            this.label17.TabIndex = 1;
            this.label17.Text = "0";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("IRANSans(FaNum)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(59, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 36);
            this.label18.TabIndex = 1;
            this.label18.Text = "/";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.Image = global::RfidConnectRegister.Properties.Resources.registerdataon;
            this.btnRegister.Location = new System.Drawing.Point(0, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(1370, 123);
            this.btnRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegister.TabIndex = 10;
            this.btnRegister.TabStop = false;
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnCancelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelRegister.FlatAppearance.BorderSize = 0;
            this.btnCancelRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRegister.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
            this.btnCancelRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelRegister.ImageKey = "cancel-131964784714462788.png";
            this.btnCancelRegister.ImageList = this.imageList2;
            this.btnCancelRegister.Location = new System.Drawing.Point(881, 680);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(231, 57);
            this.btnCancelRegister.TabIndex = 96;
            this.btnCancelRegister.Text = "ابطال رجیستر تگ";
            this.btnCancelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelRegister.UseVisualStyleBackColor = false;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
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
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.button11.Location = new System.Drawing.Point(1118, 680);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(231, 57);
            this.button11.TabIndex = 97;
            this.button11.Text = "تست رجیستر تگ";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // lblShowBarcode
            // 
            this.lblShowBarcode.Font = new System.Drawing.Font("IRANSans(FaNum)", 15.25F);
            this.lblShowBarcode.Location = new System.Drawing.Point(551, 214);
            this.lblShowBarcode.Name = "lblShowBarcode";
            this.lblShowBarcode.Size = new System.Drawing.Size(242, 48);
            this.lblShowBarcode.TabIndex = 91;
            this.lblShowBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowEpc
            // 
            this.lblShowEpc.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.25F);
            this.lblShowEpc.Location = new System.Drawing.Point(255, 219);
            this.lblShowEpc.Name = "lblShowEpc";
            this.lblShowEpc.Size = new System.Drawing.Size(245, 28);
            this.lblShowEpc.TabIndex = 92;
            this.lblShowEpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEpc
            // 
            this.txtEpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpc.Location = new System.Drawing.Point(307, 176);
            this.txtEpc.Name = "txtEpc";
            this.txtEpc.Size = new System.Drawing.Size(189, 31);
            this.txtEpc.TabIndex = 87;
            this.txtEpc.TabStop = false;
            this.txtEpc.TextChanged += new System.EventHandler(this.txtEpc_TextChanged);
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialCode.Location = new System.Drawing.Point(618, 132);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(3, 31);
            this.txtSerialCode.TabIndex = 83;
            this.txtSerialCode.TextChanged += new System.EventHandler(this.txtSerialCode_TextChanged);
            this.txtSerialCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerialCode_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::RfidConnectRegister.Properties.Resources._9_9;
            this.pictureBox3.Location = new System.Drawing.Point(-23, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(272, 441);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            // 
            // pbxBarcode
            // 
            this.pbxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxBarcode.BackColor = System.Drawing.Color.Transparent;
            this.pbxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBarcode.Image = global::RfidConnectRegister.Properties.Resources._141_tr;
            this.pbxBarcode.Location = new System.Drawing.Point(545, 164);
            this.pbxBarcode.Name = "pbxBarcode";
            this.pbxBarcode.Size = new System.Drawing.Size(254, 441);
            this.pbxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBarcode.TabIndex = 85;
            this.pbxBarcode.TabStop = false;
            // 
            // pbxRfid
            // 
            this.pbxRfid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxRfid.BackColor = System.Drawing.Color.White;
            this.pbxRfid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRfid.Image = global::RfidConnectRegister.Properties.Resources._14_tra;
            this.pbxRfid.Location = new System.Drawing.Point(250, 164);
            this.pbxRfid.Name = "pbxRfid";
            this.pbxRfid.Size = new System.Drawing.Size(254, 441);
            this.pbxRfid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRfid.TabIndex = 86;
            this.pbxRfid.TabStop = false;
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.AllowUserToDeleteRows = false;
            this.dgvRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4});
            this.dgvRegister.Location = new System.Drawing.Point(1095, 164);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.RowHeadersWidth = 5;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegister.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegister.Size = new System.Drawing.Size(269, 441);
            this.dgvRegister.TabIndex = 82;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ردیف";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "سریال محموله";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "شناسه تگ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "وضعیت عملیات";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 185;
            // 
            // lblMessages
            // 
            this.lblMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessages.Font = new System.Drawing.Font("IRANSans(FaNum)", 20F);
            this.lblMessages.Location = new System.Drawing.Point(843, 164);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(244, 441);
            this.lblMessages.TabIndex = 88;
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("IRANSans(FaNum)", 25F);
            this.label21.Location = new System.Drawing.Point(776, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 381);
            this.label21.TabIndex = 89;
            this.label21.Text = "=";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 25F);
            this.label3.Location = new System.Drawing.Point(482, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 382);
            this.label3.TabIndex = 90;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCheckFillings
            // 
            this.timerCheckFillings.Interval = 1000;
            this.timerCheckFillings.Tick += new System.EventHandler(this.timerCheckFillings_Tick);
            // 
            // timerTextboxBarcode
            // 
            this.timerTextboxBarcode.Interval = 500;
            this.timerTextboxBarcode.Tick += new System.EventHandler(this.timerTextboxBarcode_Tick);
            // 
            // timerClearBarcodWhenDontReadTag
            // 
            this.timerClearBarcodWhenDontReadTag.Interval = 4000;
            this.timerClearBarcodWhenDontReadTag.Tick += new System.EventHandler(this.timerClearBarcodWhenDontReadTag_Tick);
            // 
            // timerClearEPCWhenDontReadBarcode
            // 
            this.timerClearEPCWhenDontReadBarcode.Interval = 4000;
            this.timerClearEPCWhenDontReadBarcode.Tick += new System.EventHandler(this.timerClearEPCWhenDontReadBarcode_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "5 copy.PNG";
            this.button1.Location = new System.Drawing.Point(0, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 80);
            this.button1.TabIndex = 98;
            this.button1.TabStop = false;
            this.button1.Text = "مرحله قبل\r\n<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConnectToReaderStatus
            // 
            this.lblConnectToReaderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectToReaderStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.5F);
            this.lblConnectToReaderStatus.Location = new System.Drawing.Point(737, 684);
            this.lblConnectToReaderStatus.Name = "lblConnectToReaderStatus";
            this.lblConnectToReaderStatus.Size = new System.Drawing.Size(138, 52);
            this.lblConnectToReaderStatus.TabIndex = 99;
            this.lblConnectToReaderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConnectToReaderStatus.Click += new System.EventHandler(this.lblConnectToReaderStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 6.249999F);
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // frmRFIDRegisterByBarfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConnectToReaderStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.lblShowBarcode);
            this.Controls.Add(this.lblShowEpc);
            this.Controls.Add(this.txtEpc);
            this.Controls.Add(this.txtSerialCode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbxBarcode);
            this.Controls.Add(this.pbxRfid);
            this.Controls.Add(this.dgvRegister);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlbtnRegister);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRFIDRegisterByBarfid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رجیستر تگ ها (RFID Barfid)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRFIDRegisterByBarfid_FormClosing);
            this.Load += new System.EventHandler(this.frmRFIDRegisterByBarfid_Load);
            this.pnlbtnRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRfid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlbtnRegister;
        private System.Windows.Forms.Label lblbtnRegister;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox btnRegister;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lblShowBarcode;
        private System.Windows.Forms.Label lblShowEpc;
        private System.Windows.Forms.TextBox txtEpc;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbxBarcode;
        private System.Windows.Forms.PictureBox pbxRfid;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerCheckFillings;
        private System.Windows.Forms.Timer timerTextboxBarcode;
        private System.Windows.Forms.Timer timerClearBarcodWhenDontReadTag;
        private System.Windows.Forms.Timer timerClearEPCWhenDontReadBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConnectToReaderStatus;
        private System.Windows.Forms.Label label1;
    }
}