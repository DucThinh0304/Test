using System;

namespace Bai04
{
    class Program
    {
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 4 == 0 && year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }
        static int CountDay(int month, int year)
        {
            bool flag = IsLeapYear(year);
            if (year < 0) return -1;
            if (month <= 0 || month > 12) return -1;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) return 31;
            if (month == 4 || month == 6 || month == 9 || month == 11) return 30;
            if (flag == false && month == 2) return 28;
            else return 29;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int i = CountDay(month, year);
            if (i == -1) Console.WriteLine("Invalid input!!!");
            else Console.WriteLine($"{month}/{year} has {i} days");
        }
    }
}
