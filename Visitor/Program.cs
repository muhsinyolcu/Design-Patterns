using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager muhsin = new Manager() { Name = "Muhsin", Salary = 1000 };
            Manager ahmet = new Manager() { Name = "Ahmet", Salary = 1000 };

            Worker selin = new Worker() { Name = "Selin", Salary = 800 };
            Worker ufuk = new Worker() { Name = "Ufuk", Salary = 800 };

            muhsin.SubOrdinates.Add(selin);
            ahmet.SubOrdinates.Add(ufuk);

            OrganitionalStructure organitionalStructure = new OrganitionalStructure(muhsin);

            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayriseVisitor payriseVisitor = new PayriseVisitor();

            organitionalStructure.Accept(payrollVisitor);
            organitionalStructure.Accept(payriseVisitor);
        }
    }
}
