using System;
using System.Linq;

namespace Bubble.Sort.First.Try
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
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
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
