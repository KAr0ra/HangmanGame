using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WMPLib;



namespace Hangman_Game
{
    public partial class MainMenu : Form
    {

        //win media player
        WindowsMediaPlayer player = new WindowsMediaPlayer();

           
        //captures the sql data source in a string
        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kan\source\repos\Hangman_Game\DB\test.mdf; Integrated Security = True;Connect Timeout=30";

        public MainMenu()
        {
            InitializeComponent();

            //Plays song once you start game
            player.URL = "song.mp3";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //checks to see if text boxes are filled 
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;


            }
            if (txtPassword.Text == "")
            {

                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;

            }


            try
            {
                //creates new sql connection 
                SqlConnection myConnection = new SqlConnection(cs);
                

                //sql command to get sql user data from table
                SqlCommand myCommand = new SqlCommand("SELECT Username,Password FROM TblLogin WHERE Username = @Username AND Password = @Password", myConnection);

                //sql data from table is set up as uName, and uPassword
                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                //grab user info from text box 
                uName.Value = txtUserName.Text.Trim();
                uPassword.Value = txtPassword.Text.Trim();

                //takes sql command adds sql parameters and then adds to DB
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                //open sql connection 
                myCommand.Connection.Open();

                //set up new sql data reader
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                //if the user is in the DB they will be redirected to the choose game page
                if (myReader.Read() == true)
                {
                    ChooseGame Game = new ChooseGame();
                    this.Hide();
                    Game.Show();
                    
                     

                }

                //login failed error pops up for any entries are worng
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                //closed sql connection 
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // opens new users form
        private void btnPass_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            this.Hide();
            newUser.Show();
            player.controls.stop();
        }

        //opens password recovery form
        private void btnPassReset_Click(object sender, EventArgs e)
        {
          
            recPass recPass = new recPass();
            this.Hide();
            recPass.Show();
            player.controls.stop();
        }
        //debuging button set up to skill login
       // private void button1_Click(object sender, EventArgs e)
        //{
          //  EasyGame easyGame = new EasyGame();
            //this.Hide();
        //    easyGame.Show();
        //}

        

        //shows user to enter username in textbox
        private void txtUserName_Click_1(object sender, EventArgs e)
        {

            txtUserName.Text = String.Empty;
        }
        //shows users to enter password in textbox
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //player.controls.play();
        }

        
    }
    }

        
 
        


