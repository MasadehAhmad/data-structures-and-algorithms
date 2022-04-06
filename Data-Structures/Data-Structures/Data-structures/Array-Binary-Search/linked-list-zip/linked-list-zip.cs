using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.Linked_List;
using Data_Structures.Data_structures.Linked_List_Insertions;



namespace Data_Structures.Data_structures.Array_Binary_Search.linked_list_zip
{
    public class linkedlistZip : linkedListInsertions
    {
        public static linkedListInsertions Zip(linkedListInsertions list1, linkedListInsertions list2)
        {

            Node currant1 = list1.head;
            Node currant2 = list2.head;
            Node temp = null;


            while (true)
            {
                if (currant2 != null && currant1.next != null)
                {
                    temp = currant1.next;
                    currant1.next = currant2;
                    currant2 = currant2.next;
                    currant1.next.next = temp;
                    currant1 = temp;
                    
                }
                if(currant1.next == null) 

                {
                    currant1.next=currant2;
                    break;
                }
                if (currant2 == null) break;
            }
            return list1;

        } 
    }
}
