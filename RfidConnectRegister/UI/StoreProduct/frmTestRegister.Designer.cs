namespace RfidConnectRegister.UI.StoreProduct
{
    partial class frmTestRegister
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
            this.pnlTestRegister = new System.Windows.Forms.Panel();
            this.txtSerialCode = new System.Windows.Forms.TextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLablePSerial = new System.Windows.Forms.Label();
            this.lblLablePTitle = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lblLablePCode = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lblLablePStatus = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.timerFocus = new System.Windows.Forms.Timer(this.components);
            this.timerCheckBarcode = new System.Windows.Forms.Timer(this.components);
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.lblTestResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTestRegister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTestRegister
            // 
            this.pnlTestRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTestRegister.Controls.Add(this.txtSerialCode);
            this.pnlTestRegister.Controls.Add(this.txtEpc);
            this.pnlTestRegister.Controls.Add(this.groupBox1);
            this.pnlTestRegister.Controls.Add(this.groupBox3);
            this.pnlTestRegister.Controls.Add(this.pictureBox6);
            this.pnlTestRegister.Controls.Add(this.pictureBox7);
            this.pnlTestRegister.Location = new System.Drawing.Point(0, 2);
            this.pnlTestRegister.Name = "pnlTestRegister";
            this.pnlTestRegister.Size = new System.Drawing.Size(784, 367);
            this.pnlTestRegister.TabIndex = 83;
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialCode.Location = new System.Drawing.Point(408, 29);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(1, 26);
            this.txtSerialCode.TabIndex = 85;
            this.txtSerialCode.TextChanged += new System.EventHandler(this.txtSerialCode_TextChanged);
            // 
            // txtEpc
            // 
            this.txtEpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpc.Location = new System.Drawing.Point(19, 29);
            this.txtEpc.Name = "txtEpc";
            this.txtEpc.Size = new System.Drawing.Size(124, 26);
            this.txtEpc.TabIndex = 84;
            this.txtEpc.TabStop = false;
            this.txtEpc.Visible = false;
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
            this.groupBox1.Location = new System.Drawing.Point(4, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 272);
            this.groupBox1.TabIndex = 65;
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
            this.lblRegisterPSerial.TextChanged += new System.EventHandler(this.lblRegisterPSerial_TextChanged);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblLablePSerial);
            this.groupBox3.Controls.Add(this.lblLablePTitle);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.lblLablePCode);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.lblLablePStatus);
            this.groupBox3.Controls.Add(this.label53);
            this.groupBox3.Location = new System.Drawing.Point(394, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 272);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات چاپ شده بر روی  لیبل";
            // 
            // lblLablePSerial
            // 
            this.lblLablePSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLablePSerial.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblLablePSerial.Location = new System.Drawing.Point(15, 17);
            this.lblLablePSerial.Name = "lblLablePSerial";
            this.lblLablePSerial.Size = new System.Drawing.Size(233, 31);
            this.lblLablePSerial.TabIndex = 50;
            this.lblLablePSerial.TextChanged += new System.EventHandler(this.lblLablePSerial_TextChanged);
            // 
            // lblLablePTitle
            // 
            this.lblLablePTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLablePTitle.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.5F);
            this.lblLablePTitle.Location = new System.Drawing.Point(15, 101);
            this.lblLablePTitle.Name = "lblLablePTitle";
            this.lblLablePTitle.Size = new System.Drawing.Size(233, 41);
            this.lblLablePTitle.TabIndex = 50;
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label44.Location = new System.Drawing.Point(245, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(134, 31);
            this.label44.TabIndex = 50;
            this.label44.Text = "سریال محموله:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLablePCode
            // 
            this.lblLablePCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLablePCode.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblLablePCode.Location = new System.Drawing.Point(13, 60);
            this.lblLablePCode.Name = "lblLablePCode";
            this.lblLablePCode.Size = new System.Drawing.Size(233, 31);
            this.lblLablePCode.TabIndex = 50;
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label46.Location = new System.Drawing.Point(245, 102);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(134, 31);
            this.label46.TabIndex = 50;
            this.label46.Text = "عنوان کالا:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label48.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label48.Location = new System.Drawing.Point(243, 61);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(134, 31);
            this.label48.TabIndex = 50;
            this.label48.Text = "کد کالا:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLablePStatus
            // 
            this.lblLablePStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLablePStatus.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblLablePStatus.Location = new System.Drawing.Point(13, 142);
            this.lblLablePStatus.Name = "lblLablePStatus";
            this.lblLablePStatus.Size = new System.Drawing.Size(233, 31);
            this.lblLablePStatus.TabIndex = 61;
            // 
            // label53
            // 
            this.label53.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label53.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.label53.Location = new System.Drawing.Point(243, 143);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(134, 31);
            this.label53.TabIndex = 61;
            this.label53.Text = "رنگ کالا:";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::RfidConnectRegister.Properties.Resources._141;
            this.pictureBox6.Location = new System.Drawing.Point(394, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(385, 84);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = global::RfidConnectRegister.Properties.Resources._14;
            this.pictureBox7.Location = new System.Drawing.Point(3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(385, 84);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 78;
            this.pictureBox7.TabStop = false;
            // 
            // timerFocus
            // 
            this.timerFocus.Interval = 1000;
            this.timerFocus.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerCheckBarcode
            // 
            this.timerCheckBarcode.Tick += new System.EventHandler(this.timerCheckBarcode_Tick);
            // 
            // timerClear
            // 
            this.timerClear.Interval = 3000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // lblTestResult
            // 
            this.lblTestResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestResult.Font = new System.Drawing.Font("IRANSans(FaNum)", 14F);
            this.lblTestResult.Location = new System.Drawing.Point(0, 372);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(736, 45);
            this.lblTestResult.TabIndex = 50;
            this.lblTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::RfidConnectRegister.Properties.Resources.iconfinder_refresh_430112;
            this.pictureBox1.Location = new System.Drawing.Point(738, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmTestRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTestRegister);
            this.Controls.Add(this.lblTestResult);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(802, 459);
            this.MinimumSize = new System.Drawing.Size(802, 459);
            this.Name = "frmTestRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تست رجیستر تگ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTestRegister_FormClosing);
            this.Load += new System.EventHandler(this.frmTestRegister_Load);
            this.pnlTestRegister.ResumeLayout(false);
            this.pnlTestRegister.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTestRegister;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLablePSerial;
        private System.Windows.Forms.Label lblLablePTitle;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label lblLablePCode;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label lblLablePStatus;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtEpc;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.Timer timerFocus;
        private System.Windows.Forms.Timer timerCheckBarcode;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}