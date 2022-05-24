using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Abstract_Factory
{
     interface ITireSmall
    {
        void drowSmallTire();
    }

    class TireSmall : ITireSmall
    {
        public void drowSmallTire()
        {
            Console.WriteLine("THIS IS : tire small");
        }
    }
}
