namespace zad_dom_5
{
    class Program
    {
        static void Main()
        { 
            int week = 0;
            IceCreamFactory factory = new IceCreamFactory();
            IceMan man = new IceMan(factory);
            for (int i = 0; i < 7; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 7);
                factory.productionType = (ProductionType)num;
                week++;
                Console.WriteLine($@"Week {week}: {factory.productionType}");
                for (int y = 0; y < 14; y++)
                {
                    man.PresentTodays();
                }
            }
        }
    }

}