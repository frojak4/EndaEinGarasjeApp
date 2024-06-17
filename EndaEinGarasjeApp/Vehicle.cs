using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndaEinGarasjeApp
{
    internal abstract class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;
        private int _wheels;
        private int _speed;
        public int distance;

        public Vehicle(string brand, string model, int year,int wheels, int speed)
        {
            _speed = speed;
            _brand = brand;
            _model = model;
            _year = year;
            _wheels = wheels;
        }

        public virtual void Drive()
        {
            Console.WriteLine("This vehicle cannot drive.");
        }

        public virtual void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine($"Vehicle: {_brand} - {_model} - {_year}");
            Console.WriteLine($"Wheels: {_wheels} - Speed {_speed}");
            Drive();
            Console.ReadKey();
        }

        public string getBrand()
        {
            return _brand;
        }

        public string getModel()
        {
            return _model;
        }

        public int getSpeed()
        {
            return _speed;
        }

    }
}
