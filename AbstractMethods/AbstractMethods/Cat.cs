using System;
namespace AbstractMethods
{
    public class Cat : Animal
    {
        public Cat()
        {}

		public override void Describe()
		{
            Console.WriteLine("I'm a cat!");
		}
	}
}
