using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class vowels
    {
        public void vowelslet()
        {
            Console.WriteLine("To check vowels or not");
            char letter = Convert.ToChar(Console.ReadLine());
            if(letter=='a'|| letter=='e'||letter== 'i'||letter =='o'||letter=='u')
            {
                Console.WriteLine("its vowels");
            }
            else
            {
                Console.WriteLine("its not vowels");
            }
        }
    }
}