using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public class PromotionForA: IPromotion
    {
        private readonly Dictionary<string, int> _promotionForA = new Dictionary<string, int> { { "A", 3 } };

        public Dictionary<string, int> GetPromotion()
        {
            return _promotionForA;
        }
    }
}
