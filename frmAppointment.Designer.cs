namespace projectPAWD
{
    partial class frmAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.username = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.subtitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppButton = new System.Windows.Forms.Button();
            this.AppDate = new System.Windows.Forms.DateTimePicker();
            this.appHour = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_appointments = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_users = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.appHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.username.Location = new System.Drawing.Point(78, 41);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(164, 27);
            this.username.TabIndex = 0;
            this.username.Text = "HEllo razvan";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button3.Location = new System.Drawing.Point(571, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(484, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(54, 86);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(227, 17);
            this.subtitle.TabIndex = 15;
            this.subtitle.Text = "Make an appointment for your CAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // AppButton
            // 
            this.AppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppButton.FlatAppearance.BorderSize = 0;
            this.AppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppButton.ForeColor = System.Drawing.Color.White;
            this.AppButton.Location = new System.Drawing.Point(57, 259);
            this.AppButton.Name = "AppButton";
            this.AppButton.Size = new System.Drawing.Size(216, 35);
            this.AppButton.TabIndex = 28;
            this.AppButton.Text = "MAKE APPOINTMENT";
            this.AppButton.UseVisualStyleBackColor = false;
            this.AppButton.Click += new System.EventHandler(this.AppButton_Click);
            // 
            // AppDate
            // 
            this.AppDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppDate.Location = new System.Drawing.Point(57, 151);
            this.AppDate.Name = "AppDate";
            this.AppDate.Size = new System.Drawing.Size(216, 25);
            this.AppDate.TabIndex = 30;
            // 
            // appHour
            // 
            this.appHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appHour.Location = new System.Drawing.Point(57, 210);
            this.appHour.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.appHour.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.appHour.Name = "appHour";
            this.appHour.Size = new System.Drawing.Size(216, 25);
            this.appHour.TabIndex = 31;
            this.appHour.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projectPAWD.Properties.Resources.suv_icon_9_64;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btn_appointments
            // 
            this.btn_appointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_appointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_appointments.FlatAppearance.BorderSize = 0;
            this.btn_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointments.ForeColor = System.Drawing.Color.White;
            this.btn_appointments.Location = new System.Drawing.Point(183, 546);
            this.btn_appointments.Name = "btn_appointments";
            this.btn_appointments.Size = new System.Drawing.Size(189, 30);
            this.btn_appointments.TabIndex = 33;
            this.btn_appointments.Text = "SHOW APPOINTMENTS";
            this.btn_appointments.UseVisualStyleBackColor = false;
            this.btn_appointments.Visible = false;
            this.btn_appointments.Click += new System.EventHandler(this.btn_appointments_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(57, 390);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(527, 150);
            this.dataGridView.TabIndex = 34;
            this.dataGridView.Visible = false;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Location = new System.Drawing.Point(378, 546);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(100, 30);
            this.btn_users.TabIndex = 35;
            this.btn_users.Text = "SHOW USERS";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Visible = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(57, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 35);
            this.button4.TabIndex = 37;
            this.button4.Text = "SHOW/UPDATE CHART";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(307, 107);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "APP";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(284, 246);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 588);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_users);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_appointments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appHour);
            this.Controls.Add(this.AppDate);
            this.Controls.Add(this.AppButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AppButton;
        private System.Windows.Forms.DateTimePicker AppDate;
        private System.Windows.Forms.NumericUpDown appHour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_appointments;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}