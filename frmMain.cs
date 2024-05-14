using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBPROJECT
{
    public partial class frmMain : Form
    {
        frmLogin fm;   // login form
        public frmMain()
        {
            InitializeComponent();


        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Exit the application?", "Please confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            //         this.Close();
            if (csMessageBox.Show("Exit the application?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool mustchangepwd = false;

            Globals.glInitializeVariables();
            this.fm = new frmLogin();

            if (this.fm.ShowDialog() == DialogResult.Abort)
                this.Close();

            if (Globals.gLoginName != null)
            {
                this.txtUserName.Text = Globals.gLoginName;
            }

            if (Globals.gdbServerName != null)
            {
                this.txtServer.Text = Globals.gdbServerName;
            }

            this.glSetSizeToDesktop();
            this.BringToFront();
        }
        private frmChangePassword ChangePasswordfrm;
        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm.Dispose();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(Globals.gIdUser, Globals.gLoginName);
            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;
            //ChangePasswordfrm.MdiParent = this;
            ChangePasswordfrm.ShowDialog();
        }

        private frmUserProfile UserProfilefrm;
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfilefrm = new frmUserProfile(Globals.gIdUser, Globals.gLoginName);
            UserProfilefrm.FormClosed += UserProfilefrm_FormClosed;
            UserProfilefrm.MdiParent = this;
            UserProfilefrm.Show();
        }

        private void UserProfilefrm_FormClosed(object sender, EventArgs e)
        {
            UserProfilefrm.Dispose();
        }

        frmUser Userfrm;

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userfrm = new frmUser();
            Userfrm.FormClosed += Userfrm_FormClosed;
            Userfrm.MdiParent = this;
            Userfrm.Show();
        }

        private void Userfrm_FormClosed(object sender, EventArgs e)
        {
            Userfrm.Dispose();
        }

        frmCustomers Customerfrm;

        private void customer_btn_Click(object sender, EventArgs e)
        {
            Customerfrm = new frmCustomers();
            Customerfrm.FormClosed += Customerfrm_FormClosed;
            Customerfrm.MdiParent = this;
            Customerfrm.Show();
        }

        private void Customerfrm_FormClosed(object sender, EventArgs e)
        {
            Customerfrm.Dispose();
        }

        frmVendors Vendorfrm;

        private void vendor_btn_Click(object sender, EventArgs e)
        {
            Vendorfrm = new frmVendors();
            //Vendorfrm.FormClosed += Vedndorfrm_FormClosed;
            Vendorfrm.MdiParent = this;
            Vendorfrm.Show();
        }

        private void Vendorfrm_FormClosed(object sender, EventArgs e)
        {
            Vendorfrm.Dispose();
        }

        frmItems Itemfrm;

        private void item_btn_Click(object sender, EventArgs e)
        {
            Itemfrm = new frmItems();
            //Itemfrm.FormClosed += Itemfrm_FormClosed;
            Itemfrm.MdiParent = this;
            Itemfrm.Show();
        }
        private void Itemfrm_FormClosed(object sender, EventArgs e)
        {
            Itemfrm.Dispose();
        }

    }
}
    