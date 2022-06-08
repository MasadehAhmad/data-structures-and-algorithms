using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Data_Structures.Data_structures.hashtable;
namespace TestProject1
{
    public class HashTable_Test
    {
        [Fact]
        public void add_get_Test()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.set(5, 522);
            hashtable.set(4, 365);
            Assert.Equal( 522,hashtable.get(5));
        }
        [Fact]
        public void keys_Test()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.set(5, 522);
            hashtable.set(4, 365);
            hashtable.set(88, 365);
            hashtable.set(77, 85596);
            Assert.Equal(new List<int> { 88, 77, 4, 5 }, hashtable.keys());
        }
        [Fact] 
        public void containsTest()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.set(5, 522);
            hashtable.set(4, 365);
            hashtable.set(88, 365);
            hashtable.set(77, 85596);
            Assert.True(hashtable.contains(4));
            Assert.True(hashtable.contains(88));
            Assert.False(hashtable.contains(66));
        }
    }
}
