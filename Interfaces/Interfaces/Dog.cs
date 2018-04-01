using System;
namespace Interfaces
{
    public class Dog : IAnimal, IComparable
    {
        private string name;

        public Dog(string name)
        {
            this.name = name;
        }

        public void Describe()
        {
            Console.WriteLine("I am a dog and my name is " + this.Name);
        }

        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return this.Name.CompareTo((obj as IAnimal).Name);
            return 0;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
