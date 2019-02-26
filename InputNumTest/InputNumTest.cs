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
        public int Grade(int count)
        {
            int track = 0;
            int sum = 0;
            int val = 0;
            int grade;
            while(track < count)
            {
                
                Console.WriteLine("Input Test Score");
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

            grade = sum / count;
            SumFirst gradeSum = new SumFirst();
            gradeSum.TotalGrade(grade);
            return grade;
        }
    }
}
