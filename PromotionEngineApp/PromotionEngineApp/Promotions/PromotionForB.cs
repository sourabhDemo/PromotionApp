using System;
using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public class PromotionForB : IPromotion
    {
        private readonly Dictionary<string, int> _promotionForB = new Dictionary<string, int> { { "B", 2 } };

        public Tuple<Dictionary<string, int>,int> GetPromotion()
        {
            var promotion = Tuple.Create(_promotionForB, 45);
            return promotion;
        }
    }
}
