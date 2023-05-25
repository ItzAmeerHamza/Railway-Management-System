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
    public partial class pending_emp : Form
    {
        sql_connection sqlConnection = new sql_connection();
        public pending_emp()
        {
            InitializeComponent();

            InitializeComponent();
            sqlConnection.connection();
            String Query = "SELECT * FROM [All Pending Employees]";
            SqlCommand command = new SqlCommand(Query, sqlConnection.Connection);
            var dataAdapter = new SqlDataAdapter(Query, sqlConnection.Connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            AllEmp_grd.ReadOnly = true;
            AllEmp_grd.DataSource = ds.Tables[0];
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllEmp_grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AllEmp_grd.CurrentRow.Selected = true;
            int id = int.Parse(AllEmp_grd.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

        }

        private void AllEmp_lbl_Click(object sender, EventArgs e)
        {

        }

        private void status_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Status_lbl_Click(object sender, EventArgs e)
        {

        }

        private void AllEmp_grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AllEmp_grd.CurrentRow.Selected = true;
            int id = int.Parse(AllEmp_grd.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

        }
    }
}
