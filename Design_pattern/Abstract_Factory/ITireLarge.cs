using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Abstract_Factory
{
     interface ITireLarge
    {
        void drowLargeTire();
    }
    class TireLarge : ITireLarge
    {
        public void drowLargeTire()
        {
            Console.WriteLine("THIS IS : tire large");
        }
    }
}
