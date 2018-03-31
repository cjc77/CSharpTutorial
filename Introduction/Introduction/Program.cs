using System;

namespace Introduction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] colors = { "blue", "green" };
            string[] types = { "sedan", "sports car" };
            Factory carFactory = new Factory();
            carFactory.OrderRandom();
            carFactory.DisplayInventory();
        }

    }
}
