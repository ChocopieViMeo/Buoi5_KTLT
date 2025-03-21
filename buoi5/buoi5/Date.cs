using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set 
            {
                if (value < 0 && value > 31)
                    day = value;
                else
                    Console.WriteLine("Day must be between 1 und 31");
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 && value > 12)
                    month = value;
                else
                    Console.WriteLine("Month must be between 1 und 12");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1990 && value > 9999)
                    value = month;
                else
                    Console.WriteLine("Year must be between 19000 und 9999");
            }
        }
        public Date()
        {
            day = 1;
            month = 1;
            year = 1990;
        }
        public Date( int day, int month , int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void InPut()
        {
            do
            {
                Console.Write("day: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("year: ");
                year = int.Parse(Console.ReadLine());
            } while (day < 1 || day > 31 || month < 1 || month > 12 || year < 1990 || year > 9999);
        }
        public override string ToString()
        {
            return $"{day:D2} / {month:D2} / {year}";
        }
    }
}
