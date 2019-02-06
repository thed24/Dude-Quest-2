using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Serializable]
    public sealed class Player : Entity
    {
        private static readonly Lazy<Player> lazy =
            new Lazy<Player>(() => new Player());

        public static Player Instance { get { return lazy.Value; } }

        private Player()
        {
        }

        private int _playerExp;
        private bool _playerGender;
        private int _playerGold;

        public int PlayerGold { get => _playerGold; set => _playerGold = value; }
        public int PlayerExp { get => _playerExp; set => _playerExp = value; }
        public bool PlayerGender { get => _playerGender; set => _playerGender = value; } //True is Male, False is Female, not sexist I promise

        public int generateLevelRequirement()
        {
            return (int)Math.Round((EntityLevel ^ 2) / 0.04);
        }

        public string LevelUp(double levelRequirement)
        {
            if (PlayerExp >= levelRequirement)
            {
                PlayerExp = 0;
                EntityLevel += 1;
                EntityStats.charChr += 1;
                EntityStats.charStr += 1;
                EntityStats.charDex += 1;
                EntityStats.charCon += 1;
                EntityStats.charInt += 1;
                EntityStats.charWis += 1;
                EntityStats.charHP += 10;
                EntityStats.charMP += 5;
                if (EntityLevel == 2)
                {
                    Abilities Fireball = new Abilities();
                    Fireball.SkillPower = 25;
                    Fireball.SkillAccuracy = 85;
                    Fireball.SkillCost = 3;
                    Fireball.SkillName = "Fire Ball";
                    EntitySkills.MagicalSkills.Add(Fireball);
                }
                return "\nYou have leveled up! You have gotten stronger!";
            }
            return null;
        }

        public override void ApplyEquipedArmor()
        {
            if (ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatType == "Strength")
            {
                EntityStats.charStr += ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatBonus;
            }
            if (ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatType == "Intelligence")
            {
                EntityStats.charInt += ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatBonus;
            }

            if (ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatType == "Wisdom")
            {
                EntityStats.charWis += ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatBonus;
            }

            if (ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatType == "Constitution")
            {
                EntityStats.charCon += ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatBonus;
            }

            if (ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatType == "Dexterity")
            {
                EntityStats.charDex += ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatBonus;
            }
            if (ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatType == "Charisma")
            {
                EntityStats.charChr += ArmorEquipped[ArmorEquipped.Count() - 1].Stats.StatBonus;
            }
        }

        public override void ApplyEquipedWeapon()
        {
            if (WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatType == "Strength")
            {
                EntityStats.charStr += WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatBonus;
            }
            if (WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatType == "Intelligence")
            {
                EntityStats.charInt += WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatBonus;
            }

            if (WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatType == "Wisdom")
            {
                EntityStats.charWis += WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatBonus;
            }

            if (WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatType == "Constitution")
            {
                EntityStats.charCon += WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatBonus;
            }

            if (WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatType == "Dexterity")
            {
                EntityStats.charDex += WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatBonus;
            }
            if (WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatType == "Charisma")
            {
                EntityStats.charChr += WeaponEquipped[WeaponEquipped.Count() - 1].Stats.StatBonus;
            }
        }
    }
}
