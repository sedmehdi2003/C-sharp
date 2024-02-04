using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
namespace Exercise5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine(MiladiToShamsi());
                        
        }

        static string MiladiToShamsi()
        {
            PersianCalendar today = new PersianCalendar();
            int day = today.GetDayOfMonth(DateTime.Now);
            int month = today.GetMonth(DateTime.Now);
            int year = today.GetYear(DateTime.Now);

            string toDay = year + "/" + month + "/" + day + "\n" + TimeOfNow();
            return toDay ;
        } 
        /// <summary>
        /// this method will return time of now
        /// </summary>
        /// <returns></returns>
        static string TimeOfNow()
        {
            PersianCalendar today = new PersianCalendar();
            int hour = today.GetHour(DateTime.Now);
            int min = today.GetMinute(DateTime.Now);
            int sec = today.GetSecond(DateTime.Now);
            
            string timeOfDay = hour + ":" + min + ":" + sec;
            return timeOfDay;
        }
        
    }
}