using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Referee : Athlete
    {
        public int CareerYears { get; set; }
        public Referee(string FirstName, string LastName, int Age, RoleEnum Role, int CareerYears)
           : base(FirstName, LastName, Age)
        {
            this.CareerYears = CareerYears;
        }

        public Referee() { }
    }
}
