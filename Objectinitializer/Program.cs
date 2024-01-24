using System;

namespace Objectinitializer
{
    public class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }

        public Program() { 
        }
        public Program(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FullName()
        {
            return $"{FirstName} {LastName} {Age}";
        }
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.FirstName = "John";
            p1.LastName = "Doe";
            p1.Age = 25;
            Console.WriteLine(p1.FullName());

            Program p2 = new Program("cm","gomais");
            p2.Age = 22;
            Console.WriteLine(p2.FullName());

            var p3 = new Program
            {
                FirstName = "mogali",
                LastName = "Gomasi",
                Age = 1
            };
            Console.WriteLine(p3.FullName());
        }
    }
}
