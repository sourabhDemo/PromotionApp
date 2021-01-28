using PromotionEngineApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order firstOrder = new Order(1, new List<Sku>() { new Sku("A"), new Sku("B"), new Sku("C") });
            Order secondOrder = new Order(2, new List<Sku>() { new Sku("A"), new Sku("A"), new Sku("A"), new Sku("A"), new Sku("A"), new Sku("B"), new Sku("B"), new Sku("B"), new Sku("B"), new Sku("B"), new Sku("C") });
            Order thirdOrder = new Order(3, new List<Sku>() { new Sku("A"), new Sku("A"), new Sku("A"), new Sku("B"), new Sku("B"), new Sku("B"), new Sku("B"), new Sku("B"), new Sku("C"), new Sku("D") });

            List<Order> orders = new List<Order>();
            orders.AddRange(new Order[] { firstOrder, secondOrder, thirdOrder });
            var activePromotion = new ActivePromotion();
            foreach (Order order in orders)
            {
                var promotions = activePromotion.GetPromotions(order);
                List<decimal> promotionPrices = promotions
                    .Select(promotion => activePromotion.GetPromotionPrice(order, promotion))
                    .ToList();
                decimal totalPrice = order.StockUnits.Sum(x => x.Price);
                decimal promotionPrice = promotionPrices.Sum();
                Console.WriteLine($"OrderID: {order.OrderId}");
                Console.WriteLine($"Final price: {(totalPrice - promotionPrice):0.00}");
            }
        }
    }
}
