﻿using System;

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
            car2.Color = ("silver");
            Console.WriteLine(car2.Describe());
            //car2.Color = ("Purple");
            //Console.WriteLine(car2.Describe());
        }
    }
}
