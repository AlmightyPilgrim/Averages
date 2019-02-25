using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputNumTest
{
    public class TeacherInput
    {
        public double Sum(double value)
        {
            double count = 0;
            double sum = 0;
            double val = 0;
            Console.WriteLine("How many tests will be inputted?");
            count = double.Parse(Console.ReadLine());
            while(count < count + 1)
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
                    count--;
                }
                count++;
            }
            
            return sum;
        }
    }
}
