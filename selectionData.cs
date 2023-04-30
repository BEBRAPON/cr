using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace cal
{
    public class saves
    {
        public string month { get; set; }
        public string year { get; set; }
        public string day { get; set; }
        public Image img { get; set; }


        public saves(string Month, string Year, string Day, Image Img)
        {
            month = Month;
            year = Year;
            day = Day;
            img = Img;
        }
    }

    public class savesDATE
    {
        public static List<saves> date = new List<saves>();


    }
}
