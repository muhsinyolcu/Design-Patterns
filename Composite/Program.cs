using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee muhsin = new Employee
            {
                Name = "Muhsin Yolcu"
            };
            Employee ahmet = new Employee
            {
                Name = "Ahmet Yıldıran"
            };
            Employee ayse = new Employee
            {
                Name = "Ayse Yolcu"
            };
            Employee selin = new Employee
            {
                Name = "Selin Yolcu"
            };
            Contractor ali = new Contractor { Name = "Ali Ci" };

            ahmet.AddSubordinate(ali);

            muhsin.AddSubordinate(ahmet);
            muhsin.AddSubordinate(ayse);
            ayse.AddSubordinate(selin);

            Console.WriteLine(muhsin.Name);
            foreach (Employee manager in muhsin)
            {
                Console.WriteLine("     *{0}", manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("        *{0}", employee.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
