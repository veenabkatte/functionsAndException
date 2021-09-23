using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class ParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            int[] marks = { 50, 60, 70, 80, 90 };
            myMath.PrintMarks(marks);
            myMath.PrintMarks(50, 60, 70, 80, 90);
            Console.ReadLine();
        }
    }
}
