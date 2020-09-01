using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutePropertyPattern();
        }

        public static void ExecutePropertyPattern()
        {
            Calculate calculate = new Calculate { MultiplyBy = "5 times" };

            var res = ComputeOverallPrice(calculate, 10M);

            CalculateMultipleProperty calculate2 = new CalculateMultipleProperty { MultiplyBy = "5 times", IsAdditionApplicable = true };
            var res2 = ComputeOverallPriceMultiple(calculate2, 10M);

            Console.WriteLine("Result " + res);
            Console.WriteLine("Result Mutiple Property " + res2);
        }


        private static decimal ComputeOverallPrice(Calculate calculate, decimal price) =>
        calculate switch
        {
            { MultiplyBy: "10 times" } => 10 * price,
            { MultiplyBy: "5 times" } => 5 * price,
            { MultiplyBy: "20 times" } => 20 * price,
            _ => 0M
        };

        private static decimal ComputeOverallPriceMultiple(CalculateMultipleProperty calculate, decimal price) =>
        calculate switch
        {
            { MultiplyBy: "10 times", IsAdditionApplicable: true } => 10 * price + 100,
            { MultiplyBy: "5 times", IsAdditionApplicable: true } => 5 * price + 50,
            { MultiplyBy: "20 times", IsAdditionApplicable: true } => 20 * price + 70,
            _ => 0M
        };
    }
}
