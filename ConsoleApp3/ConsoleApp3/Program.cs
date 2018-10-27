using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {10, 20, 30, 40, 50};
            var sum = calculateSum(numbers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static double calculateSum(int[] nos)
        {
            return nos.Where(i => i % 2 == 0).Sum(i => (long)i);
        }

    }
}
