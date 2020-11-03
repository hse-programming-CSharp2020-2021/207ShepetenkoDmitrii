using System;

namespace Task2
{
    class Schedule
    {
        string[] days = { "Moday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public string this[int index]
        {
            get
            {
                return ((index < 1) | (index > 7)) ? "It is not a day of week" : days[index - 1];
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schedule a = new Schedule();
            for (int i = 0; i < 8; i++)
                Console.WriteLine(a[i]);
        }
    }
}
