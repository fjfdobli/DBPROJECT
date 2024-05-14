using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace DBPROJECT
{
    
    public partial class frmUserEmail : Form
    {
        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        public frmUserEmail(String uLoginName, String uSendto)
        {
            String semail = "", ssmtphost = "", ssmtpport = "";

            InitializeComponent();
            this.Text = "Email User:" + uLoginName;
            this.txtEmailSendto.Text = uSendto;

            Globals.GetUserEmail(Globals.gIdUser, ref semail, ref ssmtphost, ref ssmtpport);
            this.txtEmailfrom.Text = semail;
            this.txtSMTPHost.Text = ssmtphost;
            this.txtSMTPPort.Text = ssmtpport;
        }

        public void SetTheme()
        {
            this.BackColor = Globals.gFormBackGroundColor;
            this.groupBox1.BackColor = Globals.gFormBackGroundColor;
            this.groupBox2.BackColor = Globals.gFormBackGroundColor;
            this.groupBox3.BackColor = Globals.gFormBackGroundColor;
            this.groupBox4.BackColor = Globals.gFormBackGroundColor;
        }

        private void frmUserEmail_Load(object sender, EventArgs e)
        {
            this.SetTheme();
        }

        private void txtEmailSendto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true; // PUT THE DING OFF
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void tspClear_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Clear email message?", "Please confirm.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                         this.txtMessage.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Open text file";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    this.txtMessage.Text = text;
                }
                catch (IOException)
                {
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save text file";
            
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtMessage.Text);
            }
        }

        private void sendmail()
        {
            // attach files
            String fname = "";
            this.message.Attachments.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                fname=listBox1.Items[i].ToString();
                if (File.Exists(fname))
                    this.message.Attachments.Add(new Attachment(fname));

            }
            try
            {

               
                this.smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                string msg = "Mail cannot be sent:";
                msg += ex.Message;

                csMessageBox.Show("Error:" + msg, "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw new Exception(msg);
            }
            finally
            {
                csMessageBox.Show("Email Message Sent","Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
               
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String Password = "";
                       
            if (AskDialog.AskPassword("Please type Gmail Password", ref Password)
                == DialogResult.OK)
            {
               
               message.From = new MailAddress(this.txtEmailfrom.Text);
               message.To.Add(new MailAddress(this.txtEmailSendto.Text));
               message.Subject = this.txtSubject.Text;
               message.IsBodyHtml = false; //to make message body as html
               message.Body = this.txtMessage.Text;
               smtp.Port = Convert.ToInt32(this.txtSMTPPort.Text);
               smtp.Host = this.txtSMTPHost.Text; //for gmail host
               smtp.EnableSsl = true;
               smtp.UseDefaultCredentials = false;


               smtp.Credentials = new NetworkCredential(this.txtEmailfrom.Text, Password);
               smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

//                CustomMessageBox.ShowMessage("from:" + this.txtEmailfrom.Text + " " +
//                    "To:"+this.txtEmailSendto.Text + " " +
//                    "port:"+this.txtSMTPPort.Text+" "+
//                    "password"+Password,"To email",MessageBoxButtons.OK,
 //                   MessageBoxIcon.Information
  //                                      );

               using (frmWait frm = new frmWait(sendmail, "Sending Email..."))
               {
                   frm.ShowDialog(this);

               }
            }
        }

        private void tsbAddAttachment_Click(object sender, EventArgs e)
        {
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            openFileDialog2.Title = "Open a file for attachment.";
            
            openFileDialog2.Filter = "(*.*)|*.*";
                        
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                this.listBox1.Items.Add(openFileDialog2.FileName);
                this.listBox1.Refresh();
            }  
        }

        private void tsmRremoveAttachment_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;
            if (listBox1.SelectedIndex != -1)
            {
                foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                    listBox1.Items.Remove(s);
            }
            else
                csMessageBox.Show("Please select an attachment to remove", "Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }
}
