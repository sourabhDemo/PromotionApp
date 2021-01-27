using System;
using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public class PromotionForA: IPromotion
    {
        private readonly Dictionary<string, int> _promotionForA = new Dictionary<string, int> { { "A", 3 } };

        public Tuple<Dictionary<string, int>,int> GetPromotion()
        {
            var promotion = Tuple.Create(_promotionForA, 130);
            return promotion;
        }
    }
}
