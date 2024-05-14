
namespace DBPROJECT
{
    partial class frmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSMTPHOST = new System.Windows.Forms.TextBox();
            this.txtSMTPport = new System.Windows.Forms.TextBox();
            this.pkrBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.pictBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPhoto.Image")));
            this.btnLoadPhoto.Location = new System.Drawing.Point(106, 269);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(125, 23);
            this.btnLoadPhoto.TabIndex = 1;
            this.btnLoadPhoto.Text = "Load New Photo";
            this.btnLoadPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(237, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Photo";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePwd.Image")));
            this.btnChangePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePwd.Location = new System.Drawing.Point(13, 500);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(218, 23);
            this.btnChangePwd.TabIndex = 3;
            this.btnChangePwd.Text = "Change User Password";
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(353, 500);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(256, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "SMTP Host";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "SMTP Port";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(107, 305);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.ReadOnly = true;
            this.txtLoginName.Size = new System.Drawing.Size(336, 20);
            this.txtLoginName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 336);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSavebutton);
            // 
            // txtSMTPHOST
            // 
            this.txtSMTPHOST.Location = new System.Drawing.Point(106, 367);
            this.txtSMTPHOST.Name = "txtSMTPHOST";
            this.txtSMTPHOST.Size = new System.Drawing.Size(337, 20);
            this.txtSMTPHOST.TabIndex = 14;
            this.txtSMTPHOST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSavebutton);
            // 
            // txtSMTPport
            // 
            this.txtSMTPport.Location = new System.Drawing.Point(107, 396);
            this.txtSMTPport.Name = "txtSMTPport";
            this.txtSMTPport.Size = new System.Drawing.Size(124, 20);
            this.txtSMTPport.TabIndex = 15;
            this.txtSMTPport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSavebutton);
            // 
            // pkrBirthdate
            // 
            this.pkrBirthdate.CustomFormat = "MM/dd/yyyy";
            this.pkrBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrBirthdate.Location = new System.Drawing.Point(106, 427);
            this.pkrBirthdate.Name = "pkrBirthdate";
            this.pkrBirthdate.Size = new System.Drawing.Size(125, 20);
            this.pkrBirthdate.TabIndex = 16;
            this.pkrBirthdate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.pkrBirthdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSavebutton);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.cbxGender.Location = new System.Drawing.Point(106, 459);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(125, 21);
            this.cbxGender.TabIndex = 17;
            this.cbxGender.TextChanged += new System.EventHandler(this.cbxGender_TextChanged);
            // 
            // pictBoxUser
            // 
            this.pictBoxUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxUser.Location = new System.Drawing.Point(106, 12);
            this.pictBoxUser.Name = "pictBoxUser";
            this.pictBoxUser.Size = new System.Drawing.Size(255, 242);
            this.pictBoxUser.TabIndex = 0;
            this.pictBoxUser.TabStop = false;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 536);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.pkrBirthdate);
            this.Controls.Add(this.txtSMTPport);
            this.Controls.Add(this.txtSMTPHOST);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnChangePwd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.pictBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSMTPHOST;
        private System.Windows.Forms.TextBox txtSMTPport;
        private System.Windows.Forms.DateTimePicker pkrBirthdate;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.PictureBox pictBoxUser;
    }
}