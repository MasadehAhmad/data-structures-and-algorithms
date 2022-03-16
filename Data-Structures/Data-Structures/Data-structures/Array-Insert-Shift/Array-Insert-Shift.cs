using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.Array_Insert_Shift
{
    internal class Array_Insert_Shift
    {
        public static int[] arrayInsertShift(int[] arr,int num)
        {
            int[] newArr = new int[arr.Length+1];
            bool flag=true;
            int center = Convert.ToInt32(Math.Round(decimal.Divide(arr.Length,2)));
            for(int i = 0; i < newArr.Length; i++)
            {
                if (i == center)
                {
                    flag = false;
                    newArr[i] = num;
                    continue;
                }
                if(flag) newArr[i] = arr[i];
                else newArr[i] = arr[i-1];    
            }
            return newArr;
        }
    }
}
