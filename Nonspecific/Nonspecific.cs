using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstSum;

namespace Nonspecific
{
    public class Average
    {
        public int Grade(int track)
        {
            int grade = 0;
            int val = 0;
            track = 0;
            int sum = 0;
            int checker = 1;

            while (checker == 1)
            {
                sum = sum + val;
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
                track++;
                Console.WriteLine("Are there more tests?");
                string prompt = "Options:\n\t1 - Yes\n\t2 - No\nChoice: ";

                Console.WriteLine(prompt);
                checker = int.Parse(Console.ReadLine());
            }

            grade = sum / track;
            SumFirst gradeSum = new SumFirst();
            gradeSum.TotalGrade(grade);
            return grade;
        }
    }
}
