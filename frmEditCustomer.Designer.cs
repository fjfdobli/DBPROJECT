
namespace DBPROJECT
{
    partial class frmEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            this.pictBoxCustomer = new System.Windows.Forms.PictureBox();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerContactNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBoxCustomer
            // 
            this.pictBoxCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxCustomer.Location = new System.Drawing.Point(12, 12);
            this.pictBoxCustomer.Name = "pictBoxCustomer";
            this.pictBoxCustomer.Size = new System.Drawing.Size(336, 267);
            this.pictBoxCustomer.TabIndex = 0;
            this.pictBoxCustomer.TabStop = false;
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearPhoto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClearPhoto.ImageIndex = 4;
            this.btnClearPhoto.ImageList = this.imageList1;
            this.btnClearPhoto.Location = new System.Drawing.Point(167, 285);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(181, 23);
            this.btnClearPhoto.TabIndex = 47;
            this.btnClearPhoto.Text = "Clear Photo";
            this.btnClearPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearPhoto.UseVisualStyleBackColor = true;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-icon-5402-Windows.ico");
            this.imageList1.Images.SetKeyName(1, "refresh-icon-png-40262-Windows.ico");
            this.imageList1.Images.SetKeyName(2, "edit-icon-png-3597.png");
            this.imageList1.Images.SetKeyName(3, "camera-icon-39.jpg");
            this.imageList1.Images.SetKeyName(4, "clear-icon-9196.gif");
            this.imageList1.Images.SetKeyName(5, "save-icon-5402.png");
            this.imageList1.Images.SetKeyName(6, "refresh-icon-10850.png");
            this.imageList1.Images.SetKeyName(7, "arrow-icon-1156.png");
            this.imageList1.Images.SetKeyName(8, "arrow-icon-1151.png");
            this.imageList1.Images.SetKeyName(9, "rightdouble.png");
            this.imageList1.Images.SetKeyName(10, "leftdouble-arrow.png");
            this.imageList1.Images.SetKeyName(11, "fast-forward-double-right-arrows-symbol.png");
            this.imageList1.Images.SetKeyName(12, "left-arrow.png");
            this.imageList1.Images.SetKeyName(13, "right-arrow.png");
            this.imageList1.Images.SetKeyName(14, "forgot-password-icon-18359.png");
            this.imageList1.Images.SetKeyName(15, "email-icon-122.png");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnSendEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCustomerContactNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCustomerAddress);
            this.groupBox2.Controls.Add(this.txtCustomerEmail);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(370, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 236);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendEmail.ImageIndex = 15;
            this.btnSendEmail.ImageList = this.imageList1;
            this.btnSendEmail.Location = new System.Drawing.Point(175, 193);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(229, 23);
            this.btnSendEmail.TabIndex = 49;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 1006;
            this.label7.Text = "Customer Contact No.";
            // 
            // txtCustomerContactNo
            // 
            this.txtCustomerContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerContactNo.Location = new System.Drawing.Point(175, 126);
            this.txtCustomerContactNo.Name = "txtCustomerContactNo";
            this.txtCustomerContactNo.Size = new System.Drawing.Size(229, 22);
            this.txtCustomerContactNo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 1005;
            this.label8.Text = "Customer Address";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(175, 88);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(229, 22);
            this.txtCustomerAddress.TabIndex = 1;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(175, 56);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(229, 22);
            this.txtCustomerEmail.TabIndex = 0;
            this.txtCustomerEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerEmail_KeyDown);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AcceptsReturn = true;
            this.txtCustomerName.AcceptsTab = true;
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(175, 23);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(229, 22);
            this.txtCustomerName.TabIndex = 1002;
            this.txtCustomerName.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRefresh.ImageKey = "refresh-icon-png-40262-Windows.ico";
            this.btnRefresh.Location = new System.Drawing.Point(292, 164);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.ImageIndex = 0;
            this.btnSave.Location = new System.Drawing.Point(175, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Name";
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPhoto.Image")));
            this.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPhoto.Location = new System.Drawing.Point(12, 285);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(149, 23);
            this.btnLoadPhoto.TabIndex = 47;
            this.btnLoadPhoto.Text = "Load New Photo";
            this.btnLoadPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.pictBoxCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditCustomer";
            this.Text = "Edit Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxCustomer;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerContactNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnLoadPhoto;
    }
}