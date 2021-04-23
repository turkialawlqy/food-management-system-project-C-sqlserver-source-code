using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DATA_BASE_WITH_CSHARP_AND_SQLSERVER
{
    public partial class FRM_ITEMS : Form
    {

        FL_CLASSES.DB_CONNECT dbs = new FL_CLASSES.DB_CONNECT();
        public FRM_ITEMS()
        {
            InitializeComponent();
        }

        void LoadData_dgvItems()
        {
            string SQL = FL_CLASSES.DATA_COLLECTION.SQL;
            DataTable dt = new DataTable();
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
           dgvItems.DataSource = dt;
            dbs.con.Close();
        }

        void Search()
        {
            string SqlQuery = FL_CLASSES.DATA_COLLECTION.SQL_WHERE + " '%"+txtSearch.Text+"%'  ";
            DataTable dt = new DataTable();
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SqlQuery, dbs.connect());
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvItems.DataSource = dt;
            //if(dgvItems.Rows.Count == 0)
            //{
            //    MessageBox.Show(" لا يودج كلمة متطابقة ردجاء ادخل كلمة اخری لبحث","تنبه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    txtSearch.Focus();
            //    txtSearch.SelectionStart = 0;
            //    txtSearch.SelectionLength = txtSearch.TextLength;
            //}
            dbs.con.Close();
        }

        private void FRM_ITEMS_Load(object sender, EventArgs e)
        {
            LoadData_dgvItems();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
