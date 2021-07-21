using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Athlete
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected int Age { get; set; }

        public Athlete()
        {

        }

        public Athlete(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public Athlete(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

    }
}
