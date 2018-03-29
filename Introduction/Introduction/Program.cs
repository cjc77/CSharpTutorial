using System;
using System.Linq;

namespace Introduction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car1, car2;

            car1 = new Car("Red");
            Console.WriteLine(car1.Describe());

            car2 = new Car("Green");
            Console.WriteLine(car2.Describe());
        }
    }

    class Car
    {
        private string color;
        private string [] acceptableColors = {"Red", "Green", "Blue",
            "Silver", "Black"};

        public Car(string color)
        {
            if (acceptableColors.Contains(color))
                this.color = color;
            else
                Console.WriteLine("Illegal Color");
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}
