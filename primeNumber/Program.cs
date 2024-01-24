using System;
using System.Threading;

namespace primeNumber
{
    public class Program
    {
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for(int i=3;i*i<=n;i += 2)
            {
                if(n%i == 0) return false;
            }

            return true;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (isPrime(num))
            {
                Console.WriteLine($"the given number {num} is prime number ");
            }
            else
            {
                Console.WriteLine($"the given numbnber {num} is Not Prime number ");
            }
        }
    }
}
