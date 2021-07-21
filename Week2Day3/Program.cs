using System;

namespace Week2Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Superclasse - classe madre
            Person p1 = new Person("Mario", "Rossi");
            
            //Classe derivata - classe figlia
            //eredita sia gli attributi che i metodi della classe madre
            Employee e = new Employee("Mario", "Rossi", RoleEnum.Manager);

            Person p2 = new Person();
            p2.FirstName = "Marco";
            p2.LastName = "Verdi";

            //eredita il nome, il cognome e l'età della superclasse 
            // e li aggrega ai suoi attributi (es eta)
            Employee e2 = new Employee("Sara", "Bianchi", RoleEnum.Technician, 13);
            e2.GetFullName();
        }
    }
}
