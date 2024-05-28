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
    public partial class registerForm4 : Form
    {
        sql_connection sqlConnection = new sql_connection();
        public registerForm4()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            sqlConnection.connection();
            String Query = "SELECT TOP (1) [Id] FROM[RailwaysDB].[dbo].[WORKER] ORDER BY Id DESC";
            SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
            command.ExecuteNonQuery();
            int ID = ((int)command.ExecuteScalar());

            Query = "EXEC sp_insertIntoDependent '" + name_txt.Text + "','" +this.dob_date.Text+ "','" + ID + "'";
            if (name_txt.Text != "" && dob_date.Text != "")
            {
                command = new SqlCommand(Query, sqlConnection.Connection);
                command.ExecuteNonQuery();
                sqlConnection.Connection.Close();
            }
            this.Hide();
        }
    }
}
