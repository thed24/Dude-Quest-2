using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG.GUI
{
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void GameoverButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
