using System;
using OperatorsAssignment.Models;
using OperatorsAssignment.Controllers;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create controller
            InsureeController controller = new InsureeController();

            // Example insurees
            Insuree person1 = new Insuree
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 20,
                CarMake = "Porsche",
                CarModel = "911 Carrera",
                CarYear = 2018,
                SpeedingTickets = 2,
                HasDUI = false,
                FullCoverage = true
            };

            Insuree person2 = new Insuree
            {
                FirstName = "Sarah",
                LastName = "Miller",
                Age = 30,
                CarMake = "Toyota",
                CarModel = "Camry",
                CarYear = 2010,
                SpeedingTickets = 0,
                HasDUI = true,
                FullCoverage = false
            };

            // Calculate quotes
            decimal quote1 = controller.CalculateQuote(person1);
            decimal quote2 = controller.CalculateQuote(person2);

            // Show results
            Console.WriteLine($"{person1.FirstName} {person1.LastName}'s Quote: ${quote1}");
            Console.WriteLine($"{person2.FirstName} {person2.LastName}'s Quote: ${quote2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
