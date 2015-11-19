using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 7.	Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements. Don’t use arrays and the built-in sorting functionality.

namespace Problem07Sort3NumbersWithNestedIfs
{
    class SortWIthNestedIfs
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");

            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double thirdNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);   
                }
            }
            else
            {
                if (secondNumber < thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
                    
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, secondNumber);
                }
            }
        }
    }
}
