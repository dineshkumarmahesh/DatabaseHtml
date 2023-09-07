using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class loop_using_temp
    {
        
            public void total1()
            {
                int temp1 = 0;
                Console.WriteLine("enter the array size");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] s = new int[size];
                for (int a = 0; a < size; a++)
                {
                    Console.WriteLine("enter value");
                    s[a] = Convert.ToInt32(Console.ReadLine());
                    temp1 = temp1 + s[a];
                }
                Console.WriteLine(temp1);
            }
        
    }
}
