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
    public partial class login_view : Form
    {
        sql_connection sqlConnection = new sql_connection();
        public login_view()
        {
            InitializeComponent();
        }
        bool isEmp = false;
        bool isPessenger = false;
        private void reset_pos()
        {
            email_lbl.Location = new Point(email_lbl.Location.X, 145);
            password_lbl.Location = new Point(password_lbl.Location.X, 258);
            name_lbl.Location = new Point(name_lbl.Location.X, 40);
        }
        private void LabelEffect_Click(object sender, EventArgs e)
        {
            reset_pos();
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            if(name_lbl.Location.Y == 40)
            {
                email_lbl.Location = new Point(email_lbl.Location.X, 145);
                password_lbl.Location = new Point(password_lbl.Location.X, 258);
                name_lbl.Location = new Point(name_lbl.Location.X, name_lbl.Location.Y - 25);
            }
            name_panel.BackColor = Color.Black;
            name_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {
            if (email_lbl.Location.Y == 145)
            {
                name_lbl.Location = new Point(name_lbl.Location.X, 40);
                password_lbl.Location = new Point(password_lbl.Location.X, 258);
                email_lbl.Location = new Point(email_lbl.Location.X, email_lbl.Location.Y - 25);
            }
            email_panel.BackColor = Color.Black;
            email_lbl.ForeColor = ColorTranslator.FromHtml("#000000");

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if (password_lbl.Location.Y == 258)
            {
                email_lbl.Location = new Point(email_lbl.Location.X, 145);
                name_lbl.Location = new Point(name_lbl.Location.X, 40);
                password_lbl.Location = new Point(password_lbl.Location.X, password_lbl.Location.Y - 25);
            }
            password_panel.BackColor = Color.Black;
            password_txt.PasswordChar = '*';
            password_lbl.ForeColor = ColorTranslator.FromHtml("#000000");

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            reset_pos(); // reset the position of the labels
            sqlConnection.connection();
            String Query = "SELECT Worker_Id FROM[RailwaysDB].[dbo].[AUTHENTICATION] WHERE[User Name] LIKE '" + name_txt.Text+"' AND[Email] LIKE '" +email_txt.Text+ "' AND[Password] LIKE '"+password_txt.Text+"'";
            SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
            command.ExecuteNonQuery();
            int ID = ((int)command.ExecuteScalar());
            Query = "SELECT role FROM[RailwaysDB].[dbo].[WORKER] WHERE Id = "+ ID;
            command = new SqlCommand(Query, sqlConnection.Connection);
            command.ExecuteNonQuery();
            string Role = ((string)command.ExecuteScalar());
            Form pannel;
            if (Role == "Employee") // logged in user is an employee
            {
                pannel = new EmployeePannel_view();
                this.Hide();
                pannel.Show();

            }
            else if(Role == "Admin") // logged in user is the admin
            {
                pannel = new AdminPanel_view(ID);
                this.Hide();
                pannel.Show();
            }

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(isEmp == false && isPessenger == false)
            {
                MessageBox.Show("Please select one of the options");
            }
            else if(isEmp)
            {
                this.Hide();
                Form registrationForm = new register_view(isEmp);
                registrationForm.Show();
            }
            else if(isPessenger)
            {
                this.Hide();
                isEmp = false;
                Form registrationForm = new register(isEmp);
                registrationForm.Show();
            }
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isEmp = true;
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isPessenger = true;
        }
    }
}
