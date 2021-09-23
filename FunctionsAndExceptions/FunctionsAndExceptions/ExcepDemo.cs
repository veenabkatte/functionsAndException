using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class ExcepDemo
    {
        static void Main()
        {

            try
            {
                Console.Write("Enter a Product Amount:");
                double proAmt = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter GST Per:");
                double gstPer = Convert.ToDouble(Console.ReadLine());

                double gstAmt = proAmt / 100 * gstPer;
                double totalProAmt = gstAmt + proAmt;
                Console.WriteLine($"Total Product amount with GST is:{totalProAmt}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
                //  To close connection close.
                //  To collect garbage.
                GC.Collect();
            }

        }
    }
}
