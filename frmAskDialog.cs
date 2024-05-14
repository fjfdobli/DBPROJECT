using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public static class AskDialog
    {
        public static System.Windows.Forms.DialogResult AskString(string title, string caption, ref String resultstr)
        {
            DialogResult dlgResult;

            using (frmAskString stringBox = new frmAskString())
            {
                stringBox.Text = caption;
                stringBox.Title = title;

                dlgResult = stringBox.ShowDialog();
                if (dlgResult == DialogResult.OK)
                    resultstr = stringBox.StrValue;
            }            
            return dlgResult;
        }

        public static System.Windows.Forms.DialogResult AskPassword(string caption, ref String resultstr)
        {
            DialogResult dlgResult;

            using (frmAskStringPassword stringBox = new frmAskStringPassword())
            {
                stringBox.Text = caption;
                
                dlgResult = stringBox.ShowDialog();
                if (dlgResult == DialogResult.OK)
                    resultstr = stringBox.StrValue;

            }
            return dlgResult;

        }

        public static System.Windows.Forms.DialogResult AskDate(string caption, ref DateTime result)
        {
            DialogResult dlgResult;

            using (frmAskDate rBox = new frmAskDate())
            {
                rBox.Text = caption;

                dlgResult = rBox.ShowDialog();

                if (dlgResult == DialogResult.OK)
                    result = rBox.DateValue;

            }
            return dlgResult;

        }

        public static System.Windows.Forms.DialogResult AskInt(string caption,long startvalue, ref long result)
        {
            DialogResult dlgResult;

            using (frmAskInt rBox = new frmAskInt())
            {
                rBox.Text = caption;

                rBox.IntValue = startvalue;
                
                dlgResult = rBox.ShowDialog();
                if (dlgResult == DialogResult.OK)
                    result = rBox.IntValue;

            }
            return dlgResult;

        }

        public static System.Windows.Forms.DialogResult AskFloat(string caption, string fmt,double startvalue, ref double result)
        {
            DialogResult dlgResult;

            using (frmAskFloat rBox = new frmAskFloat())
            {
                rBox.Text = caption;

                rBox.FloatValue = startvalue;
                rBox.FormatStr = fmt;
                dlgResult = rBox.ShowDialog();
                if (dlgResult == DialogResult.OK)
                   result = rBox.FloatValue;

            }
            return dlgResult;

        }

    }
}
