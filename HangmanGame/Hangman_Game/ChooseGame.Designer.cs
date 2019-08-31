namespace Hangman_Game
{
    partial class ChooseGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGame));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEasyGame = new System.Windows.Forms.Button();
            this.btnHardGame = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::Hangman_Game.Properties.Resources.game_button_color;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("HWT Tuscan Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(81, 156);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(287, 33);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEasyGame
            // 
            this.btnEasyGame.BackgroundImage = global::Hangman_Game.Properties.Resources.game_button_color;
            this.btnEasyGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEasyGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEasyGame.FlatAppearance.BorderSize = 2;
            this.btnEasyGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasyGame.Font = new System.Drawing.Font("HWT Tuscan Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasyGame.ForeColor = System.Drawing.Color.Red;
            this.btnEasyGame.Location = new System.Drawing.Point(81, 40);
            this.btnEasyGame.Name = "btnEasyGame";
            this.btnEasyGame.Size = new System.Drawing.Size(287, 33);
            this.btnEasyGame.TabIndex = 1;
            this.btnEasyGame.Text = "Easy Game";
            this.btnEasyGame.UseVisualStyleBackColor = true;
            this.btnEasyGame.Click += new System.EventHandler(this.btnEasyGame_Click);
            // 
            // btnHardGame
            // 
            this.btnHardGame.BackgroundImage = global::Hangman_Game.Properties.Resources.game_button_color;
            this.btnHardGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHardGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHardGame.FlatAppearance.BorderSize = 2;
            this.btnHardGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardGame.Font = new System.Drawing.Font("HWT Tuscan Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardGame.ForeColor = System.Drawing.Color.Red;
            this.btnHardGame.Location = new System.Drawing.Point(81, 79);
            this.btnHardGame.Name = "btnHardGame";
            this.btnHardGame.Size = new System.Drawing.Size(287, 32);
            this.btnHardGame.TabIndex = 2;
            this.btnHardGame.Text = "Hard Game";
            this.btnHardGame.UseVisualStyleBackColor = true;
            this.btnHardGame.Click += new System.EventHandler(this.btnHardGame_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackgroundImage = global::Hangman_Game.Properties.Resources.game_button_color;
            this.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePass.FlatAppearance.BorderSize = 2;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("HWT Tuscan Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Red;
            this.btnChangePass.Location = new System.Drawing.Point(81, 117);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(287, 33);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // ChooseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_Game.Properties.Resources.hangman_game_bdrop_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 253);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnHardGame);
            this.Controls.Add(this.btnEasyGame);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseGame";
            this.Text = "Game Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEasyGame;
        private System.Windows.Forms.Button btnHardGame;
        private System.Windows.Forms.Button btnChangePass;
    }
}