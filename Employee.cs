using System;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // "==" operatörünü overload et
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        // "!=" operatörünü de overload et (çift olarak yazmak zorunlu)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }

        // Object.Equals ve GetHashCode override edilmeli
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
