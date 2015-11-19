using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 5.	The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

namespace Problem05TheBiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");

            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double thirdNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((firstNumber > secondNumber) && ( firstNumber > thirdNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
