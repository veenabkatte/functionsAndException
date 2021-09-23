using System;

namespace FunctionsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
                MyMath myMath = new MyMath();
                myMath.Add();
                int no1 = 40;
                int no2 = 50;
                Console.WriteLine($"Sum is :{myMath.Add(no1, no2)}");
                Console.ReadLine();
            
        }
    }
}
