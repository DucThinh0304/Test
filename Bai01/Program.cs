using System;

namespace Bai01
{
    class Program
    {


        static int OddSum(int[] arr)
        {
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                    Sum += arr[i];
            }
            return Sum;
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
        static int CountPrime(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i])) count++;
            }
            return count;
        }
        static bool IsSquare(int num)
        {
            return ((int)Math.Sqrt(num) == Math.Sqrt(num));
        }
        static int SquareMin(int[] arr)
        {
            int Min = 10000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSquare(arr[i]) && Min > arr[i])
                    Min = arr[i];
            }
            if (Min == 10000) return -1;
            return Min;
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.Write("Enter number of element: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1001);
            }
            Console.WriteLine("Elements in array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}   ");
            }
            Console.WriteLine($"\nThe sum of odd numbers is: {OddSum(arr)}");
            Console.WriteLine($"The number of primes is: {CountPrime(arr)}");
            Console.WriteLine($"The smallest square number is: {SquareMin(arr)}");
            //ThinhdeptraiCuteKhoaito
        }
    }
}
