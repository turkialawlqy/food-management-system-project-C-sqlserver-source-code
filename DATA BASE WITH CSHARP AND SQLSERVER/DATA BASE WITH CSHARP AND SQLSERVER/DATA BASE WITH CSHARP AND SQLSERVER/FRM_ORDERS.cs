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

namespace DATA_BASE_WITH_CSHARP_AND_SQLSERVER
{
    public partial class FRM_ORDERS : Form
    {
        FL_CLASSES.DB_CONNECT dbs = new FL_CLASSES.DB_CONNECT();

        static double Am = 0;
        public FRM_ORDERS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        void load_data_combobox()
        {
            string SQL = "SELECT c_no,c_name FROM customers";
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                cmbNoCutomer.Items.Add(rd["c_no"].ToString());
                cmbNameCutomer.Items.Add(rd["c_name"].ToString());
            }

        }

        int Max_Number()
        {
            dbs.disconnect();
            int x = 0;
            string SQL = "SELECT No_Order FROM head_order ";
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (x < Int32.Parse(dr[0].ToString()))
                    x = Int32.Parse(dr[0].ToString());
            }
            x++;
            return x ;
        }

        void FillDataGritView()
        {
            string SQL = "SELECT no_items,name_items FROM items";

            DataGridViewComboBoxColumn c1 = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["No_Items"];
            DataGridViewComboBoxColumn c2 = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["NameItems"];
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                c1.Items.Add(dr["no_items"].ToString());
                c2.Items.Add(dr["name_items"].ToString());
            }
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {
            load_data_combobox();
            int max = Max_Number();
            txtOrder.Text = max.ToString();
            FillDataGritView();
        }

        private void cmbNoCutomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNameCutomer.SelectedIndex = cmbNoCutomer.SelectedIndex;
        }

        private void cmbNameCutomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNoCutomer.SelectedIndex = cmbNameCutomer.SelectedIndex;
        }


        private void showItems (string s, int coll, int indx)
        {
            string SQL = "";
            if (coll == 0)
                SQL = "SELECT * FROM items WHERE no_items ='" + s + "' ";
            if (coll == 1)
                SQL = "SELECT * FROM items WHERE name_items ='" + s + "' ";

            dbs.disconnect();

            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());

            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows[indx].Cells["Qtty"].Value = "1";
            dataGridView1.Rows[indx].Cells["Total"].Value = "0";
            dataGridView1.Rows[indx].Cells["Descount"].Value = "0";
            dataGridView1.Rows[indx].Cells["Amount"].Value = "0";
            if (dr.Read())
            {
                dataGridView1.Rows[indx].Cells["No_Items"].Value = dr["no_items"].ToString();
                dataGridView1.Rows[indx].Cells["NameItems"].Value = dr["name_items"].ToString();
                dataGridView1.Rows[indx].Cells["Price"].Value = dr["item_price"].ToString();


                double x1 = double.Parse(dataGridView1.Rows[indx].Cells["Price"].Value.ToString());
                double x2 = double.Parse(dataGridView1.Rows[indx].Cells["Qtty"].Value.ToString());
                double x3 = x1 * x2;
                dataGridView1.Rows[indx].Cells["Total"].Value = x3.ToString();


            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells["No_items"].Value != null)
                {
                  string  Noitems = dataGridView1.Rows[e.RowIndex].Cells["No_items"].Value.ToString();
                    showItems(Noitems, e.ColumnIndex,e.RowIndex);
                }
            }


            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["NameItems"].Value != null)
                {
                    string Nameitems = dataGridView1.Rows[e.RowIndex].Cells["NameItems"].Value.ToString();
                    showItems(Nameitems, e.ColumnIndex, e.RowIndex);
                }
            }

            if (e.ColumnIndex == 3)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Qtty"].Value != null)
                {
                    double x1 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                    double x2 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Qtty"].Value.ToString());
                    double x3 = x1 * x2;
                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = x3.ToString();
                }
            }

            if (e.ColumnIndex == 5)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Descount"].Value != null)
                {
                    double x1 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Total"].Value.ToString());
                    double x2 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Descount"].Value.ToString());
                    double x3 = x1 - x2;
                    dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value = x3.ToString();


                }
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                double x1 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Total"].Value.ToString());
                double x2 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Descount"].Value.ToString());
                double x3 = x1 - x2;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value = x3.ToString();

                Am += double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
                txtTotal.Text = Am.ToString();
            }
        }

        private void SaveHeade()
        {
            dbs.disconnect();
            string SQL = "INSERT INTO head_order(No_Order,Data_Order,c_no,Total,name_order) VALUES(@No_Order,@Data_Order,@c_no,@Total,@name_order) ";
            SqlCommand cmd = new SqlCommand(SQL,dbs.connect());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@No_Order", txtOrder.Text);
            cmd.Parameters.AddWithValue("@Data_Order", DateOrder.Value);
            cmd.Parameters.AddWithValue("@c_no", cmbNoCutomer.Text);
            cmd.Parameters.AddWithValue("@Total",txtTotal.Text);
            cmd.Parameters.AddWithValue("@name_order", cmbNameCutomer.Text);
            cmd.ExecuteNonQuery();
        }


        private string maxNumber(string SQL)
        {
            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            cmd.ExecuteNonQuery();
            var x = cmd.ExecuteScalar();
            return x.ToString();
        }

        private void SaveDetail()
        {
            string x1 = maxNumber("SELECT MAX(No_Det_Order) FROM detaile_order");
            int x;
            if (x1 == "")
                x = 0;
            else
                x = Int32.Parse(x1);
            x++;
            int count = dataGridView1.Rows.Count;

            for(int i =0; i < count -1; i++)
            {
                dbs.disconnect();
                /////// INsert to Database
                string SQL = "INSERT INTO detaile_order(No_Det_Order,No_Order,no_items,Qtty,Price,Total,Descount,name_order) VALUES(@No_Det_Order,@No_Order,@no_items,@Qtty,@Price,@Total,@Descount,@name_order) ";
                SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@No_Det_Order",x);
                cmd.Parameters.AddWithValue("@No_Order", txtOrder.Text);
                cmd.Parameters.AddWithValue("@no_items",dataGridView1.Rows[i].Cells["No_Items"].Value);
                cmd.Parameters.AddWithValue("@Qtty", dataGridView1.Rows[i].Cells["Qtty"].Value);
                cmd.Parameters.AddWithValue("@Price", dataGridView1.Rows[i].Cells["Price"].Value);
                cmd.Parameters.AddWithValue("@Total", dataGridView1.Rows[i].Cells["Total"].Value);
                cmd.Parameters.AddWithValue("@Descount", dataGridView1.Rows[i].Cells["Descount"].Value);
                cmd.Parameters.AddWithValue("@name_order", cmbNameCutomer.Text);
                x++;
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ معلومات بالنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }


        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            SaveHeade();
            SaveDetail();
            this.Close();
        }
    }
}
