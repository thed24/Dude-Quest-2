using System;
using RPG;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Models;

namespace RPG_Testing
{
    [TestClass]
    public class TestLevelUp
    {
        [TestMethod]
        public void TestLevelUpOnce()
        {
            Player TestPlayer = Player.Instance;
            TestPlayer.EntityLevel = 1;
            int Test = TestPlayer.generateLevelRequirement();
            Assert.IsTrue(true == false);
        }
    }
}
