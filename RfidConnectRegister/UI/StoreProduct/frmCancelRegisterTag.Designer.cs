namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmCancelRegisterTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelRegisterTag));
            this.txtEpc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegisterPSerial = new System.Windows.Forms.Label();
            this.lblRegisterPTitle = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblRegisterPCode = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblRegisterPSize = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblRegisterPRegCode = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblRegisterPStatus = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEpc
            // 
            this.txtEpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpc.Location = new System.Drawing.Point(18, 32);
            this.txtEpc.Name = "txtEpc";
            this.txtEpc.Size = new System.Drawing.Size(180, 26);
            this.txtEpc.TabIndex = 87;
            this.txtEpc.TabStop = false;
            this.txtEpc.TextChanged += new System.EventHandler(this.txtEpc_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblRegisterPSerial);
            this.groupBox1.Controls.Add(this.lblRegisterPTitle);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.lblRegisterPCode);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.lblRegisterPSize);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.lblRegisterPRegCode);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.lblRegisterPStatus);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Location = new System.Drawing.Point(3, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 272);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات رجیستر شده برای تگ";
            // 
            // lblRegisterPSerial
            // 
            this.lblRegisterPSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPSerial.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblRegisterPSerial.Location = new System.Drawing.Point(15, 17);
            this.lblRegisterPSerial.Name = "lblRegisterPSerial";
            this.lblRegisterPSerial.Size = new System.Drawing.Size(233, 31);
            this.lblRegisterPSerial.TabIndex = 50;
            // 
            // lblRegisterPTitle
            // 
            this.lblRegisterPTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.5F);
            this.lblRegisterPTitle.Location = new System.Drawing.Point(15, 100);
            this.lblRegisterPTitle.Name = "lblRegisterPTitle";
            this.lblRegisterPTitle.Size = new System.Drawing.Size(233, 41);
            this.lblRegisterPTitle.TabIndex = 50;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label29.Location = new System.Drawing.Point(245, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(134, 31);
            this.label29.TabIndex = 50;
            this.label29.Text = "سریال محموله:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterPCode
            // 
            this.lblRegisterPCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblRegisterPCode.Location = new System.Drawing.Point(13, 58);
            this.lblRegisterPCode.Name = "lblRegisterPCode";
            this.lblRegisterPCode.Size = new System.Drawing.Size(233, 31);
            this.lblRegisterPCode.TabIndex = 50;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label33.Location = new System.Drawing.Point(245, 101);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(134, 31);
            this.label33.TabIndex = 50;
            this.label33.Text = "عنوان کالا:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterPSize
            // 
            this.lblRegisterPSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPSize.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblRegisterPSize.Location = new System.Drawing.Point(14, 184);
            this.lblRegisterPSize.Name = "lblRegisterPSize";
            this.lblRegisterPSize.Size = new System.Drawing.Size(233, 31);
            this.lblRegisterPSize.TabIndex = 63;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label35.Location = new System.Drawing.Point(243, 59);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(134, 31);
            this.label35.TabIndex = 50;
            this.label35.Text = "کد کالا:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterPRegCode
            // 
            this.lblRegisterPRegCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPRegCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblRegisterPRegCode.Location = new System.Drawing.Point(15, 142);
            this.lblRegisterPRegCode.Name = "lblRegisterPRegCode";
            this.lblRegisterPRegCode.Size = new System.Drawing.Size(233, 31);
            this.lblRegisterPRegCode.TabIndex = 62;
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label37.Location = new System.Drawing.Point(244, 185);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(134, 31);
            this.label37.TabIndex = 63;
            this.label37.Text = "سایز کالا:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterPStatus
            // 
            this.lblRegisterPStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblRegisterPStatus.Location = new System.Drawing.Point(13, 229);
            this.lblRegisterPStatus.Name = "lblRegisterPStatus";
            this.lblRegisterPStatus.Size = new System.Drawing.Size(233, 31);
            this.lblRegisterPStatus.TabIndex = 61;
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label39.Location = new System.Drawing.Point(245, 143);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(134, 31);
            this.label39.TabIndex = 62;
            this.label39.Text = "کد تولید:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label40.Location = new System.Drawing.Point(243, 230);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(134, 31);
            this.label40.TabIndex = 61;
            this.label40.Text = "رنگ کالا:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = global::RfidConnectRegister.Properties.Resources._14;
            this.pictureBox7.Location = new System.Drawing.Point(2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(385, 84);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 86;
            this.pictureBox7.TabStop = false;
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelRegister.BackColor = System.Drawing.Color.Red;
            this.btnCancelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelRegister.FlatAppearance.BorderSize = 0;
            this.btnCancelRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRegister.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
            this.btnCancelRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelRegister.ImageKey = "cancel-131964784714462788.png";
            this.btnCancelRegister.ImageList = this.imageList2;
            this.btnCancelRegister.Location = new System.Drawing.Point(147, 416);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(227, 40);
            this.btnCancelRegister.TabIndex = 88;
            this.btnCancelRegister.TabStop = false;
            this.btnCancelRegister.Text = "تأیید ابطال تگ";
            this.btnCancelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelRegister.UseVisualStyleBackColor = false;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "cancel-131964784714462788.png");
            this.imageList2.Images.SetKeyName(1, "back-icon.png");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "back-icon.png";
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(12, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 88;
            this.button1.TabStop = false;
            this.button1.Text = "انصراف";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTestResult
            // 
            this.lblTestResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestResult.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblTestResult.Location = new System.Drawing.Point(2, 363);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(385, 45);
            this.lblTestResult.TabIndex = 89;
            this.lblTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClear
            // 
            this.timerClear.Interval = 3000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 26);
            this.textBox1.TabIndex = 0;
            // 
            // frmCancelRegisterTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTestResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.txtEpc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox7);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(405, 502);
            this.MinimumSize = new System.Drawing.Size(405, 502);
            this.Name = "frmCancelRegisterTag";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ابطال رجیستر تگ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCancelRegisterTag_FormClosing);
            this.Load += new System.EventHandler(this.frmCancelRegisterTag_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEpc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRegisterPSerial;
        private System.Windows.Forms.Label lblRegisterPTitle;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblRegisterPCode;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblRegisterPSize;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblRegisterPRegCode;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblRegisterPStatus;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.TextBox textBox1;
    }
}