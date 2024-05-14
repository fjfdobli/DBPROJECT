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
    public partial class frmAskInt : Form
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
        public frmAskInt()
        {
            InitializeComponent();
            SetTheme();
        }

        public string Title
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }
        public long IntValue
        {
            get { return int.Parse(this.StrBox.Text); }
            set { this.StrBox.Text = value.ToString(); }
        }

        private void StrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsControl(ch) && !char.IsDigit(ch)
                && ch!=8 && ch!=127 && ch!='-')
            {
                e.Handled = true;
            }
            // limit - negative signs to only  one
            if ((ch == '-'))
            {
                if ((sender as TextBox).Text.IndexOf('-') > -1)
                  e.Handled = true;
            }

        }

        private void StrBox_KeyDown(object sender, KeyEventArgs e)
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
