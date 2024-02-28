using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace DBPROJECT
{
    public partial class frmChangePassword : Form
    {
        long iduser;
        String loginname;
        public frmChangePassword(long riduser, String rloginname)
        {
            InitializeComponent();
            this.iduser = riduser;
            this.loginname = rloginname;
            this.SetTheme();
            this.btnApply.Enabled = false;

            this.Text = "Change User (" + this.loginname + ") Password";
        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;
        }
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (this.btnShowHide.Text == "Show")
            {
                this.btnShowHide.Text = "Hide";
                this.btnShowHide.ImageIndex = 1;

                this.txtPassword1.PasswordChar = '\0';
                this.txtPassword2.PasswordChar = '\0';
            }
            else
            {
                this.btnShowHide.Text = "Show";
                this.btnShowHide.ImageIndex = 0;

                this.txtPassword1.PasswordChar = '●';
                this.txtPassword2.PasswordChar = '●';
            }
        }

        private void txtPassword1_KeyDown(object sender, KeyEventArgs e)
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

            this.btnApply.Enabled = true;
        }

        private void SavePassword()
        {
            String HashedPwd = "", pwd="";


            if (Globals.glOpenSqlConn())
            {
                pwd = this.txtPassword1.Text.Trim();

                if (pwd.Length > 0)
                {
                    HashedPwd = Globals.EncodePasswordToBase64(pwd);
                }
                else HashedPwd = pwd;


                SqlCommand cmd = new SqlCommand("spUpdateUserPwd", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("lidUser", this.iduser);
                cmd.Parameters.AddWithValue("lpassword", HashedPwd);

                cmd.ExecuteNonQuery();

            }
            Globals.glCloseSqlConn();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            String p1, p2;
            System.Windows.Forms.DialogResult dr;

            p1 = this.txtPassword1.Text.Trim();
            p2 = this.txtPassword2.Text.Trim();
            
            if (p1 != p2)
            {
                csMessageBox.Show("Passwords do not match.", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                dr = csMessageBox.Show("Save New Password.", "Please confirm.",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    this.SavePassword();
                    this.Close();
                    this.btnApply.Enabled = false;
                }
                else
                    this.btnApply.Enabled = true;
                                     
            }
        }
    }
}
