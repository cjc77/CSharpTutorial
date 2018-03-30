using System;
using System.Globalization;

namespace Introduction
{
    public class TimeStamp
    {
        private const int US = 0;
        private DateTime dateAndTime;
        private readonly string[] locales = { "en-US", "en-GB",
            "fr-FR", "de-DE", "ru-RU"};
        
        public TimeStamp()
        {
            this.dateAndTime = DateTime.Now;
        }

        public string DisplayUS()
        {
            var culture = new CultureInfo(locales[US]);
            string returnVal = (locales[0] + " " 
                                + this.dateAndTime.ToString(culture));
            return returnVal;
        }
    }
}
