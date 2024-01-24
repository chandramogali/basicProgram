using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Person
{
    public class Program

    {
        public string FirstName;
        public string LastName;
        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public string SayHi()
        {
            return $"Hi, I'm {this.GetFullName()}";
        }

        public Program  SetFirstName(string name)
        {
            this.FirstName = name ;
            return this ;
        }
        public Program SetLastName(string lastName)
        {
            this.LastName = lastName ;
            return this ;
        }

        static void Main(string[] args)
        {
            Program p1= new Program();
            p1.SetFirstName("John");
            p1.SetLastName("Doe");
            string greeting = p1.SayHi();
            Console.WriteLine(greeting);

            Program p2 = new Program();

            /* string greeting2 = p2.SetFirstName("Chandra")
                                .SetLastName("gomasi")
                                .SayHi(); */

            string greeting2=p2.SetFirstName("chandra")
                                .SetLastName("gomasi")
                                .SayHi();
            Console.WriteLine(greeting2);
        }

       
    }
}
