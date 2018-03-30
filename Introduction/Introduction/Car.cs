using System;
using System.Linq;
using System.Diagnostics;

namespace Introduction
{

    public class Car
    {
        private string color;
        private string carType;
        private TimeStamp timeStamp;
        private Random rand = new Random();
        private readonly string[] acceptableColors = {"Red", "Green", "Blue",
            "Silver", "Black"};
        private readonly string[] acceptableTypes = {"Sedan", "SUV", "Sports Car",
            "Van", "Mini-Van"};

        public Car()
        {
            timeStamp = new TimeStamp();
        }

        public Car(string random) : this()
        {
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
            if (color == "r")
                Randomize(this.acceptableColors);
            else
                ValidateColor(color);
            if (type == "r")
                Randomize(this.acceptableTypes);
            else
                ValidateType(color);
        }

        public string Display()
        {
            string val = ("Color: " + Color + "\nCar Type: " + CarType +
                          "\nTime Stamp: " + this.timeStamp.DisplayUS());
            return val;
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

        private void ValidateColor(string color)
        {
            color = char.ToUpper(color[0]) + color.Substring(1);
            if (this.acceptableColors.Contains(color))
                this.color = color;
            else
                Console.WriteLine("Illegal Color.");
        }

        private void ValidateType(string carType)
        {
            carType = char.ToUpper(carType[0]) + carType.Substring(1);
            if (this.acceptableTypes.Contains(carType))
                this.carType = carType;
            else
                Console.WriteLine("Illegal Car Type.");
        }
    }
}
