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
            Connection = new SqlConnection(@"Data Source=DESKTOP-3LA7J74\SQLEXPRESS;Initial Catalog=RailwaysDB;Integrated Security=True");
            Connection.Open();
        }
    }
}
