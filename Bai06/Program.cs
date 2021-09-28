using System;

namespace Bai06
{
    class Program
    {
        static void ExportMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void FindMaxMin(int[,] matrix)
        {
            int Min = 10000;
            int Max = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < Min) Min = matrix[i, j];
                    if (matrix[i, j] > Max) Max = matrix[i, j];
                }
            }
            Console.WriteLine("\nMax is: " + Max);
            Console.WriteLine("Min is: " + Min);
        }
        static void FindMaxRow(int[,] matrix)
        {
            int Max = -1;
            int MaxInRow = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int Sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Sum += matrix[i, j];
                }
                if (Max < Sum)
                {
                    Max = Sum;
                    MaxInRow = i + 1;
                }
            }
            Console.WriteLine("\nRow that has the highest sum is: " + MaxInRow + ", with sum is: " + Max);
        }
        static bool IsPrime(int num)
        {
            if (num == 0 || num == 1) return false;
            if (num == 2) return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static void SumNonPrimes(int[,] matrix)
        {
            int Sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (IsPrime(matrix[i, j]) == false) Sum += matrix[i, j];
                }
            }
            Console.WriteLine("\nSum of non primes is: " + Sum);
        }
        static int[,] DeleteRow(int[,] matrix, int RowToDelete)
        {
            int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];

            for (int i = 0, j = 0; i < matrix.GetLength(0); i++)
            {
                if (i == RowToDelete)
                    continue;

                for (int k = 0, u = 0; k < matrix.GetLength(1); k++)
                {


                    result[j, u] = matrix[i, k];
                    u++;
                }
                j++;
            }

            return result;
        }
        static int[,] ColumnHasMAX(int[,] matrix)
        {
            int Max = -1;
            int MaxInComlumn = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > Max)
                    {
                        Max = matrix[i, j];
                        MaxInComlumn = j;
                    }
                }
            }
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];

            for (int i = 0, j = 0; i < matrix.GetLength(0); i++)
            {

                for (int k = 0, u = 0; k < matrix.GetLength(1); k++)
                {
                    if (k == MaxInComlumn) continue;
                    result[j, u] = matrix[i, k];
                    u++;
                }
                j++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of row: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of column: ");
            int m = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1001);
                }
            }
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n0: Exit");
                Console.WriteLine("1: Export matrix");
                Console.WriteLine("2: Find Min/Max");
                Console.WriteLine("3: Find row that has the highest sum");
                Console.WriteLine("4: Sum of non primes");
                Console.WriteLine("5: Delete a row");
                Console.WriteLine("6: Delete column has Max");
                Console.Write("Your Pick: ");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        flag = false;
                        Console.WriteLine("\nGoodbye");
                        break;
                    case 1:
                        Console.WriteLine("\nMatrix: ");
                        ExportMatrix(matrix);
                        break;
                    case 2:
                        FindMaxMin(matrix);
                        break;
                    case 3:
                        FindMaxRow(matrix);
                        break;
                    case 4:
                        SumNonPrimes(matrix);
                        break;
                    case 5:
                        Console.Write("\nEnter a row to delete: ");
                        int DongCanXoa = Convert.ToInt32(Console.ReadLine());
                        matrix = DeleteRow(matrix, DongCanXoa - 1);
                        Console.WriteLine("\nMatrix after deleted row: ");
                        ExportMatrix(matrix);
                        break;
                    case 6:
                        matrix = ColumnHasMAX(matrix);
                        Console.WriteLine("\nMatrix after deleted column: ");
                        ExportMatrix(matrix);
                        break;
                    default:
                        Console.WriteLine("Wrong input, please reentered!!!!");
                        break;
                }
            }

        }
    }
}
