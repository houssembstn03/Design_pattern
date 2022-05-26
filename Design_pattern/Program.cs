using System;
using Design_pattern.Factory;
using Design_pattern.Abstract_Factory;
using Design_pattern.Builder;

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

            ////test factory

            //Car car = null;
            //Console.WriteLine("select your type car U= usv car, S= Sudan car, T= track car:");
            //string type=Console.ReadLine();
            //car = new FactoryCar().GetYourCar(type);
            //RunningActions(car);

            ////test abstract factory

            //Console.WriteLine("select your type car U= usv car, S= Sudan car, T= track car:");
            //string type=Console.ReadLine();
            //Abstract_Factory.Abstract_factory af =new Abstract_Factory.Factory();
            //af.drowTire(type);

            //test builder

            Userbuilder user = UserAccount.getUserAccount();
            UserAccount account=user.SetlastName("houssem").SetfirstName("bensalha").Setemail("houssem.bensalha@gmail.com").build();
            Console.WriteLine(account.lastName);
            Console.ReadKey(true);  
        }
        public static void RunningActions(Car car)
        {
            car.showCar();
            car.RunCar();
        }
    }
}
