
namespace DBPROJECT
{
    partial class frmUserEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserEmail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtEmailSendto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.txtSMTPHost = new System.Windows.Forms.TextBox();
            this.txtEmailfrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.tspClear = new System.Windows.Forms.ToolStripButton();
            this.tsbAddAttachment = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRremoveAttachment = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.txtEmailSendto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Recipient";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(97, 46);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(701, 22);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailSendto_KeyDown);
            // 
            // txtEmailSendto
            // 
            this.txtEmailSendto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSendto.Location = new System.Drawing.Point(97, 20);
            this.txtEmailSendto.Name = "txtEmailSendto";
            this.txtEmailSendto.Size = new System.Drawing.Size(347, 22);
            this.txtEmailSendto.TabIndex = 0;
            this.txtEmailSendto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailSendto_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send to";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSMTPPort);
            this.groupBox2.Controls.Add(this.txtSMTPHost);
            this.groupBox2.Controls.Add(this.txtEmailfrom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Sender";
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPPort.Location = new System.Drawing.Point(590, 43);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(208, 22);
            this.txtSMTPPort.TabIndex = 1002;
            this.txtSMTPPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailSendto_KeyDown);
            // 
            // txtSMTPHost
            // 
            this.txtSMTPHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPHost.Location = new System.Drawing.Point(590, 15);
            this.txtSMTPHost.Name = "txtSMTPHost";
            this.txtSMTPHost.Size = new System.Drawing.Size(208, 22);
            this.txtSMTPHost.TabIndex = 1001;
            this.txtSMTPHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailSendto_KeyDown);
            // 
            // txtEmailfrom
            // 
            this.txtEmailfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailfrom.Location = new System.Drawing.Point(97, 15);
            this.txtEmailfrom.Name = "txtEmailfrom";
            this.txtEmailfrom.Size = new System.Drawing.Size(347, 22);
            this.txtEmailfrom.TabIndex = 1000;
            this.txtEmailfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailSendto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "SMTP Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "SMTP Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "From";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye-icon-1463.png");
            this.imageList1.Images.SetKeyName(1, "ClosedEye.jpg");
            this.imageList1.Images.SetKeyName(2, "txt-file-icon-1185.png");
            this.imageList1.Images.SetKeyName(3, "txt-file-icon-1192.png");
            this.imageList1.Images.SetKeyName(4, "txt-file-icon-1193.png");
            this.imageList1.Images.SetKeyName(5, "txt-file-icon-1203.png");
            this.imageList1.Images.SetKeyName(6, "eraser-icon-23405.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(6, 19);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(574, 213);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.btnSave,
            this.btnSend,
            this.tspClear,
            this.tsbAddAttachment});
            this.toolStrip1.Location = new System.Drawing.Point(0, 405);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 45);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 42);
            this.btnLoad.Text = "Load Text";
            this.btnLoad.ToolTipText = "Load from Text File";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 42);
            this.btnSave.Text = "Save Text";
            this.btnSave.ToolTipText = "Save to Text File";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 42);
            this.btnSend.Text = "Send Email";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tspClear
            // 
            this.tspClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspClear.Image = ((System.Drawing.Image)(resources.GetObject("tspClear.Image")));
            this.tspClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tspClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspClear.Name = "tspClear";
            this.tspClear.Size = new System.Drawing.Size(58, 42);
            this.tspClear.Text = "Clear";
            this.tspClear.Click += new System.EventHandler(this.tspClear_Click);
            // 
            // tsbAddAttachment
            // 
            this.tsbAddAttachment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAddAttachment.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAttachment.Image")));
            this.tsbAddAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAttachment.Name = "tsbAddAttachment";
            this.tsbAddAttachment.Size = new System.Drawing.Size(115, 42);
            this.tsbAddAttachment.Text = "Add Attachment";
            this.tsbAddAttachment.Click += new System.EventHandler(this.tsbAddAttachment_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(606, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 234);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Attachments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRremoveAttachment});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 26);
            // 
            // tsmRremoveAttachment
            // 
            this.tsmRremoveAttachment.Name = "tsmRremoveAttachment";
            this.tsmRremoveAttachment.Size = new System.Drawing.Size(183, 22);
            this.tsmRremoveAttachment.Text = "Remove Attachment";
            this.tsmRremoveAttachment.Click += new System.EventHandler(this.tsmRremoveAttachment_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 208);
            this.listBox1.TabIndex = 0;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // frmUserEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email User";
            this.Load += new System.EventHandler(this.frmUserEmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSend;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtEmailSendto;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.TextBox txtSMTPHost;
        private System.Windows.Forms.TextBox txtEmailfrom;
        private System.Windows.Forms.ToolStripButton tspClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton tsbAddAttachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRremoveAttachment;
    }
}