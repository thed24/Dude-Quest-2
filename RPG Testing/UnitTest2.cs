using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Models;

namespace RPG_Testing
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Merchant EventMerchant = new Merchant();
            EventMerchant.GenerateSaleList();
            EventMerchant.NamePimper();
            Assert.IsNull(EventMerchant.WeaponInventory);
        }
    }
}
