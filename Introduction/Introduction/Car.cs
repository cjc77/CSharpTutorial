using System;
using System.Linq;
using System.Globalization;

namespace Introduction
{

    public class Car
    {
        // Project-wide count of how many cars (in total) have been created.
        internal static int carsCreated;
        protected string color;
        protected string carType;
        protected TimeStamp manufactureDate;
        Random rand = new Random();

        public Car()
        {
            //Console.WriteLine("Default Constructor Called.");
            manufactureDate = new TimeStamp();
            carsCreated += 1;
        }

        public Car(string argument) : this()
        {
            //Console.WriteLine("Random Constructor Called.");
            if (argument != Defs.random)
            {
                Console.WriteLine("Illegal Constructor Argument.");
            } else {
                int idx = rand.Next(0, Defs.acceptableColors.Length);
                ValidateColor(Defs.acceptableColors[idx]);
                idx = rand.Next(0, Defs.acceptableTypes.Length);
                ValidateType(Defs.acceptableTypes[idx]);
            }
        }

        public Car(string color, string type) : this()
        {
            //Console.WriteLine("2 Argument Constructor Called.");
            ValidateColor(color);
            ValidateType(type);
        }

        ~Car()
        {}

        public void Vroom()
        {
            Console.WriteLine("Vroom");
        }

        public void Vroom(int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine("Vroom");
        }

        public string Display()
        {
            string val = ("Color: " + Color + "\nCar Type: " + CarType +
                          "\nManufacture Date: " + this.manufactureDate.DisplayUS());
            return val;
        }

        private void Randomize(string [] attribute)
        {
            int idx = rand.Next(0, attribute.Length);
            if (attribute == Defs.acceptableColors)
                this.color = Defs.acceptableColors[idx];
            else if (attribute == Defs.acceptableTypes)
                this.carType = Defs.acceptableTypes[idx];
            else
                Console.WriteLine("Error Randomizing.");
            
        }

        private void ValidateColor(string n_color)
        {
            TextInfo tInfo = new CultureInfo(Defs.locales[Defs.US], false).TextInfo;
            n_color = tInfo.ToTitleCase(n_color);
            if (Defs.acceptableColors.Contains(n_color))
                this.color = n_color;
            else
                Console.WriteLine("Illegal Color.");
        }

        private void ValidateType(string n_carType)
        {
            TextInfo tInfo = new CultureInfo(Defs.locales[Defs.US], false).TextInfo;
            n_carType = tInfo.ToTitleCase(n_carType);
            if (Defs.acceptableTypes.Contains(n_carType))
                this.carType = n_carType;
            else
                Console.WriteLine("Illegal Car Type.");
        }

        public string Color
        {
            get { return this.color; }

            set { ValidateColor(value); }
        }

        public string CarType
        {
            get { return this.carType; }

            set { ValidateType(value); }
        }
    }
}
