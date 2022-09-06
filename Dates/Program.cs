using System;
using System.ComponentModel;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var DateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var yesterday = today.AddDays(-1);
            var tomorrow = today.AddDays(1);

            Console.WriteLine(String.Format("Today is {0}\nTomorrow is {1}\nYesterday was {2}", today, tomorrow, yesterday));

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm"));


            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            Console.WriteLine(DateTime.Now.Year);
        }
    }
}