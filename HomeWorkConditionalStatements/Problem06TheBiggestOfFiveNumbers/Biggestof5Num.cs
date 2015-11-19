using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem06TheBiggestOfFiveNumbers
{
    class BiggestOf5Num
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");

            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double thirdNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double fourthNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double fifthNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber) && 
                (firstNumber > fourthNumber) && (firstNumber > fifthNumber))
            {
                Console.WriteLine(firstNumber);
            }
            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber) && 
                (secondNumber > fourthNumber) && (secondNumber > fifthNumber))
            {
                Console.WriteLine(secondNumber);
            }
            else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber) &&
                    (thirdNumber > fourthNumber) && (thirdNumber > fifthNumber))
            {
                Console.WriteLine(thirdNumber);
            }
            else if ((fourthNumber > firstNumber ) && (fourthNumber > secondNumber) &&
                    (fourthNumber > thirdNumber) && (fourthNumber > fifthNumber))
            {
                Console.WriteLine(fourthNumber);
            }
            else
            {
                Console.WriteLine(fifthNumber);
            }
        }
    }
}
