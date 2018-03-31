using System;
using System.Linq;
using System.Diagnostics;
using System.Globalization;

namespace Introduction
{

    public class Car
    {
        protected internal static int carsCreated;
        protected string color;
        protected string carType;
        protected TimeStamp timeStamp;
        private Random rand = new Random();
        private readonly string[] acceptableColors = {"Red", "Green", "Blue",
            "Silver", "Black"};
        private readonly string[] acceptableTypes = {"Sedan", "SUV",
            "Sports Car", "Van", "Jeep"};

        public Car()
        {
            Console.WriteLine("Default Constructor Called.");
            timeStamp = new TimeStamp();
            carsCreated += 1;
        }

        public Car(string random) : this()
        {
            Console.WriteLine("Random Constructor Called.");
            if (random != "random")
            {
                Console.WriteLine("Illegal Constructor Argument.");
            } else {
                int idx = rand.Next(0, acceptableColors.Length);
                ValidateColor(acceptableColors[idx]);
                idx = rand.Next(0, acceptableTypes.Length);
                ValidateType(acceptableTypes[idx]);
            }
        }

        public Car(string color, string type) : this()
        {
            Console.WriteLine("2 Argument Constructor Called.");
            ValidateColor(color);
            ValidateType(type);
        }

        ~Car()
        {
            Console.WriteLine("Cleaning up, sir!");
            carsCreated -= 1;
            Console.WriteLine("Cars Remaining: " + carsCreated);
        }

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
                          "\nTime Stamp: " + this.timeStamp.DisplayUS());
            return val;
        }

        private void Randomize(string [] attribute)
        {
            int idx = rand.Next(0, attribute.Length);
            if (attribute == this.acceptableColors)
                this.color = this.acceptableColors[idx];
            else if (attribute == this.acceptableTypes)
                this.carType = this.acceptableTypes[idx];
            else
                Console.WriteLine("Error Randomizing.");
            
        }

        private void ValidateColor(string n_color)
        {
            n_color = char.ToUpper(n_color[0]) + n_color.Substring(1);
            if (this.acceptableColors.Contains(n_color))
                this.color = n_color;
            else
                Console.WriteLine("Illegal Color.");
        }

        private void ValidateType(string n_carType)
        {
            TextInfo tInfo = new CultureInfo("en-US", false).TextInfo;
            n_carType = tInfo.ToTitleCase(n_carType);
            if (this.acceptableTypes.Contains(n_carType))
                this.carType = n_carType;
            else
                Console.WriteLine("Illegal Car Type.");
        }

        public string Color
        {
            get { return this.color; }

            set
            {
                ValidateColor(value);
            }
        }

        public string CarType
        {
            get { return this.carType; }

            set
            {
                ValidateType(value);
            }
        }
    }
}
