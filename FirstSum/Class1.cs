using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSum
{
    public class SumFirst
    {
        public int Sum (int count)
        {
            int sum = 0;
            int val = 0;
            int track = 0;
            while (track < count)
            {
                
                Console.WriteLine("Give a value between 0 and 100");
                val = int.Parse(Console.ReadLine());
                if ((val >= 0) && (val <= 100))
                {

                } else {
                    Console.WriteLine("Incorrect number input");
                    val = 0;
                    track--;
                }
                sum = sum + val;
                track++;
            } ;
            Console.WriteLine($"The total sum is {sum}");
            return sum;
        }

        public int Grades(int count)
        {
            int track = 0;
            int sum = 0;
            int val = 0;
            while (track < count)
            {
                
                Console.WriteLine("Input scores");
                val = int.Parse(Console.ReadLine());
                if ((val >= 0) && (val <= 100))
                { 
                }
                else
                {
                    Console.WriteLine("Incorrect number input");
                    val = 0;
                    track--;
                }
                sum = sum + val;
                track++;
            }

            int grade = sum / count;
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
        public int totalGrade (int grade)
        {
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
