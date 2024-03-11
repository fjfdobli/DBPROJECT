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
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;
        
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
            this.dgvMain.Columns["id"].Visible = false;

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
    }
}