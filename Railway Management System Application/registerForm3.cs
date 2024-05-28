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
    public partial class registerForm3 : Form
    {
        sql_connection sqlConnection = new sql_connection();
        public registerForm3()
        {
            InitializeComponent();
        }

        private void close3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            /*sqlConnection.connection();
            String Query = "EXEC sp_insertIntoPassenger '" + fname.Text + "','" + lname_txt.Text + "','" + contact_txt.Text + "','" + this.dob_date.Text + "','" + gender_combox.Text + "','" + email_txt.Text + "','" + pass_txt.Text + "'";
            if (fname_txt.Text != "" && lname_txt.Text != "" && contact_txt.Text != "" && email_txt.Text != "")
            {
                if (pass_txt.Text == cPass_txt.Text) // check for confirm password
                {
                    SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
                    command.ExecuteNonQuery();
                    sqlConnection.Connection.Close();
                    this.Hide();
                    var login = new login_view();
                    login.Closed += (s, args) => this.Close();
                    login.Show();
                }
            }*/
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            sqlConnection.connection();
            String Query = "SELECT TOP (1) [Id] FROM[RailwaysDB].[dbo].[WORKER] ORDER BY Id DESC";
            SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
            command.ExecuteNonQuery();
            int ID = ((int)command.ExecuteScalar());

            Query = "EXEC sp_insertIntoAuth '" + uname_txt.Text + "','" + email_txt.Text + "','" + pass_txt.Text + "','" + ID + "'";
            if (uname_txt.Text != "" && email_txt.Text != "" && pass_txt.Text != "")
            {
                if(pass_txt.Text == cPass_txt.Text)
                {
                    command = new SqlCommand(Query, sqlConnection.Connection);
                    command.ExecuteNonQuery();
                    sqlConnection.Connection.Close();
                }
            }
            this.Hide();
        }
    }
}
