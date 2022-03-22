using Data_Structures.Data_structures.Array_Insert_Shift;
using Data_Structures.Data_structures.Array_Reverse;
using Data_Structures.Data_structures.Array_Binary_Search;
using System;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] output = Array_Insert_Shift.arrayInsertShift(arr, 999);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }*/
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 19, 36, 44, 64, 84, 120, 889 };
            int output = array_binary_search.BinarySearch(arr, 64);
            Console.WriteLine(output+"   "+arr[output]);
        }
    }
}
