using System;
using System.Collections.Generic;

namespace _6._Custom_Linked_List
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        LLNode<int> head = GenerateLinkedList();
    //        DisplayLinkedList(head);
    //        head = ReverseLinkedList(head);
    //        DisplayLinkedList(head);
    //    }

    //    static LLNode<int> ReverseLinkedList(LLNode<int> head)
    //    {
    //        LLNode<int> reversedHead = null;
    //        while (head != null)
    //        {
    //            LLNode<int> temp = head.Clone();
    //            temp.Next = reversedHead;
    //            reversedHead = temp;

    //            head = head.Next;
    //        }

    //        return reversedHead;
    //    }

    //    static void DisplayLinkedList(LLNode<int> head)
    //    {
    //        while (head != null)
    //        {
    //            Console.WriteLine(head.Value);
    //            head = head.Next;
    //        }

    //        Console.WriteLine("=============================");
    //    }

    //    static LLNode<int> GenerateLinkedList()
    //    {
    //        LLNode<int> head = null, last = null;
    //        for (int i = 1; i <= 10; i++)
    //        {
    //            LLNode<int> temp = new LLNode<int>(i, null);
    //            if (head == null)
    //            {
    //                head = last = temp;
    //            }
    //            else
    //            {
    //                last.Next = temp;
    //                last = last.Next;
    //            }
    //        }

    //        return head;
    //    }
    //}

    //public class Person: ICloneable
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public Person(string firstName, string lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{FirstName} {LastName}";
    //    }

    //    public object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class CustomLinkedList<T>
    {
        public static void DisplayLinkedList(LLNode<T> head)
        {
            if (head is null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (!(head is null))
            {
                Console.Write($"{head.Value.ToString()} ");
                head = head.Next;
            }

            Console.WriteLine();
        }

        public static LLNode<T> GenerateLinkedList(List<T> items)
        {
            LLNode<T> head, temp;
            head = temp = null;
            foreach (var item in items)
            {
                LLNode<T> newNode = new LLNode<T>(item);
                if (head is null)
                {
                    head = temp = newNode;
                }
                else
                {
                    temp.Next = newNode;
                    temp = temp.Next;
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

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
