using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class CustomExcepDemo
    {
        static void Main()
        {
            try
            {
                Employee employee = new Employee();
                employee.ValidateEmployeeCode(0, "Scott");
            }
            catch (InvalidEmployeeCode ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
