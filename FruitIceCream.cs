namespace zad_dom_5
{
    class FruitIceCream : IceCream
    {
        public bool in_waffle{get; set;}
        public string icing{get; set;}
        public override void GetInformation()
        {
            Console.WriteLine($"Fruit icecream, cost {cost}, flavour {flavour}, in waffle? {in_waffle}, what icing? {icing}");
        }
    }
}