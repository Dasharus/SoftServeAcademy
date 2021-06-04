using System;

namespace hw_3
{
    class Program
    {

        static void Main(string[] args)
        {
            //  Enter a and b are two integers.Calculate how many integers in the range[a..b]
            //  are divided by 3 without remainder.
            Console.WriteLine("Enter a and b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine("Counter:{0}", counter);

            // Enter a character string. Print each second character
            Console.WriteLine("\nEnter a character string:");
            string characterStr = Console.ReadLine();
            for (int i = 0; i < characterStr.Length; i += 2)
            {
                Console.Write(characterStr[i]);
            }

            // Enter the name of the drink (coffee, tea, juice, water). Print the name of the drink and its price.

            Console.WriteLine("\n drink (coffee, tea, juice, water)");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "coffee":
                    Console.WriteLine("Coffee - price = 12");
                    break;
                case "water":
                    Console.WriteLine("Water - price = 10");
                    break;
                case "tea":
                    Console.WriteLine("Tea - price = 7");
                    break;
                case "juice":
                    Console.WriteLine("Juice - price = 20");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            // Enter a sequence of positive integers (to the first negative). 
            //  Calculate the arithmetic average of the entered numbers.
            Console.WriteLine("\nEnter n: ");
            int n = int.Parse(Console.ReadLine());
            int copy_n = n;
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] < 0)
                {
                    copy_n = copy_n - i + 1;
                    break;
                }
            }
            double result = 0;
            for (int i = 0; i < copy_n; i++)
            {
                result += nums[i];
            }
            result /= copy_n;
            Console.WriteLine($"Average: {result}");

            // Check whether the entered year is a leap

            Console.WriteLine("\nEnter Year : ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year));

            //  Find the sum of digits of the entered integer number
            Console.WriteLine("\nEnter number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int copy_number = 0;
            while (Math.Abs(number) > 0)
            {
                copy_number = number % 10;
                sum += copy_number;
                number /= 10;
            }
            Console.WriteLine($"sum:{sum}");

            // Check whether the entered integer number contains only odd numbers
            Console.WriteLine("Enter the number to check if contains only odd numbers");
            int odd_number = int.Parse(Console.ReadLine());
            int copy_oddNumber;
            bool isOdd = true;
            while (Math.Abs(odd_number) > 0)
            {
                copy_oddNumber = odd_number % 10;
                if (copy_oddNumber % 2 == 0)
                {
                    isOdd = false;
                    break;
                }
                odd_number /= 10;
            }
            Console.WriteLine($"contains only odd numbers: {isOdd}");

            // Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.
            Console.WriteLine("Enter a string:");
            string text = Console.ReadLine();
            int count_a = 0;
            int count_o = 0;
            int count_i = 0;
            int count_e = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        count_a += 1;
                        break;
                    case 'o':
                        count_o += 1;
                        break;
                    case 'i':
                        count_i += 1;
                        break;
                    case 'e':
                        count_e += 1;
                        break;
                }
            }
            Console.WriteLine($"Amount of 'a':{count_a}, 'o':{count_o}, 'i':{count_i}, 'e':{count_e}");

            // Ask user to enter the number of month. Read the value and write the amount of days in this month.
            Console.WriteLine("Enter the number of month: ");
            int number_month = int.Parse(Console.ReadLine());
            Console.WriteLine(System.DateTime.DaysInMonth(2021, number_month));

            // Enter 10 integer numbers. Calculate the sum of first 5 elements
            //  if they are positive or product of last 5 element in  the other case.
            Console.WriteLine("\nEnter 10 int numbers:");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    res = 1;
                    for (int j = 5; j < 10; j++)
                    {
                        res *= numbers[j];
                    }
                    break;
                }
                res += numbers[i];
            }
            Console.WriteLine($"Result is:{res}");









        }
    }
}
