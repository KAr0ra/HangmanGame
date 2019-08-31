namespace Hangman_Game
{
    partial class recPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recPass));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackgroundImage = global::Hangman_Game.Properties.Resources.game_playdrop;
            this.btnSendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendEmail.Font = new System.Drawing.Font("HWT Tuscan Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.Black;
            this.btnSendEmail.Location = new System.Drawing.Point(12, 117);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(212, 50);
            this.btnSendEmail.TabIndex = 1;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackgroundImage = global::Hangman_Game.Properties.Resources.game_playdrop;
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainMenu.Font = new System.Drawing.Font("HWT Tuscan Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(249, 117);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(212, 50);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(144, 54);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "Username";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(224, 38);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 5;
            // 
            // recPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_Game.Properties.Resources.game_playdrop1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 226);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "recPass";
            this.Text = "Recover Password";
            this.Load += new System.EventHandler(this.recPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblMessage;
    }
}