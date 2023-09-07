using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class typecasting
    {
        int total;
        public void readmark()
        {
            Console.WriteLine("tamil");
            string tamil = Console.ReadLine();
            Console.WriteLine("english");
            string english = Console.ReadLine();
            Console.WriteLine("maths");
            string maths = Console.ReadLine();
            Console.WriteLine("science");
            string science = Console.ReadLine();
            Console.WriteLine("social science");
            string socialscience = Console.ReadLine();

            //converting to int
            int tamil1 = Convert.ToInt16("tamil");
            int english1 = Convert.ToInt16("english");
            int maths1 = Convert.ToInt16("maths");
            int science1 = Convert.ToInt16("science");
            int scocialscience1 = Convert.ToInt16("socialscience");
            total = tamil1 + english1 + maths1 + science1 + scocialscience1;
            Console.WriteLine(total);
        }
        public void calcuag()
        {
            Console.WriteLine(total / 5);
        }
    }
}  
