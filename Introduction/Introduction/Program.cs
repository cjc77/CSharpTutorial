﻿using System;

namespace Introduction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car1, car2;

            //car1 = new Car("Red");
            //Console.WriteLine(car1.Describe());

            //car2 = new Car("Green");
            //Console.WriteLine(car2.Describe());
            //car2.Color = ("silver");
            //Console.WriteLine(car2.Describe());
            //car2.Color = ("Purple");
            //Console.WriteLine(car2.Describe());

            //car3 = new Car();
            //Console.WriteLine(car3.Describe());
            car1 = new Car("random");
            car2 = new Car("Blue", "Sedan");
            //Console.WriteLine(car1.Display());
            //Console.WriteLine(car2.Display());

            Console.WriteLine("One Vroom...");
            car1.Vroom();
            Console.WriteLine("5 Vrooms...");
            car1.Vroom(5);
        }
    }
}
