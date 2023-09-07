using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class duplicate
    {
        int count;
        public void Duplicate()
        {
            string a = "chennai";
            string duplicate = string.Empty;
            //int count;
            string temp = string.Empty;

            for(int i=0;i<a.Length;i++)
            {
                if (temp.Contains(a[i]))
                    temp = temp + a[i];
                if(!(duplicate.Contains(a[i])))
                {
                    duplicate = duplicate + a[i];
                    count++;
                }
            }
            Console.WriteLine("the duplicate letter is dinesh=" + duplicate);
            Console.WriteLine("count of the duplicate number is " + count);

        }
    }
}
