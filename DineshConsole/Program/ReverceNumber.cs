using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class ReverceNumber
    {
        public void rev1()
        {
            int no = 12345;
            int rev = 0;

            while (no > 0)
            {
                rev = (rev * 10) + no % 10;
                no = no / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
