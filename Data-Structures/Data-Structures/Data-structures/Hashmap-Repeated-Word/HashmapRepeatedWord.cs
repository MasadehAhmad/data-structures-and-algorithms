﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.Hashmap_Repeated_Word
{
    public class HashmapRepeatedWord
    {
        public static string RepeatedWord(string input)
        {
            input = input.Replace(",", "");
            input = input.ToLower();
            
            string[] splitInput = input.Split(" ");

            for (int i = 0; i < splitInput.Length; i++)
            {
                for (int j = i+1; j < splitInput.Length; j++)
                {
                    if( splitInput[i] == splitInput[j] )
                        return splitInput[i];
                }
            }
            return null;    
        }
    }
}
