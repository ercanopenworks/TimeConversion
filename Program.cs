using System;
using System.Globalization;

namespace TimeConversion
{
    class Program
    {
        static string tConvert(string sTime)
        {
            //easiest way

            var dt = DateTime.ParseExact(sTime, "hh:mm:sstt", CultureInfo.InvariantCulture);

            return $"{dt:HH:mm:ss}";
            //manual parsing
            // var tType = sTime.Substring(sTime.Length-2).ToUpper();
            // var timeValue = sTime.Substring(0, sTime.Length - 2);

            // var seperate = timeValue.Split(':');
            // var hour = Convert.ToInt32(seperate[0]);
            // var min = Convert.ToInt32(seperate[1]);
            // var sec = Convert.ToInt32(seperate[2]);
            // if (tType=="AM" && hour>=12)
            // {
            //     hour -= 12;

            // }
            // else if (tType == "PM" && hour < 12)
            // {
            // hour += 12;

            // }
            // var sHour = (hour < 10) ? 0 + hour.ToString() : hour.ToString();
            // var sMinute = (min < 10) ? 0 + min.ToString() : min.ToString();
            // var sSecond = (sec < 10) ? 0 + sec.ToString() : sec.ToString();

            // var result = $"{sHour}:{sMinute}:{sSecond}";

            // return result;   
        }
        static void Main(string[] args)
        {
            string sTime = Console.ReadLine();
            Console.WriteLine(tConvert(sTime));
        }
    }
}
