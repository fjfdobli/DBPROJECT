using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBPROJECT
{
    public partial class frmUser : Form
    {
        DataTable DTable;

        public SqlCommand DCommand { get; private set; }

        SqlDataAdapter DAdapter;
        SqlCommand dCommand;
        BindingSource DBindingSource;

        Boolean CancelUpates;
        
        int idcolumn = 0;
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            this.BindMainGrid();
            this.FormatGrid();
        }
        private void BindMainGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                this.DCommand = new SqlCommand("spGetAllUsers", Globals.sqlconn);
                this.DAdapter = new SqlDataAdapter(this.DCommand);

                this.DTable = new DataTable();

                this.DAdapter.Fill(DTable);
                this.DBindingSource = new BindingSource();
                this.DBindingSource.DataSource = DTable;

                dgvMain.DataSource = DBindingSource;
                this.bNavMain.BindingSource = this.DBindingSource;
            }
        }

        private void FormatGrid()
        {
            this.dgvMain.Columns["id"].Visible = true;

            this.dgvMain.Columns["loginname"].HeaderText = "Login Name";
            this.dgvMain.Columns["active"].HeaderText = "Active";
            this.dgvMain.Columns["mustchangepwd"].HeaderText = "Change Password";
            this.dgvMain.Columns["email"].HeaderText = "E-Mail";
            this.dgvMain.Columns["smtphost"].HeaderText = "SMTP-HOST";
            this.dgvMain.Columns["smtpport"].HeaderText = "SMTP-PORT";
            this.dgvMain.Columns["gender"].HeaderText = "Gender";
            this.dgvMain.Columns["birthdate"].HeaderText = "Birthday";

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    String.Format("{0,10}", (e.RowIndex + 1).ToString()),
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

        private void dgvMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int iduser;
            DataGridViewRow row = this.dgvMain.CurrentRow;
            String name = row.Cells["loginname"].Value.ToString().Trim();

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
            } e.Cancel = true;
        }

        private void dgvMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            long userid = 0;
            if (this.CancelUpates == false && this.dgvMain.CurrentRow != null)
            {
                if (Globals.glOpenSqlConn())
                {
                    DataGridViewRow row = dgvMain.CurrentRow;

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

                    // DateTime dt1 = row.Cells["birthdate"].Value == DBNull.Value ? ""
                    // : row.Cells["birthdate"].Value;
                    // String ubirthdate = row.Cells["birthdate"].Value == DBNull.Value ? ""
                    //  : row.Cells["birthdate"].Value.ToString();

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

                            if (row.Cells[this.idcolumn].Value == DBNull.Value)
                                userid = 0;
                            else
                                userid = Convert.ToInt64(row.Cells[this.idcolumn].Value);
                            cmd.Parameters.AddWithValue("@uid", userid);
                            cmd.Parameters.AddWithValue("@uloginname", uloginname);
                            cmd.Parameters.AddWithValue("@uactive", uactive);
                            cmd.Parameters.AddWithValue("@umustchangepwd", umustchangepwd);
                            cmd.Parameters.AddWithValue("@uemail", uemail);
                            cmd.Parameters.AddWithValue("@usmtphost", usmtphost);
                            cmd.Parameters.AddWithValue("@usmtpport", usmtpport);
                            cmd.Parameters.AddWithValue("@ugender", ugender);
                            //  cmd.Parameters.AddWithValue("@ubirthdate", ubirthdate);

                            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            dAdapt.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            csMessageBox.Show("Exception Error:" + ex.Message,
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    Globals.glCloseSqlConn();
                }
                Globals.glCloseSqlConn();
            }
        }
    }
}