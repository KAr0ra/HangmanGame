using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
//The SMTP code was provided by http://csharp.net-informations.com/communications/csharp-smtp-mail.htm
//Someone of the forgot password code to get info from the DB was provided by https://www.aspsnippets.com/Articles/Implement-Forgot-Password-Password-Recovery-and-send-password-in-Email-in-ASPNet.aspx
namespace Hangman_Game
{
    public partial class recPass : Form
    {

        //captures the sql data source in a string 
        String cs = "";
        public recPass()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            
            try
            {
                string username = string.Empty;
                string password = string.Empty;
              
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Username, [Password] FROM  TblLogin WHERE Email = @Email"))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                username = sdr["Username"].ToString();
                                password = sdr["Password"].ToString();
                            }
                        }
                        con.Close();
                    }
                }
                if (!string.IsNullOrEmpty(password))
                {
                    //set up new MailMessage and SmtpClient class
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


                    //Provide auth info
                    //will not work if two factor auth is on
                    mail.From = new MailAddress("");// enter your email here
                    mail.To.Add(txtEmail.Text);
                    mail.Subject = "Hey " + txtUserName.Text.Trim();
                    mail.Body = string.Format("Hi {0},Your password is {1} Thank You.", username, password);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("your email", "your password");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                   
                    MessageBox.Show("Password sent to your Email");
                }

                else
                {
                    //bad info provided
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "This email address does not match our records.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }

        private void recPass_Load(object sender, EventArgs e)
        {

        }
    }
}
