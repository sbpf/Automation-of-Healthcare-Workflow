namespace login1
{
    partial class f_PharmacyHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_PharmacyHomeScreen));
            this.ll_logout = new System.Windows.Forms.LinkLabel();
            this.b_DispenseMedicine = new System.Windows.Forms.Button();
            this.l_welcome = new System.Windows.Forms.Label();
            this.infodetailtable = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.infodetailtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ll_logout
            // 
            this.ll_logout.AutoSize = true;
            this.ll_logout.BackColor = System.Drawing.Color.Transparent;
            this.ll_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_logout.Location = new System.Drawing.Point(727, 7);
            this.ll_logout.Name = "ll_logout";
            this.ll_logout.Size = new System.Drawing.Size(42, 13);
            this.ll_logout.TabIndex = 16;
            this.ll_logout.TabStop = true;
            this.ll_logout.Text = "LogOut";
            this.ll_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_logout_LinkClicked);
            // 
            // b_DispenseMedicine
            // 
            this.b_DispenseMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_DispenseMedicine.Location = new System.Drawing.Point(309, 354);
            this.b_DispenseMedicine.Name = "b_DispenseMedicine";
            this.b_DispenseMedicine.Size = new System.Drawing.Size(162, 25);
            this.b_DispenseMedicine.TabIndex = 1;
            this.b_DispenseMedicine.Text = "Dispense Medicines";
            this.b_DispenseMedicine.UseVisualStyleBackColor = true;
            this.b_DispenseMedicine.Click += new System.EventHandler(this.b_DispenseMedicine_Click);
            // 
            // l_welcome
            // 
            this.l_welcome.BackColor = System.Drawing.Color.Transparent;
            this.l_welcome.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_welcome.Location = new System.Drawing.Point(10, 52);
            this.l_welcome.Name = "l_welcome";
            this.l_welcome.Size = new System.Drawing.Size(149, 24);
            this.l_welcome.TabIndex = 10;
            this.l_welcome.Text = "WELCOME";
            this.l_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infodetailtable
            // 
            this.infodetailtable.AllowUserToAddRows = false;
            this.infodetailtable.AllowUserToDeleteRows = false;
            this.infodetailtable.AllowUserToOrderColumns = true;
            this.infodetailtable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infodetailtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infodetailtable.Location = new System.Drawing.Point(134, 166);
            this.infodetailtable.Name = "infodetailtable";
            this.infodetailtable.ReadOnly = true;
            this.infodetailtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infodetailtable.Size = new System.Drawing.Size(537, 165);
            this.infodetailtable.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::login1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(629, 7);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 129;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // f_PharmacyHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login1.Properties.Resources.BKGND1;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infodetailtable);
            this.Controls.Add(this.ll_logout);
            this.Controls.Add(this.b_DispenseMedicine);
            this.Controls.Add(this.l_welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_PharmacyHomeScreen";
            this.Text = "Pharmacy Home - MediClinic";
            ((System.ComponentModel.ISupportInitialize)(this.infodetailtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_logout;
        internal System.Windows.Forms.Button b_DispenseMedicine;
        private System.Windows.Forms.Label l_welcome;
        //private HISDataSet hISDataSet;
        //private Final.HISDataSetTableAdapters.DoctorprescriptionTableAdapter doctorprescriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMedicinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateofvisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView infodetailtable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}