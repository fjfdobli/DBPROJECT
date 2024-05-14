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
    public partial class frmCustomerEmail : Form
    {
        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        public frmCustomerEmail(String cName, String cSendto)
        {
            String cemail = "", csmtphost = "", csmtpport = "";

            InitializeComponent();

            this.Text = "Email Customer: " + cName;
            this.txtcustEmailsendto.Text = cSendto;

            Globals.GetUserEmail(Globals.gIdUser, ref cemail, ref csmtphost, ref csmtpport);
            this.txtcustEmailfrom.Text = cemail;
            this.txtSMTPHost.Text = csmtphost;
            this.txtSMTPPort.Text = csmtpport;
        }

        private void txtcustEmailsendto_KeyDown(object sender, KeyEventArgs e)
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
        private void sendmail()
        {
            String fname = "";
            this.message.Attachments.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                fname = listBox1.Items[i].ToString();
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
                csMessageBox.Show("Email Message Sent", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String Password = "";

            if (AskDialog.AskPassword("Please type Gmail Password", ref Password)
                == DialogResult.OK)
            {

                message.From = new MailAddress(this.txtcustEmailfrom.Text);
                message.To.Add(new MailAddress(this.txtcustEmailsendto.Text));
                message.Subject = this.txtcustSubject.Text;
                message.IsBodyHtml = false; //to make message body as html
                message.Body = this.txtcustMessage.Text;
                smtp.Port = Convert.ToInt32(this.txtSMTPPort.Text);
                smtp.Host = this.txtSMTPHost.Text; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;


                smtp.Credentials = new NetworkCredential(this.txtcustEmailfrom.Text, Password);
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

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {

        }
    }
}
