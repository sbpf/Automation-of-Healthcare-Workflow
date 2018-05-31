namespace login1
{
    partial class f_ScheduleAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ScheduleAppointment));
            this.bClear = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.cAmOrPm = new System.Windows.Forms.ComboBox();
            this.cMinutes = new System.Windows.Forms.ComboBox();
            this.cHour = new System.Windows.Forms.ComboBox();
            this.cYear = new System.Windows.Forms.ComboBox();
            this.cMonth = new System.Windows.Forms.ComboBox();
            this.cDate = new System.Windows.Forms.ComboBox();
            this.tMRN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linklabel1 = new System.Windows.Forms.LinkLabel();
            this.ll_logout = new System.Windows.Forms.LinkLabel();
            this.bReschedule = new System.Windows.Forms.Button();
            this.manDate = new System.Windows.Forms.Label();
            this.manTime = new System.Windows.Forms.Label();
            this.manMrn = new System.Windows.Forms.Label();
            this.manAll = new System.Windows.Forms.Label();
            this.slots = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(515, 351);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 25);
            this.bClear.TabIndex = 25;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click_1);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(397, 351);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 25);
            this.bCancel.TabIndex = 24;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click_1);
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(280, 351);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 25);
            this.bSubmit.TabIndex = 23;
            this.bSubmit.Text = "Save";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click_1);
            // 
            // cAmOrPm
            // 
            this.cAmOrPm.FormattingEnabled = true;
            this.cAmOrPm.Items.AddRange(new object[] {
            "PM"});
            this.cAmOrPm.Location = new System.Drawing.Point(429, 290);
            this.cAmOrPm.Name = "cAmOrPm";
            this.cAmOrPm.Size = new System.Drawing.Size(54, 21);
            this.cAmOrPm.TabIndex = 22;
            this.cAmOrPm.Text = "AM";
            // 
            // cMinutes
            // 
            this.cMinutes.FormattingEnabled = true;
            this.cMinutes.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cMinutes.Location = new System.Drawing.Point(358, 290);
            this.cMinutes.Name = "cMinutes";
            this.cMinutes.Size = new System.Drawing.Size(54, 21);
            this.cMinutes.TabIndex = 21;
            this.cMinutes.Text = "Min";
            // 
            // cHour
            // 
            this.cHour.FormattingEnabled = true;
            this.cHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cHour.Location = new System.Drawing.Point(280, 290);
            this.cHour.Name = "cHour";
            this.cHour.Size = new System.Drawing.Size(54, 21);
            this.cHour.TabIndex = 20;
            this.cHour.Text = "Hr";
            // 
            // cYear
            // 
            this.cYear.FormattingEnabled = true;
            this.cYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cYear.Location = new System.Drawing.Point(429, 250);
            this.cYear.Name = "cYear";
            this.cYear.Size = new System.Drawing.Size(54, 21);
            this.cYear.TabIndex = 19;
            this.cYear.Text = "YYYY";
            // 
            // cMonth
            // 
            this.cMonth.FormattingEnabled = true;
            this.cMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cMonth.Location = new System.Drawing.Point(358, 250);
            this.cMonth.Name = "cMonth";
            this.cMonth.Size = new System.Drawing.Size(50, 21);
            this.cMonth.TabIndex = 18;
            this.cMonth.Text = "MM";
            // 
            // cDate
            // 
            this.cDate.FormattingEnabled = true;
            this.cDate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cDate.Location = new System.Drawing.Point(280, 250);
            this.cDate.Name = "cDate";
            this.cDate.Size = new System.Drawing.Size(54, 21);
            this.cDate.TabIndex = 17;
            this.cDate.Text = "DD";
            // 
            // tMRN
            // 
            this.tMRN.Location = new System.Drawing.Point(280, 204);
            this.tMRN.Name = "tMRN";
            this.tMRN.Size = new System.Drawing.Size(128, 20);
            this.tMRN.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Appointment Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Appointment Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "MRN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "SCHEDULE APPOINTMENT";
            // 
            // linklabel1
            // 
            this.linklabel1.AutoSize = true;
            this.linklabel1.BackColor = System.Drawing.Color.Transparent;
            this.linklabel1.Location = new System.Drawing.Point(687, 9);
            this.linklabel1.Name = "linklabel1";
            this.linklabel1.Size = new System.Drawing.Size(35, 13);
            this.linklabel1.TabIndex = 29;
            this.linklabel1.TabStop = true;
            this.linklabel1.Text = "Home";
            this.linklabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel1_LinkClicked);
            // 
            // ll_logout
            // 
            this.ll_logout.AutoSize = true;
            this.ll_logout.BackColor = System.Drawing.Color.Transparent;
            this.ll_logout.Location = new System.Drawing.Point(730, 9);
            this.ll_logout.Name = "ll_logout";
            this.ll_logout.Size = new System.Drawing.Size(42, 13);
            this.ll_logout.TabIndex = 28;
            this.ll_logout.TabStop = true;
            this.ll_logout.Text = "LogOut";
            this.ll_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_logout_LinkClicked);
            // 
            // bReschedule
            // 
            this.bReschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReschedule.Location = new System.Drawing.Point(216, 608);
            this.bReschedule.Name = "bReschedule";
            this.bReschedule.Size = new System.Drawing.Size(99, 25);
            this.bReschedule.TabIndex = 30;
            this.bReschedule.Text = "Reschedule";
            this.bReschedule.UseVisualStyleBackColor = true;
            this.bReschedule.Visible = false;
            this.bReschedule.Click += new System.EventHandler(this.bReschedule_Click);
            // 
            // manDate
            // 
            this.manDate.AutoSize = true;
            this.manDate.BackColor = System.Drawing.Color.Transparent;
            this.manDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDate.ForeColor = System.Drawing.Color.Red;
            this.manDate.Location = new System.Drawing.Point(85, 243);
            this.manDate.Name = "manDate";
            this.manDate.Size = new System.Drawing.Size(25, 31);
            this.manDate.TabIndex = 111;
            this.manDate.Text = "*";
            this.manDate.Visible = false;
            // 
            // manTime
            // 
            this.manTime.AutoSize = true;
            this.manTime.BackColor = System.Drawing.Color.Transparent;
            this.manTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manTime.ForeColor = System.Drawing.Color.Red;
            this.manTime.Location = new System.Drawing.Point(85, 282);
            this.manTime.Name = "manTime";
            this.manTime.Size = new System.Drawing.Size(25, 31);
            this.manTime.TabIndex = 110;
            this.manTime.Text = "*";
            this.manTime.Visible = false;
            // 
            // manMrn
            // 
            this.manMrn.AutoSize = true;
            this.manMrn.BackColor = System.Drawing.Color.Transparent;
            this.manMrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manMrn.ForeColor = System.Drawing.Color.Red;
            this.manMrn.Location = new System.Drawing.Point(85, 199);
            this.manMrn.Name = "manMrn";
            this.manMrn.Size = new System.Drawing.Size(25, 31);
            this.manMrn.TabIndex = 109;
            this.manMrn.Text = "*";
            this.manMrn.Visible = false;
            // 
            // manAll
            // 
            this.manAll.AutoSize = true;
            this.manAll.BackColor = System.Drawing.Color.Transparent;
            this.manAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manAll.ForeColor = System.Drawing.Color.Red;
            this.manAll.Location = new System.Drawing.Point(560, 444);
            this.manAll.Name = "manAll";
            this.manAll.Size = new System.Drawing.Size(136, 15);
            this.manAll.TabIndex = 112;
            this.manAll.Text = "* Please fill all the fields";
            this.manAll.Visible = false;
            // 
            // slots
            // 
            this.slots.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slots.Location = new System.Drawing.Point(259, 428);
            this.slots.Name = "slots";
            this.slots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.slots.Size = new System.Drawing.Size(240, 150);
            this.slots.TabIndex = 113;
            this.slots.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 114;
            this.button1.Text = "View busy slots\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(451, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 115;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::login1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(342, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 131;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // f_ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login1.Properties.Resources.BKGND1;
            this.ClientSize = new System.Drawing.Size(784, 697);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slots);
            this.Controls.Add(this.manAll);
            this.Controls.Add(this.manDate);
            this.Controls.Add(this.manTime);
            this.Controls.Add(this.manMrn);
            this.Controls.Add(this.bReschedule);
            this.Controls.Add(this.linklabel1);
            this.Controls.Add(this.ll_logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.cAmOrPm);
            this.Controls.Add(this.cMinutes);
            this.Controls.Add(this.cHour);
            this.Controls.Add(this.cYear);
            this.Controls.Add(this.cMonth);
            this.Controls.Add(this.cDate);
            this.Controls.Add(this.tMRN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_ScheduleAppointment";
            this.Text = "Schedule Appointment - MediClinic";
            ((System.ComponentModel.ISupportInitialize)(this.slots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.ComboBox cAmOrPm;
        private System.Windows.Forms.ComboBox cMinutes;
        private System.Windows.Forms.ComboBox cHour;
        private System.Windows.Forms.ComboBox cYear;
        private System.Windows.Forms.ComboBox cMonth;
        private System.Windows.Forms.ComboBox cDate;
        private System.Windows.Forms.TextBox tMRN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linklabel1;
        private System.Windows.Forms.LinkLabel ll_logout;
        private System.Windows.Forms.Button bReschedule;
        private System.Windows.Forms.Label manDate;
        private System.Windows.Forms.Label manTime;
        private System.Windows.Forms.Label manMrn;
        private System.Windows.Forms.Label manAll;
        private System.Windows.Forms.DataGridView slots;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}