using System;

namespace PalindromeNumber
{
    public class Program
    {
        
       public static void Main(string[] args)
        {
            int n;
            int rem=0;
            int rev=0;
            
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());

            int number = Convert.ToInt32(n);

            while (n > 0)
            {
                rem = n % 10;
                rev=(rev * 10) + rem;
                n= n/10;
                
            }
            Console.WriteLine(rev);
            if(rev == number) {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is Not palindrome");
            }
        }
    }
}
