using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class Arraycompareval
    {
        public Arraycompareval()
        {
            int[] a = new int[] { 5, 7, 8, 9 };
            int[] b = new int[] { 5, 7, 8, 9 };
            if (a.Length == b.Length)
            {
                int temp = 0;
                for(int i=0; i < b.Length; i++)
                {
                    if (a[i] == b[i]) 
                    {
                        temp++;
                    }
                        

                }
                if (temp == a.Length)

                {
                    Console.WriteLine("same");
                }

             
                 else
                    Console.WriteLine("not same");
            }

        }

    }
}
