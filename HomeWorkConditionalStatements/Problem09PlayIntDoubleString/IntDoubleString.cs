using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 9.	Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
//If the variable is int or double, the program increases it by one. If the variable is a string,
//the program appends "*" at the end. Print the result at the console. Use switch statement. 

namespace Problem09PlayIntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
            int inputChoice = int.Parse(Console.ReadLine());

            switch (inputChoice)
            {
                case 1:
                    Console.Write("Please enter an int: ");
                    int inputInteger = int.Parse(Console.ReadLine());
                    inputInteger += 1;
                    Console.WriteLine(inputInteger);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double inputDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    inputDouble += 1;
                    Console.WriteLine(inputDouble);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string userString = Console.ReadLine();
                    Console.WriteLine(userString + "*");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
