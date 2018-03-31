using System;
using System.Collections.Generic;

namespace Introduction
{
    public class Factory
    {
        private LinkedList<Car> inventory;

        public Factory()
        {
            inventory = new LinkedList<Car>();
        }

        public void DisplayInventory()
        {
            foreach (Car cr in this.inventory)
                Console.WriteLine(cr.Display());
        }

        // Takes in tuples of cars to create
        // (color, type)
        public void OrderSpecific(Tuple<string, string> order)
        {
            Manufacture(out Car n_car, order.Item1, order.Item2);
            this.inventory.AddFirst(n_car);
        }

        // Manufacture a random car
        public void OrderRandom()
        {
            Manufacture(out Car n_car, Defs.random);
            this.inventory.AddFirst(n_car);
        }

        private void Manufacture(out Car car, params string[] args)
        {
            int argLen = args.Length;
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
                    Console.WriteLine("Improper Entry, Making Random Car.");
                    car = new Car(Defs.random);
                    break;
            }
        }
    }
}