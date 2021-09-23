using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class ByValByRefDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            int a = 99;
            Console.WriteLine($"Incremented value={myMath.Increment(a)}");
            Console.WriteLine($"Value of local variable={a}");
            Console.WriteLine($"Incremented value={myMath.Increment(ref a)}");
            Console.WriteLine($"Value of local variable={a}");

            Console.ReadLine();
        }
    }
}
