using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Bicycle : Vehicle
    {
        public PropertyEnum Property { get; set; }
        
        public Bicycle(string IdCode, string Brand, string Model, PropertyEnum Property)
            :base( IdCode, Brand, Model)
        {
            this.Property = Property;
        }
    }

    public enum PropertyEnum
    {
        Electric,
        NonEletric
    }
}
