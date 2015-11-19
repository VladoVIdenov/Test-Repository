using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16ExamEncryptTheMessages
{
    class EncryptTheMessages
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;
            List<string> message = new List<string>();
            do
            {
                inputString = Console.ReadLine();
            } while (inputString.ToUpper() != "START");

            inputString = Console.ReadLine();

            while (inputString.ToUpper() != "END")
            {


                if (inputString != string.Empty)
                {
                    string decryptedMessage = string.Empty;
                    for (int letter = 0; letter < inputString.Length; letter++)
                    {
                        if ((inputString[letter] >= 'a' && inputString[letter] <= 'z') ||
                            (inputString[letter] >= 'A' && inputString[letter] <= 'Z'))
                        {
                            if ((inputString[letter] >= 'a' && inputString[letter] <= 'm') ||
                                (inputString[letter] >= 'A' && inputString[letter] <= 'M'))
                            {
                                decryptedMessage += (char)(inputString[letter] + 13);
                            }
                            else
                            {
                                decryptedMessage += (char)(inputString[letter] - 13);
                            }

                        }
                        else
                        {
                            switch (inputString[letter])
                            {
                                case ' ':
                                    decryptedMessage += '+';
                                    break;
                                case ',':
                                    decryptedMessage += '%';
                                    break;
                                case '.':
                                    decryptedMessage += '&';
                                    break;
                                case '?':
                                    decryptedMessage += '#';
                                    break;
                                case '!':
                                    decryptedMessage += '$';
                                    break;
                                default:
                                    decryptedMessage += inputString[letter];
                                    break;
                            }
                        }
                    }
                    char[] reversedStringArray = decryptedMessage.ToCharArray();
                    Array.Reverse(reversedStringArray);
                    decryptedMessage = new string(reversedStringArray);
                    message.Add(decryptedMessage);
                }
                inputString = Console.ReadLine();
            }
            if (message.Count != 0)
            {
                Console.WriteLine("Total number of messages: {0}", message.Count);
                foreach (var msg in message)
                {
                    Console.WriteLine(msg);
                }
            }
            else
            {
                Console.WriteLine("No messages sent.");
            }
        }
    }
}
