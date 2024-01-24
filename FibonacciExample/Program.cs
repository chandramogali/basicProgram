using System;

namespace FibonacciExample
{
    public class Program
    {
         static int FibonacciSeries(int n)
        {
            if (n <= 0)
            {
                return n;
            }
            else
            {
               return Math.Abs(FibonacciSeries(n - 2) + FibonacciSeries(n - 1));
            }


        }
        public static void Main(string[] args)
        {
            /* int n1 = 0;
             int n2 = 1;
             int n3;
             int i;
             int number;
             Console.WriteLine("Enter the number of elements");
             number=Convert.ToInt32(Console.ReadLine());

             for (i = 2; i < number; i++)
             {
                 n3 = n1 + n2;
                 Console.WriteLine(n3);
                 n1 = n2;
                 n2 = n3;
 ;            }

            */

            // Using recursion

            int number;
            Console.WriteLine("enter the number");
            number=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(FibonacciSeries(i));
            }

        }
    }
}
