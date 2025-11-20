namespace zad_dom_5
{
    class Program
    {
        static void Main()
    {
        IceCreamFactory factory = new IceCreamFactory();
        IceMan man = new IceMan(factory);
    }
    }

}