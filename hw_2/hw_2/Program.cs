using System;

namespace hw_2
{
    enum HTTPError
    {
        BadRequest,
        Unauthorized,
        PaymentRequired,
        Forbidden
    }

    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }

    struct RGB
    {
        public byte red;
        public byte blue;
        public byte green;

        public void Info()
        {
            Console.WriteLine($"red:{red}, blue:{blue}, green:{green}");
        }

    }
    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {
            return string.Format($"\nName: {Name}  Mark: {Mark}  Age: {Age}");
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            // Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).  
            //  Assign status “Pass” for the variable  test1Status and print the value of the variable console.
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);

            // read number of HTTP Error (400, 401,402, ...) and write the name
            //  of this error (Declare enum HTTPError)

            Console.WriteLine("Enter number of error: ");
            int er = int.Parse(Console.ReadLine());
            switch(er)
            {
                case 400:
                    Console.WriteLine(HTTPError.BadRequest);
                    break;
                case 401:
                    Console.WriteLine(HTTPError.Unauthorized);
                    break;
                case 402:
                    Console.WriteLine(HTTPError.PaymentRequired);
                    break;
                case 403:
                    Console.WriteLine(HTTPError.Forbidden);
                    break;
                default:
                    Console.WriteLine(HTTPError.BadRequest);
                    break;
            }

            // read 3 float numbers and check: are they all belong to the range [-5,5].
            int a = -5;
            int b = 5;
            Console.WriteLine("Enter 3 numbers");
            float number = float.Parse(Console.ReadLine());
            float number1 = float.Parse(Console.ReadLine());
            float number2= float.Parse(Console.ReadLine());
            bool answer = false;
            if(number<=b && number >=a )
            {
                if(number1>=a && number1<=b)
                {
                    if(number2>=a && number2<=b)
                    {
                        Console.WriteLine($"All numbers are in [{a},{b}] ");
                        answer = true;
                    }
                }
            }
            if(!answer)
            {
                Console.WriteLine($"Not all numbers are in [{a},{b}]  ");
            }

            // read 3 integers and write max and min of them.
            Console.WriteLine("\nEnter n and numbers");
            int n = int.Parse(Console.ReadLine());
            int [] nums = new int[n];
            for(int i=0; i<n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int max = nums[0];
            int min = nums[0];
            for(int i=0; i<n; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine($"min={min}, max={max}");

            // declare struct Dog with fields Name, Mark, Age. Declare variable 
            //  myDog of Dog type and read values for it. Output myDos into console. 
            //  (Declare method ToString in struct)

            Dog myDog;
            myDog.Name = "Alex";
            myDog.Mark = "Gaff";
            myDog.Age = 110;
            Console.WriteLine(myDog.ToString());

            RGB rgb_black;
            rgb_black.blue = 0;
            rgb_black.green = 0;
            rgb_black.red = 0;
            rgb_black.Info();

            RGB rgb_white;
            rgb_white.red = 255;
            rgb_white.blue = 255;
            rgb_white.green = 255;
            rgb_white.Info();

            //Enter two integers numbers and check if they can represent the day and month. Print true or false.

            Console.WriteLine("\nEnter 2 int numbers for month/day task");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            bool rez = ((first <= 31 && first >= 1) || (second <= 31 && second >= 1)) 
                && ((second >= 1 && second <= 12) || (first >= 1 && first <= 12));
            Console.WriteLine(rez.ToString());


            // Enter double  number  and get the first 2 digits after the point
            //  of this number and output the sum of these numbers. For example: 3.456 -> 4+5=9

            Console.WriteLine("\nDouble number task");
            double dblNumber = double.Parse(Console.ReadLine());
            dblNumber *= 100;
            dblNumber = Math.Floor(dblNumber);
            dblNumber %= 100;
            int temp = (int)dblNumber / 10 + (int)dblNumber % 10;
            Console.WriteLine($"sum is:{temp}");

            // Enter integer number h, representing the time of day (hour). 
            //  Depending on the time of day, print greetings ("Good morning!", 
                    //  "Good afternoon!", "Good evening!", "Good night!")

            Console.WriteLine("\n Hour task. Enter h");
            int h = int.Parse(Console.ReadLine());
            if (h >= 6 && h < 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (h >= 11 && h < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (h >= 18 && h < 21)
            {
                Console.WriteLine("Good evening!");
            }
            else if (h >= 21 && h < 6)
            {
                Console.WriteLine("Good night!");
            }
            else
                Console.WriteLine("Hello"); 
        }


    }
}
