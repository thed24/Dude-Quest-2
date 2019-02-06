namespace GUI
{
    partial class Character_Creator
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
            this.strButton = new System.Windows.Forms.Button();
            this.intButton = new System.Windows.Forms.Button();
            this.conButton = new System.Windows.Forms.Button();
            this.dexButton = new System.Windows.Forms.Button();
            this.wisButton = new System.Windows.Forms.Button();
            this.chrButton = new System.Windows.Forms.Button();
            this.strLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strButton
            // 
            this.strButton.Location = new System.Drawing.Point(12, 12);
            this.strButton.Name = "strButton";
            this.strButton.Size = new System.Drawing.Size(124, 51);
            this.strButton.TabIndex = 0;
            this.strButton.Text = "Strength";
            this.strButton.UseVisualStyleBackColor = true;
            this.strButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // intButton
            // 
            this.intButton.Location = new System.Drawing.Point(12, 80);
            this.intButton.Name = "intButton";
            this.intButton.Size = new System.Drawing.Size(124, 51);
            this.intButton.TabIndex = 1;
            this.intButton.Text = "Intelligence";
            this.intButton.UseVisualStyleBackColor = true;
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(12, 151);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(124, 51);
            this.conButton.TabIndex = 2;
            this.conButton.Text = "Constitution";
            this.conButton.UseVisualStyleBackColor = true;
            // 
            // dexButton
            // 
            this.dexButton.Location = new System.Drawing.Point(12, 224);
            this.dexButton.Name = "dexButton";
            this.dexButton.Size = new System.Drawing.Size(124, 51);
            this.dexButton.TabIndex = 3;
            this.dexButton.Text = "Dexterity";
            this.dexButton.UseVisualStyleBackColor = true;
            // 
            // wisButton
            // 
            this.wisButton.Location = new System.Drawing.Point(12, 299);
            this.wisButton.Name = "wisButton";
            this.wisButton.Size = new System.Drawing.Size(124, 51);
            this.wisButton.TabIndex = 4;
            this.wisButton.Text = "Wisdom";
            this.wisButton.UseVisualStyleBackColor = true;
            // 
            // chrButton
            // 
            this.chrButton.Location = new System.Drawing.Point(12, 377);
            this.chrButton.Name = "chrButton";
            this.chrButton.Size = new System.Drawing.Size(124, 51);
            this.chrButton.TabIndex = 5;
            this.chrButton.Text = "Charisma";
            this.chrButton.UseVisualStyleBackColor = true;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(142, 12);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(0, 13);
            this.strLabel.TabIndex = 6;
            this.strLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 16;
            // 
            // Character_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.chrButton);
            this.Controls.Add(this.wisButton);
            this.Controls.Add(this.dexButton);
            this.Controls.Add(this.conButton);
            this.Controls.Add(this.intButton);
            this.Controls.Add(this.strButton);
            this.Name = "Character_Creator";
            this.Text = "Character_Creator";
            this.Load += new System.EventHandler(this.Character_Creator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strButton;
        private System.Windows.Forms.Button intButton;
        private System.Windows.Forms.Button conButton;
        private System.Windows.Forms.Button dexButton;
        private System.Windows.Forms.Button wisButton;
        private System.Windows.Forms.Button chrButton;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}