using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class WordReverce
    {
        public void WordReverce1() 
        {
            Console.WriteLine("enter the sentence to revere");
            string sen = Console.ReadLine();
            string[] a = sen.Split(' ');

           for(int i=a.Length-1;i>=0;i--)
           {
                Console.WriteLine(a[i]+' ');
           }
        }
    }
}
