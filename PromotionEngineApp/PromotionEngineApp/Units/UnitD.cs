namespace PromotionEngineApp.Units
{
    public class UnitD: IUnit
    {
        private int UnitPriceForD { get; } = 15;

        public int GetUnitPrice()
        {
            return UnitPriceForD;
        }
    }
}
