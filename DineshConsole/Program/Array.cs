using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class Array
    {
        public string name;
        public int tamil;
        public int english;
        public int maths;
        public int science;
        public int ss;
        public int total;
        public int average;
        public int grade;
        public void marklist()
        {
            Array[] s= new Array[1];
            s[0] = new Array();
            Console.WriteLine("enter your name");
            s[0].name =Console.ReadLine();
           Console.WriteLine("enter your tamil mark");
            s[0].tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your english mark");
            s[0].english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your maths mark");
            s[0].maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the science mark");
            s[0].science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ss mark");
            s[0].ss = Convert.ToInt32(Console.ReadLine());
            s[0].total =s[0].tamil + s[0].english + s[0].maths + s[0].science + s[0]. ss;
            Console.WriteLine("enter your total");
            Console.WriteLine(s[0].total);
            Console.WriteLine("enter your average");
            s[0].average = s[0].total / 5;
            Console.WriteLine(s[0].average);

           if (s[0].average >=100 && s[0].average>100)
            {
                Console.WriteLine("A"); 
            }
          else if (s[0].average >= 90 && s[0].average > 80) 
            {
                Console.WriteLine("B");
            }
             else if (s[0].average >= 96 && s[0].average > 80) 
            {
                Console.WriteLine("c");
            }
            else
            {

            }
        }
            



    }
}
