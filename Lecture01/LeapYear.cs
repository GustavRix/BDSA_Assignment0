using System;

namespace Lecture01
{
    public class Calculator
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new ArgumentException("Year must be greater than 1582, this is your number", nameof(year));
            }
            if (year > 9999)
            {
                throw new ArgumentException("Year must less than 10000, this is your number", nameof(year));
            }
            return year % 4 != 0 ? false : year % 100 != 0 ? true : year % 400 != 0 ? false : true;
        }
    }
}
