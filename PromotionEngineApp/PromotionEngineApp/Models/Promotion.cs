using System.Collections.Generic;

namespace PromotionEngineApp.Models
{
    public class Promotion
    {
        public int PromotionId { get; set; }

        public decimal PromotionPrice { get; set; }

        public Dictionary<string, int> PromotionInfo{ get; set; }

        public Promotion(int promotionId, Dictionary<string, int> promotionInfo, int promotionPrice)
        {
            PromotionId = promotionId;
            PromotionInfo = promotionInfo;
            PromotionPrice = promotionPrice;
        }
    }
}
