using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
    public partial class ChooseGame : Form
    {
        public ChooseGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MainMenu MainMenu = new MainMenu();
            this.Hide();
            MainMenu.Show();

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            EasyGame easyGame = new EasyGame();
            this.Hide();
            easyGame.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HardGame hardGame = new HardGame();
            this.Hide();
            hardGame.Show();
        }
    }
}
