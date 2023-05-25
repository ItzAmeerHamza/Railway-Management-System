namespace Railway_Management_System_Application
{
    partial class active_emp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.close_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AllEmp_lbl = new System.Windows.Forms.Label();
            this.active_emp_grd = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.active_emp_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Animated = true;
            this.close_btn.AutoRoundedCorners = true;
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BorderRadius = 24;
            this.close_btn.CheckedState.Parent = this.close_btn;
            this.close_btn.CustomImages.Parent = this.close_btn;
            this.close_btn.DefaultAutoSize = true;
            this.close_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close_btn.DisabledState.Parent = this.close_btn;
            this.close_btn.Font = new System.Drawing.Font("Lobster 1.4", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.HoverState.Parent = this.close_btn;
            this.close_btn.IndicateFocus = true;
            this.close_btn.Location = new System.Drawing.Point(744, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.ShadowDecoration.Parent = this.close_btn;
            this.close_btn.Size = new System.Drawing.Size(55, 51);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "X";
            this.close_btn.UseTransparentBackground = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // AllEmp_lbl
            // 
            this.AllEmp_lbl.AutoSize = true;
            this.AllEmp_lbl.Font = new System.Drawing.Font("Lobster 1.4", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllEmp_lbl.ForeColor = System.Drawing.Color.White;
            this.AllEmp_lbl.Location = new System.Drawing.Point(301, 0);
            this.AllEmp_lbl.Name = "AllEmp_lbl";
            this.AllEmp_lbl.Size = new System.Drawing.Size(215, 38);
            this.AllEmp_lbl.TabIndex = 3;
            this.AllEmp_lbl.Text = "Active Employees";
            // 
            // active_emp_grd
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.active_emp_grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.active_emp_grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.active_emp_grd.BackgroundColor = System.Drawing.Color.White;
            this.active_emp_grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.active_emp_grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.active_emp_grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.active_emp_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.active_emp_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.active_emp_grd.DefaultCellStyle = dataGridViewCellStyle6;
            this.active_emp_grd.EnableHeadersVisualStyles = false;
            this.active_emp_grd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.active_emp_grd.Location = new System.Drawing.Point(1, 103);
            this.active_emp_grd.Name = "active_emp_grd";
            this.active_emp_grd.RowHeadersVisible = false;
            this.active_emp_grd.RowHeadersWidth = 51;
            this.active_emp_grd.RowTemplate.Height = 24;
            this.active_emp_grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.active_emp_grd.Size = new System.Drawing.Size(798, 539);
            this.active_emp_grd.TabIndex = 5;
            this.active_emp_grd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.active_emp_grd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.active_emp_grd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.active_emp_grd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.active_emp_grd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.active_emp_grd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.active_emp_grd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.active_emp_grd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.active_emp_grd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.active_emp_grd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.active_emp_grd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.active_emp_grd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.active_emp_grd.ThemeStyle.HeaderStyle.Height = 4;
            this.active_emp_grd.ThemeStyle.ReadOnly = false;
            this.active_emp_grd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.active_emp_grd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.active_emp_grd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.active_emp_grd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.active_emp_grd.ThemeStyle.RowsStyle.Height = 24;
            this.active_emp_grd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.active_emp_grd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // active_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(799, 644);
            this.Controls.Add(this.active_emp_grd);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.AllEmp_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "active_emp";
            this.Text = "active_emp";
            ((System.ComponentModel.ISupportInitialize)(this.active_emp_grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton close_btn;
        private System.Windows.Forms.Label AllEmp_lbl;
        private Guna.UI2.WinForms.Guna2DataGridView active_emp_grd;
    }
}