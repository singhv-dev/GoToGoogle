using System;
using System.Collections.Generic;

namespace _3._Linked_List_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<int> head = GetLinkedList();
            DisplayLinkedList(head);
        }

        static void DisplayLinkedList(LinkedListNode<int> head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }

            Console.WriteLine("=================================");
        }

        static LinkedListNode<int> GetLinkedList()
        {
            LinkedList<int> LList = new LinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                LList.AddLast(i);
            }
           
            return LList.First;
        }
    }
}
