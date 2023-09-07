using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class AssendingOrder
    {
        public void AssendingOrder1()
        {
            Console.WriteLine("int[] a=new int[] {1,2,5,7,8,9};");
            Console.WriteLine("");
            int[] a = new int[] { 1, 2, 5, 7, 8, 9 };
            
            for (int i =0; i< a.Length; i++)
                
            {
                int temp = 0;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] >= a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);

        }    
    }
}
