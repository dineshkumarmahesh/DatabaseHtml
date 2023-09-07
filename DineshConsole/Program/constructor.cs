using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class constructor
    {
        public int tamil, english, maths, science, socialscience,total,average;

        public constructor()
        {
            Console.WriteLine("enter the tamil mark");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the english mark");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the maths mark");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the science mark");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the socialscience mark");
            int socialscience = Convert.ToInt32(Console.ReadLine());
        }
        public void markstotal()
        {
            total = tamil + english + maths + science + socialscience;
            Console.WriteLine($"your total is:{total}");
            
        }
        public void markaverage()
        {
            average = total / 5;
            Console.WriteLine($"your total is:{average}");
        }
        
    }
}
