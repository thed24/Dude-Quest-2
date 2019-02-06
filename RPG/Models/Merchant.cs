using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    enum Prefix
    {
        Legendary, Serrated, Powerful, Agile, Thunderous, Dangerous, Wicked, Empowered, Magical, Overflowing
    }

    public class Merchant : Entity
    {
        public Random random = new Random();
        public Weapon GenWeapon = new Weapon();
        public Armor GenArmor = new Armor();

        public void GenerateSaleList()
        {
            ArmorInventory.Add(GenerateArmor());
            WeaponInventory.Add(GenerateWeapon());
        }

        public void NamePimper()
        {
            for (int I = 0; I < WeaponInventory.Count; I++)
            {
                Array Names = Enum.GetValues(typeof(Prefix));
                Prefix Prefix = (Prefix)Names.GetValue(random.Next(Names.Length));
                WeaponInventory[I].Name = Prefix.ToString() + " " + WeaponInventory[I].Name;
            }
            for (int I = 0; I < ArmorInventory.Count; I++)
            {
                Array Names = Enum.GetValues(typeof(Prefix));
                Prefix Prefix = (Prefix)Names.GetValue(random.Next(Names.Length));
                ArmorInventory[I].Name = Prefix.ToString() + " " + ArmorInventory[I].Name;
            }
        }

        public Weapon GenerateWeapon()
        {
            GenWeapon.Name = GenWeapon.GenerateName();
            GenWeapon.Attack = GenWeapon.GenerateValue(GenWeapon.Name);
            GenWeapon.Stats = GenWeapon.GenerateStatBonus(GenWeapon.Name);
            GenWeapon.Price = GenWeapon.GeneratePrice(GenWeapon.Attack, GenWeapon.Stats.StatBonus);
            return GenWeapon;
        }

        public Armor GenerateArmor()
        {
            GenArmor.Name = GenArmor.GenerateName();
            GenArmor.Defense = GenArmor.GenerateValue(GenArmor.Name);
            GenArmor.Stats = GenArmor.GenerateStatBonus(GenArmor.Name);
            GenArmor.Price = GenArmor.GeneratePrice(GenArmor.Defense, GenArmor.Stats.StatBonus);
            return GenArmor;
        }

        public override void ApplyEquipedArmor()
        {
            throw new NotImplementedException();
        }

        public override void ApplyEquipedWeapon()
        {
            throw new NotImplementedException();
        }
    }
}
