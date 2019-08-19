using System;

namespace tp1_OPEN_CLASSROOM
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday
                || (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9) ||
                (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 18))
                Console.WriteLine("Bon week-end " + System.Environment.UserName);
            else if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                Console.WriteLine("Bonjour " + System.Environment.UserName);
            else
                Console.WriteLine("Bonsoir " + System.Environment.UserName);

        }
    }
}
