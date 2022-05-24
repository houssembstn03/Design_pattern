using Design_pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Abstract_Factory
{
    class Factory : Abstract_factory
    {
        public void drowTire(string type)
        {
            switch (type)
            {
                case "U":
                    new TireLarge().drowLargeTire();
                    break;
                case "S":
                    new TireSmall().drowSmallTire();
                    break;
                
                default:
                    new TireXLarge().drowXLargTire();
                    break;
            }
        }

        public Car GetYourCar(string Type)
        {
            throw new NotImplementedException();
        }
    }
}
