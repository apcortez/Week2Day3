using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Vehicle
    {
        public string IdCode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string IdCode, string Brand, string Model)
        {
            this.IdCode = IdCode;
            this.Brand = Brand;
            this.Model = Model;
        }

    }
}
