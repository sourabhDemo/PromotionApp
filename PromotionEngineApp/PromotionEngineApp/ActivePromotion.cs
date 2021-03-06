﻿using PromotionEngineApp.Models;
using PromotionEngineApp.Promotions;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineApp
{
    public class ActivePromotion
    {
        public IList<Promotion> Promotions = new List<Promotion>();

        public IEnumerable<Promotion> GetPromotions(Order order)
        {
            var uniqueSkus = order.StockUnits.Select(t => t.Id).Distinct();
            IPromotion promotion = null;
            foreach (var uniqueSku in uniqueSkus)
            {
                switch (uniqueSku)
                {
                    case "A":
                        promotion = new PromotionForA();
                        var promotionOfA = promotion.GetPromotion();
                        Promotions.Add(new Promotion(1, promotionOfA.Item1, promotionOfA.Item2));
                        break;
                    case "B":
                        promotion = new PromotionForB();
                        var promotionOfB = promotion.GetPromotion();
                        Promotions.Add(new Promotion(2, promotionOfB.Item1, promotionOfB.Item2));
                        break;
                    case "C":
                    case "D":
                        promotion = new PromotionForCAndD();
                        var promotionOfC = promotion.GetPromotion();
                        Promotions.Add(new Promotion(3, promotionOfC.Item1, promotionOfC.Item2));
                        break;
                }
            }

            return Promotions.GroupBy(t => t.PromotionId).Select(x => x.First());
        }

        public decimal GetPromotionPrice(Order order, Promotion promotion)
        {
            decimal totalPrice = 0M;

            var stockUnitPrice = order.StockUnits
                .GroupBy(x => x.Id)
                .Where(g => promotion.PromotionInfo.Any(y => g.Key == y.Key && g.Count() >= y.Value))
                .Select(g => g.Count())
                .Sum();

            var promotionPrice = promotion.PromotionInfo.Sum(k => k.Value);
            while (stockUnitPrice >= promotionPrice)
            {
                totalPrice += promotion.PromotionPrice;
                stockUnitPrice -= promotionPrice;
            }
            return totalPrice;
        }
    }
}
