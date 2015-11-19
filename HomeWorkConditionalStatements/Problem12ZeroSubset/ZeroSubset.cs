using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12.	* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
//Assume that repeating the same subset several times is not a problem. 

namespace Problem12ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
            {
                Console.WriteLine("no zero subset");
            }
            else
            {
                //a
                if (a + b + c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, (a + b + c + d + e));
                }
                if (a + b + c + d == 0) // - e
                {
                    Console.WriteLine("{0} + {1} + {2} + {3}  = {4}", a, b, c, d, (a + b + c + d));
                }
                if (a + b + c + e == 0) // -d
                {
                    Console.WriteLine("{0} + {1} + {2} + {3}  = {4}", a, b, c, e, (a + b + c + e));
                }
                if (a + b + e + d == 0) // -c
                {
                    Console.WriteLine("{0} + {1} + {2} + {3}  = {4}", a, b, d, e, (a + b + d + e));
                }
                if (a + b + e + d == 0) // -b
                {
                    Console.WriteLine("{0} + {1} + {2} + {3}  = {4}", a, c, d, e, (a + c + d + e));
                }
                if (a + b + c == 0) // - d , e
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, (a + b + c));
                }
                if (a + b + d == 0) // - c , e
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, (a + b + d));
                }
                if (a + b + e == 0) // - c , d
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, (a + b + e));
                }
                if(a + d + c == 0) // - b , e
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", a, d, c, (a + d + c));
                }
                if (a + e + c == 0) // - b , d
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", a, e, c, (a + e + c));
                }
                if (a + d + e == 0)  // - b , c
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, (a + b + e));
                }
                if (a + b == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
                }
                if (a + c == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, c, (a + c));
                }
                if (a + d == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, d, (a + d));
                }
                if (a + e == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, e, (a + e));
                }

                // b
                if (b + c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, (b + c + d + e));
                }
                if (b + c + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, (b + c + d));
                }
                if (b + c + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", b, c, e, (b + c + e));
                }
                if (b + e == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", b, e, (b + e));
                }
                if (b + d == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", b, d, (b + d));
                }

                //c
                if (c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", c, d, e, (c + d + e));
                }
                if (c + d == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", c, d, (c + d));
                }
                if (c + e == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", c, e, (c + e));
                }

                // d / e
                if (d + e == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", d, e, (d + e));
                }
                else
                {
                    Console.WriteLine("no zero subset");
                }
            }
        }
    }
}
