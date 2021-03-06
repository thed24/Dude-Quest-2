﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RPG.Models
{
    public class Slime : Monster
    {
        Random random = new Random();
        public override void GenerateName()
        {
            string name = RandomNameGenerator.NameGenerator.GenerateFirstName(RandomNameGenerator.Gender.Female);
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            EntityName = textInfo.ToTitleCase(name.ToLower());
        }

        public override void GenerateStats()
        {
            EntityStats.charHP = random.Next(50, 101);
            EntityStats.charMP = 20;
            EntityStats.charDex = random.Next(1, 6);
            EntityStats.charCon = random.Next(1, 6);
            EntityStats.charChr = random.Next(1, 6);
            EntityStats.charInt = random.Next(5, 16);
            EntityStats.charStr = random.Next(1, 6);
            EntityStats.charWis = random.Next(5, 16);
        }

        public override void GenerateSkills()
        {
            Abilities SlimeShot = new Abilities();
            SlimeShot.SkillPower = 40;
            SlimeShot.SkillAccuracy = 50;
            SlimeShot.SkillCost = 2;
            SlimeShot.SkillName = "Slime Shot";
            EntitySkills.MagicalSkills.Add(SlimeShot);
            Abilities MagicBlast = new Abilities();
            MagicBlast.SkillPower = 25;
            MagicBlast.SkillAccuracy = 80;
            MagicBlast.SkillCost = 2;
            MagicBlast.SkillName = "Magic Blast";
            EntitySkills.MagicalSkills.Add(MagicBlast);
        }

        public override void GenerateWeapon()
        {
            Weapon BanditWeapon = new Weapon();
            BanditWeapon.Name = BanditWeapon.GenerateName();
            BanditWeapon.Attack = BanditWeapon.GenerateValue(BanditWeapon.Name);
            BanditWeapon.Stats = BanditWeapon.GenerateStatBonus(BanditWeapon.Name);
            BanditWeapon.Price = BanditWeapon.GeneratePrice(BanditWeapon.Attack, BanditWeapon.Stats.StatBonus);
            WeaponInventory.Add(BanditWeapon);
            WeaponEquipped.Add(BanditWeapon);
            ApplyEquipedWeapon();
        }

        public override void GenerateArmor()
        {
            Armor BanditArmor = new Armor();
            BanditArmor.Name = BanditArmor.GenerateName();
            BanditArmor.Defense = BanditArmor.GenerateValue(BanditArmor.Name);
            BanditArmor.Stats = BanditArmor.GenerateStatBonus(BanditArmor.Name);
            BanditArmor.Price = BanditArmor.GeneratePrice(BanditArmor.Defense, BanditArmor.Stats.StatBonus);
            ArmorInventory.Add(BanditArmor);
            ArmorEquipped.Add(BanditArmor);
            ApplyEquipedArmor();
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
        public override int GenerateGold()
        {
            return random.Next(EntityLevel, EntityLevel * (WeaponEquipped[WeaponEquipped.Count - 1].Attack + ArmorEquipped[ArmorEquipped.Count - 1].Defense));
        }
        public override int GenerateEXP()
        {
            return random.Next(EntityLevel, EntityLevel * (WeaponEquipped[WeaponEquipped.Count - 1].Attack + ArmorEquipped[ArmorEquipped.Count - 1].Defense));
        }

        public override int GenerateDamage()
        {
            return (WeaponEquipped[WeaponEquipped.Count() - 1].Attack * EntityStats.charInt) / 10;
        }
    }
}
