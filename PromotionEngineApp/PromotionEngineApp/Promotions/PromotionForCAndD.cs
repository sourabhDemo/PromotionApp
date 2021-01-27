using System;
using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public class PromotionForCAndD : IPromotion
    {
        private readonly Dictionary<string, int> _promotionForCAndD = new Dictionary<string, int> { { "C", 1 }, { "D", 1 } };

        public Tuple<Dictionary<string, int>, int> GetPromotion()
        {
            var promotion = Tuple.Create(_promotionForCAndD, 30);
            return promotion;
        }
    }
}
