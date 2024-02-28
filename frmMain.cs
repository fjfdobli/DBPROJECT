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
        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm = null;
        }

        private frmChangePassword ChangePasswordfrm;

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(Globals.gIdUser, Globals.gLoginName);
            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;

            ChangePasswordfrm.ShowDialog();
        }

        private frmUserProfile UserProfilefrm;

        private void editUserProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfilefrm = new frmUserProfile(Globals.gIdUser, Globals.gLoginName);
            UserProfilefrm.FormClosed += UserProfilefrm_FormClosed;
            UserProfilefrm.ShowDialog();
        }

        private void UserProfilefrm_FormClosed(object sender, FormClosedEventArgs e)
        {

            UserProfilefrm.Dispose();
        }
        /*
        private void UserProfilefrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserProfilefrm = null;
            
            this.txtUserName.Text = Globals.gLoginName;
        }

        private void editUserProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfilefrm == null)
            {
                UserProfilefrm = new frmUserProfile();
                //UserProfilefrm.MdiParent = this;

                UserProfilefrm.FormClosed += UserProfilefrm_FormClosed;

                UserProfilefrm.Show();
            }
            else UserProfilefrm.Activate();

            this.txtUserName.Text = Globals.gLoginName;

        }
        */
    }
}
