using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineApp;
using PromotionEngineApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineAppTest
{
    [TestClass]
    public class ActivePromotionTest
    {
        [TestMethod]
        public void GetPromotionsTest()
        {
            Order order = new Order(1, new List<Sku>() { new Sku("A"), new Sku("A"), new Sku("B"), new Sku("B"), new Sku("C"), new Sku("D") });

            var activePromotions = new ActivePromotion();
            var promotions = activePromotions.GetPromotions(order);

            Assert.AreEqual(3, promotions.Count());
        }

        [TestMethod]
        public void GetPromotionsTestOne()
        {
            Order order = new Order(1, new List<Sku>() { new Sku("B"), new Sku("B"), new Sku("C"), new Sku("D") });

            var activePromotions = new ActivePromotion();
            var promotions = activePromotions.GetPromotions(order);

            Assert.AreEqual(2, promotions.Count());
        }
    }
}
