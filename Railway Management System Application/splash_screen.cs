using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Railway_Management_System_Application
{
    public partial class splash_screen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int bottom,
            int width,
            int height
            );

        
        public splash_screen()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            InitializeComponent();
            // the rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 17, 17));



            // loading
            string str = string.Empty;
            for(int i = 0; i < 10000; i++)
            {
                str += i.ToString();
            }
            t.Abort(); // aborting the thread
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x000020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Railway Management System";
            Application.Run(frm);
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            railway_lbl.Parent = splash_pic;
            management_lbl.Parent = splash_pic;
            railway_lbl.BackColor = Color.Transparent;
            management_lbl.BackColor = Color.Transparent;
        }
        int count = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            circleProgressBar.Increment(3);
            
            if( circleProgressBar.Value == 300 )
            {
                timer.Stop();
                circleProgressBar.Value = 1;
                Form login = new login_view();
                this.Hide();
                login.Show();
            }
            //circleProgressBar.Animated = 
            /*count += 10;
            if(count == 100)
            {
                Form login = new login_view();
                this.Hide();
                login.Show();
            }*/
        }

    }
}
