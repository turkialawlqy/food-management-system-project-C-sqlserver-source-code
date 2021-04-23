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
    public partial class FRM_COSTUMERS : Form
    {
        FL_CLASSES.DB_CONNECT dbs = new FL_CLASSES.DB_CONNECT();
        string btn = "";
        public FRM_COSTUMERS()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            
        }

        // جلب اخر رقم لعدد زبائن
        int Max_Number()
        {
            dbs.disconnect();
            string SqlQuery = "SELECT ISNULL (MAX(c_no)+1,1) FROM customers ";
            SqlCommand cmd = new SqlCommand(SqlQuery);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbs.connect();
            cmd.ExecuteNonQuery();
            var max = cmd.ExecuteScalar();
            return int.Parse(max.ToString());
        }

        void Save()
        {

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال اسم زبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال رقم هاتف زبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            string SqlQuery = "";
            dbs.disconnect();
            if (btn == "new")
                SqlQuery = "INSERT INTO customers (c_no,c_name,c_phone) VALUES(@c_no,@c_name,@c_phone)";

            else
            if (btn == "update")

                SqlQuery = "UPDATE customers SET  c_name = @c_name, c_phone = @c_phone WHERE c_no = '" + txtNomber.Text + "'  ";
            SqlCommand cmd = new SqlCommand(SqlQuery);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbs.connect();
            cmd.Parameters.AddWithValue("@c_no", txtNomber.Text);
            cmd.Parameters.AddWithValue("@c_name", txtName.Text);
            cmd.Parameters.AddWithValue("@c_phone", txtPhone.Text);
            cmd.ExecuteNonQuery();
            dbs.con.Close();
            MessageBox.Show("تم الحفظ صنف بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void FRM_COSTUMERS_Load(object sender, EventArgs e)
        {
            btn = "new";
            int max = Max_Number();
            txtNomber.Text = max.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FL_CLASSES.DATA_COLLECTION.SQL = "SELECT c_no AS 'رقم الزبون' ,c_name AS 'اسم الزبون', c_phone AS 'هاتف الزبون' FROM customers";
            FL_CLASSES.DATA_COLLECTION.SQL_WHERE = "SELECT c_no AS 'رقم الزبون' ,c_name AS 'اسم الزبون', c_phone AS 'هاتف الزبون' FROM customers WHERE c_name + CONVERT(VARCHAR, c_no) + CONVERT(VARCHAR, c_phone) LIKE ";
            FRM_ITEMS frm = new FRM_ITEMS();
            frm.ShowDialog();
            txtNomber.Text = frm.dgvItems.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = frm.dgvItems.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = frm.dgvItems.CurrentRow.Cells[2].Value.ToString();
            btn = "update";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void Delete()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال اسم الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال رقم الهاتف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            string SqlQuery = "DELETE FROM  customers WHERE c_no  = '" + txtNomber.Text + "' ";
            SqlCommand cmd = new SqlCommand(SqlQuery);
            dbs.disconnect();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbs.connect();
            cmd.ExecuteNonQuery();
            dbs.con.Close();
            MessageBox.Show("تم الحذف صنف بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

    }
}
