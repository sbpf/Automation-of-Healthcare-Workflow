namespace login1
{
    partial class changePasswordForm
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
            this.lOldPassword = new System.Windows.Forms.Label();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.lConfirmNewPassword = new System.Windows.Forms.Label();
            this.tOldPassword = new System.Windows.Forms.TextBox();
            this.tNewPassword = new System.Windows.Forms.TextBox();
            this.tNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.mandatoryOld = new System.Windows.Forms.Label();
            this.mandatoryConfirm = new System.Windows.Forms.Label();
            this.mandatoryNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lOldPassword
            // 
            this.lOldPassword.AutoSize = true;
            this.lOldPassword.Location = new System.Drawing.Point(156, 145);
            this.lOldPassword.Name = "lOldPassword";
            this.lOldPassword.Size = new System.Drawing.Size(97, 13);
            this.lOldPassword.TabIndex = 0;
            this.lOldPassword.Text = "Enter old password";
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Location = new System.Drawing.Point(156, 190);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(103, 13);
            this.lNewPassword.TabIndex = 1;
            this.lNewPassword.Text = "Enter new password";
            // 
            // lConfirmNewPassword
            // 
            this.lConfirmNewPassword.AutoSize = true;
            this.lConfirmNewPassword.Location = new System.Drawing.Point(156, 241);
            this.lConfirmNewPassword.Name = "lConfirmNewPassword";
            this.lConfirmNewPassword.Size = new System.Drawing.Size(113, 13);
            this.lConfirmNewPassword.TabIndex = 2;
            this.lConfirmNewPassword.Text = "Confirm new password";
            // 
            // tOldPassword
            // 
            this.tOldPassword.Location = new System.Drawing.Point(367, 142);
            this.tOldPassword.Name = "tOldPassword";
            this.tOldPassword.PasswordChar = '*';
            this.tOldPassword.Size = new System.Drawing.Size(140, 20);
            this.tOldPassword.TabIndex = 3;
            // 
            // tNewPassword
            // 
            this.tNewPassword.Location = new System.Drawing.Point(368, 190);
            this.tNewPassword.Name = "tNewPassword";
            this.tNewPassword.PasswordChar = '*';
            this.tNewPassword.Size = new System.Drawing.Size(140, 20);
            this.tNewPassword.TabIndex = 4;
            // 
            // tNewPasswordConfirm
            // 
            this.tNewPasswordConfirm.Location = new System.Drawing.Point(366, 238);
            this.tNewPasswordConfirm.Name = "tNewPasswordConfirm";
            this.tNewPasswordConfirm.PasswordChar = '*';
            this.tNewPasswordConfirm.Size = new System.Drawing.Size(140, 20);
            this.tNewPasswordConfirm.TabIndex = 5;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(220, 325);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 6;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(340, 325);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "CLEAR";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(458, 325);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // mandatoryOld
            // 
            this.mandatoryOld.AutoSize = true;
            this.mandatoryOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryOld.ForeColor = System.Drawing.Color.Red;
            this.mandatoryOld.Location = new System.Drawing.Point(526, 142);
            this.mandatoryOld.Name = "mandatoryOld";
            this.mandatoryOld.Size = new System.Drawing.Size(180, 13);
            this.mandatoryOld.TabIndex = 9;
            this.mandatoryOld.Text = "Please enter the Old password";
            this.mandatoryOld.Visible = false;
            // 
            // mandatoryConfirm
            // 
            this.mandatoryConfirm.AutoSize = true;
            this.mandatoryConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryConfirm.ForeColor = System.Drawing.Color.Red;
            this.mandatoryConfirm.Location = new System.Drawing.Point(526, 241);
            this.mandatoryConfirm.Name = "mandatoryConfirm";
            this.mandatoryConfirm.Size = new System.Drawing.Size(232, 13);
            this.mandatoryConfirm.TabIndex = 10;
            this.mandatoryConfirm.Text = "Please enter the Confirmation Password";
            this.mandatoryConfirm.Visible = false;
            // 
            // mandatoryNew
            // 
            this.mandatoryNew.AutoSize = true;
            this.mandatoryNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryNew.ForeColor = System.Drawing.Color.Red;
            this.mandatoryNew.Location = new System.Drawing.Point(526, 197);
            this.mandatoryNew.Name = "mandatoryNew";
            this.mandatoryNew.Size = new System.Drawing.Size(187, 13);
            this.mandatoryNew.TabIndex = 11;
            this.mandatoryNew.Text = "Please enter the New Password";
            this.mandatoryNew.Visible = false;
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login1.Properties.Resources.master04_background1;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mandatoryNew);
            this.Controls.Add(this.mandatoryConfirm);
            this.Controls.Add(this.mandatoryOld);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.tNewPasswordConfirm);
            this.Controls.Add(this.tNewPassword);
            this.Controls.Add(this.tOldPassword);
            this.Controls.Add(this.lConfirmNewPassword);
            this.Controls.Add(this.lNewPassword);
            this.Controls.Add(this.lOldPassword);
            this.Name = "changePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lOldPassword;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.Label lConfirmNewPassword;
        private System.Windows.Forms.TextBox tOldPassword;
        private System.Windows.Forms.TextBox tNewPassword;
        private System.Windows.Forms.TextBox tNewPasswordConfirm;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label mandatoryOld;
        private System.Windows.Forms.Label mandatoryConfirm;
        private System.Windows.Forms.Label mandatoryNew;
    }
}

