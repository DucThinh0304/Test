using System;

namespace Bai03
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
        static bool IsValid(int date, int month, int year)
        {
            bool flag = IsLeapYear(year);
            if (date < 0 || date > 31) return false;
            if (month > 12 || month < 0) return false;
            if (year < 0) return false;
            if (month == 2 && date > 29) return false;
            if (month == 2 && flag == false && date == 29) return false;
            if ((month == 4 || month == 6 || month == 9 || month == 11) && date > 30) return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter date: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (IsValid(date, month, year)) Console.Write($"{date}/{month}/{year} is valid!!!");
            else Console.Write($"{date}/{month}/{year} is invalid!!!");
        }
    }
}
