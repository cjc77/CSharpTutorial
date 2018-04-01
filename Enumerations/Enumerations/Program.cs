using System;

namespace Enumerations
{
    public enum Days
    {
        Monday, Tuesday, Wednesday, Thursday,
        Friday, Saturday, Sunday
    }

    public enum Numbers
    {
        One = 1, Two = 2, Seven = 7, Eight
    }

    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine((Days)0);
            Console.WriteLine((int)Numbers.Seven);
            Console.WriteLine((int)Numbers.Eight);
            //Get enums as strings
            string[] dayStrings = Enum.GetNames(typeof(Days));
            foreach (string ds in dayStrings)
                Console.WriteLine(ds);
        }
    }
}
