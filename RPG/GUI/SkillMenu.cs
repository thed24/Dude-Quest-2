using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.Models;
using System.Media;


namespace RPG.GUI
{
    public partial class SkillMenu : Form
    {
        public Abilities playerChosen;
        public Player mainPlayer;
        public bool Checker = false;
        public int AttackType;
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);

        public SkillMenu(Player inheritPlayer)
        {
            InitializeComponent();
            Checker = false;
            mainPlayer = inheritPlayer;
        }

        public Abilities ChosenSkill // retrieving a value from
        {
            get
            {
                return playerChosen;
            }
        }

        public bool AttackPrompt // retrieving a value from
        {
            get
            {
                return Checker;
            }
        }

        public int AnimType // retrieving a value from
        {
            get
            {
                return AttackType;
            }
        }

        private void PhysicalButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            SkillList.DataSource = mainPlayer.EntitySkills.PhysicalSkills.ToList();
            AttackType = 1;
        }

        private void SkillMenu_Load(object sender, EventArgs e)
        {

        }

        private void MagicalButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            SkillList.DataSource = mainPlayer.EntitySkills.MagicalSkills.ToList();
            AttackType = 2;
        }

        private void SelfButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            SkillList.DataSource = mainPlayer.EntitySkills.SelfSkills.ToList();
            AttackType = 3;
        }

        private void SkillList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void SkillList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SkillList.SelectedItem != null)
            {
                Checker = true;
                Console.WriteLine("Test");
            }
        }

        private void SelectSkillButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (SkillList.SelectedItem != null)
            {
                Checker = true;
                playerChosen.SkillName = ((Abilities)SkillList.SelectedItem).SkillName;
                playerChosen.SkillCost = ((Abilities)SkillList.SelectedItem).SkillCost;
                playerChosen.SkillAccuracy = ((Abilities)SkillList.SelectedItem).SkillAccuracy;
                playerChosen.SkillPower = ((Abilities)SkillList.SelectedItem).SkillPower;
                Close();
            }
        }
    }
}
