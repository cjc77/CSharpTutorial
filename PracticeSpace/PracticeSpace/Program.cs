using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence";

            var sentence_split = sentence.Split(" ".ToCharArray());
            foreach (var item in sentence_split)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
