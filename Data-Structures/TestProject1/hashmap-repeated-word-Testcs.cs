using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Data_Structures.Data_structures.Hashmap_Repeated_Word;

namespace TestProject1
{
    public class hashmap_repeated_word_Testcs
    {
        [Fact]
        public void Test1()
        {
            string input = "Once upon a time, there was a brave princess who...";
            Assert.Equal("a", HashmapRepeatedWord.RepeatedWord(input));
        }
        [Fact]
        public void Test2()
        {
            string input = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            Assert.Equal("it", HashmapRepeatedWord.RepeatedWord(input));
        }
        [Fact]
        public void Test3()
        {
            string input = "Once upon a time, there was brave princess who...";
            Assert.Null(HashmapRepeatedWord.RepeatedWord(input));
        }
    }
}
