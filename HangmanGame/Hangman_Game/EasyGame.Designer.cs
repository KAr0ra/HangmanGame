namespace Hangman_Game
{
    partial class EasyGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyGame));
            this.flpLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.picCowboy0 = new System.Windows.Forms.PictureBox();
            this.picCowboy5 = new System.Windows.Forms.PictureBox();
            this.picCowboy4 = new System.Windows.Forms.PictureBox();
            this.picCowboy3 = new System.Windows.Forms.PictureBox();
            this.picCowboy2 = new System.Windows.Forms.PictureBox();
            this.picCowboy1 = new System.Windows.Forms.PictureBox();
            this.picCowboy6 = new System.Windows.Forms.PictureBox();
            this.btnChooseGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy6)).BeginInit();
            this.SuspendLayout();
            // 
            // flpLetters
            // 
            this.flpLetters.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpLetters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flpLetters.Location = new System.Drawing.Point(380, 97);
            this.flpLetters.Name = "flpLetters";
            this.flpLetters.Size = new System.Drawing.Size(423, 70);
            this.flpLetters.TabIndex = 113;
            this.flpLetters.Paint += new System.Windows.Forms.PaintEventHandler(this.flpLetters_Paint);
            // 
            // lblWon
            // 
            this.lblWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.ForeColor = System.Drawing.Color.Blue;
            this.lblWon.Location = new System.Drawing.Point(385, 180);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(423, 46);
            this.lblWon.TabIndex = 112;
            this.lblWon.Text = "Congratulations, you won!";
            this.lblWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWon.Visible = false;
            // 
            // lblLost
            // 
            this.lblLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLost.ForeColor = System.Drawing.Color.Red;
            this.lblLost.Location = new System.Drawing.Point(380, 180);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(423, 46);
            this.lblLost.TabIndex = 111;
            this.lblLost.Text = "Sorry, you lost.";
            this.lblLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLost.Visible = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewGame.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(390, 421);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(177, 32);
            this.btnNewGame.TabIndex = 110;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // button25
            // 
            this.button25.Enabled = false;
            this.button25.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(745, 291);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(37, 34);
            this.button25.TabIndex = 109;
            this.button25.TabStop = false;
            this.button25.Text = "L";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Enabled = false;
            this.button26.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(767, 251);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(37, 34);
            this.button26.TabIndex = 108;
            this.button26.TabStop = false;
            this.button26.Text = "P";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Enabled = false;
            this.button27.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(724, 251);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(37, 34);
            this.button27.TabIndex = 107;
            this.button27.TabStop = false;
            this.button27.Text = "O";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(681, 331);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(37, 34);
            this.button17.TabIndex = 106;
            this.button17.TabStop = false;
            this.button17.Text = "M";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Enabled = false;
            this.button18.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(638, 331);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(37, 34);
            this.button18.TabIndex = 105;
            this.button18.TabStop = false;
            this.button18.Text = "N";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Enabled = false;
            this.button19.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(595, 331);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(37, 34);
            this.button19.TabIndex = 104;
            this.button19.TabStop = false;
            this.button19.Text = "B";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Enabled = false;
            this.button20.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(552, 331);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(37, 34);
            this.button20.TabIndex = 103;
            this.button20.TabStop = false;
            this.button20.Text = "V";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(509, 331);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(37, 34);
            this.button21.TabIndex = 102;
            this.button21.TabStop = false;
            this.button21.Text = "C";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(466, 331);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(37, 34);
            this.button22.TabIndex = 101;
            this.button22.TabStop = false;
            this.button22.Text = "X";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Enabled = false;
            this.button23.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(423, 331);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(37, 34);
            this.button23.TabIndex = 100;
            this.button23.TabStop = false;
            this.button23.Text = "Z";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(702, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 34);
            this.button8.TabIndex = 99;
            this.button8.TabStop = false;
            this.button8.Text = "K";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(659, 291);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 34);
            this.button9.TabIndex = 98;
            this.button9.TabStop = false;
            this.button9.Text = "J";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(616, 291);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(37, 34);
            this.button10.TabIndex = 97;
            this.button10.TabStop = false;
            this.button10.Text = "H";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(573, 291);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 34);
            this.button11.TabIndex = 96;
            this.button11.TabStop = false;
            this.button11.Text = "G";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(530, 291);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(37, 34);
            this.button12.TabIndex = 95;
            this.button12.TabStop = false;
            this.button12.Text = "F";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(487, 291);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(37, 34);
            this.button13.TabIndex = 94;
            this.button13.TabStop = false;
            this.button13.Text = "D";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(444, 291);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(37, 34);
            this.button14.TabIndex = 93;
            this.button14.TabStop = false;
            this.button14.Text = "S";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(401, 291);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(37, 34);
            this.button15.TabIndex = 92;
            this.button15.TabStop = false;
            this.button15.Text = "A";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(681, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 34);
            this.button4.TabIndex = 91;
            this.button4.TabStop = false;
            this.button4.Text = "I";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(638, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 34);
            this.button5.TabIndex = 90;
            this.button5.TabStop = false;
            this.button5.Text = "U";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.Enabled = false;
            this.btnY.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(595, 251);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(37, 34);
            this.btnY.TabIndex = 89;
            this.btnY.TabStop = false;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.Enabled = false;
            this.btnT.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(552, 251);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(37, 34);
            this.btnT.TabIndex = 88;
            this.btnT.TabStop = false;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Enabled = false;
            this.btnR.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(509, 251);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(37, 34);
            this.btnR.TabIndex = 87;
            this.btnR.TabStop = false;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(466, 251);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(37, 34);
            this.btnE.TabIndex = 86;
            this.btnE.TabStop = false;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.Enabled = false;
            this.btnW.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(423, 251);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(37, 34);
            this.btnW.TabIndex = 85;
            this.btnW.TabStop = false;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            this.btnQ.Enabled = false;
            this.btnQ.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(380, 251);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(37, 34);
            this.btnQ.TabIndex = 84;
            this.btnQ.TabStop = false;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // picCowboy0
            // 
            this.picCowboy0.BackColor = System.Drawing.Color.White;
            this.picCowboy0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy0.Location = new System.Drawing.Point(47, 29);
            this.picCowboy0.Name = "picCowboy0";
            this.picCowboy0.Size = new System.Drawing.Size(264, 306);
            this.picCowboy0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy0.TabIndex = 83;
            this.picCowboy0.TabStop = false;
            // 
            // picCowboy5
            // 
            this.picCowboy5.BackgroundImage = global::Hangman_Game.Properties.Resources.hang6;
            this.picCowboy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy5.Location = new System.Drawing.Point(47, 29);
            this.picCowboy5.Name = "picCowboy5";
            this.picCowboy5.Size = new System.Drawing.Size(264, 306);
            this.picCowboy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy5.TabIndex = 82;
            this.picCowboy5.TabStop = false;
            this.picCowboy5.Visible = false;
            // 
            // picCowboy4
            // 
            this.picCowboy4.BackgroundImage = global::Hangman_Game.Properties.Resources.hang5;
            this.picCowboy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy4.Location = new System.Drawing.Point(47, 29);
            this.picCowboy4.Name = "picCowboy4";
            this.picCowboy4.Size = new System.Drawing.Size(264, 306);
            this.picCowboy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy4.TabIndex = 81;
            this.picCowboy4.TabStop = false;
            this.picCowboy4.Visible = false;
            // 
            // picCowboy3
            // 
            this.picCowboy3.BackgroundImage = global::Hangman_Game.Properties.Resources.hang4;
            this.picCowboy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy3.Location = new System.Drawing.Point(60, 29);
            this.picCowboy3.Name = "picCowboy3";
            this.picCowboy3.Size = new System.Drawing.Size(264, 306);
            this.picCowboy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy3.TabIndex = 80;
            this.picCowboy3.TabStop = false;
            this.picCowboy3.Visible = false;
            // 
            // picCowboy2
            // 
            this.picCowboy2.BackgroundImage = global::Hangman_Game.Properties.Resources.hang3;
            this.picCowboy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy2.Location = new System.Drawing.Point(60, 29);
            this.picCowboy2.Name = "picCowboy2";
            this.picCowboy2.Size = new System.Drawing.Size(264, 306);
            this.picCowboy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy2.TabIndex = 79;
            this.picCowboy2.TabStop = false;
            this.picCowboy2.Visible = false;
            // 
            // picCowboy1
            // 
            this.picCowboy1.BackgroundImage = global::Hangman_Game.Properties.Resources.hang2;
            this.picCowboy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy1.Location = new System.Drawing.Point(60, 29);
            this.picCowboy1.Name = "picCowboy1";
            this.picCowboy1.Size = new System.Drawing.Size(264, 306);
            this.picCowboy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy1.TabIndex = 78;
            this.picCowboy1.TabStop = false;
            this.picCowboy1.Visible = false;
            // 
            // picCowboy6
            // 
            this.picCowboy6.BackgroundImage = global::Hangman_Game.Properties.Resources.hang7;
            this.picCowboy6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCowboy6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCowboy6.Location = new System.Drawing.Point(60, 29);
            this.picCowboy6.Name = "picCowboy6";
            this.picCowboy6.Size = new System.Drawing.Size(264, 306);
            this.picCowboy6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCowboy6.TabIndex = 77;
            this.picCowboy6.TabStop = false;
            this.picCowboy6.Visible = false;
            // 
            // btnChooseGame
            // 
            this.btnChooseGame.Font = new System.Drawing.Font("HWT Tuscan Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseGame.Location = new System.Drawing.Point(595, 421);
            this.btnChooseGame.Name = "btnChooseGame";
            this.btnChooseGame.Size = new System.Drawing.Size(180, 31);
            this.btnChooseGame.TabIndex = 115;
            this.btnChooseGame.Text = "Choose Game";
            this.btnChooseGame.UseVisualStyleBackColor = true;
            this.btnChooseGame.Click += new System.EventHandler(this.btnChooseGame_Click);
            // 
            // EasyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_Game.Properties.Resources.game_playdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 487);
            this.Controls.Add(this.btnChooseGame);
            this.Controls.Add(this.flpLetters);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.picCowboy0);
            this.Controls.Add(this.picCowboy5);
            this.Controls.Add(this.picCowboy4);
            this.Controls.Add(this.picCowboy3);
            this.Controls.Add(this.picCowboy2);
            this.Controls.Add(this.picCowboy1);
            this.Controls.Add(this.picCowboy6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasyGame";
            this.Text = "EasyGame";
            this.Load += new System.EventHandler(this.EasyGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCowboy6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLetters;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.PictureBox picCowboy0;
        private System.Windows.Forms.PictureBox picCowboy5;
        private System.Windows.Forms.PictureBox picCowboy4;
        private System.Windows.Forms.PictureBox picCowboy3;
        private System.Windows.Forms.PictureBox picCowboy2;
        private System.Windows.Forms.PictureBox picCowboy1;
        private System.Windows.Forms.PictureBox picCowboy6;
        private System.Windows.Forms.Button btnChooseGame;
    }
}