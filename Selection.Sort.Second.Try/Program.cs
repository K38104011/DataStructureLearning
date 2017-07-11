using System;
using System.Linq;

namespace Selection.Sort.Second.Try
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

            for (int i = 0; i < numbers.Length; i++)
            {
                var smallest = i;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[smallest];
                numbers[smallest] = temp;
            }

            Console.WriteLine();

            foreach (var number in numbers)
            {
                Console.Write(number + ",");
            }

            Console.ReadKey();
        }

    }
}
