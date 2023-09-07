using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class FibonacciSeries
    {
        public FibonacciSeries()
        {
            int a = 10;
            int b = 5;
            int temp = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);


            for(int d=0;d<=100;d++)
            {
                temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine(temp);
            }
            
        }
    }
}
