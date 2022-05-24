using System;
using Design_pattern.Factory;


namespace Design_pattern.Abstract_factory
{
     class FactoryCar
    {

        public Car GetYourCar(string type)
        {
            switch (type)
            {
                case "U":
                    return new SUVCar();
                case "S":
                    return  new sedanCar();
                case "T":
                
                default:
                    return new TrackCar();
            }
        }
    }
}
