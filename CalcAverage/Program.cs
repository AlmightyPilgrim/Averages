using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstSum;
using InputNumTest;
using Nonspecific;

namespace CalcAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            SumFirst totalSum = new SumFirst();
            Console.WriteLine("Enter number of values to be inputted");
            int count = int.Parse(Console.ReadLine());
            totalSum.Sum(count);
            totalSum.Grades(count);

            TeacherInput teacherGrade = new TeacherInput();
            Console.WriteLine("Enter number of tests to be averaged");
            count = int.Parse(Console.ReadLine());
            teacherGrade.Grade(count);

            Average randomTest = new Average();
            Console.WriteLine("Please being entering scores");
            randomTest.Grade(0);
        }
    }
}
