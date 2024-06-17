using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndaEinGarasjeApp
{
    internal class Boat : Vehicle
    {
        public Boat(string brand, string model, int year, int wheels, int speed) : base(brand, model, year, wheels, speed)
        {
            wheels = 0;
        }

        public override void Drive()
        {
            Console.WriteLine("Broom broom, on the water");
        }
    }
}
