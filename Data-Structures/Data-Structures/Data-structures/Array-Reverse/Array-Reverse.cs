using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.Array_Reverse
{
    internal class Array_Reverse
    {
        public static int[] reverseArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newArr[j] = arr[i];
                j++;
            }
            return newArr;
        }
        
    }
}
