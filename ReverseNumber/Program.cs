using System;

namespace ReverseNumber
{
    public class Program
    {
        static int reverseNum(int n)
        {
            int temp = n;
            int rem = 0;
            int rev = 0;

            while (n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n /= 10;
            }
            return rev;
        }
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine(reverseNum(num));
        }
    }
}
