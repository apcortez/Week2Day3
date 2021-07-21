using System;

namespace Esercizio1
{
    class Program
    {
        //Creare una classe Veicolo con le seguenti proprietà(brand, modello, codice) e poi le seguenti classi derivate Automobile(con proprietà targa e carburante) e bicicletta(con proprietà Elettrica/Non Elettrica).
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("A1", "Audi", "Sport");
            Car c = new Car("A1", "Audi", "Sport", "FR123", FluelEnum.Diesel);

            Vehicle v2 = new Vehicle("B", "Btwin", "ScattoFisso");
            Bicycle b = new Bicycle("B", "Btwin", "ScattoFisso", PropertyEnum.Electric);
            b.Property = PropertyEnum.NonEletric;
        }
    }
}
