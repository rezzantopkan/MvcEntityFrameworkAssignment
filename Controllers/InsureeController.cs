using System;
using OperatorsAssignment.Models;

namespace OperatorsAssignment.Controllers
{
    public class InsureeController
    {
        public decimal CalculateQuote(Insuree insuree)
        {
            decimal total = 50; // Base price

            // Age rules
            if (insuree.Age <= 18)
                total += 100;
            else if (insuree.Age >= 19 && insuree.Age <= 25)
                total += 50;
            else if (insuree.Age >= 26)
                total += 25;

            // Car year rules
            if (insuree.CarYear < 2000)
                total += 25;
            if (insuree.CarYear > 2015)
                total += 25;

            // Car make/model rules
            if (insuree.CarMake.ToLower() == "porsche")
            {
                total += 25;
                if (insuree.CarModel.ToLower() == "911 carrera")
                    total += 25;
            }

            // Speeding tickets
            total += insuree.SpeedingTickets * 10;

            // DUI
            if (insuree.HasDUI)
                total *= 1.25m; // +25%

            // Full coverage
            if (insuree.FullCoverage)
                total *= 1.5m; // +50%

            insuree.Quote = total;
            return total;
        }
    }
}
