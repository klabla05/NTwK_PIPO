namespace zad_dom_5
{
    class ItalianIceCream : Icecream
    {
        public bool in_waffle{get; set;}
        public bool topping{get; set;}
        public override void GetInformation()
        {
            Console.WriteLine($"Italian icecream, cost {cost}, flavour {flavour}, in waffle? {in_waffle}, is topping? {topping}");
        }
    }
}