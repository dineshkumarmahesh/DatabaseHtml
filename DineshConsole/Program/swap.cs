using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class swap
    {
        public void swap1()
        {
            int a = 5;
            int b = 10;


            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public void swap2()
        {
            int a = 20;
            int b = 30;
            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

       
        }
    }
}
