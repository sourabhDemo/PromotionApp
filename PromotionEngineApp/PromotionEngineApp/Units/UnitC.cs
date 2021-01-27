namespace PromotionEngineApp.Units
{
    public class UnitC: IUnit
    {
        private int UnitPriceForC { get; } = 20;

        public int GetUnitPrice()
        {
            return UnitPriceForC;
        }
    }
}
