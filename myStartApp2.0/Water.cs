namespace myStartApp2._0
{
    public class Water : Service
    {
        private const string WaterName = "water";
        private const string WaterUnitsType = "m^3";
        public Water(double unitPrice, string company):base()
        {
            ServiceName = WaterName;
            UnitPrice = unitPrice;
            UnitType = WaterUnitsType;
            Company = company;
        }
    }
}