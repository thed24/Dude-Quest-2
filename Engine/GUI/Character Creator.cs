using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.GUI
{
    public partial class Character_Creator : Form
    {
        int remainingPoints = 8;
        int strPoints = 10;
        int dexPoints = 10;
        int intPoints = 10;
        int wisPoints = 10;
        int chrPoints = 10;
        int conPoints = 10;
        string playerName;        

        public Character_Creator()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            strPoints = 10;
            dexPoints = 10;
            intPoints = 10;
            wisPoints = 10;
            chrPoints = 10;
            conPoints = 10;
            remainingPoints = 8;
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                intPoints = intPoints + 1;
            }
        }

        private void conButton_Click(object sender, EventArgs e)
        {
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                conPoints = conPoints + 1;
            }
        }

        private void wisButton_Click(object sender, EventArgs e)
        {
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                wisPoints = wisPoints + 1;
            }
        }

        private void chrButton_Click(object sender, EventArgs e)
        {
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                chrPoints = chrPoints + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                strPoints = strPoints + 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                dexPoints = dexPoints + 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Character_Creator_Load(object sender, EventArgs e)
        {
            strLabel.Text = strPoints.ToString();
            intLabel.Text = intLabel.ToString();
            chrLabel.Text = chrLabel.ToString();
            wisLabel.Text = wisLabel.ToString();
            conLabel.Text = conPoints.ToString();
            dexLabel.Text = dexPoints.ToString();
            remainingLabel.Text = remainingPoints.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            playerName = nameTxt.Text;
        }
    }
}
