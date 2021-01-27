using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public class PromotionForCAndD:IPromotion
    {
        private readonly Dictionary<string, int> _promotionForCAndD = new Dictionary<string, int> { { "C", 1 }, {"D", 1} };

        public Dictionary<string, int> GetPromotion()
        {
            return _promotionForCAndD;
        }
    }
}
