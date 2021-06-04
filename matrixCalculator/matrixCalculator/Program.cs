using System;

namespace matrixCalculator
{
    class Program
    {
        static void FillMatrixRand(double[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                }
            }
        }

        static void FillMatrix(double[,] arr)
        {
            Console.WriteLine("\nFilling the matrix: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Enter matr[{0};{1}]: ",i,j);
                    try
                    {
                        arr[i, j] = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Exception caught: {0}", e);
                        Console.WriteLine("Enter again: ");
                        arr[i, j] = double.Parse(Console.ReadLine());
                    }
                }
            }
        }

        static void AddMatrix(double[,] arr,  double[,] arr1)
        {
            double[,] arr2 = new double[arr.GetLength(0), arr.GetLength(1)];
            if ((arr.GetLength(0) == arr1.GetLength(0)) && (arr.GetLength(1) == arr1.GetLength(1)))
            {
                for (int i = 0; i< arr.GetLength(0); i++)
                {
                    for(int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr2[i,j] = arr[i, j] + arr1[i, j];
                    }
                }
                Output(arr2);
            }
            else
            {
                Console.WriteLine("\nError. Invalid sizes.");
            }
        }

        static void SubstracMatrix(double[,] arr, double[,] arr1)
        {
            double[,] arr2 = new double[arr.GetLength(0), arr.GetLength(1)];
            if ((arr.GetLength(0) == arr1.GetLength(0)) && (arr.GetLength(1) == arr1.GetLength(1)))
            {
                for(int i=0; i< arr.GetLength(0); i++)
                {
                    for(int j=0; j< arr.GetLength(1); j++)
                    {
                        arr2[i, j] = arr[i, j] - arr1[i, j];
                    }
                }
                Output(arr2);
            }
            else
            {
                Console.WriteLine("\nError. Invalid sizes.");
            }
        }

        static void MultMatrix(double[,] arr, double[,] arr1)
        {
            double[,] arr2 = new double[arr.GetLength(0), arr1.GetLength(1)];
            if (arr.GetLength(1) == arr1.GetLength(0))
            {
                for(int i=0; i< arr.GetLength(0); i++)
                {
                    for(int j=0; j< arr1.GetLength(1); j++)
                    {
                        double temp = 0;
                        for(int k = 0; k < arr.GetLength(1); k++)
                        {
                            temp += arr[i, k] * arr1[k, j];
                            arr2[i, j] = temp;
                        }
                    }
                }
                Output(arr2);
            }
            else
            {
                Console.WriteLine("\nError. Invalid sizes.");
            }
        }

        static void Output(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+"  ");
                }
                Console.WriteLine("  ");
            }
        }

        static void Check(ref int a)
        {
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                Console.WriteLine("Enter again: ");
                a = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void Main(string[] args)
        {
            int rows=0, columns=0, rows1=0, columns1=0;
            Console.WriteLine("\nEnter an amount of rows of the first matrix: ");
            Check(ref rows);
            Console.WriteLine("\nEnter an amount of columns of the first matrix: ");
            Check(ref columns);
            Console.WriteLine("\nEnter an amount of rows of the second matrix: ");
            Check(ref rows1);
            Console.WriteLine("\nEnter an amount of columns of the second matrix: ");
            Check(ref columns1);

            double[,] matr = new double[rows, columns];
            double[,] matr1 = new double[rows1, columns1];

            Console.Write("Do you want to fill them with random values?  y/ n: ");
            if(Console.ReadLine() == "y")
            {
                FillMatrixRand(matr);
                FillMatrixRand(matr1);
            }
            else
            {
                FillMatrix(matr);
                FillMatrix(matr1);
            }

            Console.WriteLine("\nFirst matrix");
            Output(matr);
            Console.WriteLine("\nSecond matrix");
            Output(matr1);

            
            bool yes = true;
            while(yes)
            {
                Console.WriteLine("\nChoose what do you want to do (add - +, multiply - *, substract -):  ");
                string selection = Console.ReadLine();
                
                switch (selection)
                {
                    case "*":
                        MultMatrix(matr, matr1);
                        break;
                    case "+":
                        AddMatrix(matr, matr1);
                        
                        break;
                    case "-":
                        SubstracMatrix(matr, matr1);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("\nDo you want to continue?: y/n");
                if(Console.ReadLine()!="y")
                {
                    yes = false;
                }
            }
        }
    }
}
