using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.stack_queue_brackets
{
    public class StackQueueBrackets
    {
        public static bool ValidateBrackets(string input)
        {
            char[] Chars = input.ToCharArray();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < Chars.Length; i++)
            {

                if (Chars[i] == '{' || Chars[i] == '(' || Chars[i] == '[')
                    stack.Push(Chars[i]);

                if (Chars[i] == '}' || Chars[i] == ')' || Chars[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char pop = stack.Pop();
                        if (pop == '(' && Chars[i] == ')')
                            continue;
                        else if (pop == '{' && Chars[i] == '}')
                            continue;
                        else if (pop == '[' && Chars[i] == ']')
                            continue;
                        else
                            return false;
                    }

                }
            }

            if (stack.Count == 0)
                return true;
            else
            {
                return false;
            }
        
        }

    }
}
