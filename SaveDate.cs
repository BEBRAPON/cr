using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class SaveDate
    {
        public static DateTime date = DateTime.Now;

        public static void setDate(DateTime newDate)
        {
            date = newDate;
        }

        public static string dayNum;
    }

    public class antoherSaveData
    {
        public static string month;
        public static string year;
    }
}
