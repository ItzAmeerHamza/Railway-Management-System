namespace Railway_Management_System_Application
{
    partial class splash_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_screen));
            this.splash_pic = new System.Windows.Forms.PictureBox();
            this.railway_lbl = new System.Windows.Forms.Label();
            this.management_lbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.circleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splash_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_pic
            // 
            this.splash_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splash_pic.Image = ((System.Drawing.Image)(resources.GetObject("splash_pic.Image")));
            this.splash_pic.Location = new System.Drawing.Point(0, 0);
            this.splash_pic.Name = "splash_pic";
            this.splash_pic.Size = new System.Drawing.Size(921, 542);
            this.splash_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splash_pic.TabIndex = 0;
            this.splash_pic.TabStop = false;
            // 
            // railway_lbl
            // 
            this.railway_lbl.AutoSize = true;
            this.railway_lbl.Font = new System.Drawing.Font("Lobster 1.4", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.railway_lbl.ForeColor = System.Drawing.Color.White;
            this.railway_lbl.Location = new System.Drawing.Point(12, 21);
            this.railway_lbl.Name = "railway_lbl";
            this.railway_lbl.Size = new System.Drawing.Size(232, 75);
            this.railway_lbl.TabIndex = 1;
            this.railway_lbl.Text = "Railway";
            // 
            // management_lbl
            // 
            this.management_lbl.AutoSize = true;
            this.management_lbl.Font = new System.Drawing.Font("Lobster 1.4", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.management_lbl.ForeColor = System.Drawing.Color.White;
            this.management_lbl.Location = new System.Drawing.Point(12, 125);
            this.management_lbl.Name = "management_lbl";
            this.management_lbl.Size = new System.Drawing.Size(331, 48);
            this.management_lbl.TabIndex = 2;
            this.management_lbl.Text = "Management System";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circleProgressBar.FillColor = System.Drawing.Color.Black;
            this.circleProgressBar.FillOffset = 20;
            this.circleProgressBar.FillThickness = 4;
            this.circleProgressBar.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleProgressBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.circleProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.circleProgressBar.Location = new System.Drawing.Point(384, 402);
            this.circleProgressBar.Maximum = 300;
            this.circleProgressBar.Minimum = 0;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.ProgressColor = System.Drawing.Color.Black;
            this.circleProgressBar.ProgressColor2 = System.Drawing.Color.DarkRed;
            this.circleProgressBar.ProgressOffset = 15;
            this.circleProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleProgressBar.ProgressThickness = 10;
            this.circleProgressBar.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.circleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar.ShadowDecoration.Parent = this.circleProgressBar;
            this.circleProgressBar.ShowPercentage = true;
            this.circleProgressBar.Size = new System.Drawing.Size(140, 140);
            this.circleProgressBar.TabIndex = 3;
            this.circleProgressBar.Text = "guna2CircleProgressBar1";
            this.circleProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.circleProgressBar.UseTransparentBackground = true;
            this.circleProgressBar.UseWaitCursor = true;
            this.circleProgressBar.Value = 100;
            // 
            // splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 542);
            this.Controls.Add(this.circleProgressBar);
            this.Controls.Add(this.management_lbl);
            this.Controls.Add(this.railway_lbl);
            this.Controls.Add(this.splash_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash_screen";
            this.Load += new System.EventHandler(this.splash_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splash_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splash_pic;
        private System.Windows.Forms.Label railway_lbl;
        private System.Windows.Forms.Label management_lbl;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgressBar;
    }
}