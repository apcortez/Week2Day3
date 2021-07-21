using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected int Age { get; set; }
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public Person(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        public Person()
        {

        }

        public void GetFullname()
        {
            Console.WriteLine(FirstName + " " + Lastname);

        }

        //metodo astratto della superclasse che deve essere implementata in maniera piu dettagliata nelle classi figlie
        //si utilizza la dicitura "virtual" o "abstract" 
        public virtual void PrintInfo()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Age);
        }
    }
}
