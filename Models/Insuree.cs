using System;

namespace OperatorsAssignment.Models
{
    public class Insuree
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public int SpeedingTickets { get; set; }
        public bool HasDUI { get; set; }
        public bool FullCoverage { get; set; }
        public decimal Quote { get; set; }
    }
}
