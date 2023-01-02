using System;
using System.Collections.Generic;
using System.Text;

namespace P05_DateModifier
{
    public class DateModifier
    {
        public DateModifier(string date1, string date2)
        {
            Date1 = DateTime.ParseExact(date1, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            Date2 = DateTime.ParseExact(date2, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        }
        public DateTime Date1 { get;private set; }
        public DateTime Date2 { get;private set;}

        public int GetDaysDifference(string date1, string date2)
        {
            return Math.Abs((Date1.Date - Date2.Date).Days);
        }

    }
}
