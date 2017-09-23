using System;

namespace Quick.Sort
{
    class Program
    {
        static void Main()
        {
            var qs = new QuickSort(new []{ 10, 7, 8, 9, 1 ,5 });
            Console.WriteLine(string.Join(",", qs.GetSorted));
            Console.ReadKey();
        }
    }
}
