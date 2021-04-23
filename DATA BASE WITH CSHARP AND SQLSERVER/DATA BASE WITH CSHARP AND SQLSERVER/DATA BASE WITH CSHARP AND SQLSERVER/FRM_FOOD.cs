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
    
    public partial class FRM_FOOD : Form
    {

        FL_CLASSES.DB_CONNECT dbs = new FL_CLASSES.DB_CONNECT();
        string btn;
        int i = 0 ;
        DataSet ds = new DataSet();
        public FRM_FOOD()
        {
            InitializeComponent();
        }

        // جلب اخر رقم لعدد منتج
        int Max_Number()
        {
            dbs.disconnect();
            string SqlQuery = "SELECT ISNULL (MAX(no_items)+1,1) FROM items ";
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
                MessageBox.Show("قم بادخال اسم الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال سعر الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

                string SqlQuery = "";
                 dbs.disconnect();
                    if (btn == "new")
                    SqlQuery = "INSERT INTO items (no_items,name_items,item_price) VALUES(@no_items,@name_items,@item_price)";

                     else
                    if (btn == "update")
                SqlQuery = "UPDATE items SET  name_items = @name_items, item_price=@item_price WHERE no_items ='"+txtNomber.Text+"'";
                    SqlCommand cmd = new SqlCommand(SqlQuery);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = dbs.connect();
                    cmd.Parameters.AddWithValue("@no_items", txtNomber.Text);
                    cmd.Parameters.AddWithValue("@name_items", txtName.Text);
                    cmd.Parameters.AddWithValue("@item_price", txtPrice.Text);
                    cmd.ExecuteNonQuery();
                    dbs.con.Close();
                    MessageBox.Show("تم الحفظ صنف بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

        }

        void Delete ()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال اسم الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال سعر الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            string SqlQuery = "DELETE FROM  items WHERE no_items  = '"+txtNomber.Text+"' ";
            SqlCommand cmd = new SqlCommand(SqlQuery);
            dbs.disconnect();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbs.connect();
            cmd.ExecuteNonQuery();
            dbs.con.Close();
            MessageBox.Show("تم الحذف صنف بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ITEMS frm = new FRM_ITEMS();

            FL_CLASSES.DATA_COLLECTION.SQL = "SELECT no_items as 'رقم صنف' , name_items as 'اسم صنف' , item_price as 'سعر صنف' FROM items";
            FL_CLASSES.DATA_COLLECTION.SQL_WHERE = "select no_items as 'رقم صنف' , name_items as 'اسم صنف' , item_price as 'سعر صنف' FROM items WHERE name_items+CONVERT(VARCHAR, no_items) + CONVERT(VARCHAR, item_price) LIKE ";
            frm.ShowDialog();
            txtNomber.Text = frm.dgvItems.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = frm.dgvItems.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = frm.dgvItems.CurrentRow.Cells[2].Value.ToString();

            btn = "update";
        }
        //private void button3_Click_1(object sender, EventArgs e)
        //{



        //    string SQL = "", value = "";

        //    FRM_ITEMS frm = new FRM_ITEMS();
        //    if (frm.ShowDialog(this) == DialogResult.Yes)
        //        value = frm.txtSearch.Text;

        //    SQL = "select * FROM items WHERE name_items= " + value + " ";
        //    dbs.disconnect();
        //    SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
        //    SqlDataReader rd = cmd.ExecuteReader();

        //    while (rd.Read() == true)
        //    {
        //        txtNomber.Text = rd[0].ToString();
        //        txtName.Text = rd[1].ToString();
        //        txtPrice.Text = rd[2].ToString();
        //    }
        //}


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_FOOD_Load(object sender, EventArgs e)
        {
            btn = "new";
            string SQL = "SELECT * FROM items";
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(ds, "Table");
            txtNomber.Text = ds.Tables["Table"].Rows[i][0].ToString();
            txtName.Text = ds.Tables["Table"].Rows[i][1].ToString();
            txtPrice.Text = ds.Tables["Table"].Rows[i][2].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void First_Click(object sender, EventArgs e)
        {
            i = 0;
            txtNomber.Text = ds.Tables["Table"].Rows[i][0].ToString();
            txtName.Text = ds.Tables["Table"].Rows[i][1].ToString();
            txtPrice.Text = ds.Tables["Table"].Rows[i][2].ToString();
        }

        private void Last_Click(object sender, EventArgs e)
        {
            i = ds.Tables["Table"].Rows.Count - 1;
            txtNomber.Text = ds.Tables["Table"].Rows[i][0].ToString();
            txtName.Text = ds.Tables["Table"].Rows[i][1].ToString();
            txtPrice.Text = ds.Tables["Table"].Rows[i][2].ToString();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (i < ds.Tables["Table"].Rows.Count - 1)
            {
                i++;
                txtNomber.Text = ds.Tables["Table"].Rows[i][0].ToString();
                txtName.Text = ds.Tables["Table"].Rows[i][1].ToString();
                txtPrice.Text = ds.Tables["Table"].Rows[i][2].ToString();
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (i !=0 )
            {
                i--;
                txtNomber.Text = ds.Tables["Table"].Rows[i][0].ToString();
                txtName.Text = ds.Tables["Table"].Rows[i][1].ToString();
                txtPrice.Text = ds.Tables["Table"].Rows[i][2].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max = Max_Number();
            txtNomber.Text = max.ToString();
            txtName.Clear();
            txtPrice.Clear();
        }
    }

}
