namespace Command
{
    class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {
            System.Console.WriteLine($"Stock: {_name}, {_quantity} bought!");
        }
        public void Sell()
        {
            System.Console.WriteLine($"Stock: {_name}, {_quantity} sold!");
        }
    }
}
