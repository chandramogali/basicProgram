﻿using System;

namespace FactorialNumber
{
    public class Program
    {
        static int FactorialNum( int num)
        {
            int factorial = 1;

            for(int i=1; i<=num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FactorialNum(num));

        }
    }
}
