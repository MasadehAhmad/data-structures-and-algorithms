using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.hashmap_left_join
{
    public class LeftJoin 
    {
        public List<List<string>> LeftJoinMethod(Hashtable left,Hashtable right)
        {
            if ((left == null && right == null) || (left == null)) { return null; }
            List<List<string>> List = new List<List<string>>();
            foreach (DictionaryEntry item in left)
            {
                List.Add(new List<string> { item.Key.ToString(), item.Value.ToString() });
            }
            if (right == null)
            {
                return List;
            }
            foreach (DictionaryEntry item in right)
            {
                var s = List.Find(x => x[0] == item.Key.ToString());
                if(s != null)
                s.Add(item.Value.ToString());
            }
            return List;

        }

    }
}
