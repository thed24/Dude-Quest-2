using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Serializable]
    public struct StatStruct
    {
        public int StatBonus;
        public string StatType;
    }

    public interface Item
    {
        int GenerateValue(string Name);
        int GeneratePrice(int Value, int Stat);
        string GenerateName();
        StatStruct GenerateStatBonus(string Name);
    }
}
