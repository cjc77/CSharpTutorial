using System;
using System.Linq;

namespace Introduction
{

    public class Car
    {
        private string color;
        private readonly string[] acceptableColors = {"Red", "Green", "Blue",
            "Silver", "Black"};

        public Car(string color)
        {
            ValidateColor(color);
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return this.color; }

            set
            {
                ValidateColor(value);
            }
        }

        private void ValidateColor(string color)
        {
            color = char.ToUpper(color[0]) + color.Substring(1);
            if (this.acceptableColors.Contains(color))
                this.color = color;
            else
                Console.WriteLine("Illegal Color.");
        }
    }
}
