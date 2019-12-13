namespace Visitor
{
    class PayriseVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            System.Console.WriteLine($"{worker.Name} salary increased to {worker.Salary * (decimal)1.1}");
        }

        public override void Visit(Manager manager)
        {
            System.Console.WriteLine($"{manager.Name} salary increased to {manager.Salary * (decimal)1.2}");
        }
    }
}
