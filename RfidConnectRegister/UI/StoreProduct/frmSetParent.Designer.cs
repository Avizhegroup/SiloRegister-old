namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmSetParent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEpc = new System.Windows.Forms.TextBox();
            this.rdbType = new System.Windows.Forms.RadioButton();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.txtProductSerial = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddSerial = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchItems = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnStartRFID = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSavePackageMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEpc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_barcode = new System.Windows.Forms.Timer(this.components);
            this.dgvColumnProductSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTagDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchItems)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEpc);
            this.groupBox1.Controls.Add(this.rdbType);
            this.groupBox1.Controls.Add(this.rdbBarcode);
            this.groupBox1.Controls.Add(this.txtProductSerial);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddSerial);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(809, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن سریال به بسته بندی";
            // 
            // txtEpc
            // 
            this.txtEpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpc.Location = new System.Drawing.Point(356, 26);
            this.txtEpc.Name = "txtEpc";
            this.txtEpc.Size = new System.Drawing.Size(124, 26);
            this.txtEpc.TabIndex = 85;
            this.txtEpc.TabStop = false;
            this.txtEpc.Visible = false;
            this.txtEpc.TextChanged += new System.EventHandler(this.txtEpc_TextChanged);
            // 
            // rdbType
            // 
            this.rdbType.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbType.AutoSize = true;
            this.rdbType.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.rdbType.Location = new System.Drawing.Point(250, 25);
            this.rdbType.Name = "rdbType";
            this.rdbType.Size = new System.Drawing.Size(129, 35);
            this.rdbType.TabIndex = 57;
            this.rdbType.TabStop = true;
            this.rdbType.Text = "حالت تایپ سریال";
            this.rdbType.UseVisualStyleBackColor = true;
            this.rdbType.CheckedChanged += new System.EventHandler(this.rdbType_CheckedChanged);
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F);
            this.rdbBarcode.Location = new System.Drawing.Point(385, 25);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(125, 35);
            this.rdbBarcode.TabIndex = 57;
            this.rdbBarcode.TabStop = true;
            this.rdbBarcode.Text = "حالت قرائت بارکد";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            this.rdbBarcode.CheckedChanged += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // txtProductSerial
            // 
            this.txtProductSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSerial.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.txtProductSerial.Location = new System.Drawing.Point(560, 26);
            this.txtProductSerial.Name = "txtProductSerial";
            this.txtProductSerial.Size = new System.Drawing.Size(173, 35);
            this.txtProductSerial.TabIndex = 53;
            this.txtProductSerial.TextChanged += new System.EventHandler(this.txtProductSerial_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label14.Location = new System.Drawing.Point(735, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 31);
            this.label14.TabIndex = 56;
            this.label14.Text = "سریال:";
            // 
            // btnAddSerial
            // 
            this.btnAddSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSerial.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAddSerial.FlatAppearance.BorderSize = 0;
            this.btnAddSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSerial.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnAddSerial.ForeColor = System.Drawing.Color.Black;
            this.btnAddSerial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSerial.ImageKey = "4 copy.PNG";
            this.btnAddSerial.Location = new System.Drawing.Point(516, 25);
            this.btnAddSerial.Name = "btnAddSerial";
            this.btnAddSerial.Size = new System.Drawing.Size(42, 36);
            this.btnAddSerial.TabIndex = 54;
            this.btnAddSerial.TabStop = false;
            this.btnAddSerial.Text = "+";
            this.btnAddSerial.UseVisualStyleBackColor = false;
            this.btnAddSerial.Click += new System.EventHandler(this.btnAddSerial_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchItems);
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(809, 373);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست سریال های این بسته";
            // 
            // dgvSearchItems
            // 
            this.dgvSearchItems.AllowUserToAddRows = false;
            this.dgvSearchItems.AllowUserToDeleteRows = false;
            this.dgvSearchItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnProductSerial,
            this.dataGridViewTextBoxColumn1,
            this.dgvColumnProductTitle,
            this.dgvColumnProductCount,
            this.Column15,
            this.btnTagDelete});
            this.dgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchItems.Location = new System.Drawing.Point(4, 23);
            this.dgvSearchItems.Name = "dgvSearchItems";
            this.dgvSearchItems.ReadOnly = true;
            this.dgvSearchItems.RowHeadersWidth = 15;
            this.dgvSearchItems.RowTemplate.Height = 27;
            this.dgvSearchItems.Size = new System.Drawing.Size(801, 346);
            this.dgvSearchItems.TabIndex = 8;
            this.dgvSearchItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchItems_CellClick);
            this.dgvSearchItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSearchItems_RowsAdded);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPackageId);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.btnStartRFID);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.lblSavePackageMessage);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblEpc);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 453);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(809, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مشخصات بسته";
            // 
            // txtPackageId
            // 
            this.txtPackageId.Font = new System.Drawing.Font("IRANSans(FaNum)", 12.25F);
            this.txtPackageId.Location = new System.Drawing.Point(172, 53);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(100, 35);
            this.txtPackageId.TabIndex = 57;
            this.txtPackageId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPackageId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPackageId_KeyDown);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.lblCount.Location = new System.Drawing.Point(541, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(85, 31);
            this.lblCount.TabIndex = 56;
            this.lblCount.Text = "0";
            // 
            // btnStartRFID
            // 
            this.btnStartRFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnStartRFID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartRFID.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnStartRFID.FlatAppearance.BorderSize = 0;
            this.btnStartRFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartRFID.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.btnStartRFID.ForeColor = System.Drawing.Color.Black;
            this.btnStartRFID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartRFID.ImageKey = "4 copy.PNG";
            this.btnStartRFID.Location = new System.Drawing.Point(686, 52);
            this.btnStartRFID.Name = "btnStartRFID";
            this.btnStartRFID.Size = new System.Drawing.Size(109, 36);
            this.btnStartRFID.TabIndex = 54;
            this.btnStartRFID.TabStop = false;
            this.btnStartRFID.Text = "1-قرائت تگ";
            this.btnStartRFID.UseVisualStyleBackColor = false;
            this.btnStartRFID.Click += new System.EventHandler(this.btnStartRFID_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "4 copy.PNG";
            this.button2.Location = new System.Drawing.Point(7, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 36);
            this.button2.TabIndex = 54;
            this.button2.TabStop = false;
            this.button2.Text = "3-چاپ لیبل";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnSave.Location = new System.Drawing.Point(347, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 36);
            this.btnSave.TabIndex = 54;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "2-ثبت بسته";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSavePackageMessage
            // 
            this.lblSavePackageMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSavePackageMessage.Font = new System.Drawing.Font("IRANSans(FaNum)", 8F);
            this.lblSavePackageMessage.Location = new System.Drawing.Point(11, 27);
            this.lblSavePackageMessage.Name = "lblSavePackageMessage";
            this.lblSavePackageMessage.Size = new System.Drawing.Size(334, 20);
            this.lblSavePackageMessage.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label2.Location = new System.Drawing.Point(619, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "تعداد سریال های بسته :";
            // 
            // lblEpc
            // 
            this.lblEpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEpc.Font = new System.Drawing.Font("IRANSans(FaNum)", 7.249999F);
            this.lblEpc.Location = new System.Drawing.Point(511, 51);
            this.lblEpc.Name = "lblEpc";
            this.lblEpc.Size = new System.Drawing.Size(173, 36);
            this.lblEpc.TabIndex = 56;
            this.lblEpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F);
            this.label1.Location = new System.Drawing.Point(274, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 56;
            this.label1.Text = "کد بسته:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_barcode
            // 
            this.timer_barcode.Interval = 500;
            this.timer_barcode.Tick += new System.EventHandler(this.timer_barcode_Tick);
            // 
            // dgvColumnProductSerial
            // 
            this.dgvColumnProductSerial.HeaderText = "سریال";
            this.dgvColumnProductSerial.Name = "dgvColumnProductSerial";
            this.dgvColumnProductSerial.ReadOnly = true;
            this.dgvColumnProductSerial.Width = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "کد کالا";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dgvColumnProductTitle
            // 
            this.dgvColumnProductTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnProductTitle.HeaderText = "عنوان کالا";
            this.dgvColumnProductTitle.Name = "dgvColumnProductTitle";
            this.dgvColumnProductTitle.ReadOnly = true;
            // 
            // dgvColumnProductCount
            // 
            this.dgvColumnProductCount.HeaderText = "مقدار ";
            this.dgvColumnProductCount.Name = "dgvColumnProductCount";
            this.dgvColumnProductCount.ReadOnly = true;
            this.dgvColumnProductCount.Width = 60;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "وضعیت";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 150;
            // 
            // btnTagDelete
            // 
            this.btnTagDelete.HeaderText = "...";
            this.btnTagDelete.Name = "btnTagDelete";
            this.btnTagDelete.ReadOnly = true;
            this.btnTagDelete.Width = 40;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageKey = "4 copy.PNG";
            this.btnClear.Location = new System.Drawing.Point(11, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 60);
            this.btnClear.TabIndex = 54;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "پاک کردن اطلاعات و ایجاد رول جدید";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSetParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetParent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف بسته بندی کالا";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetParent_FormClosing);
            this.Load += new System.EventHandler(this.frmSetParent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchItems)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtProductSerial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddSerial;
        private System.Windows.Forms.DataGridView dgvSearchItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.RadioButton rdbType;
        private System.Windows.Forms.Timer timer_barcode;
        private System.Windows.Forms.TextBox txtEpc;
        private System.Windows.Forms.Button btnStartRFID;
        private System.Windows.Forms.Label lblEpc;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label lblSavePackageMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnProductSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewButtonColumn btnTagDelete;
        private System.Windows.Forms.Button btnClear;
    }
}