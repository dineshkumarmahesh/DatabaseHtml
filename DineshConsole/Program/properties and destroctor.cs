using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class properties_and_destroctor
    {
        public string Name { get; set; }
        public double netweight { get; set; }
        public double price { get; set; }
        public double expdate { get; set; }
    }
    class properties_and_destroctor2
    {
        public void modelmethod()
        {
            properties_and_destroctor a = new properties_and_destroctor();
            Console.WriteLine("Enter the array range");
            int size = Convert.ToInt32(Console.ReadLine());
            properties_and_destroctor[] b = new properties_and_destroctor[size];
            for (int range=0;range<size;range++)
            {
                b[range].Name = Console.ReadLine();
                b[range].netweight = Convert.ToDouble(Console.ReadLine());
                b[range].price = Convert.ToDouble(Console.ReadLine());
                b[range].expdate = Convert.ToDouble(Console.ReadLine());


            }
            Console.WriteLine(b[0]);

        }
    }
}
