using System;
using System.Text;

    class PrintAsciiTable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i <= 255; i++)
			{
                char character = (char)i;
                Console.WriteLine("{0} : {1}", i, character);
			    
			}
        }
    }

