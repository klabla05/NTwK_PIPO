namespace zad_dom_5
{
    class DiaryIceCream : IceCream
    {
        public bool in_waffle{get; set;}
        public string icing{get; set;}
        public bool topping{get; set;}
        public override void GetInformation()
        {
            Console.WriteLine($"Diary icecream, cost {cost}, flavour {flavour}, in waffle? {in_waffle}, what icing? {icing}, is topping? {topping}");
        }
    }
}