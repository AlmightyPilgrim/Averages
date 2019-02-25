using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSum
{
    public class SumFirst
    {
        public double Sum (double value)
        {
            double val = 0;
            double x = 0;
            double y = 0;
            do
            {
                x = x + y;
                Console.WriteLine("Give a value between 0 and 100");
                y = double.Parse(Console.ReadLine());
                if ((y >= 0) && (y <= 100))
                {

                } else {
                    Console.WriteLine("Incorrect number input");
                    y = 0;
                    val--;
                }
                val++;
            } while (val < 11);
            Console.WriteLine($"The total sum is {x}");
            return x;
        }

        public double Grades(double value)
        {
            double count = 0;
            double sum = 0;
            double val = 0;
            do
            {
                sum = sum + val;
                Console.WriteLine("Give a value between 0 and 100");
                val = double.Parse(Console.ReadLine());
                if ((val >= 0) && (val <= 100))
                { 
                }
                else
                {
                    Console.WriteLine("Incorrect number input");
                    val = 0;
                    count--;
                }
                count++;
            } while (count < 10);

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
