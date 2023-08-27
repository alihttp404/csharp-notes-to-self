using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Class__Dates__Random
{
    internal class _DateTime
    {
        // DateTime - contains both date and time
        // The kind of date/time can be specified with DateKind
        // Left unspecified, DateTime uses the machine's time zone

        // Each method has its description in comment 

        // Some methods: (some methods/members are static,
                        // meaning you don't have to create an object to use them)
        public static DateTime dt1 = new DateTime(2007, 09, 20);
        public static DateTime dt2 = new DateTime(2023, 08, 27);

        public static void foo()
        {
            Console.WriteLine("DateTime.Now: ", DateTime.Now); // date time current
            Console.WriteLine("DateTime.UtcNow: ", DateTime.UtcNow); // date with utc time now
            Console.WriteLine("DateTime.Today: ", DateTime.Today); // no time only date

            // DateTime.Now returns a DateTime object, therefore we can use its members
            Console.WriteLine("DateTime.Now.TimeOfDay: ", DateTime.Now.TimeOfDay); // today's time
            // Many useful members, like Date, Day, DayOfWeek, DayOfYear, Kind
            // Operators: + - > < >= <= == != ++ --


            // -----------------------------------------------------------------------------------
            // Date Formatting
            // We can format dates by giving its ToString() override different arguments like "MM.dd.yyyy", and many many others
            // Some general ones: 
            // "MMMM" --> name of month
            // "dddd" --> name of day of week
            Console.WriteLine(dt1.ToString("d"));
            // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1 --> useful resource for the most popular formats
        }
    }
}
