using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using RPG.Models;

namespace RPG.GUI
{
    public partial class MerchantInventory : Form
    {
        public List<Armor> AmrList;
        public string ErrorMessage;
        public Player MainPlayer;
        public Armor PurchasedArmor;
        public Weapon PurchasedWeapon;
        public Armor TruePurchasedArmor;
        public Weapon TruePurchasedWeapon;
        public List<Weapon> WpList;
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);

        public MerchantInventory(List<Weapon> WeaponList, List<Armor> ArmorList, Player PlayerPrice)
        {
            InitializeComponent();
            WpList = WeaponList;
            AmrList = ArmorList;
            MainPlayer = PlayerPrice;
        }

        private void SellerList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var a = typeof(Weapon);
            var b = typeof(Armor);

            if (SellerList.SelectedItems.Count > 0)
            {
                Console.WriteLine(SellerList.SelectedItems[0].Tag.ToString());
                if (SellerList.SelectedItems[0].Tag.GetType().Equals(a))
                {
                    PurchasedWeapon = (Weapon)SellerList.SelectedItems[0].Tag;
                    PurchasedArmor = null;
                }

                if (SellerList.SelectedItems[0].Tag.GetType().Equals(b))
                {
                    PurchasedArmor = (Armor)SellerList.SelectedItems[0].Tag;
                    PurchasedWeapon = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (PurchasedWeapon != null)
            {
                if (MainPlayer.PlayerGold >= PurchasedWeapon.Price)
                {
                    MainPlayer.PlayerGold -= PurchasedWeapon.Price;
                    TruePurchasedWeapon = PurchasedWeapon;
                    Close();
                }
                else
                {
                    ErrorMessage = "You cannot afford the " + PurchasedWeapon.Name;
                    Close();
                }
            }

            if (PurchasedArmor != null)
            {
                if (MainPlayer.PlayerGold >= PurchasedArmor.Price)
                {
                    MainPlayer.PlayerGold -= PurchasedArmor.Price;
                    TruePurchasedArmor = PurchasedArmor;
                    Close();
                }
                else
                {
                    ErrorMessage = "You cannot afford the " + PurchasedArmor.Name;
                    Close();
                }
            }
        }

        private void MerchantInventory_Load(object sender, EventArgs e)
        {
            SellerList.View = View.Details;
            SellerList.Columns.Add("Item", 100, HorizontalAlignment.Left);
            SellerList.Columns.Add("Price", 100, HorizontalAlignment.Left);
            SellerList.Columns.Add("Type", 100, HorizontalAlignment.Left);
            SellerList.Columns.Add("Bonus", 100, HorizontalAlignment.Left);
            for (var I = 0; I < WpList.Count(); I++)
            {
                var item1 = new ListViewItem(WpList[I].Name);
                item1.SubItems.Add(WpList[I].Price.ToString());
                item1.SubItems.Add("Weapon");
                item1.SubItems.Add(WpList[I].Attack.ToString());
                item1.Tag = WpList[I];
                SellerList.Items.AddRange(new[] { item1 });
            }

            for (var I = 0; I < AmrList.Count(); I++)
            {
                var item1 = new ListViewItem(AmrList[I].Name);
                item1.SubItems.Add(AmrList[I].Price.ToString());
                item1.SubItems.Add("Armor");
                item1.SubItems.Add(AmrList[I].Defense.ToString());
                item1.Tag = AmrList[I];
                SellerList.Items.AddRange(new[] { item1 });
            }

            SellerList.SelectedIndexChanged += SellerList_SelectedIndexChanged_1;
        }
    }
}