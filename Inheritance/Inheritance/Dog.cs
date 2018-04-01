using System;
namespace Inheritance
{
    public class Dog : Animal
    {
        public Dog()
        { }

        public override void Greet()
        {
            Console.WriteLine("Hi, I'm a dog.");
        }
    }
}
