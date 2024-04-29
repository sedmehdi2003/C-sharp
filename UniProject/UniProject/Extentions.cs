using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;
namespace UniProject;

static class Extentions
{
    public static void PrintDateTime(this DateTime date)
    {
        PersianCalendar pc = new PersianCalendar();
        int year   = pc.GetYear(date);
        int month = pc.GetMonth(date);
        int day = pc.GetDayOfMonth(date);
        int hour = pc.GetHour(date);
        int min = pc.GetMinute(date);
        int sec = pc.GetSecond(date);
        Clear();
        WriteLine(year + "/" + month + "/" + day + "   " + hour + ":" + min + ":" + sec+ "\n");
    }
}