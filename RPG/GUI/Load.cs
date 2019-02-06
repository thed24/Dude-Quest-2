using RPG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpriteLibrary;
using System.Reflection;
using System.IO;
using System.Media;

namespace RPG.GUI
{
    public partial class Load : Form
    {
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);
        public Load()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory("Saves");
            string CurDirect = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Saves\";
            DirectoryInfo dinfo = new DirectoryInfo(CurDirect);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                LoadList.Items.Add(file.FullName);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            Player mainPlayer = PlayerSaveLoad.ReadFromBinaryFile<Player>(LoadList.SelectedItem.ToString());
            Main_Game MainGame = new Main_Game(mainPlayer);
            MainGame.ShowDialog();
            Close();
        }

        private void LoadList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Load_Load(object sender, EventArgs e)
        {

        }
    }
}
