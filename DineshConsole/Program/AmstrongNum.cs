using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class AmstrongNum
    {
        public void Amstrongnum1()
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int d = 0;

            while (a != 0)
            {
                int c = a % 10;
                d = d + (c * c * c);
                a = a / 10;
            }
            if(b==d)
            {
                Console.WriteLine("enter the number is amstrong");

            }
            else
            {
                Console.Write("the number is not amstrong");
            }
        } 
    }
}
