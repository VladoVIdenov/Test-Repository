using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3.	Check for a Play Card
//Classical play cards use the following signs to designate the card face: 
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
//and prints “yes” if it is a valid card sign or “no” otherwise.

namespace Problem03CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            int playCardSign = 0;

            if (int.TryParse(str, out playCardSign))
            {
                if ((playCardSign >= 2) && (playCardSign <= 10))
                   
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else if ((str == "J") || (str == "Q") ||
                   ((str == "K") || (playCardSign == 'A')))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
