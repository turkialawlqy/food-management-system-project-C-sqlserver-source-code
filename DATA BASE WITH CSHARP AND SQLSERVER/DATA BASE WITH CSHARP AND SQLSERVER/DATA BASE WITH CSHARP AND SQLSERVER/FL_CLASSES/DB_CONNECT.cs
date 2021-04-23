using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA_BASE_WITH_CSHARP_AND_SQLSERVER.FL_CLASSES
{
    class DB_CONNECT
    {
        public SqlConnection con;

        public DB_CONNECT()
        {
            con = new SqlConnection("Server=.; Database=food; Integrated Security=True");
        }

        public SqlConnection connect()
        {
            con.Open();
            return con;
        }

        public void disconnect()
        {
            if (con.State == ConnectionState.Open == true)
                con.Close();
        }
    }
}
