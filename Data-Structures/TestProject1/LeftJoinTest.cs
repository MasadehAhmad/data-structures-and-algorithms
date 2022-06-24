using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.hashmap_left_join;
using Xunit;

namespace TestProject1
{
    public class LeftJoinTest
    {
        [Fact]
        public void Test()
        {
            
            var leftJoin = new LeftJoin();
            Hashtable left = new Hashtable();
            left.Add("diligent", "employed");
            left.Add("fond", "enamored");
            left.Add("guide", "usher");
            left.Add("outfit", "garb"); 
            left.Add("wrath", "anger");
            Hashtable right = new Hashtable();
            right.Add("diligent", "idle");
            right.Add("fond", "averse");
            right.Add("guide", "follow");
            right.Add("flow", "jam");
            right.Add("wrath", "delight");

            var list1 = new List<List<string>>() 
            {
                new List<string> { "guide", "usher","follow" },
                new List<string> { "font", "enamored", "averse" } ,
                new List<string> { "diligent", "employed", "idle"},
                 new List<string> { "outfit", "garb" },
                new List<string> { "wrath", "anger", "delight" }
            };
            var list2 = leftJoin.LeftJoinMethod(left, right);


            Assert.Equal(list2,list2);
            
        }
    }
}
