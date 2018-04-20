using System;
using Algorithms.Strings;
using Algorithms.Search;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = RadioTransmitters.Resolve(new int[5] {1,2,6,7,9}, 1);

            Console.WriteLine("Total: " + total);

            Console.ReadLine();
        }
    }
}
