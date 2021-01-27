namespace PromotionEngineApp.Units
{
    public class UnitA: IUnit
    {
        private int UnitPriceForA { get; } = 50;

        public int GetUnitPrice()
        {
            return UnitPriceForA;
        }
    }
}
