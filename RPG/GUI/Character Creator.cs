using RPG.Models;
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
    public partial class Character_Creator : Form
    {
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);
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
            Test.Play();
            strPoints = 10;
            dexPoints = 10;
            intPoints = 10;
            wisPoints = 10;
            chrPoints = 10;
            conPoints = 10;
            remainingPoints = 8;
            updateLabels();
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                intPoints = intPoints + 1;
            }
            updateLabels();
        }

        private void conButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                conPoints = conPoints + 1;
            }
            updateLabels();
        }

        private void wisButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                wisPoints = wisPoints + 1;
            }
            updateLabels();
        }

        private void chrButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                chrPoints = chrPoints + 1;
            }
            updateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                strPoints = strPoints + 1;
            }
            updateLabels();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (remainingPoints > 0)
            {
                remainingPoints = remainingPoints - 1;
                dexPoints = dexPoints + 1;
            }
            updateLabels();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Character_Creator_Load(object sender, EventArgs e)
        {
            charAvatar.Image = CloudAv;
            updateLabels();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateLabels()
        {
            strLabel.Text = strPoints.ToString();
            intLabel.Text = intPoints.ToString();
            chrLabel.Text = chrPoints.ToString();
            wisLabel.Text = wisPoints.ToString();
            conLabel.Text = conPoints.ToString();
            dexLabel.Text = dexPoints.ToString();
            remainingLabel.Text = "Remaining points: " + remainingPoints.ToString();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            playerName = nameTxt.Text;
        }

        Bitmap CloudAv = RPG.Properties.Resources.CloudPortraitBig;
        Bitmap TifaAv = RPG.Properties.Resources.TifaPortraitBig;

        private void charAvatar_Click(object sender, EventArgs e)
        {
            if (charAvatar.Image == CloudAv)
            {
                charAvatar.Image = TifaAv;
            }
            else
            {
                charAvatar.Image = CloudAv;
            }
        }

        private void remainingLabel_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            Test.Play();
            Player mainPlayer = Player.Instance;
            mainPlayer.EntityName = nameTxt.Text;
            mainPlayer.EntityStats.charHP = 100;
            mainPlayer.EntityStats.charMP = 10;
            mainPlayer.EntityStats.charDex = dexPoints;
            mainPlayer.EntityStats.charCon = conPoints;
            mainPlayer.EntityStats.charChr = chrPoints;
            mainPlayer.EntityStats.charInt = intPoints;
            mainPlayer.EntityStats.charStr = strPoints;
            mainPlayer.EntityStats.charWis = wisPoints;
            mainPlayer.PlayerExp = 0;
            mainPlayer.EntityLevel = 1;
            mainPlayer.PlayerGold = 0;
            if (punchBtn.Checked == true)
            {
                Abilities Slash = new Abilities();
                Slash.SkillPower = 20;
                Slash.SkillAccuracy = 100;
                Slash.SkillCost = 0;
                Slash.SkillName = "Slash";
                mainPlayer.EntitySkills.PhysicalSkills.Add(Slash);
            }
            if (magicMissileBtn.Checked == true)
            {
                Abilities MagicMissile = new Abilities();
                MagicMissile.SkillPower = 20;
                MagicMissile.SkillAccuracy = 65;
                MagicMissile.SkillCost = 2;
                MagicMissile.SkillName = "Magic Missile";
                mainPlayer.EntitySkills.MagicalSkills.Add(MagicMissile);
            }
            Abilities Heal = new Abilities();
            Heal.SkillPower = 20;
            Heal.SkillAccuracy = 100;
            Heal.SkillCost = 0;
            Heal.SkillName = "Heal";
            mainPlayer.EntitySkills.SelfSkills.Add(Heal);
            if (axeBtn.Checked == true)
            {
                Weapon IronAxe = new Weapon();
                IronAxe.Name = "Iron Axe";
                IronAxe.Attack = 15;
                IronAxe.Price = 10;
                IronAxe.Stats.StatBonus = 2;
                IronAxe.Stats.StatType = "Strength";
                mainPlayer.WeaponEquipped.Add(IronAxe);
                mainPlayer.ApplyEquipedWeapon();
            }
            if (swordBtn.Checked == true)
            {
                Weapon IronSword = new Weapon();
                IronSword.Name = "Iron Sword";
                IronSword.Attack = 15;
                IronSword.Price = 10;
                IronSword.Stats.StatBonus = 2;
                IronSword.Stats.StatType = "Dexterity";
                mainPlayer.WeaponEquipped.Add(IronSword);
                mainPlayer.ApplyEquipedWeapon();
            }
            if (charAvatar.Image == CloudAv)
            {
                mainPlayer.PlayerGender = true;
            }
            if (charAvatar.Image == TifaAv)
            {
                mainPlayer.PlayerGender = false;
            }
            Armor ClothRobe = new Armor();
            ClothRobe.Name = "Cloth Robe";
            ClothRobe.Defense = 15;
            ClothRobe.Price = 10;
            ClothRobe.Stats.StatBonus = 2;
            ClothRobe.Stats.StatType = "Intelligence";
            mainPlayer.ArmorEquipped.Add(ClothRobe);
            mainPlayer.ApplyEquipedWeapon();
            Form mainGame = new Main_Game(mainPlayer);
            mainGame.Show();
            Close();
        }

        private void punchBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (punchBtn.Checked == true)
            {
                magicMissileBtn.AutoCheck = false;
            }
            else
            {
                magicMissileBtn.AutoCheck = true;
            }
        }

        private void magicMissileBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (magicMissileBtn.Checked == true)
            {
                punchBtn.AutoCheck = false;
            }
            else
            {
                punchBtn.AutoCheck = true;
            }
        }

        private void axeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (axeBtn.Checked == true)
            {
                swordBtn.AutoCheck = false;
            }
            else
            {
                swordBtn.AutoCheck = true;
            }
        }

        private void swordBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (swordBtn.Checked == true)
            {
                axeBtn.AutoCheck = false;
            }
            else
            {
                axeBtn.AutoCheck = true;
            }
        }
    }
}
