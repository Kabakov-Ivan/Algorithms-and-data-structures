using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalList
{
    // Объект этого класса ListNode прелставялет узел списка хранящий
    // целочисленную инфоомацию и ссылку на следующий узел
    class ListNode
    {
        public int Data;
        public ListNode Next;

        public ListNode(int data, ListNode next = null) 
        {
            Data = data;
            Next = next;
        }
    }
}
