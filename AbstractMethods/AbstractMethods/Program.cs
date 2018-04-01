using System;

namespace AbstractMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var animalList = new System.Collections.ArrayList();
            animalList.Add(new Dog());
            animalList.Add(new Cat());
            foreach (Animal animal in animalList)
                animal.Describe();
        }
    }
}
