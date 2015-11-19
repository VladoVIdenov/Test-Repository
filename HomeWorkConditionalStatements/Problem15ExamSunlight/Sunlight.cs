using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15ExamSunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dots = new string('.', (n + n / 2));
            Console.WriteLine(dots + "*" + dots);

            for (int i = 0; i < n - 1; i++)
            {
                string outerDots = new string('.', n / n + i);
                string innerDots = new string('.', ((n + n / 2) - (n / n + i) - 1 ));
                Console.WriteLine(outerDots + "*" + innerDots + "*" + innerDots + "*" + outerDots);
            }

            for (int i = 0; i < n / 2 ; i++)
            {
                string sunDots = new string('.', n);
                string asterisk = new string('*', n);
                Console.WriteLine(sunDots + asterisk + sunDots);
            }
            string beltAsterisk = new string('*', 3 * n);
            Console.WriteLine(beltAsterisk);

            for (int i = 0; i < n / 2; i++)
            {
                string sunDots = new string('.', n);
                string asterisk = new string('*', n);
                Console.WriteLine(sunDots + asterisk + sunDots);
            }

            for (int i = 0; i < n - 1; i++)
            {
                string innerDots = new string('.', (n / 2) + i);
                string outerDots = new string('.', ((n + n / 2) - ((n / 2) + i) - 1));
                Console.WriteLine(outerDots + "*" + innerDots + "*" + innerDots + "*" + outerDots);
            }
            Console.WriteLine(dots + "*" + dots);
        }
    }
}
