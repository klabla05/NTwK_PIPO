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
        public void SetProductionType(ProductionType t)
        {
            productionType = t;
        }
        public IceCream TodayFavourite()
        {
            switch (productionType)
            {
                case ProductionType.Economic:
                    return new DiaryIceCream{cost = 8, flavour = "Chocolate", in_waffle = false, icing = "chocolate", topping = true};
                case ProductionType.Fast:
                    return new Sorbet{cost = 10, flavour = "Strawberry"};
                case ProductionType.Premium:
                    return new ItalianIceCream{cost = 12, flavour = "mixed strawbery and chocolate", in_waffle = true, topping = true};
                case ProductionType.Ecologic:
                    return new FruitIceCream{cost = 6, flavour = "Banana", in_waffle = false};
                case ProductionType.Experimential:
                    return new Sorbet{cost = 9, flavour = "Mint with Banana"};
                case ProductionType.New:
                    return new FruitIceCream{cost = 8, flavour = "Blueberry", in_waffle = true, icing = "Caramel"};
                case ProductionType.Cheap:
                    return new Sorbet{cost = 2, flavour = "Apple"};
                default:
                    return null;
            } 
        }
    }
}