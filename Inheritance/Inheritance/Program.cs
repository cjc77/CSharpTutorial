using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();
            Dog dog = new Dog();
            dog.Greet();
        }
    }
}
