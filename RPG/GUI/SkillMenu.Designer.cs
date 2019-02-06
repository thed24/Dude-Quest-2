namespace RPG.GUI
{
    partial class SkillMenu
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
            this.PhysicalButton = new System.Windows.Forms.Button();
            this.MagicalButton = new System.Windows.Forms.Button();
            this.SelfButton = new System.Windows.Forms.Button();
            this.SkillList = new System.Windows.Forms.ListBox();
            this.SelectSkillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhysicalButton
            // 
            this.PhysicalButton.Location = new System.Drawing.Point(12, 12);
            this.PhysicalButton.Name = "PhysicalButton";
            this.PhysicalButton.Size = new System.Drawing.Size(164, 66);
            this.PhysicalButton.TabIndex = 0;
            this.PhysicalButton.Text = "Physical Skills";
            this.PhysicalButton.UseVisualStyleBackColor = true;
            this.PhysicalButton.Click += new System.EventHandler(this.PhysicalButton_Click);
            // 
            // MagicalButton
            // 
            this.MagicalButton.Location = new System.Drawing.Point(12, 100);
            this.MagicalButton.Name = "MagicalButton";
            this.MagicalButton.Size = new System.Drawing.Size(164, 65);
            this.MagicalButton.TabIndex = 1;
            this.MagicalButton.Text = "Magic Skills";
            this.MagicalButton.UseVisualStyleBackColor = true;
            this.MagicalButton.Click += new System.EventHandler(this.MagicalButton_Click);
            // 
            // SelfButton
            // 
            this.SelfButton.Location = new System.Drawing.Point(12, 187);
            this.SelfButton.Name = "SelfButton";
            this.SelfButton.Size = new System.Drawing.Size(164, 63);
            this.SelfButton.TabIndex = 2;
            this.SelfButton.Text = "Self Skills";
            this.SelfButton.UseVisualStyleBackColor = true;
            this.SelfButton.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // SkillList
            // 
            this.SkillList.FormattingEnabled = true;
            this.SkillList.Location = new System.Drawing.Point(193, 103);
            this.SkillList.Name = "SkillList";
            this.SkillList.Size = new System.Drawing.Size(281, 147);
            this.SkillList.TabIndex = 3;
            this.SkillList.SelectedIndexChanged += new System.EventHandler(this.SkillList_SelectedIndexChanged);
            // 
            // SelectSkillButton
            // 
            this.SelectSkillButton.Location = new System.Drawing.Point(193, 12);
            this.SelectSkillButton.Name = "SelectSkillButton";
            this.SelectSkillButton.Size = new System.Drawing.Size(281, 66);
            this.SelectSkillButton.TabIndex = 4;
            this.SelectSkillButton.Text = "Select Skill Button";
            this.SelectSkillButton.UseVisualStyleBackColor = true;
            this.SelectSkillButton.Click += new System.EventHandler(this.SelectSkillButton_Click);
            // 
            // SkillMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 265);
            this.Controls.Add(this.SelectSkillButton);
            this.Controls.Add(this.SkillList);
            this.Controls.Add(this.SelfButton);
            this.Controls.Add(this.MagicalButton);
            this.Controls.Add(this.PhysicalButton);
            this.Name = "SkillMenu";
            this.Text = "SkillMenu";
            this.Load += new System.EventHandler(this.SkillMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PhysicalButton;
        private System.Windows.Forms.Button MagicalButton;
        private System.Windows.Forms.Button SelfButton;
        private System.Windows.Forms.ListBox SkillList;
        private System.Windows.Forms.Button SelectSkillButton;
    }
}