namespace Bridge
{
    class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Body { Title = "About the course!" });
            System.Console.WriteLine("Customer Updated!");
        }
    }
}
