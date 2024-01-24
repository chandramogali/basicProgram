using System;

namespace Constructor
{
    public class Program
    {

        public int age;
        public Program()
        {
            Console.WriteLine("Wellcome to Costructor");
        }
        public Program(int age)
        {
            this.age = age;
            Console.WriteLine("i am parametized constructor my age is {0}",age);
        }
      public static void Main(string[] args)
        {
            Program program=new Program();
            Program program1 = new Program(10);   

        }
    }
}
