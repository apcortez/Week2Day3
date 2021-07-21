using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Car : Vehicle
    {
        public string PlateNumber { get; set; }
        public FluelEnum Fluel { get; set; }

        public Car(string IdCode, string Brand, string Model, string PlateNumber, FluelEnum Fluel)
            : base ( IdCode, Brand, Model)
            {
                this.PlateNumber = PlateNumber;
                this.Fluel = Fluel;
            }
    }

    public enum FluelEnum
    {
        Diesel, Gasoline
    }
}
