using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class MyMath
    {

        /// <summary>
        /// This function prints addition of two numbers
        /// </summary>
        public void Add()
        {
            int num1 = 30;
            int num2 = 40;
            int sum = num1 + num2;
            Console.WriteLine($"Sum is :{sum}");
        }
        /// <summary>
        /// This function returns sum of two numbers.
        /// </summary>
        /// <param name="num1">This is numeric argument</param>
        /// <param name="num2">This is numeric argument</param>
        /// <returns></returns>
        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// This function accept byval paramater
        /// </summary>
        /// <param name="x">numeric value</param>
        /// <returns></returns>
        public int Increment(int x)
        {
            x++;
            return x;
        }

        /// <summary>
        /// This function Accept byref paramater
        /// </summary>
        /// <param name="x">memory address of int</param>
        /// <returns></returns>
        public int Increment(ref int x)
        {
            x++;
            return x;
        }

        /// <summary>
        /// This function returns total product amount with GST and GST Amount
        /// </summary>
        /// <param name="proAmount">Enter Product Price</param>
        /// <param name="per">Enter GST Percentage</param>
        /// <param name="gstAmount">This param will hold GST Amount</param>
        /// <returns></returns>
        public double GstCalc(double proAmount, double per, out double gstAmount)
        {
            double gstAmt = proAmount / 100 * per;
            gstAmount = gstAmt; // out param must be assigned
            double proAmt = proAmount + gstAmount;
            return proAmt;
        }

        /// <summary>
        /// This function returns Size.
        /// </summary>
        /// <param name="height">Enter height in inches</param>
        /// <param name="width">Enter width in inches [its Optional]</param>
        /// <returns></returns>
        public int Size(int height, int width = 10)
        {
            return height * width;
        }

        /// <summary>
        /// This function accept student details with some optional inputs
        /// </summary>
        /// <param name="age">Enter Age in year</param>
        /// <param name="name">Enter full name</param>
        /// <param name="city">Enter city [optional]</param>
        /// <param name="state">Enter State [optional]</param>
        /// <returns></returns>
        public string StudentDetails(int age, string name, string state = "MH", string city = "Pune")
        {
            //return string.Format("Age={0}\nName={1}\nCity={2}\nState={3}",age,name,city,state);
            return $"Age={age}\nName={name}\nCity={city}\nState={state}";
        }

        /// <summary>
        /// This function prints marks
        /// </summary>
        /// <param name="marks">Enter marks</param>
        public void PrintMarks(params int[] marks)
        {
            foreach (var mark in marks)
            {
                Console.Write($"{mark}\t");
            }
        }

        /// <summary>
        /// This is recursive function
        /// </summary>
        /// <param name="x">enter a number</param>
        public void MyRecFunction(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine($"{x}");
                x++;
                MyRecFunction(x);
            }
        }
    }
}

