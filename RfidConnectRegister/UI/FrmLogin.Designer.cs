namespace RfidConnectRegister.UI
{ 
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIp = new System.Windows.Forms.Panel();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnSaveIp = new System.Windows.Forms.Button();
            this.btnVisiblePanelIp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlIp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.txtPassword.Location = new System.Drawing.Point(363, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button2.Location = new System.Drawing.Point(12, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
            this.button1.Location = new System.Drawing.Point(147, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 41);
            this.label3.TabIndex = 52;
            this.label3.Text = "رمز عبور:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RfidConnectRegister.Properties.Resources.best_free_open_source_Warehouse_Management_Software_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 109);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.txtUserName.Location = new System.Drawing.Point(363, 17);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(193, 38);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(562, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 41);
            this.label1.TabIndex = 56;
            this.label1.Text = "نام کاربری:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlIp
            // 
            this.pnlIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIp.Controls.Add(this.txtIp);
            this.pnlIp.Controls.Add(this.btnSaveIp);
            this.pnlIp.Location = new System.Drawing.Point(204, 295);
            this.pnlIp.Name = "pnlIp";
            this.pnlIp.Size = new System.Drawing.Size(274, 48);
            this.pnlIp.TabIndex = 58;
            this.pnlIp.Visible = false;
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.White;
            this.txtIp.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.txtIp.Location = new System.Drawing.Point(71, 8);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(193, 38);
            this.txtIp.TabIndex = 59;
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // btnSaveIp
            // 
            this.btnSaveIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveIp.BackColor = System.Drawing.Color.White;
            this.btnSaveIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveIp.Location = new System.Drawing.Point(3, 10);
            this.btnSaveIp.Name = "btnSaveIp";
            this.btnSaveIp.Size = new System.Drawing.Size(60, 29);
            this.btnSaveIp.TabIndex = 59;
            this.btnSaveIp.Text = "ثبت";
            this.btnSaveIp.UseVisualStyleBackColor = false;
            this.btnSaveIp.Click += new System.EventHandler(this.btnSaveIp_Click);
            // 
            // btnVisiblePanelIp
            // 
            this.btnVisiblePanelIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisiblePanelIp.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVisiblePanelIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisiblePanelIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisiblePanelIp.Image = global::RfidConnectRegister.Properties.Resources.if_settings_326699;
            this.btnVisiblePanelIp.Location = new System.Drawing.Point(618, 446);
            this.btnVisiblePanelIp.Name = "btnVisiblePanelIp";
            this.btnVisiblePanelIp.Size = new System.Drawing.Size(31, 31);
            this.btnVisiblePanelIp.TabIndex = 57;
            this.btnVisiblePanelIp.UseVisualStyleBackColor = false;
            this.btnVisiblePanelIp.Click += new System.EventHandler(this.btnVisiblePanelIp_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 477);
            this.Controls.Add(this.pnlIp);
            this.Controls.Add(this.btnVisiblePanelIp);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     صفحه ورود";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlIp.ResumeLayout(false);
            this.pnlIp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnSaveIp;
        private System.Windows.Forms.Button btnVisiblePanelIp;
    }
}