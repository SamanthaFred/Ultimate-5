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

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("MUBS Primary School - Nakawa");

            Console.WriteLine("HERE IS YOUR ACADEMIC TRANSCRIPT");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(" STUDENT DETAILS");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("STUDENT IDNO :");
            Console.WriteLine(idno);
            Console.WriteLine("NAME :");
            Console.WriteLine(Name);
            Console.WriteLine("SEX :");
            Console.WriteLine(Sex);
            Console.WriteLine("CLASS :");
            Console.WriteLine(Class);
            Console.WriteLine("AGE :");
            Console.WriteLine(Age);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("SUBJECTS");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("ENGLISH :");
            Console.WriteLine(ENG);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("MATHEMATICS:");
            Console.WriteLine(MATH);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("SOCIAL STUDIES:");
            Console.WriteLine(SST);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("SCIENCE:");
            Console.WriteLine(SCI);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("AVERAGE MARK:");
            Console.WriteLine(Mark);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("WILFRED OYOO");
            Console.ReadLine();
        }
    }
}
