namespace Visitor
{
    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            System.Console.WriteLine($"{worker.Name} paid {worker.Salary}");
        }

        public override void Visit(Manager manager)
        {
            System.Console.WriteLine($"{manager.Name} paid {manager.Salary}");
        }
    }
}
