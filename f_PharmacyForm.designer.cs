namespace login1
{
    partial class f_PharmacyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_PharmacyForm));
            this.b_save = new System.Windows.Forms.Button();
            this.l_DateOfVisit = new System.Windows.Forms.Label();
            this.tfname = new System.Windows.Forms.TextBox();
            this.l_patientName = new System.Windows.Forms.Label();
            this.l_welocomePharmacy = new System.Windows.Forms.Label();
            this.t_MRN = new System.Windows.Forms.TextBox();
            this.l_MRN = new System.Windows.Forms.Label();
            this.ll_home = new System.Windows.Forms.LinkLabel();
            this.ll_logout = new System.Windows.Forms.LinkLabel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tdate = new System.Windows.Forms.TextBox();
            this.tmname = new System.Windows.Forms.TextBox();
            this.tlname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_save
            // 
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.Location = new System.Drawing.Point(374, 496);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(86, 25);
            this.b_save.TabIndex = 6;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // l_DateOfVisit
            // 
            this.l_DateOfVisit.BackColor = System.Drawing.Color.Transparent;
            this.l_DateOfVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_DateOfVisit.Location = new System.Drawing.Point(181, 246);
            this.l_DateOfVisit.Name = "l_DateOfVisit";
            this.l_DateOfVisit.Size = new System.Drawing.Size(113, 23);
            this.l_DateOfVisit.TabIndex = 44;
            this.l_DateOfVisit.Text = "Date Of Visit";
            // 
            // tfname
            // 
            this.tfname.Enabled = false;
            this.tfname.Location = new System.Drawing.Point(305, 217);
            this.tfname.Name = "tfname";
            this.tfname.Size = new System.Drawing.Size(114, 20);
            this.tfname.TabIndex = 1;
            // 
            // l_patientName
            // 
            this.l_patientName.BackColor = System.Drawing.Color.Transparent;
            this.l_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_patientName.Location = new System.Drawing.Point(181, 214);
            this.l_patientName.Name = "l_patientName";
            this.l_patientName.Size = new System.Drawing.Size(119, 25);
            this.l_patientName.TabIndex = 50;
            this.l_patientName.Text = "Patient Name";
            this.l_patientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_welocomePharmacy
            // 
            this.l_welocomePharmacy.BackColor = System.Drawing.Color.Transparent;
            this.l_welocomePharmacy.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_welocomePharmacy.Location = new System.Drawing.Point(12, 71);
            this.l_welocomePharmacy.Name = "l_welocomePharmacy";
            this.l_welocomePharmacy.Size = new System.Drawing.Size(111, 20);
            this.l_welocomePharmacy.TabIndex = 42;
            this.l_welocomePharmacy.Text = "WELCOME";
            this.l_welocomePharmacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_MRN
            // 
            this.t_MRN.Enabled = false;
            this.t_MRN.Location = new System.Drawing.Point(305, 187);
            this.t_MRN.Name = "t_MRN";
            this.t_MRN.Size = new System.Drawing.Size(114, 20);
            this.t_MRN.TabIndex = 0;
            // 
            // l_MRN
            // 
            this.l_MRN.BackColor = System.Drawing.Color.Transparent;
            this.l_MRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MRN.Location = new System.Drawing.Point(181, 188);
            this.l_MRN.Name = "l_MRN";
            this.l_MRN.Size = new System.Drawing.Size(46, 23);
            this.l_MRN.TabIndex = 40;
            this.l_MRN.Text = "MRN";
            // 
            // ll_home
            // 
            this.ll_home.AutoSize = true;
            this.ll_home.BackColor = System.Drawing.Color.Transparent;
            this.ll_home.Location = new System.Drawing.Point(695, 9);
            this.ll_home.Name = "ll_home";
            this.ll_home.Size = new System.Drawing.Size(35, 13);
            this.ll_home.TabIndex = 54;
            this.ll_home.TabStop = true;
            this.ll_home.Text = "Home";
            this.ll_home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_home_LinkClicked);
            // 
            // ll_logout
            // 
            this.ll_logout.AutoSize = true;
            this.ll_logout.Location = new System.Drawing.Point(734, 9);
            this.ll_logout.Name = "ll_logout";
            this.ll_logout.Size = new System.Drawing.Size(42, 13);
            this.ll_logout.TabIndex = 53;
            this.ll_logout.TabStop = true;
            this.ll_logout.Text = "LogOut";
            this.ll_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_logout_LinkClicked);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(184, 317);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(556, 150);
            this.grid.TabIndex = 5;
            // 
            // tdate
            // 
            this.tdate.Enabled = false;
            this.tdate.Location = new System.Drawing.Point(305, 249);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(114, 20);
            this.tdate.TabIndex = 4;
            // 
            // tmname
            // 
            this.tmname.Enabled = false;
            this.tmname.Location = new System.Drawing.Point(440, 219);
            this.tmname.Name = "tmname";
            this.tmname.Size = new System.Drawing.Size(114, 20);
            this.tmname.TabIndex = 2;
            // 
            // tlname
            // 
            this.tlname.Enabled = false;
            this.tlname.Location = new System.Drawing.Point(573, 219);
            this.tlname.Name = "tlname";
            this.tlname.Size = new System.Drawing.Size(114, 20);
            this.tlname.TabIndex = 3;
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
            // f_PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login1.Properties.Resources.BKGND1;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tlname);
            this.Controls.Add(this.tmname);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.ll_home);
            this.Controls.Add(this.ll_logout);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.l_DateOfVisit);
            this.Controls.Add(this.tfname);
            this.Controls.Add(this.l_patientName);
            this.Controls.Add(this.l_welocomePharmacy);
            this.Controls.Add(this.t_MRN);
            this.Controls.Add(this.l_MRN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_PharmacyForm";
            this.Text = "Pharmacy - MediClinic";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button b_save;
        internal System.Windows.Forms.Label l_DateOfVisit;
        private System.Windows.Forms.TextBox tfname;
        private System.Windows.Forms.Label l_patientName;
        internal System.Windows.Forms.Label l_welocomePharmacy;
        internal System.Windows.Forms.TextBox t_MRN;
        internal System.Windows.Forms.Label l_MRN;
        private System.Windows.Forms.LinkLabel ll_home;
        private System.Windows.Forms.LinkLabel ll_logout;
        private System.Windows.Forms.DataGridView grid;
        internal System.Windows.Forms.TextBox tdate;
        private System.Windows.Forms.TextBox tmname;
        private System.Windows.Forms.TextBox tlname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}