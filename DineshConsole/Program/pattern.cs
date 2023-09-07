using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class pattern
    {
        public pattern()
        {

            string a = string.Empty; 

           //for(var i=1;i<=4;i++)

            for(var i=4;i>=0;i--)
            {
               // for (var j = 1; j < i;i++)

                for(var j=4;j>i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
