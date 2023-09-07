using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class constructor_types
    {
        
        public constructor_types()
        {
            Console.WriteLine("default" + DateTime.UtcNow);
        }
        public constructor_types(string a)
        {
            Console.WriteLine("parameter constructor" + DateTime.Now);
        }
        static constructor_types()
        {
            Console.WriteLine("static constactor"+ DateTime.UtcNow );
        }
        
    }
}
