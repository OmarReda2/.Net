using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    struct HireDate
    {

        #region Attributtes
        int day, month, year;
        #endregion







        #region Constructor
        public HireDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        #endregion







        #region Properties
        public int Day
        {
            get { return day; }
            set { day = value > 0 && value <= 31 ? value : 1; }

        }

        public int Month
        {
            get { return month; }
            set { month = value > 0 && value <= 12 ? value : 1; }
        }

        public int Year
        {
            get { return year; }
            set { year = value > 1999 && value <= 2022 ? value : 2022; }
        }



        #endregion



        public override string ToString()
        {
            return $"{month}/{day}/{year}";
        }















    }


    
}
