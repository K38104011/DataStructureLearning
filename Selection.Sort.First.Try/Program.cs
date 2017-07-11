using System;
using System.Linq;

namespace Selection.Sort.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 200;

            Random randNum = new Random();
            int[] numbers = Enumerable
                .Repeat(0, randNum.Next(10, 20))
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            foreach (var number in numbers)
            {
                Console.Write(number + ",");
            }

            var subNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                var smallest = 0;
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smallest])
                    {
                        smallest = j;
                    }
                }
                subNumbers[i] = numbers[smallest];
                numbers[smallest] = int.MaxValue;
            }

            Console.WriteLine();

            foreach (var number in subNumbers)
            {
                Console.Write(number + ",");
            }

            Console.ReadKey();
        }
    }
}
