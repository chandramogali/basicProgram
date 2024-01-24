using System;

namespace Person2
{
    public class Program
    {
        private string firstName;
        private string lastName;
        

        public string GetFullName()
        {
            return $" Hi i'm {this.firstName} {this.lastName}";
        }
        private bool isValidName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        public Program SetFirstName(string firstName)
        {
            if(isValidName(firstName))
            {
                this.firstName = firstName;
            }
            return this;
        }
        public Program SetLastName(string lastName)
        {
            if (isValidName(lastName))
            {
                this.lastName = lastName;
            }
              return this;
        }

       

       public static void Main(string[] args)
        {
            Program p1 = new Program();
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();


            string fullName = p1.SetFirstName(firstname)
                            .SetLastName(lastname)
                            .GetFullName();

            Console.WriteLine(fullName);
        }
    }
}
