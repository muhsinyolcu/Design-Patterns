using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new PersonalCar
            {
                Make = "BMW",
                Model = "3.20",
                HirePrice = 2500
            };

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("Concrete: {0}", personalCar.HirePrice);
            Console.WriteLine("Special offer: {0}", specialOffer.HirePrice);

            Console.ReadLine();
        }
    }
}
