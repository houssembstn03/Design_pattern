using System;

namespace Design_pattern.Factory
{
    abstract class Car
    {
        public string CarName { get; set; }
        public int CarModel { get; set; }

        public void RunCar()
        {
            Console.WriteLine(CarName + " is running");
        }

        public void showCar()
        {
            Console.WriteLine(CarModel + " is showing");
        }

    }
}
