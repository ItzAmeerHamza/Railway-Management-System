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
    public partial class AdminPanel_view : Form
    {
        sql_connection sqlConnection = new sql_connection();
        public AdminPanel_view(int Id)
        {
            InitializeComponent();

            sqlConnection.connection();
            String Query = "SELECT [First_Name] FROM [RailwaysDB].[dbo].[WORKER] WHERE Id = " + Id+ ";";
            SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
            command.ExecuteNonQuery();
            userName_lbl.Text = ((string)command.ExecuteScalar());

            Query = "SELECT [Email] FROM [RailwaysDB].[dbo].[AUTHENTICATION] WHERE Worker_Id = " + Id + ";";
            command = new SqlCommand(Query, sqlConnection.Connection);
            command.ExecuteNonQuery();
            userEmail_lbl.Text = ((string)command.ExecuteScalar());
        }

        private Form activeform = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void personalInfo_lbl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new all_employee());
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new all_employee());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new pending_emp());
        }

        private void ActiveEmp_lbl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new active_emp());
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new active_emp());
        }

        private void Trains_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new all_pessenger());
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new all_pessenger());
        }
    }
}
