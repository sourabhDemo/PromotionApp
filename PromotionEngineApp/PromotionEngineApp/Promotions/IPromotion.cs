using System.Collections.Generic;

namespace PromotionEngineApp.Promotions
{
    public interface IPromotion
    {
        Dictionary<string, int> GetPromotion();
    }
}
