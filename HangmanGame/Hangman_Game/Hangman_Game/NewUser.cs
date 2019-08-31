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


        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kan\source\repos\Hangman_Game\DB\test.mdf; Integrated Security = True;Connect Timeout=30";

        public NewUser()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {



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
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand("NewUser", sqlCon);

                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Username", txtNewUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtNewUserPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtNewUserEmail.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
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
        }
    }
}
