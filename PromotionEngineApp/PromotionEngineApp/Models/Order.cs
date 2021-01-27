using System.Collections.Generic;

namespace PromotionEngineApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public List<Sku> StockUnits { get; set; }

        public Order(int orderId, List<Sku> units)
        {
            OrderId = orderId;
            StockUnits = units;
        }
    }
}
