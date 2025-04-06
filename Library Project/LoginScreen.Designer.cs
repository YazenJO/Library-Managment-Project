namespace frmLogin
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radLabel1.Location = new System.Drawing.Point(694, 79);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(168, 49);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "User Login";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.txtUserName.Location = new System.Drawing.Point(638, 143);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(264, 34);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPassword.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.txtPassword.Location = new System.Drawing.Point(638, 234);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(264, 34);
            this.txtPassword.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(615, 409);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Don\'t have an account?";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(776, 409);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(86, 18);
            this.hyperlinkLabelControl1.TabIndex = 6;
            this.hyperlinkLabelControl1.Text = "Rigester Now";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Project.Properties.Resources.user_profile;
            this.pictureBox2.Location = new System.Drawing.Point(702, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(948, 444);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(38, 36);
            this.pictureEdit1.TabIndex = 4;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(714, 310);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 49);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 492);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl txtUserName;
        private Telerik.WinControls.UI.RadTextBoxControl txtPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

