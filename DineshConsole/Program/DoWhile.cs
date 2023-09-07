using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class DoWhile
    {
        public DoWhile()
        {
            int b;

            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");

                b = Convert.ToInt32(Console.ReadLine());

                switch (b)
                {
                    case 1:
                        Console.WriteLine("Enter the 1st number");
                        int first = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the 1st number");
                        int second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first + second);
                        break;
                    case 2:
                        Console.WriteLine("Enter the 1st number");
                        int sub1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the 1st number");
                        int sub2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(sub1 - sub2);
                        break;
                    case 3:
                        Console.WriteLine("Enter the 1st number");
                        int re1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the 1st number");
                        int re2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(re1 - 2);
                        break;
                    default:
                        Console.WriteLine("Please give a valid OPtion");
                        break;
                }

            } while (b != 0);


        }



    }
}
