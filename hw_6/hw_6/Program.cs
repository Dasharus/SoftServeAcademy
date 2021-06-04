using System;

namespace hw_6
{
    class Program
    {
        static void Div(int number1, int number2)
        {
            double res = number1 / number2;
            Console.WriteLine($"result: {res}");
        }

        static int ReadNumber(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());
            if(num >= start && num <= end)
            {
                return num; 
            }
            else
            {
                throw (new ArgumentOutOfRangeException($"Number must be in [{start};{end}] range"));
            }
        }

        static void DivCall()
        {
             try
                {
                    Console.WriteLine("Enter first number: ");
                    int first_number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int second_number = int.Parse(Console.ReadLine());
                    Div(first_number, second_number);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\nError: {e.Message}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"\nError: {e.Message}");
                }
        }

        static void ReadNumberMethod()
        {
            try
            {
                Console.WriteLine("\nReandNumber method:");
                Console.WriteLine("Enter 1 number:");
                int number = ReadNumber(1, 100);
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"Enter {i + 1} number:");
                    number = ReadNumber(number, 100);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"\nError: {e.Message}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"\nError: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"\nError: {e.Message}");
            }
        }

        static void Main(string[] args)
        {
            bool continue_option = true;
            while (continue_option)
            {
                Console.WriteLine("Choose task: 1- DIV method or 2- ReadNumber method:");
                string task_option = Console.ReadLine();
                switch (task_option)
                {
                    case "1":
                        DivCall();
                        break;
                    case "2":
                        ReadNumberMethod();
                        break;
                    default:
                        Console.WriteLine("Error ");
                        break;
                }
                Console.WriteLine("Do you want to continue?: true/false");
                continue_option = bool.Parse(Console.ReadLine());

            }
        }
    }
}
