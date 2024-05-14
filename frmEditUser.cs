using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace DBPROJECT
{
    public partial class frmEditUser : Form
    {
        long idUser=0;
        public frmEditUser(long tidUser)
        {
            InitializeComponent();

            this.idUser = tidUser;

            this.pkrBirthdate.Format = DateTimePickerFormat.Custom;
            this.pkrBirthdate.CustomFormat = Globals.gdefaultDateFormat;

            this.SetTheme();
            this.btnSave.Enabled = false;
        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;
            this.groupBox2.BackColor = Globals.gDialogBackgroundColor;
            this.pictBoxUser.BackColor = Globals.gDialogBackgroundColor;
        }
        public long userid
        {
            get { return this.idUser; }
            set { this.idUser = value; }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnSave.Enabled = true; ;
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

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            this.RefreshData();
            this.btnSave.Enabled = false;
            this.Load_AssignedUserRoles();
            this.Load_AvailableRoles();
            this.txtEmail.Focus();
        }

        private void RefreshData()
        {
            String tloginname = "", temail = "", tgender = "MALE",tactive="", tmustchangepwd="";
            String tsmtphost = "", tsmtpport = "";
            DateTime tbirthdate = Convert.ToDateTime("01/01/1900");

            // load photo here
            this.GetUserPhotofromField();

            this.GetProfile(this.idUser, ref tloginname, ref tactive, ref tmustchangepwd,
                 ref temail, ref tsmtphost, ref tsmtpport, ref tbirthdate, ref tgender);

            this.txtLoginName.Text = tloginname;

            if (tactive == "TRUE") this.chkActive.Checked = true;
            else this.chkActive.Checked = false;

            if (tmustchangepwd == "TRUE") this.chkMustChPwd.Checked = true;
            else this.chkMustChPwd.Checked = false;

            this.txtEmail.Text = temail;
            this.txtSMTPHOST.Text = tsmtphost;
            this.txtSMTPport.Text = tsmtpport;

            this.pkrBirthdate.Value = tbirthdate;
            this.cbxGender.SelectedItem = tgender;
     
            this.btnSave.Enabled = false;
         }

        private void GetProfile(long uiduser,
            ref String uloginname,ref String uactive, ref String umustchangepwd,
            ref String uemail, ref String usmtphost, ref String usmtpport,
            ref DateTime ubirthdate,
            ref String ugender)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spGetUserProfile",
                    Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@liduser", uiduser);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    uloginname = reader["loginName"].ToString();
                    uactive = reader["active"].ToString().ToUpper();
                    umustchangepwd = reader["mustchangepwd"].ToString().ToUpper();

                    uemail = reader["email"].ToString();
                    usmtphost = reader["smtphost"].ToString();
                    usmtpport = reader["smtpport"].ToString();

                    ubirthdate = Globals.glConvertBlankDate(reader["birthdate"].ToString());

                    ugender = Globals.glConvertBlankGender(reader["gender"].ToString());

                }
                else csMessageBox.Show("No such User ID:" + this.idUser.ToString() + " is found!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Globals.glCloseSqlConn();
        }

        void GetUserPhotofromField()
        {
        
            if (Globals.glOpenSqlConn())
            {
                String qrystr = "Select isnull(photo,'') as photo from dbo.users where id=" +this.idUser.ToString();
                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                SqlDataAdapter UserAdapter = new SqlDataAdapter(cmd);

                DataTable UserTable = new DataTable();
                UserAdapter.Fill(UserTable);

                if (UserTable.Rows[0][0] != null)
                {

                    //byte[] UserImg = (byte[])UserTable.Rows[0][0];
                    byte[] UserImg = (byte[])UserTable.Rows[0][0];
                    MemoryStream imgstream = new MemoryStream(UserImg);

                    if (imgstream.Length > 0)
                        this.pictBoxUser.Image = Image.FromStream(imgstream);
                }
                UserAdapter.Dispose();
            }
            Globals.glCloseSqlConn();
        }
        
        private void UpdateUser()
        {
            int lactive = 0, lmustchangepwd = 0;

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spUpdateUser2", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@lidUser", this.idUser);
                cmd.Parameters.AddWithValue("@lloginName", this.txtLoginName.Text);

                if (this.chkActive.Checked) lactive = 1;
                else lactive = 0;

                if (this.chkMustChPwd.Checked) lmustchangepwd = 1;
                else lmustchangepwd = 0;

                cmd.Parameters.AddWithValue("lactive", lactive);
                cmd.Parameters.AddWithValue("lmustchangepwd", lmustchangepwd);
                cmd.Parameters.AddWithValue("lemail", this.txtEmail.Text);
                cmd.Parameters.AddWithValue("lsmtphost", this.txtSMTPHOST.Text);
                cmd.Parameters.AddWithValue("lsmtpport", this.txtSMTPport.Text);
                cmd.Parameters.AddWithValue("lbirthdate",
                     Globals.glConvertBlankDate(this.pkrBirthdate.Value.ToString()));
                cmd.Parameters.AddWithValue("lgender",
                    Globals.glConvertBlankGender(this.cbxGender.SelectedItem.ToString()));
                cmd.ExecuteNonQuery();
            }
            Globals.glCloseSqlConn();
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhoto = new OpenFileDialog();
            openPhoto.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openPhoto.ShowDialog() == DialogResult.OK)
            {
                pictBoxUser.Image = Image.FromFile(openPhoto.FileName);
                this.SavePhototoField();
            }

        }
        private void SavePhototoField()
        {
            MemoryStream ms = new MemoryStream();
            this.pictBoxUser.Image.Save(ms, pictBoxUser.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (Globals.glOpenSqlConn())
            {
                String qrystr = "update users set photo=@img where id =" +
                    this.idUser.ToString();

                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                cmd.Parameters.Add("@img",SqlDbType.Image); //MySqlDbType.Blob
                cmd.Parameters["@img"].Value = img;

                if (cmd.ExecuteNonQuery() == 1)
                    csMessageBox.Show("New photo is saved...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Globals.glCloseSqlConn();

        }

        private void ClearPhototoField()
        {
            if (Globals.glOpenSqlConn())
            {
                String qrystr = "update users set photo=null where id =" +
                    Globals.gIdUser.ToString();

                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    this.pictBoxUser.Image = null;

                    csMessageBox.Show("User photo is cleared...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Globals.glCloseSqlConn();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("User photo is cleared...", "Information",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.ClearPhototoField();
            }
        }

        private void frmEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.btnSave.Enabled)
            {
                DialogResult dr;

                dr = csMessageBox.Show("Changes not saved! Save changes", "Please confirm.",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (dr)
                {
                    case DialogResult.Yes:
                        if (this.txtLoginName.Text.Trim() == "")
                        {
                            csMessageBox.Show("Please provide a valid login name.", "Empty Login Name",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            e.Cancel = true;
                            this.txtEmail.Focus();
                        }
                        else
                        {
                            this.UpdateUser();
                            
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtLoginName.Text.Trim() == "")
            {
                csMessageBox.Show("Please provide a valid login name.", "Empty Login Name",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.UpdateUser();
                this.btnSave.Enabled = false;
                Globals.gLoginName = this.txtLoginName.Text;
            }
        }

        private void pkrBirthdate_ValueChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true; ;

            if (this.GetNextControl(ActiveControl, true) != null)
            {
                this.GetNextControl(ActiveControl, true).Focus();
            }
        }

        private void Load_AssignedUserRoles()
        {
            
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetUserRoles";
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable DTable = new DataTable();
                SqlDataAdapter DAdapter = new SqlDataAdapter();
                SqlCommandBuilder DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                cmd.Parameters.AddWithValue("lid", this.idUser);

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                BindingSource DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;

                bindingNavigator1.BindingSource = DBindingSource;

                this.dataGridView1.DataSource = DBindingSource;
                
            }

            Globals.glCloseSqlConn();
        }

        private void Load_AvailableRoles()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetAvailableRoles";
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable DTable = new DataTable();
                SqlDataAdapter DAdapter = new SqlDataAdapter();
                SqlCommandBuilder DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                cmd.Parameters.AddWithValue("@riduser", this.idUser);

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                BindingSource DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;

                bindingNavigator2.BindingSource = DBindingSource;

                this.dataGridView2.DataSource = DBindingSource;

            }
            Globals.glCloseSqlConn();
        }

        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.CurrentRow;

            if (Globals.glOpenSqlConn())
            {

                SqlCommand cmd = new SqlCommand("spAssignUserRole", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uidrole", Convert.ToInt64(row.Cells[1].Value));
                cmd.Parameters.AddWithValue("@uiduser", Convert.ToInt64(this.idUser));
                cmd.ExecuteNonQuery();
          
                Globals.glCloseSqlConn();

                this.Load_AssignedUserRoles();
                this.Load_AvailableRoles();
            }
            Globals.glCloseSqlConn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.CurrentRow;

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spUnAssignUserRole", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@uiduser", Convert.ToInt64(this.idUser));
                cmd.Parameters.AddWithValue("@uidrole", Convert.ToInt64(row.Cells[1].Value));
                                cmd.ExecuteNonQuery();

                Globals.glCloseSqlConn();

                this.Load_AssignedUserRoles();
                this.Load_AvailableRoles();
            }
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Remove all user roles?", "Please confirm.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes

                && Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spUnassignAllUserRoles", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@uiduser", Convert.ToInt64(this.idUser));
                cmd.ExecuteNonQuery();

                Globals.glCloseSqlConn();

                this.Load_AssignedUserRoles();
                this.Load_AvailableRoles();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Assign all roles to user?", "Please confirm.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes

                && Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spAssignAllUserRoles", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@uiduser", Convert.ToInt64(this.idUser));
                cmd.ExecuteNonQuery();

                Globals.glCloseSqlConn();

                this.Load_AssignedUserRoles();
                this.Load_AvailableRoles();

            }
        }

        private frmChangePassword ChangePasswordfrm;
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(this.idUser, 
                 this.txtLoginName.Text);

            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;

            ChangePasswordfrm.ShowDialog();
        }

        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm.Dispose();
            ChangePasswordfrm = null;
        }

        private frmUserEmail UserEmailfrm;
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            UserEmailfrm = new frmUserEmail(this.txtLoginName.Text,this.txtEmail.Text);

            UserEmailfrm.MdiParent = this.MdiParent;

            UserEmailfrm.FormClosed += UserEmailfrm_FormClosed;

            UserEmailfrm.Show();
        }

        private void UserEmailfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserEmailfrm = null;
        }
    }
}
