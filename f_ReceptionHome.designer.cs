namespace login1
{
    partial class f_ReceptionHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ReceptionHome));
            this.b_ScheduleAppointment = new System.Windows.Forms.Button();
            this.b_RegisterPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b_SearchPatient = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_logout = new System.Windows.Forms.LinkLabel();
            this.l_changepassword = new System.Windows.Forms.LinkLabel();
            this.l_Search = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_ScheduleAppointment
            // 
            this.b_ScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ScheduleAppointment.Location = new System.Drawing.Point(464, 179);
            this.b_ScheduleAppointment.Name = "b_ScheduleAppointment";
            this.b_ScheduleAppointment.Size = new System.Drawing.Size(191, 35);
            this.b_ScheduleAppointment.TabIndex = 9;
            this.b_ScheduleAppointment.Text = "Schedule Appointment";
            this.b_ScheduleAppointment.UseVisualStyleBackColor = true;
            this.b_ScheduleAppointment.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_RegisterPatient
            // 
            this.b_RegisterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_RegisterPatient.Location = new System.Drawing.Point(196, 179);
            this.b_RegisterPatient.Name = "b_RegisterPatient";
            this.b_RegisterPatient.Size = new System.Drawing.Size(191, 35);
            this.b_RegisterPatient.TabIndex = 8;
            this.b_RegisterPatient.Text = "Register Patient";
            this.b_RegisterPatient.UseVisualStyleBackColor = true;
            this.b_RegisterPatient.Click += new System.EventHandler(this.b_RegisterPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME ";
            // 
            // b_SearchPatient
            // 
            this.b_SearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SearchPatient.Location = new System.Drawing.Point(329, 289);
            this.b_SearchPatient.Name = "b_SearchPatient";
            this.b_SearchPatient.Size = new System.Drawing.Size(191, 35);
            this.b_SearchPatient.TabIndex = 12;
            this.b_SearchPatient.Text = "Search Patient";
            this.b_SearchPatient.UseVisualStyleBackColor = true;
            this.b_SearchPatient.Click += new System.EventHandler(this.b_SearchPatient_Click);
            // 
            // option
            // 
            this.option.BackColor = System.Drawing.Color.Transparent;
            this.option.Controls.Add(this.button2);
            this.option.Controls.Add(this.button1);
            this.option.Controls.Add(this.textBox1);
            this.option.Controls.Add(this.label2);
            this.option.Location = new System.Drawing.Point(294, 330);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(241, 144);
            this.option.TabIndex = 13;
            this.option.TabStop = false;
            this.option.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MRN : ";
            // 
            // l_logout
            // 
            this.l_logout.AutoSize = true;
            this.l_logout.BackColor = System.Drawing.Color.Transparent;
            this.l_logout.Location = new System.Drawing.Point(732, 9);
            this.l_logout.Name = "l_logout";
            this.l_logout.Size = new System.Drawing.Size(40, 13);
            this.l_logout.TabIndex = 9;
            this.l_logout.TabStop = true;
            this.l_logout.Text = "Logout";
            this.l_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_logout_LinkClicked);
            // 
            // l_changepassword
            // 
            this.l_changepassword.AutoSize = true;
            this.l_changepassword.BackColor = System.Drawing.Color.Transparent;
            this.l_changepassword.Location = new System.Drawing.Point(632, 9);
            this.l_changepassword.Name = "l_changepassword";
            this.l_changepassword.Size = new System.Drawing.Size(93, 13);
            this.l_changepassword.TabIndex = 14;
            this.l_changepassword.TabStop = true;
            this.l_changepassword.Text = "Change Password";
            this.l_changepassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_changepassword_LinkClicked);
            // 
            // l_Search
            // 
            this.l_Search.AutoSize = true;
            this.l_Search.BackColor = System.Drawing.Color.Transparent;
            this.l_Search.Location = new System.Drawing.Point(585, 9);
            this.l_Search.Name = "l_Search";
            this.l_Search.Size = new System.Drawing.Size(41, 13);
            this.l_Search.TabIndex = 15;
            this.l_Search.TabStop = true;
            this.l_Search.Text = "Search";
            this.l_Search.Visible = false;
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
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // f_ReceptionHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login1.Properties.Resources.BKGND1;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l_Search);
            this.Controls.Add(this.l_changepassword);
            this.Controls.Add(this.l_logout);
            this.Controls.Add(this.option);
            this.Controls.Add(this.b_SearchPatient);
            this.Controls.Add(this.b_ScheduleAppointment);
            this.Controls.Add(this.b_RegisterPatient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_ReceptionHome";
            this.Text = "Receptionist Home - MediClinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.option.ResumeLayout(false);
            this.option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_ScheduleAppointment;
        private System.Windows.Forms.Button b_RegisterPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_SearchPatient;
        private System.Windows.Forms.GroupBox option;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel l_logout;
        private System.Windows.Forms.LinkLabel l_changepassword;
        private System.Windows.Forms.LinkLabel l_Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

