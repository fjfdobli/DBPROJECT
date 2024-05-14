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
    public partial class frmAskStringPassword : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;
        
        }
        public frmAskStringPassword()
        {
            InitializeComponent();
            SetTheme();
        }

        public string Title
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }
        public string StrValue
        {
            get { return this.txtPassword.Text; }
            set { this.txtPassword.Text = value; }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {

            if (this.btnShowHide.Text == "Show")
            {
                this.btnShowHide.Text = "Hide";
                this.btnShowHide.ImageIndex = 1;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.btnShowHide.Text = "Show";
                this.btnShowHide.ImageIndex = 0;
                this.txtPassword.PasswordChar = '●';

            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
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
    }
}
