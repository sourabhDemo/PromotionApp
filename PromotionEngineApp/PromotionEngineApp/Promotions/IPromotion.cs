using System;
using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public interface IPromotion
    {
        Tuple<Dictionary<string, int>, int> GetPromotion();
    }
}
