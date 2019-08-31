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

namespace Hangman_Game
{
    public partial class recPass : Form
    {
        public recPass()
        {
            InitializeComponent();
        }

        private void recPass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");



                mail.From = new MailAddress("hangmancsc335@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Hey";
                mail.Body = "I know what you did to neil....";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("hangmancsc335@gmail.com","enter the password here");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
