using PromotionEngineApp.Units;
using System;

namespace PromotionEngineApp.Models
{
    public class Sku
    {
        public string Id { get; set; }

        public int Price { get; set; }

        public Sku(string id)
        {
            Id = id;

            var unit = (IUnit) Activator.CreateInstance(Type.GetType($"PromotionEngineApp.Units.Unit{id}"));
            Price = unit.GetUnitPrice();
        }
    }
}
