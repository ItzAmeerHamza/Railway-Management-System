using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Management_System_Application
{
    public partial class active_emp : Form
    {
        sql_connection sqlConnection = new sql_connection();
        public active_emp()
        {
            InitializeComponent();
            sqlConnection.connection();
            String Query = "SELECT * FROM [All Active Employees]";
            SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
            var dataAdapter = new SqlDataAdapter(Query, sqlConnection.Connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            active_emp_grd.ReadOnly = true;
            active_emp_grd.DataSource = ds.Tables[0];
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
