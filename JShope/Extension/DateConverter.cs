using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Extension
{
    public static class DateConverter
    {
        public static string ToKhorshidi(this DateTime time)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetHour(time):00}:{pc.GetMinute(time):00}:{pc.GetSecond(time)} {pc.GetYear(time):0000}/{pc.GetMonth(time):00}/{pc.GetDayOfMonth(time)}";

            
        }
    }
}
