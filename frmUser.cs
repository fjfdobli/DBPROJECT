using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public partial class frmUser : Form
    {
        DataTable DTable;

        SqlDataAdapter DAdapter;
        SqlCommand Dcommand;
        BindingSource DBindingSource;

        Boolean CancelUpdates;
        int idcolumn = 0;
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            this.CancelUpdates = true;
            this.BindMainGrid();
            this.FormatGrid();
            this.CancelUpdates = false;
        }

        private void BindMainGrid()
        {
            this.CancelUpdates = true;
            if (Globals.glOpenSqlConn())
            {
                this.Dcommand = new SqlCommand("spGetAllUsers", Globals.sqlconn);
                this.DAdapter = new SqlDataAdapter(this.Dcommand);

                this.DTable = new DataTable();

                this.DAdapter.Fill(DTable);

                this.DBindingSource = new BindingSource();
                this.DBindingSource.DataSource = DTable;

                dgvMain.DataSource = this.DBindingSource;

                this.bNavMain.BindingSource = this.DBindingSource;
            }
            this.CancelUpdates = false;
        }

        private void FormatGrid()
        {
            this.dgvMain.Columns["id"].Visible = false;

            this.dgvMain.Columns["loginname"].HeaderText = "Login Name";
            this.dgvMain.Columns["active"].HeaderText = "Active";
            this.dgvMain.Columns["mustchangepwd"].HeaderText = "Must Change PWD";
            this.dgvMain.Columns["email"].HeaderText = "Email";
            this.dgvMain.Columns["smtphost"].HeaderText = "SMTP Host";
            this.dgvMain.Columns["smtpport"].HeaderText = "SMTP Port";
            this.dgvMain.Columns["gender"].HeaderText = "Gender";
            this.dgvMain.Columns["birthdate"].HeaderText = "Birthdate";
            this.dgvMain.Columns["birthdate"].Visible = false;

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }
        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(String.Format("{0,10}", (e.RowIndex + 1).ToString()),
                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void dgvMain_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvMain.FirstDisplayedCell.RowIndex;
            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvMain.DisplayedRowCount(true);

            Graphics Graphics = dgvMain.CreateGraphics();

            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvMain.Font).Width);
            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvMain.Font).Width);
            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);
            dgvMain.RowHeadersWidth = rowHeaderWitdh + 40;
        }

        private void dgvMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int iduser;

            DataGridViewRow row = this.dgvMain.CurrentRow;
            String name = row.Cells["loginname"].Value.ToString().Trim();
                bool cancel = true;

            DataGridViewRow rw = this.dgvMain.CurrentRow;
            String n = rw.Cells["loginname"].Value.ToString().Trim();

            if (row.Cells[idcolumn].Value != DBNull.Value &&
                csMessageBox.Show("Delete the user:" + name, "Please confirm.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.glOpenSqlConn())
                {
                   SqlCommand cmd = new SqlCommand("dbo.spusersDelete", Globals.sqlconn);
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.AddWithValue("@rid", Convert.ToInt64(row.Cells[idcolumn].Value));
                   cmd.ExecuteNonQuery();
                   e.Cancel = false;
                }
                Globals.glCloseSqlConn();
            }
            else e.Cancel = true;
        }

        private void dgvMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            long userid = 0;
            long newuserid;
            if (this.CancelUpdates == false && this.dgvMain.CurrentRow != null)
            {
                if (Globals.glOpenSqlConn())
                {
                    DataGridViewRow row = dgvMain.CurrentRow;

                    if (row.Cells[this.idcolumn].Value == DBNull.Value)
                        userid = 0;
                    else
                        userid = Convert.ToInt64(row.Cells[this.idcolumn].Value);

                    String uloginname = row.Cells["loginname"].Value == DBNull.Value ? ""
                        : row.Cells["loginname"].Value.ToString().ToUpper();
                    int uactive = row.Cells["active"].Value == DBNull.Value
                         ? 0 : Convert.ToInt32(row.Cells["active"].Value);
                    int umustchangepwd = row.Cells["mustchangepwd"].Value == DBNull.Value
                        ? 0 : Convert.ToInt32(row.Cells["mustchangepwd"].Value);
                    String uemail = row.Cells["email"].Value == DBNull.Value ? ""
                        : row.Cells["email"].Value.ToString();
                    String usmtphost = row.Cells["smtphost"].Value == DBNull.Value ? ""
                        : row.Cells["smtphost"].Value.ToString();
                    String usmtpport = row.Cells["smtpport"].Value == DBNull.Value ? ""
                        : row.Cells["smtpport"].Value.ToString();
                    String ugender = row.Cells["gender"].Value == DBNull.Value ? ""
                        : row.Cells["gender"].Value.ToString();

                    /*
                    DateTime dt3;
                    if (userid == 0)
                    {
                        dt3 = DateTime.Now;
                    }
                    else
                        dt3 = DateTime.Parse(row.Cells["birthdate"].Value.ToString());
                        String dt4 = Globals.glToMySqlDate(dt3);

                    */
                    if (row.Cells["loginname"].Value == DBNull.Value)
                    {
                        csMessageBox.Show("Please encode a valid user name", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvMain.CancelEdit();
                    }
                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("spusersAddEdit", Globals.sqlconn);

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@uid", userid);
                            cmd.Parameters.AddWithValue("@uloginname", uloginname);
                            cmd.Parameters.AddWithValue("@uactive", uactive);
                            cmd.Parameters.AddWithValue("@umustchangepwd", umustchangepwd);
                            cmd.Parameters.AddWithValue("@uemail", uemail);
                            cmd.Parameters.AddWithValue("@usmtphost", usmtphost);
                            cmd.Parameters.AddWithValue("@usmtpport", usmtpport);
                            cmd.Parameters.AddWithValue("@ugender", ugender);
                            //cmd.Parameters.AddWithValue("@ubirthdate", dt4);

                            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                            DataTable dt = new DataTable();

                            dAdapt.Fill(dt);
                            newuserid = long.Parse(dt.Rows[0][0].ToString());
                            // save it to the grid
                            if (userid == 0)
                                row.Cells["id"].Value = newuserid;
                        }
                        catch (Exception ex)
                        {
                            if(ex.Message != "There is no row at position 0.")
                            {
                                csMessageBox.Show("Exception Error:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    Globals.glCloseSqlConn();
                }
                Globals.glCloseSqlConn();
            }
        }
        private Boolean SearchName(String searchVal)
        {
            bool resultVal = false;
            int rowIndex = -1;

            searchVal = searchVal.Trim().ToUpper();
            if (searchVal != "")
            {
                this.bNavMain.MoveFirstItem.PerformClick();

                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    try
                    {
                        if (row.Cells["loginname"].Value.ToString().StartsWith(searchVal))
                        {
                            rowIndex = row.Index;
                            dgvMain.Rows[row.Index].Selected = true;
                            resultVal = true;
                            break;
                        }
                        this.bNavMain.MoveNextItem.PerformClick();
                    }
                    catch
                    {
                        break;
                    }
                } // foreach
                if (!resultVal)
                    csMessageBox.Show("Record not found.", "Search Result",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // if
            return resultVal;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchVal = txtSearch.Text.Trim().ToUpper();

            if (this.SearchName(searchVal))
            {
                this.txtSearch.Clear();
                this.dgvMain.Focus();

            }
            else
            {
                this.txtSearch.Focus();
            }

        }
        private frmEditUser EditUserfrm;

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            long userid;
            DataGridViewRow row = dgvMain.CurrentRow;

            if (row.Cells[this.idcolumn].Value == DBNull.Value)
                userid = 0;
            else
                userid = Convert.ToInt64(row.Cells[this.idcolumn].Value);

            if (userid != 0)
            {
                EditUserfrm = new frmEditUser(userid);
                EditUserfrm.MdiParent = this.MdiParent;
                EditUserfrm.Show();
            }
        }
    }
}
