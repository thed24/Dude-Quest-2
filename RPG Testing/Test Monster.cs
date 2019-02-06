using System;
using RPG;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Models;

namespace RPG_Testing
{
    [TestClass]
    public class TestMonster
    {
        [TestMethod]
        public void TestBandit()
        {
            Bandit EnemyBandit = new Bandit();
            EnemyBandit.GenerateName();
            EnemyBandit.GenerateSkills();
            EnemyBandit.GenerateStats();
            EnemyBandit.GenerateArmor();
            EnemyBandit.GenerateWeapon();
            Assert.IsTrue(EnemyBandit.EntityName == "");
        }
    }
}
