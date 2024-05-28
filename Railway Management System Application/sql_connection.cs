using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Railway_Management_System_Application
{
    class sql_connection
    {
        public SqlConnection Connection;
        public void connection()
        {
            // This is the connection string, used to connect with any DBMS.
            // It requires "Data Source Name" and "Catalog Name". Change the name according
            Connection = new SqlConnection(@"Data Source=data_source_name;Initial Catalog=DB_name;Integrated Security=True");
            Connection.Open();
        }
    }
}
