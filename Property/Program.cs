using System;
using System.Data;

namespace Property
{
    public class Program
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { 
                return firstName; 
               }

            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name must not be empty or null");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { 
                return lastName; 
            }
            set { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name must not be empty or null");
                }
                lastName = value; 
            }

        }
        public int Age
        {
            get { return age;  }
            set
            {
                if(age > 0 && age < 100) {
                    throw new ArgumentException("Age must not be less 100 or greater than 0 ");
                      }
                age = value;
            }
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName} {Age}";
            }
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.FirstName = "chandra";
            p.LastName = "Gomasi";
            p.Age = 90;
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.FullName);
        }
    }
}
