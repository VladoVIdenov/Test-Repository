using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Persons
{
    class Problem01Persons
    {
        static void Main(string[] args)
        {
            string personName = null;
            Console.Write("Please enter a Person Name: ");
            personName = Console.ReadLine();


            int personAge;
            Console.Write("Please enter the ages of Person: ");
            personAge = int.Parse(Console.ReadLine());

            string personEmail = string.Empty;
            Console.Write("Please enter the email of Person: ");
            personEmail = Console.ReadLine();

            Person firstPerson = new Person(personName, personAge);
            Person secondPerson = new Person(personName, personAge, personEmail);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());

            
        }
    }
}
