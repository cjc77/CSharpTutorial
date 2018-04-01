using System;
namespace AbstractClasses
{
    public abstract class FourLeggedAnimal
    {
        internal FourLeggedAnimal()
        {}

        public virtual void Describe()
        {
            Console.WriteLine("I am a four-legged animal.");
        }
    }
}
