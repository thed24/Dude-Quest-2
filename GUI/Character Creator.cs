using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace GUI
{
    public partial class Character_Creator : Form
    {
        public Character_Creator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Character_Creator_Load(object sender, EventArgs e)
        {
            Player playerChar = new Player();
        }
    }
}
