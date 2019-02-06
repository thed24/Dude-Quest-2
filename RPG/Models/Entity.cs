using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Serializable]
    public struct CharacterStats
    {
        public int charHP, charMP, charStr, charInt, charCon, charDex, charWis, charChr;
    }

    [Serializable]
    public abstract class Entity
    {
        private string _EntityName;
        private int _EntityLevel;
        private List<Weapon> _WeaponInventory = new List<Weapon>();
        private List<Weapon> _WeaponEquipped = new List<Weapon>();
        private List<Armor> _ArmorInventory = new List<Armor>();
        private List<Armor> _ArmorEquipped = new List<Armor>();

        public Skills EntitySkills = new Skills();
        public CharacterStats EntityStats = new CharacterStats();
        public string EntityName { get => _EntityName; set => _EntityName = value; }
        public int EntityLevel { get => _EntityLevel; set => _EntityLevel = value; }
        public List<Weapon> WeaponInventory { get => _WeaponInventory; set => _WeaponInventory = value; }
        public List<Weapon> WeaponEquipped { get => _WeaponEquipped; set => _WeaponEquipped = value; }
        public List<Armor> ArmorInventory { get => _ArmorInventory; set => _ArmorInventory = value; }
        public List<Armor> ArmorEquipped { get => _ArmorEquipped; set => _ArmorEquipped = value; }

        public abstract void ApplyEquipedWeapon();
        public abstract void ApplyEquipedArmor();
        public virtual int GenerateDamage()
        {
            return (WeaponEquipped[WeaponEquipped.Count() - 1].Attack * EntityStats.charStr) / 10;
        }
        public int GenerateMigitation()
        {
            return ((ArmorEquipped[ArmorEquipped.Count() - 1].Defense * (EntityStats.charCon + EntityStats.charWis)) / 10) - 5;
        }
    }
}
