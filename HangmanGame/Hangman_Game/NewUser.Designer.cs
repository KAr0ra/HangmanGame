namespace Hangman_Game
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.txtNewUserEmail = new System.Windows.Forms.TextBox();
            this.txtNewUserPassword = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewUserEmail
            // 
            this.txtNewUserEmail.Location = new System.Drawing.Point(62, 124);
            this.txtNewUserEmail.Name = "txtNewUserEmail";
            this.txtNewUserEmail.Size = new System.Drawing.Size(193, 20);
            this.txtNewUserEmail.TabIndex = 10;
            this.txtNewUserEmail.Text = "Email";
            this.txtNewUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewUserEmail.Click += new System.EventHandler(this.txtNewUserEmail_Click);
            // 
            // txtNewUserPassword
            // 
            this.txtNewUserPassword.Location = new System.Drawing.Point(62, 89);
            this.txtNewUserPassword.Name = "txtNewUserPassword";
            this.txtNewUserPassword.PasswordChar = '*';
            this.txtNewUserPassword.Size = new System.Drawing.Size(193, 20);
            this.txtNewUserPassword.TabIndex = 9;
            this.txtNewUserPassword.Text = "Password";
            this.txtNewUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewUserPassword.Click += new System.EventHandler(this.txtNewUserPassword_Click);
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(62, 53);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(193, 20);
            this.txtNewUsername.TabIndex = 8;
            this.txtNewUsername.Text = "Username";
            this.txtNewUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewUsername.Click += new System.EventHandler(this.txtNewUsername_Click);
            // 
            // btnReg
            // 
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReg.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Image = global::Hangman_Game.Properties.Resources.hangman_button;
            this.btnReg.Location = new System.Drawing.Point(62, 159);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(193, 56);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Create Account ";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Hangman_Game.Properties.Resources.hangman_button;
            this.button1.Location = new System.Drawing.Point(62, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_Game.Properties.Resources.westerado_Newuser_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(324, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtNewUserEmail);
            this.Controls.Add(this.txtNewUserPassword);
            this.Controls.Add(this.txtNewUsername);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewUserEmail;
        private System.Windows.Forms.TextBox txtNewUserPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button1;
    }
}