namespace Hangman_Game
{
    partial class MainMenu
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnPassReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::Hangman_Game.Properties.Resources.hangman_button;
            this.btnLogin.Location = new System.Drawing.Point(332, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 46);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewUser.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Image = global::Hangman_Game.Properties.Resources.hangman_button;
            this.btnNewUser.Location = new System.Drawing.Point(493, 261);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(151, 46);
            this.btnNewUser.TabIndex = 2;
            this.btnNewUser.Text = "New Player";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(332, 287);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(127, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(332, 261);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(127, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // btnPassReset
            // 
            this.btnPassReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPassReset.FlatAppearance.BorderSize = 0;
            this.btnPassReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPassReset.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassReset.Image = global::Hangman_Game.Properties.Resources.hangman_button;
            this.btnPassReset.Location = new System.Drawing.Point(493, 313);
            this.btnPassReset.Name = "btnPassReset";
            this.btnPassReset.Size = new System.Drawing.Size(151, 46);
            this.btnPassReset.TabIndex = 9;
            this.btnPassReset.Text = "Password Reset";
            this.btnPassReset.UseVisualStyleBackColor = true;
            this.btnPassReset.Click += new System.EventHandler(this.btnPassReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "Easy-game-jump-test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_Game.Properties.Resources.hangman_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPassReset);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "HangMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnPassReset;
        private System.Windows.Forms.Button button1;
    }
}

