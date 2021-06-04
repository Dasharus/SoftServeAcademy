using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace hw_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for(int i=-1; i<9; i++)
            {
                numbers.Add(i);
                Console.Write($"{i}, ");
            }

            Console.WriteLine("\nNegative numbers: ");
            var underZero = string.Join(", ", numbers.Where(item => item < 0));
            Console.WriteLine($"{underZero}");

            Console.WriteLine("Positive numbers: ");
            var aboveZero = string.Join(", ", numbers.Where(item => item >= 0));
            Console.WriteLine($"{aboveZero}");

            int max = numbers.Max();
            int min = numbers.Min();
            Console.WriteLine($"Largest number: {max}, Smallest: {min}");

            double average = numbers.Average();
            Console.WriteLine($"Average: {average}");
            var underAverage = string.Join(", ", numbers.Where(item => item < average));
            Console.WriteLine($"Integers are above average: {underAverage}");

            Console.WriteLine($"Largest one: {underAverage.Max()}");

            var ordered_numbers = string.Join(",",numbers.OrderBy(nums => nums));
            Console.WriteLine($"Ordered by ASC: {ordered_numbers}");




        }
    }
}
