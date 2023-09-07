using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class BreakContinue
    {
     public void a1()
     {
        for(int i=0;i<10;i++)
        {
           if (i == 4)
           {
                    break;
           }
             Console.WriteLine(i);
        }
           
     }
        public void a2()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }

    }
}
