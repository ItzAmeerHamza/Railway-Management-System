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
    public partial class add_btn : Form
    {
        sql_connection sqlConnection = new sql_connection();

        public add_btn()
        {
            InitializeComponent();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            sqlConnection.connection();
            String Query = "EXEC sp_insertIntoWorker '" + fname_txt.Text + "','" + lname_txt.Text + "','" + contact_txt.Text + "','" + this.dob_date.Text + "','" + gender_combox.Text + "','" + doh_date.Text+"'";
            if (fname_txt.Text != "" && lname_txt.Text != "" && contact_txt.Text != "")
            {
                     SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
                    command.ExecuteNonQuery();
                    sqlConnection.Connection.Close();
                    this.Hide();
            }
        }
    }
}
