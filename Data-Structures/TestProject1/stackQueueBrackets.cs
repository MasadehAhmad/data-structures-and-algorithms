using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class stackQueueBrackets
    {
        [Fact]
        public void Test1()
        {
            string s = "()[[Extra Characters]]";
            Assert.True(Data_Structures.Data_structures.stack_queue_brackets.StackQueueBrackets.ValidateBrackets(s));
        }
        [Fact]
        public void Test2()
        {
            string s = "(){}[[]]";
            Assert.True(Data_Structures.Data_structures.stack_queue_brackets.StackQueueBrackets.ValidateBrackets(s));
        }
        [Fact]
        public void Test3()
        {
            string s = "{}{Code}[Fellows](())";
            Assert.True(Data_Structures.Data_structures.stack_queue_brackets.StackQueueBrackets.ValidateBrackets(s));
        }
        [Fact]
        public void Test4()
        {
            string s = "[({}]";
            Assert.False(Data_Structures.Data_structures.stack_queue_brackets.StackQueueBrackets.ValidateBrackets(s));
        }
        [Fact]
        public void Test5()
        {
            string s = "{(})";
            Assert.False(Data_Structures.Data_structures.stack_queue_brackets.StackQueueBrackets.ValidateBrackets(s));
        }
        [Fact]
        public void Test6()
        {
            string s = "{";
            Assert.False(Data_Structures.Data_structures.stack_queue_brackets.StackQueueBrackets.ValidateBrackets(s));
        }
    }
}
