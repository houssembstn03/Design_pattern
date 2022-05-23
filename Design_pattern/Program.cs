using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern
{
     class Program
    {
        static void Main(string[] args)
        {
            //test singleton 
            Singleton s = Singleton.getInstance();
            s.getName("houssem");
            s.print();

            Singleton s2 = Singleton.getInstance();
            s2.print();

            Console.ReadKey(true);  
        }
    }
}
