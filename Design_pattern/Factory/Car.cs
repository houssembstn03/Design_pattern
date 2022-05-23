using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
