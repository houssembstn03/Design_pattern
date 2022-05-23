using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_pattern.Factory;

namespace Design_pattern
{
     class Program
    {
        static void Main(string[] args)
        {
            ////test singleton 
            //Singleton s = Singleton.getInstance();
            //s.getName("houssem");
            //s.print();

            //Singleton s2 = Singleton.getInstance();
            //s2.print();

            //test factory
            Car car = null;
            Console.WriteLine("select your type car U= usv car, S= Sudan car, T= track car:");
            string type=Console.ReadLine();

            car = new FactoryCar().GetYourCar(type);

            RunningActions(car);

            Console.ReadKey(true);  
        }
        public static void RunningActions(Car car)
        {
            car.showCar();
            car.RunCar();
        }
          
    }
}
