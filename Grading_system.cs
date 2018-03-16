using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grading_system
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Grading system

            int ENG, MATH, SST, SCI, Mark, Age;
            string Name, Sex, Class, idno;

            Console.WriteLine("Student IDNo :");
            idno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Name :");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Sex :");
            Sex = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Age :");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Class :");
            Class = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ENGLISH Mark");
            ENG = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MATH Mark");
            MATH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SST mark");
            SST = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SCI Mark");
            SCI = Convert.ToInt32(Console.ReadLine());
            Mark = ((ENG + MATH + SST + SCI) / 4);
            Console.WriteLine("Your Average Mark is :");
            Console.WriteLine(Mark);

            if (Mark >= 80)
            {
                Console.WriteLine("A");
                Console.WriteLine("Excellent");
            }
            else if (Mark >= 70)
            {
                Console.WriteLine("B");
                Console.WriteLine("Well Done");
            }
            else if (Mark >= 60) 
            {
                Console.WriteLine("C");
                Console.WriteLine("Good");
            }
            else if (Mark >= 50)
            {
                Console.WriteLine("D");
                Console.WriteLine("Fair");
            }
            else if(Mark>=45)
            {
                Console.WriteLine("E");
                Console.WriteLine("Improve");
            }
            else
            {
                Console.WriteLine("F");
                Console.WriteLine("Below Average");
            }

            Console.ReadLine();
        }
    }
}
