using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Serializable]
    public struct Abilities
    {
        public int SkillPower;
        public int SkillAccuracy;
        public int SkillCost;
        public string SkillName;
        public override String ToString()
        {
            return SkillName + " " + SkillCost.ToString();
        }
    }
    [Serializable]
    public class Skills
    {
        public List<Abilities> PhysicalSkills = new List<Abilities>();
        public List<Abilities> MagicalSkills = new List<Abilities>();
        public List<Abilities> SelfSkills = new List<Abilities>();
    }
}
