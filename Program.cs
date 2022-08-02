using System;

namespace MinNumbOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 213, 43, 12, 4, 21, 423, 232, 1, 3, 0, 3 };
            int ind = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[ind]>arr[i])
                {
                    ind = i;
                }
            }
            Console.WriteLine($"Minimum number's index is {ind} and it is equal to {arr[ind]} ");
        }   
    }
}
