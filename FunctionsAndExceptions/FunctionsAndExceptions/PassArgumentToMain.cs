using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class PassArgumentToMain
    {
        static void Main(string[] args)
        {
            foreach (var str in args)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
