using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace sumNumber
{
    public class Program
    {
        static int NumberSum(int n)
        {
            int sum = 0;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n /= 10;
            }
            return sum;
        }
      public  static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumberSum(num));
        }
    }
}
