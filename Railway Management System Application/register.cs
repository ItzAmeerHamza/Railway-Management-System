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

namespace Railway_Management_System_Application
{
    public partial class register : Form
    {
        sql_connection sqlConnection = new sql_connection();
        bool IsEmp;
        public register(bool EmpStatus)
        {
            InitializeComponent();
            IsEmp = EmpStatus;
            isEmployee();
        }

        void isEmployee()
        {
            
        }
        private void fname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void fname_txt_TextChanged(object sender, EventArgs e)
        {
            fname_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            fname_panel.BackColor = Color.Black;
        }

        private void lname_txt_TextChanged(object sender, EventArgs e)
        {
            lname_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            lname_panel.BackColor = Color.Black;
        }

        private void contact_txt_TextChanged(object sender, EventArgs e)
        {
            contact_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            contact_panel.BackColor = Color.Black;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            gender_pannel.BackColor = Color.Black;
        }

        private void dob_date_ValueChanged(object sender, EventArgs e)
        {
            dob_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
        }


        private void dateOfHiring_ValueChanged(object sender, EventArgs e)
        {
        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {
            pass_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            pass_pannel.BackColor = Color.Black;
        }

        private void cpass_txt_TextChanged(object sender, EventArgs e)
        {
            cpass_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            cPass_pannel.BackColor = Color.Black;
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {
            email_lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            email_panel.BackColor = Color.Black;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            sqlConnection.connection();
            String Query = "EXEC sp_insertIntoPassenger '" + fname_txt.Text + "','" + lname_txt.Text + "','" + contact_txt.Text + "','" + this.dob_date.Text + "','" + gender_combox.Text + "','" + email_txt.Text + "','" + pass_txt.Text + "'";
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
            }
        }
    }
}
