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
using SpriteLibrary;
using System.Reflection;

namespace RPG.GUI
{
    public partial class Main_Game : Form
    {
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);
        public Random random = new Random();
        public Abilities PlayerChosen;
        public Abilities EnemyChosen;
        public Player MainPlayer;
        public Bandit EnemyBandit;
        public Slime EnemySlime;
        public Merchant EventMerchant;
        public SpriteController MySpriteController;
        public bool AttackPrompt = false;
        public bool EnemyType;
        public bool Continue = false;
        public int AttackType;
        public bool EnemyAttackType = false;
        public int MaxHP;
        Sprite MainPlayerSprite;
        Sprite EnemySprite;

        public void RefreshAllLabels()
        {
            intLabel.Text = "Intelligence: " + MainPlayer.EntityStats.charInt.ToString();
            strLabel.Text = "Strength: " + MainPlayer.EntityStats.charStr.ToString();
            wisLabel.Text = "Wisdom: " + MainPlayer.EntityStats.charWis.ToString();
            conLabel.Text = "Constitution: " + MainPlayer.EntityStats.charCon.ToString();
            dexLabel.Text = "Dexterity: " + MainPlayer.EntityStats.charDex.ToString();
            chaLabel.Text = "Charisma: " + MainPlayer.EntityStats.charChr.ToString();
            playerGoldLabel.Text = "Gold: " + MainPlayer.PlayerGold.ToString();
            playerHPLabel.Text = "HP: " + MainPlayer.EntityStats.charHP.ToString();
            playerMPLabel.Text = "MP: " + MainPlayer.EntityStats.charMP.ToString();
            ExpBar.Value = MainPlayer.PlayerExp;
        }

        public Main_Game(Player inheritPlayer)
        {
            InitializeComponent();
            MainPlayer = inheritPlayer;
            UserInterface.Text = MainPlayer.EntityName;
            intLabel.Text = "Intelligence: " + MainPlayer.EntityStats.charInt.ToString();
            strLabel.Text = "Strength: " + MainPlayer.EntityStats.charStr.ToString();
            wisLabel.Text = "Wisdom: " + MainPlayer.EntityStats.charWis.ToString();
            conLabel.Text = "Constitution: " + MainPlayer.EntityStats.charCon.ToString();
            dexLabel.Text = "Dexterity: " + MainPlayer.EntityStats.charDex.ToString();
            chaLabel.Text = "Charisma: " + MainPlayer.EntityStats.charChr.ToString();
            playerGoldLabel.Text = "Gold: " + MainPlayer.PlayerGold.ToString();
            playerHPLabel.Text = "HP: " + MainPlayer.EntityStats.charHP.ToString();
            playerMPLabel.Text = "MP: " + MainPlayer.EntityStats.charMP.ToString();
            ExpBar.Maximum = MainPlayer.generateLevelRequirement();
            OkayBtn.Visible = false;

            GameScreen.BackgroundImage = new Bitmap(Properties.Resources.FFIV);
            GameScreen.BackgroundImageLayout = ImageLayout.Stretch;
            MySpriteController = new SpriteController(GameScreen);
            if (MainPlayer.PlayerGender == true)
            {
                Bitmap CloudAv = Properties.Resources.CloudPortrait;
                Image oImage = Properties.Resources.CloudIdle;
                avatarPicture.Image = CloudAv;
                avatarPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                MainPlayerSprite = new Sprite(new Point(0, 0), MySpriteController, oImage, 106, 73, 200, 6);
                MainPlayerSprite.AddAnimation(new Point(0, 0), Properties.Resources.CloudAttack, 163, 125, 200, 12);
                MainPlayerSprite.AddAnimation(new Point(0, 0), Properties.Resources.CloudMagic, 97, 77, 200, 4);
                MainPlayerSprite.AddAnimation(Properties.Resources.CloudDead);
                MainPlayerSprite.SpriteAnimationComplete += AttackComplete;
                MainPlayerSprite.SetName("Cloud");
                MainPlayerSprite.PutBaseImageLocation(new Point(126, 217));
                MainPlayerSprite.SetSize(new Size(200, 250));
            }
            else
            {
                Bitmap TifaAv = Properties.Resources.TifaPortrait;
                Image oImage = Properties.Resources.TifaIdle;
                avatarPicture.Image = TifaAv;
                avatarPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                MainPlayerSprite = new Sprite(new Point(0, 0), MySpriteController, oImage, 71, 67, 200, 4);
                MainPlayerSprite.AddAnimation(new Point(0, 0), Properties.Resources.TifaAttack, 105, 98, 200, 12);
                MainPlayerSprite.AddAnimation(new Point(0, 0), Properties.Resources.TifaMagic, 63, 60, 200, 4);
                MainPlayerSprite.AddAnimation(Properties.Resources.TifaDead);
                MainPlayerSprite.SpriteAnimationComplete += AttackComplete;
                MainPlayerSprite.SetName("Tifa");
                MainPlayerSprite.PutBaseImageLocation(new Point(126, 217));
                MainPlayerSprite.SetSize(new Size(200, 250));
            }
        }

