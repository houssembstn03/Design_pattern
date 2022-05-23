using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Factory
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
