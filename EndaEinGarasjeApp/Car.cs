﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndaEinGarasjeApp
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model, int year, int wheels, int speed) : base(brand, model, year, wheels, speed)
        {
        }


        public override void Drive()
        {
            Console.WriteLine("Broom Broom!");
        }
    }
}
