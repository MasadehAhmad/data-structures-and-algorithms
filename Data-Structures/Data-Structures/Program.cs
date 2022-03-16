using Data_Structures.Data_structures.Array_Reverse;
using System;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] output = Array_Reverse.reverseArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
