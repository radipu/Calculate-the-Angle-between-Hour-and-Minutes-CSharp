using System;

namespace CalculateAngleBetweenHourMinutes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Hours: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Minutes: ");
            int m = int.Parse(Console.ReadLine());

            double hourInDegree = (h * 30) + (m * 30.0/60);
            double minuteInDegree = (m * 6);

            double diff = Math.Abs(hourInDegree - minuteInDegree);

            if (diff > 180)
                diff = 360 - diff;

            Console.WriteLine($"Angle between {h} hours and {m} minutes is {diff} degree.");
            Console.ReadKey();
        }
    }
}
