namespace login1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enterRole = new System.Windows.Forms.Label();
            this.c_role = new System.Windows.Forms.ComboBox();
            this.enterPass = new System.Windows.Forms.Label();
            this.lRole = new System.Windows.Forms.Label();
            this.enterUser = new System.Windows.Forms.Label();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_submit = new System.Windows.Forms.Button();
            this.t_password = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.TextBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "WELCOME TO MEDICLINIC";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.enterRole);
            this.groupBox1.Controls.Add(this.c_role);
            this.groupBox1.Controls.Add(this.enterPass);
            this.groupBox1.Controls.Add(this.lRole);
            this.groupBox1.Controls.Add(this.enterUser);
            this.groupBox1.Controls.Add(this.b_clear);
            this.groupBox1.Controls.Add(this.b_submit);
            this.groupBox1.Controls.Add(this.t_password);
            this.groupBox1.Controls.Add(this.lPassword);
            this.groupBox1.Controls.Add(this.t_username);
            this.groupBox1.Controls.Add(this.lUserName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(190, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 185);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // enterRole
            // 
            this.enterRole.AutoSize = true;
            this.enterRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterRole.ForeColor = System.Drawing.Color.Red;
            this.enterRole.Location = new System.Drawing.Point(182, 126);
            this.enterRole.Name = "enterRole";
            this.enterRole.Size = new System.Drawing.Size(108, 13);
            this.enterRole.TabIndex = 33;
            this.enterRole.Text = "Please select role";
            this.enterRole.Visible = false;
            // 
            // c_role
            // 
            this.c_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_role.FormattingEnabled = true;
            this.c_role.Items.AddRange(new object[] {
            "Administrator",
            "Doctor",
            "Receptionist",
            "Lab Technician",
            "Pharmacist",
            "Patient"});
            this.c_role.Location = new System.Drawing.Point(185, 99);
            this.c_role.Name = "c_role";
            this.c_role.Size = new System.Drawing.Size(164, 24);
            this.c_role.TabIndex = 2;
            // 
            // enterPass
            // 
            this.enterPass.AutoSize = true;
            this.enterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPass.ForeColor = System.Drawing.Color.Red;
            this.enterPass.Location = new System.Drawing.Point(183, 83);
            this.enterPass.Name = "enterPass";
            this.enterPass.Size = new System.Drawing.Size(157, 13);
            this.enterPass.TabIndex = 33;
            this.enterPass.Text = "Please enter the password";
            this.enterPass.Visible = false;
            // 
            // lRole
            // 
            this.lRole.BackColor = System.Drawing.Color.Transparent;
            this.lRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRole.Location = new System.Drawing.Point(63, 102);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(100, 23);
            this.lRole.TabIndex = 31;
            this.lRole.Text = "Role";
            // 
            // enterUser
            // 
            this.enterUser.AutoSize = true;
            this.enterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUser.ForeColor = System.Drawing.Color.Red;
            this.enterUser.Location = new System.Drawing.Point(182, 50);
            this.enterUser.Name = "enterUser";
            this.enterUser.Size = new System.Drawing.Size(158, 13);
            this.enterUser.TabIndex = 33;
            this.enterUser.Text = "Please enter the username";
            this.enterUser.Visible = false;
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(275, 147);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(75, 25);
            this.b_clear.TabIndex = 4;
            this.b_clear.Text = "Clear";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_submit
            // 
            this.b_submit.Location = new System.Drawing.Point(126, 147);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(75, 25);
            this.b_submit.TabIndex = 3;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // t_password
            // 
            this.t_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_password.Location = new System.Drawing.Point(186, 63);
            this.t_password.Name = "t_password";
            this.t_password.PasswordChar = '*';
            this.t_password.Size = new System.Drawing.Size(164, 22);
            this.t_password.TabIndex = 1;
            // 
            // lPassword
            // 
            this.lPassword.BackColor = System.Drawing.Color.Transparent;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(64, 65);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(72, 19);
            this.lPassword.TabIndex = 27;
            this.lPassword.Text = "Password";
            // 
            // t_username
            // 
            this.t_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_username.Location = new System.Drawing.Point(186, 25);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(164, 22);
            this.t_username.TabIndex = 0;
            // 
            // lUserName
            // 
            this.lUserName.BackColor = System.Drawing.Color.Transparent;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(64, 25);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(100, 23);
            this.lUserName.TabIndex = 25;
            this.lUserName.Text = "Username";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::login1.Properties.Resources.loginscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - MediClinic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.ComboBox c_role;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.Label enterUser;
        private System.Windows.Forms.Label enterPass;
        private System.Windows.Forms.Label enterRole;
    }
}