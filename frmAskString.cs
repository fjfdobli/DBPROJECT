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
    public partial class frmAskString : Form
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
        public frmAskString()
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
            get { return this.StrBox.Text; }
            set { this.StrBox.Text = value; }
        }
    }
}
