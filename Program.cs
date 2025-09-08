using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee() { Id = 1, FirstName = "Jane", LastName = "Smith" };
            Employee emp3 = new Employee() { Id = 2, FirstName = "Mark", LastName = "Brown" };

            // Karşılaştırmaları yap
            Console.WriteLine(emp1 == emp2);  // True (çünkü Id aynı)
            Console.WriteLine(emp1 == emp3);  // False (çünkü Id farklı)

            Console.ReadLine();
        }
    }
}
