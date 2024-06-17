using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndaEinGarasjeApp
{
    internal class Garage
    {
        private List<Vehicle> GarageList = new List<Vehicle>()
        {
            new Car("Ford", "Focus", 1999, 4, 120),
            new Car("Toyota", "Camry", 2020, 4, 217),
            new Car("Honda", "Accord", 2021, 4, 125),
            new Car("Ford", "Mustang", 2022, 4, 155),
            new Boat("Boston Whaler", "280 Outrage", 2019, 0, 55),
            new Boat("Yamaha", "242X E-Series", 2020, 0, 50),
            new Boat("Sea Ray", "SLX 400", 2021, 0, 43),
            new Plane("Cessna", "172 Skyhawk", 2018, 3, 140),
            new Plane("Boeing", "737", 2015, 6, 588),
            new Plane("Airbus", "A320", 2017, 6, 511)

        };



        public void DisplayAll()
        {
            Console.Clear();
            Console.WriteLine("Your Garage:");
            

            GarageList[ChooseVehicle()].PrintInfo();

        }

        public void DisplayCar()
        {
            
            List<Vehicle> cars = new List<Vehicle>();

            foreach (var vehicle in GarageList)
            {
                if (vehicle is Car)
                {
                    cars.Add(vehicle);
                }
            }
            
            DisplayList(cars);

        }

        public void DisplayBoat()
        {

            List<Vehicle> boats = new List<Vehicle>();

            foreach (var vehicle in GarageList)
            {
                if (vehicle is Boat)
                {
                    boats.Add(vehicle);
                }
            }

            DisplayList(boats);

        }

        public void DisplayPlane()
        {

            List<Vehicle> planes = new List<Vehicle>();

            foreach (var vehicle in GarageList)
            {
                if (vehicle is Plane)
                {
                    planes.Add(vehicle);
                }
            }

            DisplayList(planes);

        }

        public void DisplayList(List<Vehicle> list)
        {
            Console.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i].getBrand()} - {list[i].getModel()}.");
            }

            int userInput = Convert.ToInt32(Console.ReadLine());
            userInput--;

            list[userInput].PrintInfo();
        }

        public void AddVehicle()
        {   
            Console.Clear();
            Console.WriteLine("What brand is your vehicle?");
            string brand = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's the model of your vehicle?");
            string model = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What year is your vehicle from?");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("How many wheels does your vehicle have?");
            int wheels = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What's the speed of your vehicle?");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("What vehicle is it?");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Boat");
            Console.WriteLine("3. Plane");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    GarageList.Add(new Car(brand, model, year, wheels, speed));
                    break;
                case "2":
                    GarageList.Add(new Boat(brand, model, year, wheels, speed));
                    break;
                case "3":
                    GarageList.Add(new Plane(brand, model, year, wheels, speed));
                    break;
            }

            Console.Clear();
            Console.WriteLine($"{brand}, {model} successfully added");
            Console.ReadLine();
        }

        public void Race()
        {
            Console.Clear();
            Console.WriteLine("What's the first vehicle?");
            Vehicle vehicle1 = GarageList[ChooseVehicle()];
            Console.Clear();
            Console.WriteLine("What's the second vehicle?");
            Vehicle vehicle2 = GarageList[ChooseVehicle()];

            vehicle1.distance = 0;
            vehicle2.distance = 0;

            while (vehicle1.distance < 1000 && vehicle2.distance < 1000)
            {
                Console.Clear();
                Console.WriteLine($"{vehicle1.getBrand()}, {vehicle1.getModel()} \t \t {vehicle2.getBrand()}, {vehicle2.getModel()}");
                Console.WriteLine($"{vehicle1.distance} / 1000 \t \t \t {vehicle2.distance} / 1000");
                vehicle1.distance += vehicle1.getSpeed();
                vehicle2.distance += vehicle2.getSpeed();
                Thread.Sleep(500);
            }

            if (vehicle1.distance > vehicle2.distance)
            {
                Console.WriteLine($"{vehicle1.getBrand()} {vehicle1.getModel()} won!");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine($"{vehicle2.getBrand()} {vehicle2.getModel()} won!");
                Console.ReadKey(true);
            }

        }

        public int ChooseVehicle()
        {
            for (int i = 0; i < GarageList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {GarageList[i].getBrand()} - {GarageList[i].getModel()}.");
            }
            int userInput = Convert.ToInt32(Console.ReadLine());
            userInput--;
            return userInput;
        }

    }
}
