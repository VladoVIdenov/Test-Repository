using System;
using System.Linq;
using System.Numerics;

namespace Problem14ExamPetersGame
{
    class PetersGame
    {
        static void Main(string[] args)
        {
            BigInteger startNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger finalNumber = BigInteger.Parse(Console.ReadLine());
            string replaceString = Console.ReadLine();
            BigInteger middleCount = 0;
            for (BigInteger i = startNumber; i < finalNumber; i++)
            {
                if (i % 5 == 0)
                {
                    middleCount += i;
                }
                else 
                {
                    middleCount += (i % 5);
                }
            }
            if (middleCount % 2 == 0)
            {
                string middleCountString = middleCount.ToString();
                char replacedChar = middleCountString[0];
                string charString = replacedChar.ToString();
                string finalString = middleCountString.Replace(charString, replaceString);
                Console.WriteLine(finalString);
            }
            else
            {
                string middleCountString = middleCount.ToString();
                char replacedChar = middleCountString.Last();
                string charString = replacedChar.ToString();
                string finalString = middleCountString.Replace(charString, replaceString);
                Console.WriteLine(finalString);
            }
        }
    }
}
