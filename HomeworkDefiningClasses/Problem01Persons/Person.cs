using System;

namespace Problem01Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age)
            : this(name, age, "")
        {
        }

        public Person(string name, int age, string email)
            
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Put a valid Name");
                }
                value = value.Trim();

                if (value == "")
                {
                    throw new ArgumentException("Put a valid Name");
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Please enter a valid number of ages");
                }

                this.age = value;

            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("no email");
                }
                else if (!value.Contains("@") )
                {
                    throw new Exception("Please enter a valid Email");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("The Person's name is {0}, age {1} and email {2}",
                this.name, this.age, this.email);         
        }


    }
}
