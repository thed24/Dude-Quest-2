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
using RPG.Models;

namespace RPG.GUI
{
    public partial class PlayerInventory : Form
    {
        public Player MainPlayer;
        public Armor EquippedArmor;
        public Weapon EquippedWeapon;
        public SoundPlayer Test = new SoundPlayer(Properties.Resources.ButtonSound);

        public PlayerInventory(Player ImportPlayer)
        {
            InitializeComponent();
            MainPlayer = ImportPlayer;
        }

        private void Player_Inventory_Load(object sender, EventArgs e)
        {
            ItemList.View = View.Details;
            ItemList.Columns.Add("Item", 75, HorizontalAlignment.Left);
            ItemList.Columns.Add("Type", 75, HorizontalAlignment.Left);
            ItemList.Columns.Add("Bonus", 75, HorizontalAlignment.Left);
            for (var I = 0; I < MainPlayer.WeaponInventory.Count(); I++)
            {
                var item1 = new ListViewItem(MainPlayer.WeaponInventory[I].Name);
                item1.SubItems.Add("Weapon");
                item1.SubItems.Add(MainPlayer.WeaponInventory[I].Attack.ToString());
                item1.Tag = MainPlayer.WeaponInventory[I];
                ItemList.Items.AddRange(new[] { item1 });
            }

            for (var I = 0; I < MainPlayer.ArmorInventory.Count(); I++)
            {
                var item1 = new ListViewItem(MainPlayer.ArmorInventory[I].Name);
                item1.SubItems.Add("Armor");
                item1.SubItems.Add(MainPlayer.ArmorInventory[I].Defense.ToString());
                item1.Tag = MainPlayer.ArmorInventory[I];
                ItemList.Items.AddRange(new[] { item1 });
            }

            ItemList.SelectedIndexChanged += ItemList_SelectedIndexChanged;
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = typeof(Weapon);
            var b = typeof(Armor);

            if (ItemList.SelectedItems.Count > 0)
            {
                Console.WriteLine(ItemList.SelectedItems[0].Tag.ToString());
                if (ItemList.SelectedItems[0].Tag.GetType().Equals(a))
                {
                    EquippedWeapon = (Weapon)ItemList.SelectedItems[0].Tag;
                    EquippedArmor = null;
                }

                if (ItemList.SelectedItems[0].Tag.GetType().Equals(b))
                {
                    EquippedArmor = (Armor)ItemList.SelectedItems[0].Tag;
                    EquippedWeapon = null;
                }
            }
        }

        private void EquipBtn_Click(object sender, EventArgs e)
        {
            Test.Play();
            if (EquippedWeapon != null)
            {
                MainPlayer.WeaponInventory.Add(MainPlayer.WeaponEquipped[0]);
                MainPlayer.WeaponEquipped.Clear();
                MainPlayer.WeaponEquipped.Add(EquippedWeapon);
                MainPlayer.WeaponInventory.Remove(EquippedWeapon);
                Close();
            }
            if (EquippedArmor != null)
            {
                MainPlayer.ArmorInventory.Add(MainPlayer.ArmorEquipped[0]);
                MainPlayer.ArmorEquipped.Clear();
                MainPlayer.ArmorEquipped.Add(EquippedArmor);
                MainPlayer.ArmorInventory.Remove(EquippedArmor);
                Close();
            }
        }
    }
}
