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
                Console.WriteLine("Give a value between 0 and 100");
                x = x + y;
                y = double.Parse(Console.ReadLine());
                if ((y >= 0) && (y <= 100))
                {

                } else {
                    Console.WriteLine("Incorrect number input");
                    y = 0;
                    val--;
                }
                val++;
            } while (val < 10);
            Console.WriteLine($"The total sum is {x}");
            return x;
        }

        public double Grades(double value)
        {
            double z = Sum(0) / 10;
            if ((z <= 90) && (z >= 100))
            {
                Console.WriteLine($"Overall grade is an {z}, which is an 'A'");
            }
            if ((z <= 80) && (z >= 89))
            {
                Console.WriteLine($"Overall grade is an {z}, which is an 'D'");
            }
            if ((z <= 60) && (z >= 79))
            {
                Console.WriteLine($"Overall grade is an {z}, which is an 'C'");
            }
            if ((z <= 50) && (z >= 69))
            {
                Console.WriteLine($"Overall grade is an {z}, which is an 'D'");
            }
            if ((z <= 0) && (z >= 49))
            {
                Console.WriteLine($"Overall grade is an {z}, which is an 'F'");
            }
            return z;
        }
    }
}
