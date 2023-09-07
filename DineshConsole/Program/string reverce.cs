using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class string_reverce
    {
        public void stringreverce()
        {
            string a = "dinesh";
            string rev = string.Empty;

            for(int i=0; i<a.Length; i++)
            {
                rev = a[i]+ rev ;
            }
            Console.WriteLine(rev);
        }
    }
}
