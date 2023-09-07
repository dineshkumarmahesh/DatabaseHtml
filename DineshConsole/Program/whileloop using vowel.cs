using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class whileloop_using_vowel 
    {
        public void vowel() 
        {
            int i = 0;
            string a = "dinesh";
            a = a.ToLower();
            int count= 0;
            int count1 = 0;


            while (i < a.Length)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    count++;
                    
                }
                else
                {
                    count1++;
                }
                i++;
            }
            Console.WriteLine($"vovels---{count}");
            Console.WriteLine($"consonents cout---{count1}");
        }
               
    }
}
