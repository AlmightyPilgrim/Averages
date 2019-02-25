using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSum
{
    public class SumFirst
    {
        public double Sum (double count)
        {
            double sum = 0;
            double val = 0;
            double track = 0;
            while (track < count)
            {
                sum = sum + val;
                Console.WriteLine("Give a value between 0 and 100");
                val = double.Parse(Console.ReadLine());
                if ((val >= 0) && (val <= 100))
                {

                } else {
                    Console.WriteLine("Incorrect number input");
                    val = 0;
                    track--;
                }
                track++;
            } ;
            Console.WriteLine($"The total sum is {sum}");
            return sum;
        }

        public double Grades(double count)
        {
            double track = 0;
            double sum = 0;
            double val = 0;
            while (track < 10)
            {
                sum = sum + val;
                Console.WriteLine("Input scores");
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

            double grade = sum / count;
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
