using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 1. Exchange If Greater
//Write an if-statement that takes two integer variables a and b and exchanges their values 
//if the first one is greater than the second one. As a result print the values a and b, 
//separated by a space. 

namespace HomeworkConditionalStatements
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {

            CultureInfo info = CultureInfo.GetCultureInfo("en-US");

            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} {1}", secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
}