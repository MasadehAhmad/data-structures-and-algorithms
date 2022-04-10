using Data_Structures.Data_structures.Linked_List_Insertions;
using Data_Structures.Data_structures.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Data_Structures.Data_structures.linked_list_kth
{
  
    public class linkedListkth : linkedListInsertions
    {

        public int kthElemante(int k, linkedListInsertions list)
        {
            if (k > list.count) throw new IndexOutOfRangeException();
            if(k < 0) throw new Exception();
            Node current = list.head;
            for(int i = 1; i < (list.count-k); i++)
            {
                current = current.next;
            }
            return current.value;
        }
    }
}
