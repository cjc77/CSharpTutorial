using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1;
            int[] numbers2;
            //CreateBadArray(out numbers1, 3);
            CreateAndHandleBadArray(out numbers2, 3);
            //PrintNumbers(numbers);
        }

        static void CreateBadArray(out int[] numbers, int size)
        {
            Random rand = new Random();
            // Make an array that is 1 too small
            numbers = new int[size - 1];
            // This will throw an error
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(100);
        }

        static void CreateAndHandleBadArray(out int[] numbers, int size)
        {
            Random rand = new Random();
            // Make an array that is 1 too small
            numbers = new int[size - 1];
            // Handle exception
            for(int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    numbers[i] = rand.Next(100);
                }
                catch
                {
                    Console.WriteLine("You have incorrectly accessed an array element.");
                }
            }
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (int num in numbers)
                Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
