using Design_pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Abstract_Factory
{
     interface Abstract_factory
    {
        void drowTire(string Tire);
        Car GetYourCar(string Type);
    }
}
