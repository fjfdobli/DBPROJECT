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

namespace DBPROJECT
{
    public partial class frmEditCustomer : Form
    {
        long idCustomer = 0;
        public frmEditCustomer(long cidCustomer)
        {
            InitializeComponent();
            this.idCustomer = cidCustomer;

            this.btnSave.Enabled = false;
        }
        public long customerid
        {
            get { return this.idCustomer; }
            set { this.idCustomer = value; }
        }
        private void txtCustomerEmail_KeyDown(object sender, KeyEventArgs e)
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

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            this.RefreshData();
            this.btnSave.Enabled = false;
            this.txtCustomerEmail.Focus();
        }
        private void RefreshData()
        {
            String cname = "", cemail = "", cadd = "", ccon = "";

            // load photo here
            this.GetCustomerPhotofromField();

            this.GetProfile(this.idCustomer, ref cname, ref cemail, ref cadd, ref ccon);

            this.txtCustomerName.Text = cname;
            this.txtCustomerEmail.Text = cemail;
            this.txtCustomerAddress.Text = cadd;
            this.txtCustomerContactNo.Text = ccon;

            this.btnSave.Enabled = false;
        }
        private void GetProfile(long cidcustomer,
            ref String ccustomername, ref String ccustomeremail, ref String ccustomeraddress,
            ref String ccustomercontact)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spGetCustomerProfile",
                    Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cidCustomer", cidcustomer);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ccustomername = reader["nameCustomer"].ToString();
                    ccustomeremail = reader["emailCustomer"].ToString();
                    ccustomeraddress = reader["addressCustomer"].ToString();
                    ccustomercontact = reader["contactCustomer"].ToString();

                }
                else csMessageBox.Show("No such User ID:" + this.idCustomer.ToString() + " is found!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Globals.glCloseSqlConn();
        }
        void GetCustomerPhotofromField()
        {
            if (Globals.glOpenSqlConn())
            {
                String qrystr = "Select isnull(photoCustomer,'') as photo from dbo.customers where idCustomer=" + this.idCustomer.ToString();
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
                        this.pictBoxCustomer.Image = Image.FromStream(imgstream);
                }
                UserAdapter.Dispose();
            }
            Globals.glCloseSqlConn();
        }
        private void UpdateCustomer()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spUpdateCustomer", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cidCustomer", this.idCustomer);
                cmd.Parameters.AddWithValue("@cname", this.txtCustomerName.Text);

                cmd.Parameters.AddWithValue("@cemail", this.txtCustomerEmail.Text);
                cmd.Parameters.AddWithValue("@cadd", this.txtCustomerAddress.Text);
                cmd.Parameters.AddWithValue("@ccon", this.txtCustomerContactNo.Text);
                cmd.ExecuteNonQuery();
            }
            Globals.glCloseSqlConn();
        }

        private void frmEditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.btnSave.Enabled)
            {
                DialogResult dr;

                dr = csMessageBox.Show("Changes not saved! Save changes", "Please confirm.",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (dr)
                {
                    case DialogResult.Yes:
                        if (this.txtCustomerName.Text.Trim() == "")
                        {
                            csMessageBox.Show("Please provide a valid login name.", "Empty Login Name",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            e.Cancel = true;
                            this.txtCustomerEmail.Focus();
                        }
                        else
                        {
                            this.UpdateCustomer();

                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        private void SavePhototoField()
        {
            MemoryStream ms = new MemoryStream();
            this.pictBoxCustomer.Image.Save(ms, pictBoxCustomer.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (Globals.glOpenSqlConn())
            {
                String qrystr = "update customers set photoCustomer=@img where idCustomer =" +
                    this.idCustomer.ToString();

                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                cmd.Parameters.Add("@img", SqlDbType.Image); //MySqlDbType.Blob
                cmd.Parameters["@img"].Value = img;

                if (cmd.ExecuteNonQuery() == 1)
                    csMessageBox.Show("New photo is saved...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Globals.glCloseSqlConn();

        }
        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhoto = new OpenFileDialog();
            openPhoto.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openPhoto.ShowDialog() == DialogResult.OK)
            {
                pictBoxCustomer.Image = Image.FromFile(openPhoto.FileName);
                this.SavePhototoField();
            }
        }

        private void ClearPhototoField()
        {
            if (Globals.glOpenSqlConn())
            {
                String qrystr = "update customers set photoCustomer=null where idCustomer =" +
                    this.idCustomer.ToString();

                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    this.pictBoxCustomer.Image = null;

                    csMessageBox.Show("User photo is cleared...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Globals.glCloseSqlConn();
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Customer photo cleared", "Information",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.ClearPhototoField();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtCustomerName.Text.Trim() == "")
            {
                csMessageBox.Show("Please provide a valid login name.", "Empty Login Name",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.UpdateCustomer();
                this.btnSave.Enabled = false;
                //Globals.gLoginName = this.txtLoginName.Text;
            }
        }

        private frmCustomerEmail CustomerEmailfrm;
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            CustomerEmailfrm = new frmCustomerEmail(this.txtCustomerName.Text, this.txtCustomerEmail.Text);
            CustomerEmailfrm.MdiParent = this.MdiParent;
            CustomerEmailfrm.FormClosed += CustomerEmailfrm_FormClosed;
            CustomerEmailfrm.Show();
        }
        private void CustomerEmailfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerEmailfrm = null;
        }
    }
}
