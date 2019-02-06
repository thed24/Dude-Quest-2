namespace RPG.GUI
{
    partial class MerchantInventory
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
            this.SellerList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SellerList
            // 
            this.SellerList.Location = new System.Drawing.Point(12, 12);
            this.SellerList.Name = "SellerList";
            this.SellerList.Size = new System.Drawing.Size(458, 94);
            this.SellerList.TabIndex = 0;
            this.SellerList.UseCompatibleStateImageBehavior = false;
            this.SellerList.SelectedIndexChanged += new System.EventHandler(this.SellerList_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(458, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MerchantInventory
            // 
            this.ClientSize = new System.Drawing.Size(482, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SellerList);
            this.Name = "MerchantInventory";
            this.Load += new System.EventHandler(this.MerchantInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PlayerList;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.ListView SellerList;
        private System.Windows.Forms.Button button1;
    }
}