using System;

namespace ClockHandsAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 12;
            int minute = 30;

            CalculateAngle(hour, minute);
        }

        private static void CalculateAngle(int hour, int minutes)
        {
            int timeHour = 0;
            int timeMinutes = 0;
            int degreesPerMinute = 360 / 60;

            if (hour == 12)
            {
                timeHour = 0;
            }
            else if (hour > 12)
            {
                timeHour = hour % 12;
            }
            else
            {
                timeHour = hour;
            }

            if (minutes == 60)
            {
                timeMinutes = 0;
            }
            else
            {
                timeMinutes = minutes;
            }

            decimal MinuteDegrees = (decimal)timeMinutes * degreesPerMinute;

            decimal HourInMinutes = (decimal)timeHour * 5;
            decimal addedAccuracy = (decimal)timeMinutes / 60;
            decimal HourInMinutesDegrees = (HourInMinutes + addedAccuracy) * degreesPerMinute;

            decimal difference = Math.Abs(HourInMinutesDegrees - MinuteDegrees);

            if (difference > 180)
            {
                Console.WriteLine($"Difference: {Math.Abs(360 - difference)}");
            }
            else
            {
                Console.WriteLine($"Difference: {difference}");
            }


            
        }
    }
}
