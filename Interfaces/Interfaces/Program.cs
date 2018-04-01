using System;
using System.Collections.Generic;

namespace Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Toby"));
            dogs.Add(new Dog("Beth"));
            dogs.Add(new Dog("Rex"));
            // Dog objects can be sorted becase the Dog class implements
            // the IComparable interface's CompareTo method
            dogs.Sort();
            foreach (Dog dog in dogs)
                dog.Describe();
            Console.ReadKey();
        }
    }
}
