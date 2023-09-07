using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineshConsole
{
    class students
    {
            public string Name;
            public int Tamil;
            public int english;
            public int maths;
    }

    class marks
    {
            public int total;
            public int avg;
            private students Marks()
            {
                students s = new students();
                /* s[0] = new students();
                 s[1] = new students();*/

                Console.WriteLine("enter your name");
                s.Name = Console.ReadLine();
                Console.WriteLine("enter your TAMIL MARK");
                s.Tamil = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your ENGLISH MARK ");
                s.english = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your MATHS MARK");
                s.maths = Convert.ToInt32(Console.ReadLine());
                return s;
            }
            public students[] studentinfo()
            {
                students[] std = new students[2];
                std[0] = Marks();
                std[1] = Marks();
                return std;

            }
        public string Grade(students s)
        {
            
            total = s.Tamil + s.english + s.maths;
            Console.WriteLine($"the total is {total}");
            avg = total / 3;
            Console.WriteLine($"the avg is {avg}");
            string grade = "grade e";
            if (avg >= 91 && avg <= 100)
            {
                grade = "grade A";

            }


            else if (avg >= 81 && avg <= 90)
            {
                grade = "grade B";
            }

            else if (avg >= 71 && avg <= 80)
            {
                grade = "grade C";
            }
            else if (avg >= 50 && avg <= 70)
            {
                grade = "grade D";
            }

            else if (avg <= 49)
            {
                grade = "grade F";
            }
            return grade;
        }

    }
}
