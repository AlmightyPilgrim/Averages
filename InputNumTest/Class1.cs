using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstSum;

namespace InputNumTest
{
    public class TeacherInput
    {
        public double Grade(double count)
        {
            double track = 0;
            double sum = 0;
            double val = 0;
            double grade;
            while(track < count)
            {
                sum = sum + val;
                Console.WriteLine("Input Test Score");
                val = double.Parse(Console.ReadLine());
                if ((val >= 0) && (val <= 100))
                {

                }
                else
                {
                    Console.WriteLine("Incorrect number input");
                    val = 0;
                    track--;
                }
                track++;
            }

            grade = sum / count;
            if ((grade <= 90) && (grade >= 100))
            {
                Console.WriteLine($"Overall grade is an {grade}, which is an 'A'");
            }
            if ((grade <= 80) && (grade >= 89))
            {
                Console.WriteLine($"Overall grade is an {grade}, which is an 'D'");
            }
            if ((grade <= 60) && (grade >= 79))
            {
                Console.WriteLine($"Overall grade is an {grade}, which is an 'C'");
            }
            if ((grade <= 50) && (grade >= 69))
            {
                Console.WriteLine($"Overall grade is an {grade}, which is an 'D'");
            }
            else
            {
                Console.WriteLine($"Overall grade is an {grade}, which is an 'F'");
            }
            return grade;
        }
    }
}
