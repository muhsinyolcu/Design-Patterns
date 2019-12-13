namespace Command
{
    class SellStock : IOrder
    {
        StockManager _stockManager;
        public SellStock(StockManager stockmanager)
        {
            _stockManager = stockmanager;
        }
        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
