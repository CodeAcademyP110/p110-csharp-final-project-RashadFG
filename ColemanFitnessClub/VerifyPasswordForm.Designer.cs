namespace ColemanFitnessClub
{
    partial class VerifyPasswordForm
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtDefault = new System.Windows.Forms.TextBox();
            this.lblDedaultPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPasword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Black;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(34, 259);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(248, 76);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(34, 126);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(248, 29);
            this.txtNewPassword.TabIndex = 8;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Location = new System.Drawing.Point(30, 99);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(148, 24);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtDefault
            // 
            this.txtDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefault.Location = new System.Drawing.Point(34, 51);
            this.txtDefault.Name = "txtDefault";
            this.txtDefault.Size = new System.Drawing.Size(248, 29);
            this.txtDefault.TabIndex = 6;
            // 
            // lblDedaultPassword
            // 
            this.lblDedaultPassword.AutoSize = true;
            this.lblDedaultPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblDedaultPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDedaultPassword.ForeColor = System.Drawing.Color.Transparent;
            this.lblDedaultPassword.Location = new System.Drawing.Point(33, 9);
            this.lblDedaultPassword.Name = "lblDedaultPassword";
            this.lblDedaultPassword.Size = new System.Drawing.Size(170, 24);
            this.lblDedaultPassword.TabIndex = 5;
            this.lblDedaultPassword.Text = "Default Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(34, 208);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(248, 29);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // lblConfirmPasword
            // 
            this.lblConfirmPasword.AutoSize = true;
            this.lblConfirmPasword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasword.ForeColor = System.Drawing.Color.Transparent;
            this.lblConfirmPasword.Location = new System.Drawing.Point(33, 181);
            this.lblConfirmPasword.Name = "lblConfirmPasword";
            this.lblConfirmPasword.Size = new System.Drawing.Size(168, 24);
            this.lblConfirmPasword.TabIndex = 10;
            this.lblConfirmPasword.Text = "Confirm Pasword";
            // 
            // VerifyPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ColemanFitnessClub.Properties.Resources.Fat_Loss_4_Workout_Protocol;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 370);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPasword);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtDefault);
            this.Controls.Add(this.lblDedaultPassword);
            this.Name = "VerifyPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerifyPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtDefault;
        private System.Windows.Forms.Label lblDedaultPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPasword;
    }
}