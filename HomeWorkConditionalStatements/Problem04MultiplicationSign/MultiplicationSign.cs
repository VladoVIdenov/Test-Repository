using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 4.Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
//WITHOUT CALCULATING IT. Use a sequence of if operators. 

namespace Problem04MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");
            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double thirdNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) 
            {
                Console.WriteLine("+");
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            else if ((firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||     // +
                     (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) ||     // +
                     (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0))       // +
            {
                Console.WriteLine("+");
            }
            else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) ||     // -
                     (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||     // -
                     (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0))       // -
            {
                Console.WriteLine("-");
            }
            else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
