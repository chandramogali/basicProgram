using System;
using System.Linq;
namespace Arrays
{
    public class Program
    {
        public void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };

            // Create a new array with unique elements
            int[] uniqueNumbers = new int[numbers.Length];
            int currentIndex = 0;

            foreach (int num in numbers)
            {
                if (Array.IndexOf(uniqueNumbers, num) == -1)
                {
                    uniqueNumbers[currentIndex] = num;
                    currentIndex++;
                }
            }

            // Resize the array to the actual number of unique elements
            Array.Resize(ref uniqueNumbers, currentIndex);

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));
            Console.WriteLine("Array with Duplicates Removed: " + string.Join(", ", uniqueNumbers));
        }
    }
}
