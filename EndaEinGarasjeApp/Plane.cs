using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndaEinGarasjeApp
{
    internal class Plane : Vehicle
    {
        public Plane(string brand, string model, int year, int wheels, int speed) : base(brand, model, year, wheels , speed)
        {
            wheels = 8;
        }

        public override void Drive()
        {
            Console.WriteLine("Vroooooooom");
        }
    }
}
