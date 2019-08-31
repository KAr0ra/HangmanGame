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

namespace Hangman_Game
{
    public partial class MainMenu : Form
    {

        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kan\source\repos\Hangman_Game\DB\test.mdf; Integrated Security = True;Connect Timeout=30";

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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

                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Username,Password FROM TblLogin WHERE Username = @Username AND Password = @Password", myConnection);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                uName.Value = txtUserName.Text;
                uPassword.Value = txtPassword.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);


                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    ChooseGame Game = new ChooseGame();
                    this.Hide();
                    Game.Show();

                }


                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }

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



        private void btnPass_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            this.Hide();
            newUser.Show();
        }

        private void btnPassReset_Click(object sender, EventArgs e)
        {
          
            recPass recPass = new recPass();
            this.Hide();
            recPass.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EasyGame easyGame = new EasyGame();
            this.Hide();
            easyGame.Show();
        }
    }

        }
 
        


