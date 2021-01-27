namespace PromotionEngineApp.Units
{
    public class UnitB: IUnit
    {
        private int UnitPriceForB { get; } = 30;

        public int GetUnitPrice()
        {
            return UnitPriceForB;
        }
    }
}
