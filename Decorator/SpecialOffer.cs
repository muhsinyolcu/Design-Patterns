namespace Decorator
{
    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice
        {
            get
            {
                return _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage/200;
            }
            set { }
        }
    }
}
