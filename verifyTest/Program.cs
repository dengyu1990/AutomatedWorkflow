using System;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace verifyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());

            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    Console.WriteLine("Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.ReadKey();
        }

        /*protected static bool getTimeSpan(string strTime)
        {
            string _timeStart = "08:30";
            string _timeEnd = "17:30";

            TimeSpan start = DateTime.Parse(_timeStart).TimeOfDay;
            TimeSpan end = DateTime.Parse(_timeEnd).TimeOfDay;

            DateTime tt = Convert.ToDateTime(strTime);
            TimeSpan dspNow = tt.TimeOfDay;
            if (dspNow > start && dspNow < end)
                return true;
            return false;
        }*/


    }
}

//TimeSpan start = DateTime.Parse("18:30").TimeOfDay;
//TimeSpan end = DateTime.Parse(Console.ReadLine()).TimeOfDay;
//TimeSpan result = end - start;
//Console.WriteLine(result.TotalHours.ToString("f2"));

