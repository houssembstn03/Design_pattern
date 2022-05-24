using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Abstract_Factory
{
     interface ITireXLarge
    {
        void drowXLargTire();
    }
    class TireXLarge : ITireXLarge
    {
        public void drowXLargTire()
        {
            Console.WriteLine("THIS IS : tire X large");
        }
    }
}
