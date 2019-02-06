using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public struct characterStats
    {
        public int charHP, charMP, charStr, charInt, charCon, charDex, charWis, charChr;
    }

    public abstract class Entity
    {
        private characterStats _playerStats;
        private string _playerName;
        private int _playerExp;
        private int _playerLevel;
        private List<Item> _inventory = new List<Item>();

        characterStats playerStats { get => _playerStats; set => _playerStats = value; }
        string playerName { get => _playerName; set => _playerName = value; }
        int playerExp { get => _playerExp; set => _playerExp = value; }
        int playerLevel { get => _playerLevel; set => _playerLevel = value; }
        List<Item> inventory { get => _inventory; set => _inventory = value; }

        public virtual void LevelUp()
        {
            playerExp = 0;
            playerLevel += 1;
        }
    }
}
