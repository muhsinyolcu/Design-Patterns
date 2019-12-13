namespace Command
{
    class BuyStock : IOrder
    {
        StockManager _stockManager;
        public BuyStock(StockManager stockmanager)
        {
            _stockManager = stockmanager;
        }
        public void Execute()
        {
            _stockManager.Buy();
        }
    }
}
