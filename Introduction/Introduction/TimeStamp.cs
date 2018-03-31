using System;
using System.Globalization;

namespace Introduction
{
    public class TimeStamp
    {
        readonly DateTime dateAndTime;

        public TimeStamp()
        {
            this.dateAndTime = DateTime.Now;
        }

        public string DisplayUS()
        {
            var culture = new CultureInfo(Defs.locales[Defs.US]);
            string returnVal = (Defs.locales[Defs.US] + " " 
                                + this.dateAndTime.ToString(culture));
            return returnVal;
        }
    }
}
