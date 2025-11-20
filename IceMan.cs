namespace zad_dom_5
{
    class IceMan
    {
        private IceCreamFactory factory;
        public IceMan(IceCreamFactory factory_)
        {
            factory = factory_;
        }
        public void PresentTodays()
        {
            var icecream = factory.TodayFavourite();
            icecream.GetInformation();
        }
    }
}