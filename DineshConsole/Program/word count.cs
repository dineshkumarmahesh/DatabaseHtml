using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class word_count
    {
        public void wordcount()
        {
            Console.WriteLine("enter your word");
            string p = Console.ReadLine();
            int temp = 0;
            p = p.Trim();
            for(var i=0;i<p.Length;i++)
            {
                if(p[i]==' ')
                {
                    temp++;
                }
            }
            Console.WriteLine(temp + 1);
        }
        public void wordcount1()
        {
            Console.WriteLine("enter your word");
            string pp = Console.ReadLine();
            var pv = pp.Split(' ');
            Console.WriteLine(pv.Length);
        }

    }
}
