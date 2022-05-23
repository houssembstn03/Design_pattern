using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern
{
    // singleton design pattern eager loading
     sealed class Singleton
     {
        private static int counter;
        private static Singleton instance = new Singleton();
        public string _name;
        private Singleton()
        {
            counter += 1;
            Console.WriteLine("instatnce num " + counter);

        }

        public static Singleton getInstance()
        {
            
            return instance;

        }

        public void getName(string name)
        {
            _name = name;
            
        }


        public void print()
        {
            if (_name == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine(_name);
            }
        }

        
     }
}
