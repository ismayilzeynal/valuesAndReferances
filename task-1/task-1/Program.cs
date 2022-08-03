using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 8, 11, 99, 66, -44, 123, 546, 7486, 132, -4 };
            int mini = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[mini])
                    mini = i;
            }
            Console.WriteLine($"min element found at index {mini} : {arr[mini]}");
        }
    }
}