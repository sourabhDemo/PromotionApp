using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public class PromotionForB : IPromotion
    {
        private readonly Dictionary<string, int> _promotionForB = new Dictionary<string, int> { { "B", 2 } };

        public Dictionary<string, int> GetPromotion()
        {
            return _promotionForB;
        }
    }
}
