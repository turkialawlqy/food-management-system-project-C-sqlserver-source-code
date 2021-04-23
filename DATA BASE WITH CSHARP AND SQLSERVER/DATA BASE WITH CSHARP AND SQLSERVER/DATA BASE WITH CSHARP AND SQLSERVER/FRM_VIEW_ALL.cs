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
    public partial class FRM_VIEW_ALL : Form
    {
        FL_CLASSES.DB_CONNECT dbs = new FL_CLASSES.DB_CONNECT();
        public FRM_VIEW_ALL()
        {
            InitializeComponent();
        }

        private void FRM_VIEW_ALL_Load(object sender, EventArgs e)
        {
            string SQL = "SELECT head_order.No_Order as 'رقم الطلبية', customers.c_name as 'اسم الزبون', head_order.Data_Order as 'تاريخ الطلبية', items.name_items as ' اسم صنف', detaile_order.Qtty as 'الكمية', detaile_order.Price as 'السعر', detaile_order.Total as 'مجموع' FROM items INNER JOIN detaile_order ON items.no_items = detaile_order.no_items CROSS JOIN customers INNER JOIN head_order ON customers.c_no = head_order.c_no";

            dbs.disconnect();
            SqlCommand cmd = new SqlCommand(SQL, dbs.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }
    }
}
