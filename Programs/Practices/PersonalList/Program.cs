using PersonalList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace qweqwe
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(5);
            node.Next = new ListNode(4);
            node.Next.Next = new ListNode(12);
            ListNode tmp = node.Next;
            node.Next = new ListNode(1);
            node.Next = tmp;
            Print(node);

            Insert(ref node, 23, 0);
            Print(node);

            Insert(ref node, 100, 2);
            Insert(ref node, 34, 100);
            Print(node);

        }

        static void Print(ListNode head)
        {
            if (head is null)
                return;
            int i = 0;

            while (head is not null)
            {
                Console.WriteLine($"Elem {++i}: {head.Data}\t");
                head = head.Next;
            }
            Console.WriteLine();
        }

        static void Insert(ref ListNode head, int value, int position)
        {
            if (head is null || position < 0) return;
            if (position == 0)
            {
                head = new ListNode(value, head);
                return;
            }

            ListNode tmp = head;
            for (int i = 0; i < position - 1 && tmp.Next is not null; i++, head = tmp.Next) ;
            
            ListNode newNode = new ListNode(value, tmp.Next);
            tmp.Next = newNode;
        }
    }
}