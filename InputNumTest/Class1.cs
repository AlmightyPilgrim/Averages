﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputNumTest
{
    public class TeacherInput
    {
        public double Grade(double value)
        {
            double count = 0;
            double track = 0;
            double sum = 0;
            double val = 0;
            double grade;
            Console.WriteLine("How many tests will be inputted?");
            count = double.Parse(Console.ReadLine());
            while(track > count)
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
            
            return sum;
        }
    }
}
