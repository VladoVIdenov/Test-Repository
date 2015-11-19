using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 13.** Problem 1 – Compound interest
namespace Problem13ExamCompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");

            double sumOfLoan = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double yearsToPay = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double bankYearlyIntersest = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double friendInterest = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double futureSumForBank = sumOfLoan * Math.Pow((1 + bankYearlyIntersest), yearsToPay);
            double futureSUmForFriend = sumOfLoan * (1 + friendInterest);

            if (futureSumForBank < futureSUmForFriend)
            {
                Console.WriteLine("{0:F2} Bank", futureSumForBank);
            }
            else
            {
                Console.WriteLine("{0:F2} Friend", futureSUmForFriend);
            }
        }
    }
}
