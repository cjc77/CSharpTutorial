using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {}

        public virtual void Greet()
        {
            Console.WriteLine("Hi, I'm an animal.");
        }
    }
}
