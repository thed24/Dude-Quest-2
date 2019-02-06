namespace RPG.GUI
{
    partial class Gameover
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
            this.GameoverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameoverButton
            // 
            this.GameoverButton.Location = new System.Drawing.Point(12, 12);
            this.GameoverButton.Name = "GameoverButton";
            this.GameoverButton.Size = new System.Drawing.Size(216, 65);
            this.GameoverButton.TabIndex = 0;
            this.GameoverButton.Text = "Gameover";
            this.GameoverButton.UseVisualStyleBackColor = true;
            this.GameoverButton.Click += new System.EventHandler(this.GameoverButton_Click);
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 90);
            this.Controls.Add(this.GameoverButton);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameoverButton;
    }
}