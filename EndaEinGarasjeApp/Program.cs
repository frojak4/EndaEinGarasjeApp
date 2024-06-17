namespace EndaEinGarasjeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = new App();
            start.Run();
        }
    }

    internal class App
    {
        private Garage garage = new Garage();

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. See all vehicles");
                Console.WriteLine("2. See cars");
                Console.WriteLine("3. See Boats");
                Console.WriteLine("4. See Planes");
                Console.WriteLine("5. Add new Vehicle");
                Console.WriteLine("6. Race!");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        garage.DisplayAll();
                        break;
                    case "2":
                        garage.DisplayCar();
                        break;
                    case "3":
                        garage.DisplayBoat();
                        break;
                    case "4":
                        garage.DisplayPlane();
                        break;
                    case "5":
                        garage.AddVehicle();
                        break;
                    case "6":
                        garage.Race();
                        break;
                }
            }
        }
    }

}
