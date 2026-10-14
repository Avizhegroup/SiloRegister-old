namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmDefineProductType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPrintQueue = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductTitle = new System.Windows.Forms.MaskedTextBox();
            this.txtProductCode = new System.Windows.Forms.MaskedTextBox();
            this.pnlWaiting = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pbxWaitingLogo = new System.Windows.Forms.PictureBox();
            this.timerErrorClear = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintQueue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWaitingLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvPrintQueue);
            this.groupBox2.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 363);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست انواع کالا";
            // 
            // dgvPrintQueue
            // 
            this.dgvPrintQueue.AllowUserToAddRows = false;
            this.dgvPrintQueue.AllowUserToDeleteRows = false;
            this.dgvPrintQueue.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPrintQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.ProductTitle});
            this.dgvPrintQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrintQueue.Location = new System.Drawing.Point(3, 22);
            this.dgvPrintQueue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrintQueue.MultiSelect = false;
            this.dgvPrintQueue.Name = "dgvPrintQueue";
            this.dgvPrintQueue.ReadOnly = true;
            this.dgvPrintQueue.RowHeadersVisible = false;
            this.dgvPrintQueue.RowHeadersWidth = 15;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrintQueue.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrintQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrintQueue.Size = new System.Drawing.Size(659, 338);
            this.dgvPrintQueue.TabIndex = 0;
            this.dgvPrintQueue.TabStop = false;
            this.dgvPrintQueue.SelectionChanged += new System.EventHandler(this.dgvPrintQueue_SelectionChanged);
            this.dgvPrintQueue.Enter += new System.EventHandler(this.dgvPrintQueue_Enter);
            this.dgvPrintQueue.Leave += new System.EventHandler(this.dgvPrintQueue_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductTitle);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات سالن تولید";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(80, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 73);
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
            this.btnDelete.Location = new System.Drawing.Point(10, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 73);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(179, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 73);
            this.btnSave.TabIndex = 13;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label1.Location = new System.Drawing.Point(561, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "عنوان سالن تولید:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.label5.Location = new System.Drawing.Point(561, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "کد سالن تولید:";
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductTitle.Location = new System.Drawing.Point(336, 57);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(222, 32);
            this.txtProductTitle.TabIndex = 2;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
            this.txtProductCode.Location = new System.Drawing.Point(336, 16);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(222, 32);
            this.txtProductCode.TabIndex = 0;
            // 
            // pnlWaiting
            // 
            this.pnlWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.pnlWaiting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWaiting.Controls.Add(this.label11);
            this.pnlWaiting.Controls.Add(this.pbxWaitingLogo);
            this.pnlWaiting.Location = new System.Drawing.Point(179, 95);
            this.pnlWaiting.Name = "pnlWaiting";
            this.pnlWaiting.Size = new System.Drawing.Size(258, 114);
            this.pnlWaiting.TabIndex = 41;
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
            // timerErrorClear
            // 
            this.timerErrorClear.Interval = 7000;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "کد";
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
            // frmDefineProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 469);
            this.Controls.Add(this.pnlWaiting);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDefineProductType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تعریف انواع کالا ";
            this.Load += new System.EventHandler(this.frmDefineProductType_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintQueue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlWaiting.ResumeLayout(false);
            this.pnlWaiting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWaitingLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPrintQueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtProductTitle;
        private System.Windows.Forms.MaskedTextBox txtProductCode;
        private System.Windows.Forms.Panel pnlWaiting;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbxWaitingLogo;
        private System.Windows.Forms.Timer timerErrorClear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
    }
}