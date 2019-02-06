using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    public abstract class Monster : Entity
    {
        public abstract void GenerateName();
        public abstract void GenerateStats();
        public abstract void GenerateSkills();
        public abstract void GenerateWeapon();
        public abstract void GenerateArmor();
        public abstract int GenerateGold();
        public abstract int GenerateEXP();
    }
}
