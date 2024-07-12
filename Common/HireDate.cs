using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class HireDate : Employee
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string GetFormattedDate()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }


    }


    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }




}