        public void AttackComplete(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.ChangeAnimation(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GameScreen_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Console.WriteLine(coordinates);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("Saves");
            string CurDirect = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            PlayerSaveLoad.WriteToBinaryFile<Player>(CurDirect + @"\Saves\" + MainPlayer.EntityName + ".txt", MainPlayer);
        }

        private void Battle()
        {
            if (EnemyType == false)
            {
                int previousHPPlayer = MainPlayer.EntityStats.charHP;
                int previousEnemyHP = EnemyBandit.EntityStats.charHP;
                EnemyChosen = EnemyBandit.EntitySkills.PhysicalSkills[random.Next(0, EnemyBandit.EntitySkills.PhysicalSkills.Count)];
                int TurnLocker = 0;
                //If player dex is higher, player attacks first
                if ((MainPlayer.EntityStats.charDex > EnemyBandit.EntityStats.charDex) && (TurnLocker == 0))
                {
                    if (random.Next(0, 101) < PlayerChosen.SkillAccuracy)
                    {
                        if (AttackType == 1)
                        {
                            MainPlayerSprite.AnimateOnce(1);
                            EnemyBandit.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemyBandit.EntityStats.charHP) + " to " + EnemyBandit.EntityName + " leaving them on " + EnemyBandit.EntityStats.charHP;
                        }

                        if (AttackType == 2)
                        {
                            Console.WriteLine(PlayerChosen.SkillCost);
                            Console.WriteLine(MainPlayer.EntityStats.charMP);
                            if (PlayerChosen.SkillCost <= MainPlayer.EntityStats.charMP)
                            {
                                MainPlayerSprite.AnimateOnce(2);
                                EnemyBandit.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                                GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemyBandit.EntityStats.charHP) + " to " + EnemyBandit.EntityName + " leaving them on " + EnemyBandit.EntityStats.charHP;
                                MainPlayer.EntityStats.charMP -= PlayerChosen.SkillCost;
                            }
                            else GameOuputLabel.Text = MainPlayer.EntityName + " does not have the MP to cast that spell!";
                        }

                        if (AttackType == 3)
                        {
                            MainPlayerSprite.AnimateOnce(2);
                            MainPlayer.EntityStats.charHP += (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and healed " + (MainPlayer.EntityStats.charHP - previousHPPlayer) + " restoring them to " + MainPlayer.EntityStats.charHP;
                            previousHPPlayer = MainPlayer.EntityStats.charHP;
                        }
                        if (EnemyBandit.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + MainPlayer.EntityName + " has defeated " + EnemyBandit.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text = MainPlayer.EntityName + " missed!"; }
                    TurnLocker = 1;
                }
                if ((MainPlayer.EntityStats.charDex > EnemyBandit.EntityStats.charDex) && (TurnLocker == 1))
                {
                    if (random.Next(0, 101) < EnemyChosen.SkillAccuracy)
                    {
                        EnemySprite.AnimateOnce(1);
                        MainPlayer.EntityStats.charHP -= ((EnemyBandit.GenerateDamage() * EnemyChosen.SkillPower) / 10) - MainPlayer.GenerateMigitation();
                        GameOuputLabel.Text += "\n" + EnemyBandit.EntityName + " has used " + EnemyChosen.SkillName + " and dealt " + (previousHPPlayer - MainPlayer.EntityStats.charHP) + " to " + MainPlayer.EntityName + " leaving them on " + MainPlayer.EntityStats.charHP;
                        if (MainPlayer.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + EnemyBandit.EntityName + " has defeated " + MainPlayer.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text += "\n" + EnemyBandit.EntityName + " missed!"; }
                }
                //If enemy dex is higher, enemy attacks first
                if ((EnemyBandit.EntityStats.charDex > MainPlayer.EntityStats.charDex) && (TurnLocker == 0))
                {
                    if (random.Next(0, 101) < EnemyChosen.SkillAccuracy)
                    {
                        EnemySprite.AnimateOnce(1);
                        MainPlayer.EntityStats.charHP -= ((EnemyBandit.GenerateDamage() * EnemyChosen.SkillPower) / 10) - MainPlayer.GenerateMigitation();
                        GameOuputLabel.Text = EnemyBandit.EntityName + " has used " + EnemyChosen.SkillName + " and dealt " + (previousHPPlayer - MainPlayer.EntityStats.charHP) + " to " + MainPlayer.EntityName + " leaving them on " + MainPlayer.EntityStats.charHP;
                        if (MainPlayer.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + EnemyBandit.EntityName + " has defeated " + MainPlayer.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text = EnemyBandit.EntityName + " missed!"; }
                    TurnLocker = 1;
                }
                if ((EnemyBandit.EntityStats.charDex > MainPlayer.EntityStats.charDex) && (TurnLocker == 1))
                {
                    if (random.Next(0, 101) < PlayerChosen.SkillAccuracy)
                    {
                        if (AttackType == 1)
                        {
                            MainPlayerSprite.AnimateOnce(1);
                            EnemyBandit.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemyBandit.EntityStats.charHP) + " to " + EnemyBandit.EntityName + " leaving them on " + EnemyBandit.EntityStats.charHP;
                        }
                        if (AttackType == 2)
                        {
                            if (PlayerChosen.SkillCost <= MainPlayer.EntityStats.charMP)
                            {
                                MainPlayerSprite.AnimateOnce(2);
                                EnemyBandit.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                                GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemyBandit.EntityStats.charHP) + " to " + EnemyBandit.EntityName + " leaving them on " + EnemyBandit.EntityStats.charHP;
                                MainPlayer.EntityStats.charMP -= PlayerChosen.SkillCost;
                            }
                            else GameOuputLabel.Text = MainPlayer.EntityName + " does not have the MP to cast that spell!";
                    }
                        if (AttackType == 3)
                        {
                            MainPlayerSprite.AnimateOnce(2);
                            MainPlayer.EntityStats.charHP += (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and healed " + (MainPlayer.EntityStats.charHP - previousHPPlayer) + " restoring them to " + MainPlayer.EntityStats.charHP;
                            previousHPPlayer = MainPlayer.EntityStats.charHP;
                        }
                        if (EnemyBandit.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + MainPlayer.EntityName + " has defeated " + EnemyBandit.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text += "\n" + MainPlayer.EntityName + " missed!"; }
                }
            }
            if (EnemyType == true)
            {
                int previousHPPlayer = MainPlayer.EntityStats.charHP;
                int previousEnemyHP = EnemySlime.EntityStats.charHP;
                EnemyChosen = EnemySlime.EntitySkills.MagicalSkills[random.Next(0, EnemySlime.EntitySkills.MagicalSkills.Count)];
                int TurnLocker = 0;
                //If player dex is higher, player attacks first
                if ((MainPlayer.EntityStats.charDex > EnemySlime.EntityStats.charDex) && (TurnLocker == 0))
                {
                    if (random.Next(0, 101) < PlayerChosen.SkillAccuracy)
                    {
                        if (AttackType == 1)
                        {
                            MainPlayerSprite.AnimateOnce(1);
                            EnemySlime.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemySlime.EntityStats.charHP) + " to " + EnemySlime.EntityName + " leaving them on " + EnemySlime.EntityStats.charHP;
                        }
                        if (AttackType == 2)
                        {
                            if (PlayerChosen.SkillCost <= MainPlayer.EntityStats.charMP)
                            {
                                MainPlayerSprite.AnimateOnce(2);
                                EnemySlime.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                                GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemySlime.EntityStats.charHP) + " to " + EnemySlime.EntityName + " leaving them on " + EnemySlime.EntityStats.charHP;
                                MainPlayer.EntityStats.charMP -= PlayerChosen.SkillCost;
                            }
                            else GameOuputLabel.Text = MainPlayer.EntityName + " does not have the MP to cast that spell!";
                        }
                        if (AttackType == 3)
                        {
                            MainPlayerSprite.AnimateOnce(2);
                            MainPlayer.EntityStats.charHP += (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and healed " + (MainPlayer.EntityStats.charHP - previousHPPlayer) + " restoring them to " + MainPlayer.EntityStats.charHP;
                            previousHPPlayer = MainPlayer.EntityStats.charHP;
                        }
                        if (EnemySlime.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + MainPlayer.EntityName + " has defeated " + EnemySlime.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text = MainPlayer.EntityName + " missed!"; }
                    TurnLocker = 1;
                }
                if ((MainPlayer.EntityStats.charDex > EnemySlime.EntityStats.charDex) && (TurnLocker == 1))
                {
                    if (random.Next(0, 101) < EnemyChosen.SkillAccuracy)
                    {
                        EnemySprite.AnimateOnce(2);
                        MainPlayer.EntityStats.charHP -= (EnemySlime.GenerateDamage() * EnemyChosen.SkillPower) / 10;
                        GameOuputLabel.Text += "\n" + EnemySlime.EntityName + " has used " + EnemyChosen.SkillName + " and dealt " + (previousHPPlayer - MainPlayer.EntityStats.charHP) + " to " + MainPlayer.EntityName + " leaving them on " + MainPlayer.EntityStats.charHP;
                        if (MainPlayer.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + EnemySlime.EntityName + " has defeated " + MainPlayer.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text += "\n" + EnemySlime.EntityName + " missed!"; }
                }
                //If enemy dex is higher, enemy attacks first
                if ((EnemySlime.EntityStats.charDex > MainPlayer.EntityStats.charDex) && (TurnLocker == 0))
                {
                    if (random.Next(0, 101) < EnemyChosen.SkillAccuracy)
                    {
                        EnemySprite.AnimateOnce(2);
                        MainPlayer.EntityStats.charHP -= (EnemySlime.GenerateDamage() * EnemyChosen.SkillPower) / 10;
                        GameOuputLabel.Text = EnemySlime.EntityName + " has used " + EnemyChosen.SkillName + " and dealt " + (previousHPPlayer - MainPlayer.EntityStats.charHP) + " to " + MainPlayer.EntityName + " leaving them on " + MainPlayer.EntityStats.charHP;
                        if (EnemySlime.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + EnemySlime.EntityName + " has defeated " + MainPlayer.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text = EnemySlime.EntityName + " missed!"; }
                    TurnLocker = 1;
                }
                if ((EnemySlime.EntityStats.charDex > MainPlayer.EntityStats.charDex) && (TurnLocker == 1))
                {
                    if (random.Next(0, 101) < PlayerChosen.SkillAccuracy)
                    {
                        if (AttackType == 1)
                        {
                            MainPlayerSprite.AnimateOnce(1);
                            EnemySlime.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemySlime.EntityStats.charHP) + " to " + EnemySlime.EntityName + " leaving them on " + EnemySlime.EntityStats.charHP;
                        }
                        if (AttackType == 2)
                        {
                            if (PlayerChosen.SkillCost <= MainPlayer.EntityStats.charMP)
                            {
                                MainPlayerSprite.AnimateOnce(2);
                                EnemySlime.EntityStats.charHP -= (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                                GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and dealt " + (previousEnemyHP - EnemySlime.EntityStats.charHP) + " to " + EnemySlime.EntityName + " leaving them on " + EnemySlime.EntityStats.charHP;
                                MainPlayer.EntityStats.charMP -= PlayerChosen.SkillCost;
                            }
                            else GameOuputLabel.Text = MainPlayer.EntityName + " does not have the MP to cast that spell!";
                        }
                        if (AttackType == 3)
                        {
                            MainPlayerSprite.AnimateOnce(2);
                            MainPlayer.EntityStats.charHP += (MainPlayer.GenerateDamage() * PlayerChosen.SkillPower) / 10;
                            GameOuputLabel.Text = MainPlayer.EntityName + " has used " + PlayerChosen.SkillName + " and healed " + (MainPlayer.EntityStats.charHP - previousHPPlayer) + " restoring them to " + MainPlayer.EntityStats.charHP;
                            previousHPPlayer = MainPlayer.EntityStats.charHP;
                        }
                        if (MainPlayer.EntityStats.charHP <= 0)
                        {
                            GameOuputLabel.Text += "\n" + EnemySlime.EntityName + " has defeated " + MainPlayer.EntityName;
                            TurnLocker = 2;
                        }
                    }
                    else { GameOuputLabel.Text += MainPlayer.EntityName + " missed!"; }
                }
            }
            AttackPrompt = false;
            PlayerChosen = default(Abilities);
            EnemyChosen = default(Abilities);
            RefreshAllLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test.Play();
            int BattleType = random.Next(1, 3);
            int Choice = random.Next(1, 4);
            Console.WriteLine(Choice);
            if (Choice == 1)
            {
                MaxHP = MainPlayer.EntityStats.charHP;
                EnemyType = false;
                TurnStartButton.Visible = true;
                SkillButton.Visible = true;
                if (BattleType == 1)
                {
                    EnemyBandit = new Bandit();
                    EnemyBandit.GenerateName();
                    GameOuputLabel.Text = "You have encountered the bandit " + EnemyBandit.EntityName;
                    EnemyBandit.GenerateSkills();
                    EnemyBandit.GenerateStats();
                    EnemyBandit.GenerateArmor();
                    EnemyBandit.GenerateWeapon();
                    EnemyBandit.EntityLevel = MainPlayer.EntityLevel;
                    if (EnemyBandit.EntityStats.charDex == MainPlayer.EntityStats.charDex)
                    {
                        EnemyBandit.EntityStats.charDex += -1;
                    }
                    Image oImage = Properties.Resources.BanditIdle;
                    EnemySprite = new Sprite(new Point(0, 0), MySpriteController, oImage, 75, 70, 300, 4);
                    EnemySprite.AddAnimation(new Point(0, 0), Properties.Resources.BanditAttack, 161, 116, 300, 9);
                    EnemySprite.AddAnimation(Properties.Resources.BanditDead);
                    EnemySprite.SpriteAnimationComplete += AttackComplete;
                    EnemySprite.SetName("Bandit");
                    EnemySprite.PutBaseImageLocation(new Point(575, 217));
                    EnemySprite.SetSize(new Size(200, 250));
                }
                if (BattleType == 2)
                {
                    EnemyType = true;
                    EnemySlime = new Slime();
                    EnemySlime.GenerateName();
                    GameOuputLabel.Text = "You have encountered the slime " + EnemySlime.EntityName;
                    EnemySlime.GenerateSkills();
                    EnemySlime.GenerateStats();
                    EnemySlime.GenerateArmor();
                    EnemySlime.GenerateWeapon();
                    EnemySlime.EntityLevel = MainPlayer.EntityLevel;
                    if (EnemySlime.EntityStats.charDex == MainPlayer.EntityStats.charDex)
                    {
                        EnemySlime.EntityStats.charDex += -1;
                    }
                    Image oImage = Properties.Resources.SlimeIdle;
                    EnemySprite = new Sprite(new Point(0, 0), MySpriteController, oImage, 74, 51, 300, 4);
                    EnemySprite.AddAnimation(new Point(0, 0), Properties.Resources.SlimeAttack, 148, 82, 300, 16);
                    EnemySprite.AddAnimation(new Point(0, 0), Properties.Resources.SlimeMagic, 80, 59, 300, 4);
                    EnemySprite.AddAnimation(Properties.Resources.SlimeDead);
                    EnemySprite.SpriteAnimationComplete += AttackComplete;
                    EnemySprite.SetName("Slime");
                    EnemySprite.PutBaseImageLocation(new Point(575, 217));
                    EnemySprite.SetSize(new Size(200, 250));
                }
            }
            if (Choice == 2)
            {
                EventMerchant = new Merchant();
                EventMerchant.GenerateSaleList();
                EventMerchant.NamePimper();
                GameOuputLabel.Text = "You have encountered a merchant! Here is what they have for sale!";
                MerchantInventory Shops = new MerchantInventory(EventMerchant.WeaponInventory, EventMerchant.ArmorInventory, MainPlayer);

                Shops.ShowDialog();
                if (Shops.TruePurchasedWeapon != null)
                {
                    MainPlayer.WeaponInventory.Add(Shops.TruePurchasedWeapon);
                }
                if (Shops.TruePurchasedArmor != null)
                {
                    MainPlayer.ArmorInventory.Add(Shops.TruePurchasedArmor);
                }
                if (Shops.ErrorMessage != null)
                {
                    GameOuputLabel.Text = Shops.ErrorMessage;
                }
                MainPlayer.PlayerGold = Shops.MainPlayer.PlayerGold;
                RefreshAllLabels();
            }

            if (Choice == 3)
            {
                GameOuputLabel.Text = "You wandered for hours and found nothing!";
            }
        }

        private void Main_Game_Load(object sender, EventArgs e)
        {

        }

        private void SkillButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            SkillMenu SkillForm = new SkillMenu(MainPlayer);
            SkillForm.ShowDialog();
            PlayerChosen = SkillForm.ChosenSkill;
            AttackPrompt = SkillForm.AttackPrompt;
            AttackType = SkillForm.AnimType;
        }

        private void TurnStartButton_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (AttackPrompt == true)
            {
                if (MainPlayer.EntityStats.charHP > 0 || EnemyBandit.EntityStats.charHP > 0)
                {
                    Battle();
                }
                if (MainPlayer.EntityStats.charHP <= 0)
                {
                    TurnStartButton.Visible = false;
                    SkillButton.Visible = false;
                    TurnStartButton.Visible = false;
                    OkayBtn.Visible = true;
                    MainPlayerSprite.ChangeAnimation(3);
                    OkayBtn.Text = "Game Over!";
                }
                if (EnemyType == false)
                {
                    if ((MainPlayer.EntityStats.charHP <= 0) && (EnemyBandit.EntityStats.charHP <= 0))
                    {
                        TurnStartButton.Visible = false;
                        SkillButton.Visible = false;
                        TurnStartButton.Visible = false;
                        OkayBtn.Visible = true;
                        MainPlayerSprite.ChangeAnimation(3);
                        EnemySprite.ChangeAnimation(2);
                        OkayBtn.Text = "Game Over!";
                    }

                    if (EnemyBandit.EntityStats.charHP <= 0)
                    {
                        TurnStartButton.Visible = false;
                        SkillButton.Visible = false;
                        TurnStartButton.Visible = false;
                        OkayBtn.Visible = true;
                        EnemySprite.ChangeAnimation(2);
                        int gold = EnemyBandit.GenerateEXP();
                        int xp = EnemyBandit.GenerateGold();
                        MainPlayer.PlayerExp += xp;
                        MainPlayer.PlayerGold += gold;
                        GameOuputLabel.Text = MainPlayer.EntityName + " has gained " + xp + " experience, and " + gold + " gold! You have healed up to " + MaxHP + " !";
                        MainPlayer.LevelUp(MainPlayer.generateLevelRequirement());
                        ExpBar.Maximum = MainPlayer.generateLevelRequirement();
                        MainPlayer.EntityStats.charHP = MaxHP;
                        OkayBtn.Text = "You win!";                        
                        RefreshAllLabels();
                    }
                }
                else
                {
                    if ((MainPlayer.EntityStats.charHP <= 0) && (EnemySlime.EntityStats.charHP <= 0))
                    {
                        TurnStartButton.Visible = false;
                        SkillButton.Visible = false;
                        TurnStartButton.Visible = false;
                        OkayBtn.Visible = true;
                        MainPlayerSprite.ChangeAnimation(3);
                        EnemySprite.ChangeAnimation(3);
                        OkayBtn.Text = "Game Over!";
                    }

                    if (EnemySlime.EntityStats.charHP <= 0)
                    {
                        TurnStartButton.Visible = false;
                        SkillButton.Visible = false;
                        TurnStartButton.Visible = false;
                        OkayBtn.Visible = true;
                        EnemySprite.ChangeAnimation(3);
                        int gold = EnemySlime.GenerateEXP();
                        int xp = EnemySlime.GenerateGold();
                        MainPlayer.PlayerExp += xp;
                        MainPlayer.PlayerGold += gold;
                        GameOuputLabel.Text = MainPlayer.EntityName + " has gained " + xp + " experience, and " + gold + " gold! You have healed up to " + MaxHP + " !";
                        GameOuputLabel.Text += MainPlayer.LevelUp(MainPlayer.generateLevelRequirement());
                        ExpBar.Maximum = MainPlayer.generateLevelRequirement();
                        MainPlayer.EntityStats.charHP = MaxHP;
                        OkayBtn.Text = "You win!";
                        RefreshAllLabels();
                    }
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            Test.Play();
            Continue = true;
            if (MainPlayer.EntityStats.charHP <= 0)
            {
                MainPlayerSprite.Destroy();
                Close();
            }
            if (EnemySlime != null)
            {
                if (EnemySlime.EntityStats.charHP <= 0)
                {
                    EnemySprite.Destroy();
                    EnemySlime = new Slime();
                }
            }
            if (EnemyBandit != null)
            {
                if (EnemyBandit.EntityStats.charHP <= 0)
                {
                    EnemySprite.Destroy();
                    EnemyBandit = new Bandit();
                }
            }

            OkayBtn.Visible = false;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {

        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            Test.Play();
            PlayerInventory OpenInvetory = new PlayerInventory(MainPlayer);
            OpenInvetory.ShowDialog();
            MainPlayer = OpenInvetory.MainPlayer;
            GameOuputLabel.Text = "You are currently wearing " + MainPlayer.ArmorEquipped[0].Name + " and wielding " +
                                  MainPlayer.WeaponEquipped[0].Name;
        }
    }
}
