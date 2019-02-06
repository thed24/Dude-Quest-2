namespace RPG.GUI
{
    partial class PlayerInventory
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
            this.ItemList = new System.Windows.Forms.ListView();
            this.EquipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.Location = new System.Drawing.Point(12, 12);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(481, 261);
            this.ItemList.TabIndex = 0;
            this.ItemList.UseCompatibleStateImageBehavior = false;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // EquipBtn
            // 
            this.EquipBtn.Location = new System.Drawing.Point(12, 279);
            this.EquipBtn.Name = "EquipBtn";
            this.EquipBtn.Size = new System.Drawing.Size(481, 49);
            this.EquipBtn.TabIndex = 1;
            this.EquipBtn.Text = "Equip";
            this.EquipBtn.UseVisualStyleBackColor = true;
            this.EquipBtn.Click += new System.EventHandler(this.EquipBtn_Click);
            // 
            // PlayerInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 339);
            this.Controls.Add(this.EquipBtn);
            this.Controls.Add(this.ItemList);
            this.Name = "PlayerInventory";
            this.Text = "PlayerInventory";
            this.Load += new System.EventHandler(this.Player_Inventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ItemList;
        private System.Windows.Forms.Button EquipBtn;
    }
}