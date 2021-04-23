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
    public partial class FRM_LOGIN : Form
    {
        FL_CLASSES.DB_CONNECT dbs = new FL_CLASSES.DB_CONNECT();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            string SQL = "SELECT user_name FROM users";
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboUser.Items.Add(dr["user_name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboUser.Text == string.Empty)
            {
                MessageBox.Show("رجاء قم باختيار اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string SQL = "SELECT user_pass FROM users WHERE user_name='"+cboUser.Text+"'  ";
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            var pass = cmd.ExecuteScalar();

            if( txtPass.Text != pass.ToString())
            {
                MessageBox.Show("عذرا كلمة المرور التي ادخلته خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }
        }
    }
}
