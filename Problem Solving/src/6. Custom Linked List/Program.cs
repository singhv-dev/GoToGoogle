using System;

namespace _6._Custom_Linked_List
{
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
                Console.WriteLine(head.Value);
                head = head.Next;
            }

            Console.WriteLine("=============================");
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

    public class Person: ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
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
