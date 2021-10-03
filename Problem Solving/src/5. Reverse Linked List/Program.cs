using System;
using System.Collections.Generic;

namespace _5._Reverse_Linked_List
{   
    public record Node(int Value)
    {
        public Node Next { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LLNode<int> head = GenerateLinkedList();
            DisplayLinkedList(head);
            head = ReverseLinkedList(head);
            DisplayLinkedList(head);
        }

        static LLNode<int> ReverseLinkedList(LLNode<int> head)
        {
            LLNode<int> reversedHead = null;
            while (head != null)
            {
                LLNode<int> temp = head.Clone();
                temp.Next = reversedHead;
                reversedHead = temp;

                head = head.Next;
            }

            return reversedHead;
        }

        static void DisplayLinkedList(LLNode<int> head)
        {
            while (head != null)
            {
                Console.Write($"{head.Value} ");
                head = head.Next;
            }

            Console.WriteLine();
        }

        static LLNode<int> GenerateLinkedList()
        {
            LLNode<int> head = null, last = null;
            for (int i = 1; i <= 10; i++)
            {
                LLNode<int> temp = new LLNode<int>(i, null);
                if (head == null)
                {
                    head = last = temp;
                }
                else
                {
                    last.Next = temp;
                    last = last.Next;
                }
            }

            return head;
        }
    }

    public class LLNode<T>
    {
        public T Value { get; set; }
        public LLNode<T> Next { get; set; }

        public LLNode(T value, LLNode<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }

        public LLNode<T> Clone()
        {
            LLNode<T> newNode = new LLNode<T>(this.Value, this.Next);
            return newNode;
        }
    }
}
