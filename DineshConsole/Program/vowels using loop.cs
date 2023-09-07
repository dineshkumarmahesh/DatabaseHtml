using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class vowels_using_loop
    {
        public void vowel()
        {
              string sen;
              Console.WriteLine("Enter sentence to check vovel or not");
              sen = Console.ReadLine();
              sen = sen.ToLower();

              int temp = 0;
              int temp1 = 0;

            for (int i = 0; i<sen.Length;i++)
            {
                if (sen[i] == 'a'||sen[i]=='e'|| sen[i] == 'i'|| sen[i] == 'o' || sen[i] == 'u')
                {
                    temp++;
                }
                else
                {
                    temp1++;
                }
            }
            Console.WriteLine($"vovels---{temp}");
            Console.WriteLine($"consonents cout---{temp1}");
        }
    }
}
