using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstSum;

namespace CalcAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            SumFirst totalSum = new SumFirst();
            totalSum.Sum(0);

            totalSum.Grades(0);
        }
    }
}
