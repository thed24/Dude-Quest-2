namespace RPG.GUI
{
    partial class Main_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInterface = new System.Windows.Forms.GroupBox();
            this.InventoryBtn = new System.Windows.Forms.Button();
            this.OkayBtn = new System.Windows.Forms.Button();
            this.TurnStartButton = new System.Windows.Forms.Button();
            this.SkillButton = new System.Windows.Forms.Button();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wisLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.chaLabel = new System.Windows.Forms.Label();
            this.playerGoldLabel = new System.Windows.Forms.Label();
            this.playerMPLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.GameScreen = new System.Windows.Forms.PictureBox();
            this.ExpBar = new System.Windows.Forms.ProgressBar();
            this.GameOuputLabel = new System.Windows.Forms.Label();
            this.UserInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInterface
            // 
            this.UserInterface.Controls.Add(this.InventoryBtn);
            this.UserInterface.Controls.Add(this.OkayBtn);
            this.UserInterface.Controls.Add(this.TurnStartButton);
            this.UserInterface.Controls.Add(this.SkillButton);
            this.UserInterface.Controls.Add(this.avatarPicture);
            this.UserInterface.Controls.Add(this.button1);
            this.UserInterface.Controls.Add(this.wisLabel);
            this.UserInterface.Controls.Add(this.conLabel);
            this.UserInterface.Controls.Add(this.dexLabel);
            this.UserInterface.Controls.Add(this.strLabel);
            this.UserInterface.Controls.Add(this.intLabel);
            this.UserInterface.Controls.Add(this.chaLabel);
            this.UserInterface.Controls.Add(this.playerGoldLabel);
            this.UserInterface.Controls.Add(this.playerMPLabel);
            this.UserInterface.Controls.Add(this.playerHPLabel);
            this.UserInterface.Location = new System.Drawing.Point(12, 338);
            this.UserInterface.Name = "UserInterface";
            this.UserInterface.Size = new System.Drawing.Size(776, 100);
            this.UserInterface.TabIndex = 0;
            this.UserInterface.TabStop = false;
            this.UserInterface.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Location = new System.Drawing.Point(437, 16);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(40, 75);
            this.InventoryBtn.TabIndex = 14;
            this.InventoryBtn.Text = "Bag";
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // OkayBtn
            // 
            this.OkayBtn.Location = new System.Drawing.Point(320, 16);
            this.OkayBtn.Name = "OkayBtn";
            this.OkayBtn.Size = new System.Drawing.Size(111, 75);
            this.OkayBtn.TabIndex = 13;
            this.OkayBtn.Text = "Okay";
            this.OkayBtn.UseVisualStyleBackColor = true;
            this.OkayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // TurnStartButton
            // 
            this.TurnStartButton.Location = new System.Drawing.Point(320, 16);
            this.TurnStartButton.Name = "TurnStartButton";
            this.TurnStartButton.Size = new System.Drawing.Size(111, 75);
            this.TurnStartButton.TabIndex = 12;
            this.TurnStartButton.Text = "Start Turn";
            this.TurnStartButton.UseVisualStyleBackColor = true;
            this.TurnStartButton.Visible = false;
            this.TurnStartButton.Click += new System.EventHandler(this.TurnStartButton_Click);
            // 
            // SkillButton
            // 
            this.SkillButton.Location = new System.Drawing.Point(274, 16);
            this.SkillButton.Name = "SkillButton";
            this.SkillButton.Size = new System.Drawing.Size(40, 75);
            this.SkillButton.TabIndex = 10;
            this.SkillButton.Text = "Skill";
            this.SkillButton.UseVisualStyleBackColor = true;
            this.SkillButton.Visible = false;
            this.SkillButton.Click += new System.EventHandler(this.SkillButton_Click);
            // 
            // avatarPicture
            // 
            this.avatarPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarPicture.Location = new System.Drawing.Point(6, 16);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(100, 75);
            this.avatarPicture.TabIndex = 2;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wisLabel
            // 
            this.wisLabel.AutoSize = true;
            this.wisLabel.Location = new System.Drawing.Point(681, 74);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(48, 13);
            this.wisLabel.TabIndex = 9;
            this.wisLabel.Text = "Wisdom:";
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Location = new System.Drawing.Point(681, 47);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(65, 13);
            this.conLabel.TabIndex = 8;
            this.conLabel.Text = "Constitution:";
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(681, 22);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(54, 13);
            this.dexLabel.TabIndex = 7;
            this.dexLabel.Text = "Dexterity: ";
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(571, 74);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(53, 13);
            this.strLabel.TabIndex = 6;
            this.strLabel.Text = "Strength: ";
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(571, 47);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(64, 13);
            this.intLabel.TabIndex = 5;
            this.intLabel.Text = "Intelligence:";
            // 
            // chaLabel
            // 
            this.chaLabel.AutoSize = true;
            this.chaLabel.Location = new System.Drawing.Point(571, 22);
            this.chaLabel.Name = "chaLabel";
            this.chaLabel.Size = new System.Drawing.Size(53, 13);
            this.chaLabel.TabIndex = 4;
            this.chaLabel.Text = "Charisma:";
            // 
            // playerGoldLabel
            // 
            this.playerGoldLabel.AutoSize = true;
            this.playerGoldLabel.Location = new System.Drawing.Point(122, 74);
            this.playerGoldLabel.Name = "playerGoldLabel";
            this.playerGoldLabel.Size = new System.Drawing.Size(35, 13);
            this.playerGoldLabel.TabIndex = 3;
            this.playerGoldLabel.Text = "Gold: ";
            // 
            // playerMPLabel
            // 
            this.playerMPLabel.AutoSize = true;
            this.playerMPLabel.Location = new System.Drawing.Point(123, 47);
            this.playerMPLabel.Name = "playerMPLabel";
            this.playerMPLabel.Size = new System.Drawing.Size(29, 13);
            this.playerMPLabel.TabIndex = 2;
            this.playerMPLabel.Text = "MP: ";
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.AutoSize = true;
            this.playerHPLabel.Location = new System.Drawing.Point(123, 22);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(28, 13);
            this.playerHPLabel.TabIndex = 1;
            this.playerHPLabel.Text = "HP: ";
            // 
            // GameScreen
            // 
            this.GameScreen.Location = new System.Drawing.Point(12, 12);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(776, 320);
            this.GameScreen.TabIndex = 1;
            this.GameScreen.TabStop = false;
            this.GameScreen.Click += new System.EventHandler(this.GameScreen_Click);
            // 
            // ExpBar
            // 
            this.ExpBar.Location = new System.Drawing.Point(12, 444);
            this.ExpBar.Name = "ExpBar";
            this.ExpBar.Size = new System.Drawing.Size(776, 23);
            this.ExpBar.TabIndex = 2;
            this.ExpBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // GameOuputLabel
            // 
            this.GameOuputLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.GameOuputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameOuputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameOuputLabel.Location = new System.Drawing.Point(29, 265);
            this.GameOuputLabel.Name = "GameOuputLabel";
            this.GameOuputLabel.Size = new System.Drawing.Size(743, 56);
            this.GameOuputLabel.TabIndex = 3;
            // 
            // Main_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.GameOuputLabel);
            this.Controls.Add(this.ExpBar);
            this.Controls.Add(this.GameScreen);
            this.Controls.Add(this.UserInterface);
            this.Name = "Main_Game";
            this.Text = "Main_Game";
            this.Load += new System.EventHandler(this.Main_Game_Load);
            this.UserInterface.ResumeLayout(false);
            this.UserInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInterface;
        private System.Windows.Forms.Label wisLabel;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label chaLabel;
        private System.Windows.Forms.Label playerGoldLabel;
        private System.Windows.Forms.Label playerMPLabel;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.PictureBox GameScreen;
        private System.Windows.Forms.PictureBox avatarPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SkillButton;
        private System.Windows.Forms.Button TurnStartButton;
        private System.Windows.Forms.ProgressBar ExpBar;
        private System.Windows.Forms.Label GameOuputLabel;
        private System.Windows.Forms.Button OkayBtn;
        private System.Windows.Forms.Button InventoryBtn;
    }
}