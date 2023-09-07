using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class factorial
    {
        public void factorial1()
        {
            int a = 5;
            int temp = 1;
            for(int i = 0; i < a; i++)
            {
                temp = temp * a;
            }
            Console.WriteLine(temp);
        }
    }
}
