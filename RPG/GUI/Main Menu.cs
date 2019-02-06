using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG.GUI
{
    public partial class Main_Menu : Form
    {
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);
        public SoundPlayer Intro = new SoundPlayer(Properties.Resources.IntroSound);
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            Intro.PlayLooping();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            Test.Play();
            Form chrCreate = new Character_Creator();
            chrCreate.Show();
            //Close();
        }

        private void loadGameBtn_Click(object sender, EventArgs e)
        {
            Test.Play();
            Load LoadGame = new Load();
            LoadGame.ShowDialog();
            Close();
        }
    }
}
