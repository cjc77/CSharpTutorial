using System;

namespace Introduction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] colors = { "blue", "green" };
            string[] types = { "sedan", "sports car" };
            const int mx = 3;
            Car [] cars = new Car [mx];
            for (int i = 0; i < mx; i++) {
                if (i < mx - 1) {
                    Console.WriteLine("1 Ran");
                    MakeCar(out cars[i], colors[i], types[i]);
                } else {
                    Console.WriteLine("2 Ran");
                    MakeCar(out cars[i], "random");
                }
            }
            foreach (Car cr in cars)
            {
                Console.WriteLine("Car: ");
                Console.WriteLine(cr.Display());
            }
        }

        public static void MakeCar(out Car car, params string [] args)
        {
            int argLen = args.Length;
            Console.WriteLine(args.Length);
            switch (argLen)
            {
                case 0:
                    car = new Car();
                    break;
                case 1:
                    car = new Car(args[0]);
                    break;
                case 2:
                    car = new Car(args[0], args[1]);
                    break;
                default:
                    Console.WriteLine("Improper use of constructor, " +
                                     "initializing a random car.");
                    car = new Car("random");
                    break;
            }
        }
    }
}
