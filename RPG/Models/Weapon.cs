using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    enum WeaponNames
    {
       Dagger, Hammer, Wand, Staff, Sword, Spear
    }
    [Serializable]
    public class Weapon : Item
    {
        private int _Attack;
        private int _Price;
        private string _Name;

        public int Attack { get => _Attack; set => _Attack = value; }
        public int Price { get => _Price; set => _Price = value; }
        public string Name { get => _Name; set => _Name = value; }
        public StatStruct Stats = new StatStruct();
        public Random random = new Random(Guid.NewGuid().GetHashCode());

        public int GenerateValue(string Name)
        {
            if (Name == "Dagger")
            {
                return random.Next(6, 13);
            }
            if (Name == "Hammer")
            {
                return random.Next(12, 21);
            }
            if (Name == "Wand")
            {
                return random.Next(2, 11);
            }
            if (Name == "Staff")
            {
                return random.Next(10, 15);
            }
            if (Name == "Sword")
            {
                return random.Next(14, 17);
            }
            if (Name == "Spear")
            {
                return random.Next(4, 9);
            }
            return 0;
        }

        public int GeneratePrice(int Value, int Stat)
        {
            int MaximumPrice = (Value + Stat) / 2 * 12;
            int MinimumPrice = MaximumPrice / 10;
            return random.Next(MinimumPrice, MaximumPrice); 
        }

        public string GenerateName()
        {
            Array Names = Enum.GetValues(typeof(WeaponNames));
            WeaponNames randomName = (WeaponNames)Names.GetValue(random.Next(Names.Length));
            return randomName.ToString();
        }

        public StatStruct GenerateStatBonus(string Name)
        {
            StatStruct WeaponStats = new StatStruct();
            if (Name == "Dagger")
            {
                WeaponStats.StatBonus = random.Next(1, 6);
                WeaponStats.StatType = "Dexterity";
                return WeaponStats;
            }
            if (Name == "Hammer")
            {
                WeaponStats.StatBonus = random.Next(1, 3);
                WeaponStats.StatType = "Strength";
                return WeaponStats;
            }
            if (Name == "Wand")
            {
                WeaponStats.StatBonus = random.Next(1, 6);
                WeaponStats.StatType = "Intelligence";
                return WeaponStats;
            }
            if (Name == "Staff")
            {
                WeaponStats.StatBonus = random.Next(1, 6);
                WeaponStats.StatType = "Wisdom";
                return WeaponStats;
            }
            if (Name == "Sword")
            {
                WeaponStats.StatBonus = random.Next(1, 6);
                WeaponStats.StatType = "Constitution";
                return WeaponStats;
            }
            if (Name == "Spear")
            {
                WeaponStats.StatBonus = random.Next(1, 6);
                WeaponStats.StatType = "Charisma";
                return WeaponStats;
            }
             return WeaponStats; 
        }
    }
}
