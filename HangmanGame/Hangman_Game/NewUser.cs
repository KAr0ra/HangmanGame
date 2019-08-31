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
    public partial class NewUser : Form
    {

        //captures the sql data source in a string 
        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kan\source\repos\Hangman_Game\DB\test.mdf; Integrated Security = True;Connect Timeout=30";

        public NewUser()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
                //checks to see if there are any textboxs that are emptey when the button is clicked
                if (txtNewUsername.Text == "")
                {
                    MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewUsername.Focus();
                    return;


                }
                if (txtNewUserPassword.Text == "")
                {

                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewUserPassword.Focus();
                    return;

                }
                if (txtNewUserEmail.Text == "")
                {

                    MessageBox.Show("Please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewUserEmail.Focus();
                    return;

                }




            try
                {
                //create a new sql connection using the our CS string that is holding the data source
                SqlConnection myConnection = new SqlConnection(cs);
                //sets up new SqlCommand object as myCommand with sql query
                SqlCommand myCommand = new SqlCommand("INSERT INTO TblLogin (Username, Password, Email) VALUES(@Username,@Password,@Email)", myConnection);

                //set up sql parameters
                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                SqlParameter uEmail = new SqlParameter("@Email", SqlDbType.VarChar);

                //grab user info from textbox
                uName.Value = txtNewUsername.Text.Trim();
                uPassword.Value = txtNewUserPassword.Text.Trim();
                uEmail.Value = txtNewUserEmail.Text.Trim();

                //takes sql command adds sql parameters and then adds to DB
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);
                myCommand.Parameters.Add(uEmail);

                //open sql connection 
                myCommand.Connection.Open();

                //Execute sql query
                myCommand.ExecuteNonQuery();

                //new user has been added to DB
                MessageBox.Show(" You can now login! ");
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void txtNewUsername_Click(object sender, EventArgs e)
        {
            txtNewUsername.Text = "";
        }

        private void txtNewUserPassword_Click(object sender, EventArgs e)
        {
            txtNewUserPassword.Text = "";
        }

        private void txtNewUserEmail_Click(object sender, EventArgs e)
        {
            txtNewUserEmail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }
    }
}
