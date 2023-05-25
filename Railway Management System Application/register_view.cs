using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Management_System_Application
{
    public partial class register_view : Form
    {
        bool moveNext = false;
        bool isEmp = false;

        public register_view(bool EmpStatus)
        {
            InitializeComponent();
            isEmp = EmpStatus;
        }

        void isEmployee()
        {
            if (isEmp) // register as employee
            {
                depPanel.Visible = true;
            }
            else
            {
                depPanel.Visible = false;
            }
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
            OpenChildForm(new add_btn());
        }

        private void Address_lbl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm2());
        }

   

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new add_btn());
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm2());
        }

        private void dep_icon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm4());
        }

        private void register_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm2());
            moveNext = true;
        }

        private void dep_lbl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm4());
        }

        private void dep_icon_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm4());
        }

        private void auth_lbl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm3());
        }

        private void auth_icon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new registerForm3());
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new login_view();
            login.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new login_view();
            login.Show();
        }
    }
}
