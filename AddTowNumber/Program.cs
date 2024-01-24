using System;

namespace AddTowNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.addTwoNumbers();

            Program obj= new Program();
            obj.subTwoNumber();

        }

        public void subTwoNumber()
        {
            int x = 5;
            int y = 10;
            int z = y - x;
            Console.WriteLine(z);
        }
        public static void addTwoNumbers()
        {
           int a = 5;
           int b = 10;
           int c = a + b;

           Console.WriteLine("Sum of Two Number {0}", c);
           
        }


    }
}
