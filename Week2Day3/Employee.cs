using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    class Employee : Person //impiegato eredita da persona
    {
        //eredita FirstName e LastName

        public RoleEnum Role { get; set; }
    
        public Employee(string FirstName, string LastName, RoleEnum Role)
            : base(FirstName, LastName) // riferimento al costruttore della superclasse
        {
            this.Role = Role;
        }

        internal void GetFullName()
        {
            Console.WriteLine("Il suo nome è " + FirstName);
        }

        public Employee(string FirstName, string LastName, RoleEnum Role,int Age)
           : base(FirstName, LastName, Age) // riferimento al costruttore della superclasse
        {
            this.Role = Role;
        }
        public Employee()
        {

        }
    }

    public enum RoleEnum
    {
        Technician,
        Manager
    }
}
