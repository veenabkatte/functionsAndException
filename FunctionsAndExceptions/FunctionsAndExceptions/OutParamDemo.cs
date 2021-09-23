using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class OutParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            double gstAmt;
            Console.WriteLine($"Total Product Amount is:{myMath.GstCalc(1000, 8, out gstAmt)}");
            Console.WriteLine($"GST Amount is:{gstAmt}");
            Console.ReadLine();
        }
    }
}
