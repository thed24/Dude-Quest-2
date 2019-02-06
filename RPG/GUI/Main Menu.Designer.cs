namespace RPG.GUI
{
    partial class Main_Menu
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.loadGameBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(12, 319);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(283, 119);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // loadGameBtn
            // 
            this.loadGameBtn.Location = new System.Drawing.Point(317, 319);
            this.loadGameBtn.Name = "loadGameBtn";
            this.loadGameBtn.Size = new System.Drawing.Size(283, 119);
            this.loadGameBtn.TabIndex = 1;
            this.loadGameBtn.Text = "Load Game";
            this.loadGameBtn.UseVisualStyleBackColor = true;
            this.loadGameBtn.Click += new System.EventHandler(this.loadGameBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG.Properties.Resources.TitleScreen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 285);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadGameBtn);
            this.Controls.Add(this.newGameBtn);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button loadGameBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}