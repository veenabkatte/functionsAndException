using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class OptionalParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine($"Size is:{myMath.Size(20)}");
            Console.WriteLine($"Size is:{myMath.Size(20, 20)}");
            Console.WriteLine(myMath.StudentDetails(20, "Scott", city: "Mumbai"));
            Console.ReadLine();
        }
    }
}
