using System;

namespace Bai02
{
    class Program
    {
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
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"Sum of primes smaller than {n} is: {Sum}");

        }
    }
}
