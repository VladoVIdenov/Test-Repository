using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

namespace Problem11NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 0 and 999:  ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < 0 || inputNumber >999)
            {
                Console.WriteLine("Wrong Number");
            }
            string[] smallNumber = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] smallNumberToUpper = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] tenToNineteen = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sexteen", "seventeen", "eighteen", "nineteen" };
            string[] tenToNineteenToUpper = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sexteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = new string[] {"zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            string[] tensToUpper = new string[] {"Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (inputNumber < 10)
            {
                
                Console.WriteLine(smallNumberToUpper[inputNumber]);
            }
            else if (inputNumber > 9 && inputNumber <20)
            {
                inputNumber = inputNumber % 10;
                Console.WriteLine(tenToNineteenToUpper[inputNumber]);
            }
            else if (inputNumber > 19 && inputNumber < 100)
            {
                if (inputNumber / 10 == 0)
                {
                    Console.WriteLine(tensToUpper[inputNumber / 10] );
                }
                else
                {
                    Console.WriteLine(tensToUpper[inputNumber / 10] + " " + smallNumber[inputNumber % 10]);
                }
            }
            else if (inputNumber > 99 && inputNumber < 1000)
            {
                if (inputNumber % 100 == 0)
                {
                    Console.WriteLine(smallNumberToUpper[inputNumber / 100] + " hundred");
                }
                else if (inputNumber - ((inputNumber / 100) * 100) < 20 && inputNumber - (inputNumber / 100 ) *  100 > 9  )
                {
                    Console.WriteLine(smallNumberToUpper[inputNumber / 100] + " hundred and " + tenToNineteen[(inputNumber % 100) % 10] );
                }
                else if (inputNumber - ((inputNumber / 100) * 100) < 10)
                {
                    Console.WriteLine(smallNumberToUpper[inputNumber / 100] + " hundred and " + smallNumber[inputNumber % 10]);
                }
                else if ((inputNumber - (inputNumber / 100) * 100) % 10 == 0)
                {
                    Console.WriteLine(smallNumberToUpper[inputNumber / 100] + " hundred and " + tens[(inputNumber % 10)] );
                }
                else 
                {
                    Console.WriteLine(smallNumberToUpper[inputNumber / 100] + " hundred and " + tens[(inputNumber / 10) % 10] + " " + smallNumber[inputNumber  % 10]);
                }
            }
            
            
        }
    }
}
