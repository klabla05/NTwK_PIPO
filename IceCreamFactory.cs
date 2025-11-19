namespace zad_dom_5
{
    public enum ProductionType
    {
        Economic = 0,
        Fast = 1,
        Premium = 2,
        Ecologic = 3,
        Experimential = 4,
        New = 5,
        Cheap = 6
    }
    class IceCreamFactory
    {
        public ProductionType productionType;
        public void SetProductionType(int i)
        {
            if(i > -1 && i < 7)
            {
                productionType = ProductionType(i);
            }
            else
            {
                Console.Writeline("Number given to SetProductionType is out of range");
                return;
            }
        }
        public string[] TodaysFavourites()
        {
            string[] strings;
            
        }
    }
}