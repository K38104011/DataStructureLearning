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
                var smallest = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smallest])
                    {
                        smallest = j;
                    }
                }
                Swap(ref numbers[smallest], ref numbers[i]);
            }

            Console.WriteLine();

            foreach (var number in numbers)
            {
                Console.Write(number + ",");
            }

            Console.ReadKey();
        }

        static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
