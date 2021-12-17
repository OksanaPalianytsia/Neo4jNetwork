
namespace WinForms
{
    partial class LogInForm
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
            this.labelLogInEmail = new System.Windows.Forms.Label();
            this.labelLogInPassword = new System.Windows.Forms.Label();
            this.textBoxLogInEmail = new System.Windows.Forms.TextBox();
            this.textBoxLogInPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogInEmail
            // 
            this.labelLogInEmail.AutoSize = true;
            this.labelLogInEmail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogInEmail.Location = new System.Drawing.Point(213, 109);
            this.labelLogInEmail.Name = "labelLogInEmail";
            this.labelLogInEmail.Size = new System.Drawing.Size(71, 23);
            this.labelLogInEmail.TabIndex = 0;
            this.labelLogInEmail.Text = "E-mail : ";
            // 
            // labelLogInPassword
            // 
            this.labelLogInPassword.AutoSize = true;
            this.labelLogInPassword.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogInPassword.Location = new System.Drawing.Point(213, 179);
            this.labelLogInPassword.Name = "labelLogInPassword";
            this.labelLogInPassword.Size = new System.Drawing.Size(95, 23);
            this.labelLogInPassword.TabIndex = 1;
            this.labelLogInPassword.Text = "Password : ";
            // 
            // textBoxLogInEmail
            // 
            this.textBoxLogInEmail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogInEmail.Location = new System.Drawing.Point(363, 106);
            this.textBoxLogInEmail.Name = "textBoxLogInEmail";
            this.textBoxLogInEmail.Size = new System.Drawing.Size(198, 30);
            this.textBoxLogInEmail.TabIndex = 2;
            // 
            // textBoxLogInPassword
            // 
            this.textBoxLogInPassword.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogInPassword.Location = new System.Drawing.Point(363, 184);
            this.textBoxLogInPassword.Name = "textBoxLogInPassword";
            this.textBoxLogInPassword.Size = new System.Drawing.Size(198, 30);
            this.textBoxLogInPassword.TabIndex = 3;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.Location = new System.Drawing.Point(314, 290);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(184, 50);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxLogInPassword);
            this.Controls.Add(this.textBoxLogInEmail);
            this.Controls.Add(this.labelLogInPassword);
            this.Controls.Add(this.labelLogInEmail);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogInEmail;
        private System.Windows.Forms.Label labelLogInPassword;
        private System.Windows.Forms.TextBox textBoxLogInEmail;
        private System.Windows.Forms.TextBox textBoxLogInPassword;
        private System.Windows.Forms.Button buttonLogIn;
    }
}