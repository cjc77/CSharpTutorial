using System;
namespace AbstractMethods
{
    public class Dog : Animal
    {
        public Dog()
        {}

        public override void Describe()
        {
            Console.WriteLine("I'm a dog!");
        }
    }
}
