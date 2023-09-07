using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class whileloop_Using_Array
    {
          public void Total()
        {
            int temp = 0;
            int[] a = { 10, 20, 30, 40, 50 };
            int i = 0;
            while ( i<a.Length )
                {
                temp = temp + a[i];
                i++;
                }
            Console.WriteLine(temp);
    }
    }
}
