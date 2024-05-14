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
    public partial class frmAskDate : Form
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
        public frmAskDate()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = Globals.gdefaultDateFormat;
            SetTheme();
        }

        public string Title
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }
        public DateTime DateValue
        {
            get { return this.dateTimePicker1.Value; }
            set { this.dateTimePicker1.Value = value; }
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
