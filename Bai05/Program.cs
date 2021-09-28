using System;

namespace Bai05
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
        static int GetDay(int date, int month, int year)
        {
            return (date + ((153 * (month + 12 * ((14 - month) / 12) - 3) + 2) / 5) +
             (365 * (year + 4800 - ((14 - month) / 12))) +
        ((year + 4800 - ((14 - month) / 12)) / 4) -
        ((year + 4800 - ((14 - month) / 12)) / 100) +
        ((year + 4800 - ((14 - month) / 12)) / 400) - 32045) % 7;
        }
        static void Main(string[] args)
        {
            int date, month, year;
            do
            {
                Console.Write("Enter date: ");
                date = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter year: ");
                year = Convert.ToInt32(Console.ReadLine());
                if (IsValid(date, month, year) == false) Console.Write($"{date}/{month}/{year} is invalid!!!\nPlease reentered\n");
            }
            while (IsValid(date, month, year) == false);
            switch (GetDay(date, month, year))
            {
                case 0:
                    Console.Write($"{date}/{month}/{year} is Monday!!! ");
                    break;
                case 1:
                    Console.Write($"{date}/{month}/{year} is Tuesday!!! ");
                    break;
                case 2:
                    Console.Write($"{date}/{month}/{year} is Wednesday!!! ");
                    break;
                case 3:
                    Console.Write($"{date}/{month}/{year} is Thursday!!! ");
                    break;
                case 4:
                    Console.Write($"{date}/{month}/{year} is Friday!!! ");
                    break;
                case 5:
                    Console.Write($"{date}/{month}/{year} is Saturday!!! ");
                    break;
                case 6:
                    Console.Write($"{date}/{month}/{year} is Sunday!!! ");
                    break;
            }

        }
    }
}
