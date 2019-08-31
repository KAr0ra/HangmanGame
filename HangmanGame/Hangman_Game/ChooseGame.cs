using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace Hangman_Game
{
    public partial class ChooseGame : Form
    {

        //win media player
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public ChooseGame()
        {
            InitializeComponent();
            
        }


        //opens main menu when main menu button is clicked
        private void btnLogout_Click(object sender, EventArgs e)
        {
           MainMenu MainMenu = new MainMenu();
            this.Hide();
            MainMenu.Show();
            player.controls.stop();

        }

    
        //opens easy game
        private void btnEasyGame_Click(object sender, EventArgs e)
        {
            EasyGame easyGame = new EasyGame();
            this.Hide();
            easyGame.Show();
           
        }
        //opens hard game
        private void btnHardGame_Click(object sender, EventArgs e)
        {
            HardGame hardGame = new HardGame();
            this.Hide();
            hardGame.Show();
        }
        //opens change password 
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            recPass recPass = new recPass();
            this.Hide();
            recPass.Show();
        }
    }
}
