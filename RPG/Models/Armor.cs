using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    enum ArmorNames
    {
        Chainmail, Hide, Cloth, Metal, Robe, Auric
    }
    [Serializable]
    public class Armor : Item
    {
        private int _Defense;
        private int _Price;
        private string _Name;

        public int Defense { get => _Defense; set => _Defense = value; }
        public int Price { get => _Price; set => _Price = value; }
        public string Name { get => _Name; set => _Name = value; }
        public StatStruct Stats = new StatStruct();
        public Random random = new Random();

        public int GenerateValue(string Name)
        {
            if (Name == "Chainmail")
            {
                return random.Next(6, 13);
            }
            if (Name == "Hide")
            {
                return random.Next(12, 21);
            }
            if (Name == "Cloth")
            {
                return random.Next(2, 11);
            }
            if (Name == "Metal")
            {
                return random.Next(10, 16);
            }
            if (Name == "Robe")
            {
                return random.Next(14, 17);
            }
            if (Name == "Auric")
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
            Array Names = Enum.GetValues(typeof(ArmorNames));
            ArmorNames randomName = (ArmorNames)Names.GetValue(random.Next(Names.Length));
            return randomName.ToString();
        }

        public StatStruct GenerateStatBonus(string Name)
        {
            StatStruct ArmorStats = new StatStruct();
            if (Name == "Chainmail")
            {
                ArmorStats.StatBonus = random.Next(1, 6);
                ArmorStats.StatType = "Charisma";
                return ArmorStats;
            }
            if (Name == "Hide")
            {
                ArmorStats.StatBonus = random.Next(1, 3);
                ArmorStats.StatType = "Strength";
                return ArmorStats;
            }
            if (Name == "Cloth")
            {
                ArmorStats.StatBonus = random.Next(1, 6);
                ArmorStats.StatType = "Dexterity";
                return ArmorStats;
            }
            if (Name == "Metal")
            {
                ArmorStats.StatBonus = random.Next(1, 6);
                ArmorStats.StatType = "Constitution";
                return ArmorStats;
            }
            if (Name == "Robe")
            {
                ArmorStats.StatBonus = random.Next(1, 6);
                ArmorStats.StatType = "Wisdom";
                return ArmorStats;
            }
            if (Name == "Auric")
            {
                ArmorStats.StatBonus = random.Next(1, 6);
                ArmorStats.StatType = "Intelligence";
                return ArmorStats;
            }
            return ArmorStats;
        }
    }
}
