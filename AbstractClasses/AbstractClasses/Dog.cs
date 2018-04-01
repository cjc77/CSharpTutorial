using System;
namespace AbstractClasses
{
    public class Dog : FourLeggedAnimal
    {
        public Dog()
        {}

		public override void Describe()
		{
            // Use the base class behavior, too.
            base.Describe();
            Console.WriteLine("I am a dog.");
		}
	}
}
